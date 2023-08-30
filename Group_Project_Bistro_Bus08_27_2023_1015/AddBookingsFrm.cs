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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Group_Project_Bistro_Bus
{
    public partial class AddBookingsFrm : Form
    {
        //Variable Declaration for parent form that gets referenced
        AppInterface_Frm parentForm;

        //Global connection string variable declaration
        public String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Bistro_BusDB.mdf;Integrated Security = True";
        public SqlConnection cnn;

        public AddBookingsFrm(AppInterface_Frm parentForm)
        {
            InitializeComponent();

            //Set parent form
            MdiParent = parentForm;
            this.parentForm = parentForm;
        }

        private void AddBookingsFrm_Load(object sender, EventArgs e)
        {
            populateComboBoxes(); //Call Method
            //Show and enable cbIsPaid
            cbIsPaid.Enabled = true;
            cbIsPaid.Visible = true;
        }

        private void populateComboBoxes() //Method that populates combo boxes
        {
            cnn = new SqlConnection(connectionString);

            // Open connection
            cnn.Open();
            SqlCommand command;
            string sql;
            SqlDataAdapter adapter = new SqlDataAdapter();
            sql = @"Select empName FROM Employees";//Only select the names of employees
            command = new SqlCommand(sql, cnn);
            DataSet dataset = new DataSet();
            adapter.SelectCommand = command;
            adapter.Fill(dataset, "Employees");
            cbEmployee.DisplayMember = "empName"; //Field to be displayed
            cbEmployee.ValueMember = "empName"; //Value to be returned
            cbEmployee.DataSource = dataset.Tables["Employees"];//Table in the dataset to use

            adapter = new SqlDataAdapter();
            sql = @"Select clientName FROM Clients";//Only select the names of clients
            command = new SqlCommand(sql, cnn);
            dataset = new DataSet();
            adapter.SelectCommand = command;
            adapter.Fill(dataset, "Clients");
            cbClient.DisplayMember = "clientName"; //Field to be displayed
            cbClient.ValueMember = "clientName"; //Value to be returned
            cbClient.DataSource = dataset.Tables["Clients"];//Table in the dataset to use

            adapter = new SqlDataAdapter();
            sql = @"Select menuItem FROM Menus";//Only select the menu Item
            command = new SqlCommand(sql, cnn);
            dataset = new DataSet();
            adapter.SelectCommand = command;
            adapter.Fill(dataset, "Menus");
            cbMenu.DisplayMember = "menuItem"; //Field to be displayed
            cbMenu.ValueMember = "menuItem"; //Value to be returned
            cbMenu.DataSource = dataset.Tables["Menus"];//Table in the dataset to use
            cnn.Close(); //Close the connection

            //Show the populated cb's
            cbEmployee.Visible = true;
            cbClient.Visible = true;
            cbMenu.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Close current Form
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate that all required text boxes have values
                if (string.IsNullOrWhiteSpace(tbEvent.Text) || string.IsNullOrWhiteSpace(tbVenue.Text) ||
                    string.IsNullOrWhiteSpace(tbStartDate.Text) || string.IsNullOrWhiteSpace(tbEndDate.Text))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return; // Exit the method if validation fails
                }

                try
                {
                    cnn = new SqlConnection(connectionString);
                    // Open connection
                    cnn.Open();

                    // Find the highest bookingNum in the Bookings table and increment it by 1
                    string sql_queryMaxBookingNum = "SELECT MAX(bookingNum) FROM Bookings";
                    SqlCommand maxBookingCommand = new SqlCommand(sql_queryMaxBookingNum, cnn);
                    object maxBookingNumObj = maxBookingCommand.ExecuteScalar();
                    int newBookingNum = (maxBookingNumObj is DBNull) ? 1 : Convert.ToInt32(maxBookingNumObj) + 1;

                    // Find the clientNum in the Clients table where clientName = cbClient.Text
                    string sql_queryClientNum = "SELECT clientNum FROM Clients WHERE clientName = @clientName";
                    SqlCommand clientNumCommand = new SqlCommand(sql_queryClientNum, cnn);
                    clientNumCommand.Parameters.AddWithValue("@clientName", cbClient.Text);
                    object clientNumObj = clientNumCommand.ExecuteScalar();
                    int newClientNum = (clientNumObj is DBNull) ? 1 : Convert.ToInt32(clientNumObj);

                    // Find the empNum in the Employees table where empName = cbEmployee.Text
                    string sql_queryEmpNum = "SELECT empNum FROM Employees WHERE empName = @empName";
                    SqlCommand empNumCommand = new SqlCommand(sql_queryEmpNum, cnn);
                    empNumCommand.Parameters.AddWithValue("@empName", cbEmployee.Text);
                    object empNumObj = empNumCommand.ExecuteScalar();
                    int newEmpNum = (empNumObj is DBNull) ? 1 : Convert.ToInt32(empNumObj);

                    // Find the menuNum in the Menus table where menuItem = cbMenu.Text
                    string sql_queryMenuNum = "SELECT menuNum FROM Menus WHERE menuItem = @menuItem";
                    SqlCommand menuNumCommand = new SqlCommand(sql_queryMenuNum, cnn);
                    menuNumCommand.Parameters.AddWithValue("@menuItem", cbMenu.Text);
                    object menuNumObj = menuNumCommand.ExecuteScalar();
                    int newMenuNum = (menuNumObj is DBNull) ? 1 : Convert.ToInt32(menuNumObj);

                    // Insert new employee record
                    string sql_queryInsert = "INSERT INTO Bookings (bookingNum, clientNum, empNum, menuNum, event, venue, startDate, endDate, isPaid, status) VALUES (@BookingNum, @ClientNum, @EmpNum, @MenuNum, @Event, @Venue, @StartDate, @EndDate, @IsPaid, @Status)";
                    SqlCommand myCommandInsert = new SqlCommand(sql_queryInsert, cnn);
                    myCommandInsert.Parameters.AddWithValue("@BookingNum", newBookingNum);
                    myCommandInsert.Parameters.AddWithValue("@ClientNum", newClientNum);
                    myCommandInsert.Parameters.AddWithValue("@EmpNum", newEmpNum);
                    myCommandInsert.Parameters.AddWithValue("@MenuNum", newMenuNum);
                    myCommandInsert.Parameters.AddWithValue("@Event", tbEvent.Text);
                    myCommandInsert.Parameters.AddWithValue("@Venue", tbVenue.Text);
                    DateTime startDate;
                    if (DateTime.TryParse(tbStartDate.Text, out startDate)) //If date format is correct
                    {
                        myCommandInsert.Parameters.AddWithValue("@StartDate", startDate);

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
                        myCommandInsert.Parameters.AddWithValue("@EndDate", endDate);

                    }
                    else //Date format incorrect
                    {
                        MessageBox.Show("The date format is incorrect.", "Date Format", MessageBoxButtons.OK); //Error message
                        tbEndDate.Clear(); //Clear
                        tbEndDate.Focus(); //Focus
                        return; // Exit the method if validation fails
                    }

                    if (cbIsPaid.Checked) { myCommandInsert.Parameters.AddWithValue("@IsPaid", "1"); } //Paid
                    else { myCommandInsert.Parameters.AddWithValue("@IsPaid", "0"); } //Not Paid
                    myCommandInsert.Parameters.AddWithValue("@Status", cbStatus.Text);

                    myCommandInsert.ExecuteNonQuery();

                    // Confirmation message
                    MessageBox.Show("New booking record inserted successfully with empNum: " + newBookingNum);

                    // Close connection
                    cnn.Close();

                    // Navigate back to login page or perform other actions
                    this.Close();
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                // Close connection in the finally block to ensure it's always closed
                cnn.Close();
            }
        }
    }
}
