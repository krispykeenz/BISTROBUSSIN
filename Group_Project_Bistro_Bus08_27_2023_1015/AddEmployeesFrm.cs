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
    public partial class AddEmployeesFrm : Form
    {
        //Variable Declaration for parent form that gets referenced
        AppInterface_Frm parentForm;

        //Global Variables
        public String sqlQuery = @"SELECT * FROM Employees";

        //Global connection string variable declaration
        public String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Bistro_BusDB.mdf;Integrated Security = True";
        public SqlConnection cnn;

        public AddEmployeesFrm(AppInterface_Frm parentForm)
        {
            InitializeComponent();

            //Set parent form
            MdiParent = parentForm;
            this.parentForm = parentForm;
        }

        private void AddEmployeesFrm_Load(object sender, EventArgs e)
        {
            tbFirstName.Focus();
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
                if (string.IsNullOrWhiteSpace(tbFirstName.Text) || string.IsNullOrWhiteSpace(tbLastName.Text) ||
                    string.IsNullOrWhiteSpace(tbEmail.Text) || string.IsNullOrWhiteSpace(tbCell.Text) ||
                    string.IsNullOrWhiteSpace(tbTaxNumber.Text))
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
                    string sql_queryMaxEmpNum = "SELECT MAX(empNum) FROM Employees";
                    SqlCommand maxEmpNumCommand = new SqlCommand(sql_queryMaxEmpNum, cnn);
                    object maxEmpNumObj = maxEmpNumCommand.ExecuteScalar();
                    int newEmpNum = (maxEmpNumObj is DBNull) ? 1 : Convert.ToInt32(maxEmpNumObj) + 1;

                    // Insert new employee record
                    string sql_queryInsert = "INSERT INTO Employees (empNum, empRole, empName, empSurname, empEmail, empCellNum, empTaxNum, empPassword) VALUES (@EmpNum, @EmpRole, @EmpName, @EmpSurname, @EmpEmail, @EmpCellNum, @EmpTaxNum, @EmpPassword)";
                    SqlCommand myCommandInsert = new SqlCommand(sql_queryInsert, cnn);
                    myCommandInsert.Parameters.AddWithValue("@EmpNum", newEmpNum);
                    myCommandInsert.Parameters.AddWithValue("@EmpRole", cbEmployeeRole.Text);
                    myCommandInsert.Parameters.AddWithValue("@EmpName", tbFirstName.Text);
                    myCommandInsert.Parameters.AddWithValue("@EmpSurname", tbLastName.Text);
                    myCommandInsert.Parameters.AddWithValue("@EmpEmail", tbEmail.Text);
                    myCommandInsert.Parameters.AddWithValue("@EmpCellNum", tbCell.Text);
                    myCommandInsert.Parameters.AddWithValue("@EmpTaxNum", tbTaxNumber.Text);
                    myCommandInsert.Parameters.AddWithValue("@EmpPassword", tbPassword.Text);

                    myCommandInsert.ExecuteNonQuery();

                    // Confirmation message
                    MessageBox.Show("New employee record inserted successfully with empNum: " + newEmpNum);

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
