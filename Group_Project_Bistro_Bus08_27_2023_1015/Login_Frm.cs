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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.Threading;

namespace Group_Project_Bistro_Bus
{
    public partial class Login_Frm : Form
    {
        //Variable Declaration for parent form that gets referenced
        AppInterface_Frm parentForm;

        //Variables
        public bool isAdmin = false; //is user Admin?
        public bool isSalesManager = false; //is user a sales manager?
        public bool isSalesRep = false; //is user a sales representative?

        public string email;
        public string password;
        public string role;
        
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Bistro_BusDB.mdf;Integrated Security = True";
        public SqlConnection cnn;
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public SqlDataReader reader;
        public DataSet data;
        public string sql;

        public Login_Frm()
        {
            InitializeComponent();
        }

        public Login_Frm(AppInterface_Frm parentForm)
        {
            InitializeComponent();

            //Set parent form
            MdiParent = parentForm;
            this.parentForm = parentForm;
        }

        private void Login_Frm_Load(object sender, EventArgs e)
        {
            //Clear textboxes every time the form loads
            tbEmail.Clear();
            tbPassword.Clear();
            
            //Populate variables from textboxes
            email = tbEmail.Text;
            password = tbPassword.Text;

            /*Added to bypass login while building the program
            AppInterface_Frm AppInterface_Frm = new AppInterface_Frm(this);
            AppInterface_Frm.ShowDialog();*/
        }

        private void btnLogin(object sender, EventArgs e)
        {
            //Validation
            if (string.IsNullOrEmpty(tbEmail.Text))
            {
                MessageBox.Show("Email is a required field.", "Email Empty", MessageBoxButtons.OK); //Error message
                tbEmail.Clear(); //Clear tbUsername
                tbEmail.Focus(); //Focus tbUsername
            }
            else
            {
                //Check to see if email is present on Employees Table
                bool emailExists = false;

                email = tbEmail.Text;
                Console.WriteLine(email);

                try
                {
                    cnn = new SqlConnection(connectionString);
                    cnn.Open(); //Open connection

                    command = new SqlCommand("SELECT empEmail FROM Employees WHERE empEmail = @email", cnn); //Create new command instance with instruction
                    command.Parameters.AddWithValue("@email", email);

                    reader = command.ExecuteReader();

                    int count = 0;

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            count++; //This variable will only increase once matching email is found
                        }
                    }

                    if (count == 1) //If there is more than zero(0) matches
                    {
                        emailExists = true;
                    }

                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Connecting to Data Base", MessageBoxButtons.OK); //Error message
                }

                if (emailExists) //Continue with code
                {
                    if (string.IsNullOrEmpty(tbPassword.Text)) 
                    {
                        MessageBox.Show("Password is a required field.", "Password Empty", MessageBoxButtons.OK);
                        tbPassword.Clear(); //Clear tbUsername
                        tbPassword.Focus(); //Focus tbUsername
                    }
                    else
                    {
                        //check to see if password corresponds to selected employee and get the empRole
                        bool correctPassword = false;

                        password = tbPassword.Text; //Password might have been re-entered and needs to be assigned

                        try
                        {
                            cnn = new SqlConnection(connectionString);
                            cnn.Open(); //Open connection

                            command = new SqlCommand("SELECT empPassword, empRole FROM Employees WHERE empEmail = @email", cnn); //Create new command instance with instruction
                            command.Parameters.AddWithValue("@email", email);

                            reader = command.ExecuteReader();

                            if (reader.Read()) //Check if a row was returned
                            {
                                string storedPassword = reader["empPassword"].ToString(); //Get the password from the query result

                                if (storedPassword == password)
                                {
                                    correctPassword = true; //Passwords match
                                    role = reader.GetValue(1).ToString(); //Store the employee role to send to other forms
                                }
                            }

                            cnn.Close(); //Close the connection

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error Connecting to Data Base", MessageBoxButtons.OK); //Error message
                        }

                        if (correctPassword) //Syntax to load next form
                        {
                            //Initialize and load the app interface form and send an instance of this form to the app interface form
                            AppInterface_Frm AppInterface_Frm = new AppInterface_Frm(this);
                            AppInterface_Frm.fEmployeeRole = role;
                            AppInterface_Frm.ShowDialog();
                        }
                        else //Password is incorrect, user must re enter
                        {
                            MessageBox.Show("Invalid Password.", "Incorrect", MessageBoxButtons.OK); //Error message
                            tbPassword.Clear(); //Clear tbPassword
                            tbPassword.Focus(); //Focus tbPassword
                        }
                    }
                }
                else //Email is not in table, user must re-enter
                {
                    MessageBox.Show("Invalid Email.", "Email Not Found", MessageBoxButtons.OK); //Error message
                    tbEmail.Focus(); //Focus tbEmail
                }
            }
        }
    }
}
