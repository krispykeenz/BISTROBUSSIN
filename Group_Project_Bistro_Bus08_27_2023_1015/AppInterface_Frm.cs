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

namespace Group_Project_Bistro_Bus
{
    public partial class AppInterface_Frm : Form
    {

        //variables
        Login_Frm Login_Frm; //Instance of the login form.
        public string fEmployeeRole = "";

        public AppInterface_Frm(Login_Frm Login_Frm)
        {
            InitializeComponent();
            this.LayoutMdi(MdiLayout.ArrangeIcons); // Disable automatic layout
            this.Login_Frm = Login_Frm;
        }

        private void TsmClients_View_Click(object sender, EventArgs e)
        {
            ViewClientsFrm myFormClientsView = new ViewClientsFrm(this);
            myFormClientsView.StartPosition = FormStartPosition.Manual;
            myFormClientsView.Location = new Point(0, 0);
            myFormClientsView.Show();
        }

        private void TsmClients_Edit_Click(object sender, EventArgs e)
        {
            EditClientsFrm myFormClientsEdit = new EditClientsFrm(this);
            myFormClientsEdit.StartPosition = FormStartPosition.Manual;
            myFormClientsEdit.Location = new Point(0, 0);
            myFormClientsEdit.Show();
        }

        private void TsmClients_AddNew_Click(object sender, EventArgs e)
        {
            AddClientsFrm myFormClientsAdd = new AddClientsFrm(this);
            myFormClientsAdd.StartPosition = FormStartPosition.Manual;
            myFormClientsAdd.Location = new Point(0, 0);
            myFormClientsAdd.Show();
        }

        private void TsmEmp_View_Click(object sender, EventArgs e)
        {
            ViewEmployeesFrm myFormEmployeesView = new ViewEmployeesFrm(this);
            myFormEmployeesView.StartPosition = FormStartPosition.Manual;
            myFormEmployeesView.Location = new Point(0, 0);
            myFormEmployeesView.Show();

        }

        private void TsmEmp_Edit_Click(object sender, EventArgs e)
        {
            EditEmployeesFrm myFormEmployeesEdit = new EditEmployeesFrm(this);
            myFormEmployeesEdit.StartPosition = FormStartPosition.Manual;
            myFormEmployeesEdit.Location = new Point(0, 0);
            myFormEmployeesEdit.Show();
        }

        private void TsmEmp_Remove_Click(object sender, EventArgs e)
        {
            RemoveEmployeesFrm myFormEmployeesRemove = new RemoveEmployeesFrm(this);
            myFormEmployeesRemove.StartPosition = FormStartPosition.Manual;
            myFormEmployeesRemove.Location = new Point(0, 0);
            myFormEmployeesRemove.Show();
        }

        private void TsmEmp_AddNew_Click(object sender, EventArgs e)
        {
            AddEmployeesFrm myFormEmployeesAdd = new AddEmployeesFrm(this);
            myFormEmployeesAdd.StartPosition = FormStartPosition.Manual;
            myFormEmployeesAdd.Location = new Point(0, 0);
            myFormEmployeesAdd.Show();
        }

        private void TsmMenu_View_Click(object sender, EventArgs e)
        {
            ViewMenuItemFrm myFormMenuItemsView = new ViewMenuItemFrm(this);
            myFormMenuItemsView.StartPosition = FormStartPosition.Manual;
            myFormMenuItemsView.Location = new Point(0, 0);
            myFormMenuItemsView.Show();
        }

        private void TsmMenu_Edit_Click(object sender, EventArgs e)
        {
            EditMenuItemFrm myFormMenuItemsEdit = new EditMenuItemFrm(this);
            myFormMenuItemsEdit.StartPosition = FormStartPosition.Manual;
            myFormMenuItemsEdit.Location = new Point(0, 0);
            myFormMenuItemsEdit.Show();
        }

        private void TsmMenu_AddNew_Click(object sender, EventArgs e)
        {
            AddMenuItemFrm myFormMenuItemsAdd = new AddMenuItemFrm(this);
            myFormMenuItemsAdd.StartPosition = FormStartPosition.Manual;
            myFormMenuItemsAdd.Location = new Point(0, 0);
            myFormMenuItemsAdd.Show();
        }

        private void TsmBookings_View_Click(object sender, EventArgs e)
        {
            ViewBookingsFrm myFormBookingsView = new ViewBookingsFrm(this);
            myFormBookingsView.StartPosition = FormStartPosition.Manual;
            myFormBookingsView.Location = new Point(0, 0);
            myFormBookingsView.Show();
        }

        private void TsmBookings_Edit_Click(object sender, EventArgs e)
        {
            EditBookingsFrm myFormBookingsEdit = new EditBookingsFrm(this);
            myFormBookingsEdit.StartPosition = FormStartPosition.Manual;
            myFormBookingsEdit.Location = new Point(0, 0);
            myFormBookingsEdit.Show();
        }

        private void TsmBookings_AddNew_Click(object sender, EventArgs e)
        {
            AddBookingsFrm myFormBookingsAdd = new AddBookingsFrm(this);
            myFormBookingsAdd.StartPosition = FormStartPosition.Manual;
            myFormBookingsAdd.Location = new Point(0, 0);
            myFormBookingsAdd.Show();
        }

        private void TsmReports_Emp_Click(object sender, EventArgs e)
        {
            EmpReportsFrm myFormEmpReports = new EmpReportsFrm(this);
            myFormEmpReports.StartPosition = FormStartPosition.Manual;
            myFormEmpReports.Location = new Point(0, 0);
            myFormEmpReports.Show();
        }

        private void TsmReports_Menu_Click(object sender, EventArgs e)
        {
            MenuReportsFrm myFormMenuReports = new MenuReportsFrm(this);
            myFormMenuReports.StartPosition = FormStartPosition.Manual;
            myFormMenuReports.Location = new Point(0, 0);
            myFormMenuReports.Show();
        }

        private void TsmReports_Client_Click(object sender, EventArgs e)
        {
            ClientsReportsFrm myFormClientsReports = new ClientsReportsFrm(this);
            myFormClientsReports.StartPosition = FormStartPosition.Manual;
            myFormClientsReports.Location = new Point(0, 0);
            myFormClientsReports.Show();
        }

        private void TsmReports_Booking_Click(object sender, EventArgs e)
        {
            BookingsReportsFrm myFormBookingsReports = new BookingsReportsFrm(this);
            myFormBookingsReports.StartPosition = FormStartPosition.Manual;
            myFormBookingsReports.Location = new Point(0, 0);
            myFormBookingsReports.Show();
        }

        private void AppInterface_Frm_Load(object sender, EventArgs e)
        {
            Console.WriteLine(fEmployeeRole, "From AppInterface Load Method");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login_Frm myFormLogin = new Login_Frm(this);
            myFormLogin.Show();
            this.Close();
        }
    }
}   
