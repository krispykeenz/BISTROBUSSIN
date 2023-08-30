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
    public partial class ViewClientsFrm : Form
    {
        //Variables & Declaration for parent form that gets referenced
        AppInterface_Frm parentForm;
        public String sqlQuery = @"SELECT * FROM Clients";
        public String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Bistro_BusDB.mdf;Integrated Security = True";
        public SqlConnection cnn;

        public ViewClientsFrm(AppInterface_Frm parentForm)
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

        private void ViewClientsFrm_Load(object sender, EventArgs e)
        {
            this.reloadClients(); //Call Method
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
    }
}
