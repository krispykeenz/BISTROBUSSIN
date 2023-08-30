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
    public partial class RemoveEmployeesFrm : Form
    {
        //Variable Declaration for parent form that gets referenced
        AppInterface_Frm parentForm;

        //Global Variables
        public String sqlQuery = @"SELECT * FROM Employees";
        //public int fCurrentUser;

        //Global connection string variable declaration
        public String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Bistro_BusDB.mdf;Integrated Security = True";
        public SqlConnection cnn;

        public RemoveEmployeesFrm(AppInterface_Frm parentForm)
        {
            InitializeComponent();

            //Set parent form
            MdiParent = parentForm;
            this.parentForm = parentForm;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //Check if Employee Number exists
            string employeeToRemove = tbEmployeeNumber.Text;

            try
            {
                cnn = new SqlConnection(connectionString);
                cnn.Open(); //Open connection

                Console.WriteLine("Connection Open");

                SqlCommand myCommand = new SqlCommand("SELECT empNum, empRole, empName, empSurname, empEmail, empCellNum, empTaxNum, empPassword FROM Employees WHERE empNum = @employeeToUpdate", cnn); //Create new command instance with instruction
                myCommand.Parameters.AddWithValue("@employeeToUpdate", employeeToRemove);

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
                        tbFirstName.Text = datareader.GetValue(2).ToString();
                        tbLastName.Text = datareader.GetValue(3).ToString();
                        tbEmail.Text = datareader.GetValue(4).ToString();
                        tbCell.Text = datareader.GetValue(5).ToString();
                        tbTaxNumber.Text = datareader.GetValue(6).ToString();
                        tbEmployeeRole.Text = datareader.GetValue(1).ToString();
                    }
                }

                if (count == 1)
                {
                    lblFirstName.Visible = true;
                    lblLastName.Visible = true;
                    lblEmail.Visible = true;
                    lblCell.Visible = true;
                    lblTaxNumber.Visible = true;
                    lblEmployeeRole.Visible = true;

                    tbFirstName.Visible = true;
                    tbLastName.Visible = true;
                    tbEmail.Visible = true;
                    tbCell.Visible = true;
                    tbTaxNumber.Visible = true;
                    tbEmployeeRole.Visible = true;

                    btnRemove.Enabled = true;
                }

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Connecting to Data Base", MessageBoxButtons.OK); //Error message
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Close current Form
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string employeeToDelete = tbEmployeeNumber.Text;

            try
            {
                cnn = new SqlConnection(connectionString);
                cnn.Open(); // Open connection

                SqlCommand deleteCommand = new SqlCommand("DELETE FROM Employees WHERE empNum = @employeeToDelete", cnn);
                deleteCommand.Parameters.AddWithValue("@employeeToDelete", employeeToDelete);

                int rowsAffected = deleteCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Employee record with Employee Number " + employeeToDelete + " has been deleted.");
                }
                else
                {
                    MessageBox.Show("No employee record found with Employee Number " + employeeToDelete + ".");
                }

                cnn.Close();

                this.reloadEmployees();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Connecting to Database", MessageBoxButtons.OK); // Error message
            }
        }

        private void RemoveEmployeesFrm_Load(object sender, EventArgs e)
        {
            this.reloadEmployees();
        }

        private void reloadEmployees()
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
                myAdapter.Fill(myDataSet, "Employees");

                //Add Data to DataGridView
                dgvViewEmployees.DataSource = myDataSet;
                dgvViewEmployees.DataMember = "Employees";

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
    }
}
