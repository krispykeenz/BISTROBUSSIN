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
    public partial class EditClientsFrm : Form
    {
        //Variable Declaration for parent form that gets referenced
        AppInterface_Frm parentForm;

        //Global Variables
        public String sqlQuery = @"SELECT * FROM Clients";

        //Global connection string variable declaration
        public String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Bistro_BusDB.mdf;Integrated Security = True";
        public SqlConnection cnn;

        public EditClientsFrm(AppInterface_Frm parentForm)
        {
            InitializeComponent();

            //Set parent form
            MdiParent = parentForm;
            this.parentForm = parentForm;
        }

        private void EditClientsFrm_Load(object sender, EventArgs e)
        {
            this.reloadClients();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Close current Form
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //Check if Employee Number exists
            string clientToUpdate = tbClientNumber.Text;

            try
            {
                cnn = new SqlConnection(connectionString);
                cnn.Open(); //Open connection

                Console.WriteLine("Connection Open");

                SqlCommand myCommand = new SqlCommand("SELECT clientNum, clientName, clientAdress, clientEmail, clientContactNum FROM Clients WHERE clientNum = @clientToUpdate", cnn); //Create new command instance with instruction
                myCommand.Parameters.AddWithValue("@clientToUpdate", clientToUpdate);

                Console.WriteLine("Command Passed");

                SqlDataReader datareader;
                datareader = myCommand.ExecuteReader();

                Console.WriteLine("Reader Passed");

                int count = 0;

                if (datareader.HasRows)
                {
                    while (datareader.Read())
                    {
                        count++;
                        tbClientName.Text = datareader.GetValue(1).ToString();
                        tbClientAdress.Text = datareader.GetValue(2).ToString();
                        tbClientEmail.Text = datareader.GetValue(3).ToString();
                        tbCellphoneNumber.Text = datareader.GetValue(4).ToString();
                    }
                }

                if (count == 1)
                {
                    lblClientName.Visible = true;
                    lblClientAdress.Visible = true;
                    lblClientEmail.Visible = true;
                    lblCellphoneNumber.Visible = true;

                    tbClientName.Visible = true;
                    tbClientAdress.Visible = true;
                    tbClientEmail.Visible = true;
                    tbCellphoneNumber.Visible = true;

                    btnUpdate.Enabled = true;
                }

                cnn.Close();

                this.reloadClients();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Connecting to Data Base", MessageBoxButtons.OK); //Error message
            }
        }

        private void reloadClients() //Method used to reload clients display after changes
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
                myAdapter.Fill(myDataSet, "Clients");

                //Add Data to DataGridView
                dgvViewClients.DataSource = myDataSet;
                dgvViewClients.DataMember = "Clients";

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //Open connection
                cnn.Open();

                //Variable declaration
                string clientNum = tbClientNumber.Text;

                //Update employee based on user input values
                string sql_queryUpdate = "UPDATE Clients SET clientName = @ClientName, clientAdress = @ClientAdress, clientEmail = @ClientEmail, clientContactNum = @ClientContactNum WHERE clientNum = @ClientNum";
                SqlCommand myCommandUpdate = new SqlCommand(sql_queryUpdate, cnn);
                myCommandUpdate.Parameters.AddWithValue("@ClientNum", clientNum); // Provide the empNum value you want to update
                myCommandUpdate.Parameters.AddWithValue("@ClientName", tbClientName.Text);
                myCommandUpdate.Parameters.AddWithValue("@ClientAdress", tbClientAdress.Text);
                myCommandUpdate.Parameters.AddWithValue("@ClientEmail", tbClientEmail.Text);
                myCommandUpdate.Parameters.AddWithValue("@ClientContactNum", tbCellphoneNumber.Text);

                myCommandUpdate.ExecuteNonQuery();


                //Confirmation message
                MessageBox.Show("Employee details updated successfully.");


                //Close connection
                cnn.Close();

                this.reloadClients();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
