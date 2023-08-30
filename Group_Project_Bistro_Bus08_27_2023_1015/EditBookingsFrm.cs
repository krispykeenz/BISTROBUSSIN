/*CMPG223 Group 14 Project Bistro_Bus
Janco Pretorius (40951499)
Keenan Burriss (37831909)
Pieter Swart (44529996)
Marco Van Den Heever (38302187)
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Project_Bistro_Bus
{
    public partial class EditBookingsFrm : Form
    {
        //Variable Declaration for parent form that gets referenced
        AppInterface_Frm parentForm;

        //Global Variables
        public String sqlQuery = @"SELECT * FROM Bookings";

        //Global connection string variable declaration
        public String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Bistro_BusDB.mdf;Integrated Security = True";
        public SqlConnection cnn;

        public EditBookingsFrm(AppInterface_Frm parentForm)
        {
            InitializeComponent();

            //Set parent form
            MdiParent = parentForm;
            this.parentForm = parentForm;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Close current Form
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //Check if Booking Number exists
            string bookingToUpdate = tbBookingNumber.Text;

            try
            {
                cnn = new SqlConnection(connectionString);
                cnn.Open(); //Open connection

                SqlCommand myCommand = new SqlCommand("SELECT bookingNum, event, venue, startDate, endDate, isPaid, status FROM Bookings WHERE bookingNum = @bookingToUpdate", cnn); //Create new command instance with instruction
                myCommand.Parameters.AddWithValue("@bookingToUpdate", bookingToUpdate);

                SqlDataReader datareader;
                datareader = myCommand.ExecuteReader();

                int count = 0;

                if (datareader.HasRows)
                {
                    while (datareader.Read())
                    {
                        count++;
                        tbBookingNumber.Text = datareader.GetValue(1).ToString();
                        tbEventName.Text = datareader.GetValue(2).ToString();
                        tbVenue.Text = datareader.GetValue(3).ToString();
                        tbStartDate.Text = datareader.GetValue(4).ToString();
                        tbEndDate.Text = datareader.GetValue(5).ToString();
                        if ((datareader.GetValue(6).ToString()) == "1") //isPaid == 1
                        {
                            cbIsPaid.Checked = true; //Booking paid
                        }
                        else //isPaid == 0
                        {
                            cbIsPaid.Checked = false; //Booking not paid
                        }
                        if (datareader.GetValue(7).ToString() == "Pending")
                        {
                            cbStatus.SelectedIndex = 0; //Index 0 = Pending
                        }
                        else if (datareader.GetValue(7).ToString() == "Confirmed")
                        {
                            cbStatus.SelectedIndex = 1; //Index 1 = Confirmed
                        }
                        else
                        {
                            cbStatus.SelectedIndex = 2; //Index = Cancelled
                        }
                    }
                }

                if (count == 1)
                {
                    //Show and enable all elements which where sot to visible == false by default
                    tbEventName.Visible = true;
                    lblEventName.Visible = true;
                    tbVenue.Visible = true;
                    lblVenue.Visible = true;
                    tbStartDate.Visible = true;
                    lblStartDate.Visible = true;
                    tbEndDate.Visible = true;
                    lblEndDate.Visible = true;
                    cbIsPaid.Visible = true;
                    cbStatus.Visible = true;
                    lblStatus.Visible = true;

                    btnUpdate.Enabled = true;
                }

                cnn.Close();

                this.reloadBookings();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Connecting to Data Base", MessageBoxButtons.OK); //Error message
            }
        }

        private void reloadBookings() //Method used to reload clients display after changes
        {
            //Set DB connection
            cnn = new SqlConnection(connectionString);

            try
            {
                //Open connection
                cnn.Open();

                //Set SqlDataAdapter, DataSet and SqlCommand
                SqlDataAdapter myAdapter = new SqlDataAdapter();
                DataSet myDataSet = new DataSet();
                String sql_query = sqlQuery;
                SqlCommand myCommand = new SqlCommand(sql_query, cnn);

                //Fill the DataSet
                myAdapter.SelectCommand = myCommand;
                myAdapter.Fill(myDataSet, "Bookings");

                //Add Data to DataGridView
                dgvViewBookings.DataSource = myDataSet;
                dgvViewBookings.DataMember = "Bookings";

                //Show all events
                SqlDataReader datareader;
                datareader = myCommand.ExecuteReader();

                //Close connection
                cnn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error Connecting to Data Base", MessageBoxButtons.OK); //Error message
            }
        }

        private void EditBookingsFrm_Load(object sender, EventArgs e)
        {
            this.reloadBookings(); //Call Method
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //Open connection
                cnn.Open();

                //Variable declaration
                string bookingNum = tbBookingNumber.Text;

                //Update employee based on user input values
                string sql_queryUpdate = "UPDATE Bookings SET event = @Event, venue = @Venue, startDate = @StartDate, endDate = @EndDate, isPaid = @IsPaid, status WHERE bookingNum = @BookingNum";
                SqlCommand myCommandUpdate = new SqlCommand(sql_queryUpdate, cnn);
                myCommandUpdate.Parameters.AddWithValue("@BookingNum", bookingNum); //Provide the bookingNum value you want to update
                myCommandUpdate.Parameters.AddWithValue("@Event", tbEventName.Text);
                myCommandUpdate.Parameters.AddWithValue("@Venue", tbVenue.Text);

                DateTime startDate;
                if (DateTime.TryParse(tbStartDate.Text, out startDate)) //If date format is correct
                {
                    myCommandUpdate.Parameters.AddWithValue("@StartDate", startDate);
                    
                }
                else //Date format incorrect
                {
                    MessageBox.Show("The date format is incorrect.", "Date Format", MessageBoxButtons.OK); //Error message
                    tbStartDate.Clear(); //Clear
                    tbStartDate.Focus(); //Focus
                    return; // Exit the method if validation fails
                }

                DateTime endDate;
                if (DateTime.TryParse(tbEndDate.Text, out endDate)) //If date format is correct
                {
                    myCommandUpdate.Parameters.AddWithValue("@EndDate", endDate);

                }
                else //Date format incorrect
                {
                    MessageBox.Show("The date format is incorrect.", "Date Format", MessageBoxButtons.OK); //Error message
                    tbEndDate.Clear(); //Clear
                    tbEndDate.Focus(); //Focus
                    return; // Exit the method if validation fails
                }

                if (cbIsPaid.Checked) { myCommandUpdate.Parameters.AddWithValue("@IsPaid", "1"); } //Paid
                else { myCommandUpdate.Parameters.AddWithValue("@IsPaid", "0"); } //Not Paid
                myCommandUpdate.Parameters.AddWithValue("@Status", cbStatus.Text);

                myCommandUpdate.ExecuteNonQuery(); //Execute Query

                //Confirmation message
                MessageBox.Show("Booking details updated successfully.");


                //Close connection
                cnn.Close();

                this.reloadBookings(); //Call Method
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error Connecting to Data Base", MessageBoxButtons.OK); //Error message
            }
        }
    }
}
