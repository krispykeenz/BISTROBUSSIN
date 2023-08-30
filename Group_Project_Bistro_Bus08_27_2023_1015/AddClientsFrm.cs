﻿/*CMPG223 Group 14 Project Bistro_Bus
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
    public partial class AddClientsFrm : Form
    {
        //Variable Declaration for parent form that gets referenced
        AppInterface_Frm parentForm;

        //Global Variables
        public String sqlQuery = @"SELECT * FROM Clients";

        //Global connection string variable declaration
        public String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Bistro_BusDB.mdf;Integrated Security = True";
        public SqlConnection cnn;

        public AddClientsFrm(AppInterface_Frm parentForm)
        {
            InitializeComponent();

            //Set parent form
            MdiParent = parentForm;
            this.parentForm = parentForm;
        }

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Close current Form
            this.Close();
        }

        private void AddClientsFrm_Load(object sender, EventArgs e)
        {
            tbClientName.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate that all required text boxes have values
                if (string.IsNullOrWhiteSpace(tbClientName.Text) || string.IsNullOrWhiteSpace(tbClientAdress.Text) ||
                    string.IsNullOrWhiteSpace(tbEmail.Text) || string.IsNullOrWhiteSpace(tbClientCellPhoneNumber.Text))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return; // Exit the method if validation fails
                }

                try
                {
                    cnn = new SqlConnection(connectionString);
                    // Open connection
                    cnn.Open();

                    // Find the highest empNum in the Employees table and increment it by 1
                    string sql_queryMaxClientNum = "SELECT MAX(clientNum) FROM Clients";
                    SqlCommand maxClientNumCommand = new SqlCommand(sql_queryMaxClientNum, cnn);
                    object maxClientNumObj = maxClientNumCommand.ExecuteScalar();
                    int newClientNum = (maxClientNumObj is DBNull) ? 1 : Convert.ToInt32(maxClientNumObj) + 1;

                    // Insert new client record
                    string sql_queryInsert = "INSERT INTO Clients (clientNum, clientName, clientAdress, clientEmail, clientContactNum) VALUES (@ClientNum, @ClientName, @ClientAdress, @ClientEmail, @ClientContactNum)";
                    SqlCommand myCommandInsert = new SqlCommand(sql_queryInsert, cnn);
                    myCommandInsert.Parameters.AddWithValue("@ClientNum", newClientNum);
                    myCommandInsert.Parameters.AddWithValue("@ClientName", tbClientName.Text);
                    myCommandInsert.Parameters.AddWithValue("@ClientAdress", tbClientAdress.Text);
                    myCommandInsert.Parameters.AddWithValue("@ClientEmail", tbEmail.Text);
                    myCommandInsert.Parameters.AddWithValue("@ClientContactNum", tbClientCellPhoneNumber.Text);

                    myCommandInsert.ExecuteNonQuery();

                    // Confirmation message
                    MessageBox.Show("New client record inserted successfully with clientNum: " + newClientNum);

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
