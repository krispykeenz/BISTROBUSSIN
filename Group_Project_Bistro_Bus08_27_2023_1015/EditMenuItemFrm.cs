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
    public partial class EditMenuItemFrm : Form
    {
        //Variable Declaration for parent form that gets referenced
        AppInterface_Frm parentForm;

        //Global Variables
        public String sqlQuery = @"SELECT * FROM Menus";
        //public int fCurrentUser;

        //Global connection string variable declaration
        public String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Bistro_BusDB.mdf;Integrated Security = True";
        public SqlConnection cnn;

        public EditMenuItemFrm(AppInterface_Frm parentForm)
        {
            InitializeComponent();

            //Set parent form
            MdiParent = parentForm;
            this.parentForm = parentForm;
        }

        private void EditMenuItemFrm_Load(object sender, EventArgs e)
        {
            this.reloadMenus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Close current Form
            this.Close();
        }

        private void reloadMenus()
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
                myAdapter.Fill(myDataSet, "Menus");

                //Add Data to DataGridView
                dgvViewMenuItems.DataSource = myDataSet;
                dgvViewMenuItems.DataMember = "Menus";

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

        private void btnFind_Click(object sender, EventArgs e)
        {
            string menuToFind = tbMenuItemNumber.Text;

            try
            {
                cnn = new SqlConnection(connectionString);
                cnn.Open(); // Open connection

                SqlCommand myCommand = new SqlCommand("SELECT menuNum, menuItem, menuDescription, menuPrice FROM Menus WHERE menuNum = @menuToFind", cnn); // Create new command instance with instruction
                myCommand.Parameters.AddWithValue("@menuToFind", menuToFind);

                SqlDataReader datareader;
                datareader = myCommand.ExecuteReader();

                int count = 0;

                if (datareader.HasRows)
                {
                    while (datareader.Read())
                    {
                        count++;
                        tbMenuItem.Text = datareader.GetValue(1).ToString();
                        tbMenuItemDescription.Text = datareader.GetValue(2).ToString();
                        tbPrice.Text = datareader.GetValue(3).ToString();
                    }
                }

                if (count == 1)
                {
                    // Display fields and enable buttons as needed
                    lblMenuItem.Visible = true;
                    lblMenuItemDescription.Visible = true;
                    lblPrice.Visible = true;

                    tbMenuItem.Visible = true;
                    tbMenuItemDescription.Visible = true;
                    tbPrice.Visible = true;

                    btnUpdate.Enabled = true;
                }

                cnn.Close();

                // Reload menus or perform other actions
                this.reloadMenus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Connecting to Database", MessageBoxButtons.OK); // Error message
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Open connection
                cnn.Open();

                // Variable declaration
                string menuNum = tbMenuItemNumber.Text;

                // Update menu item based on user input values
                string sql_queryUpdate = "UPDATE Menus SET menuItem = @MenuItem, menuDescription = @MenuDescription, menuPrice = @MenuPrice WHERE menuNum = @MenuNum";
                SqlCommand myCommandUpdate = new SqlCommand(sql_queryUpdate, cnn);
                myCommandUpdate.Parameters.AddWithValue("@MenuNum", menuNum);
                myCommandUpdate.Parameters.AddWithValue("@MenuItem", tbMenuItem.Text);
                myCommandUpdate.Parameters.AddWithValue("@MenuDescription", tbMenuItemDescription.Text);
                myCommandUpdate.Parameters.AddWithValue("@MenuPrice", Convert.ToDecimal(tbPrice.Text));

                myCommandUpdate.ExecuteNonQuery();

                // Confirmation message
                MessageBox.Show("Menu item details updated successfully.");

                // Close connection
                cnn.Close();

                // Reload menus or perform other actions
                this.reloadMenus();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
