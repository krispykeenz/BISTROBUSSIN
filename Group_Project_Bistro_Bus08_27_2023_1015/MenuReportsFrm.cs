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
    public partial class MenuReportsFrm : Form
    {
        //Variable Declaration for parent form that gets referenced
        AppInterface_Frm parentForm;

        public MenuReportsFrm(AppInterface_Frm parentForm)
        {
            InitializeComponent();

            //Set parent form
            MdiParent = parentForm;
            this.parentForm = parentForm;
        }

        // Bookings Report
        private void GenerateBookingsReport()
        {

            // Connect to database
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            // Query bookings with joins to get related data
            string query = @"SELECT b.BookingID, b.BookingDate, c.ClientName, e.EmpName, m.MenuName
                  FROM Bookings b 
                  INNER JOIN Clients c ON b.ClientID = c.ClientID
                  INNER JOIN Employees e ON b.EmpID = e.EmpID 
                  INNER JOIN Menus m ON b.MenuID = m.MenuID
                  ORDER BY b.BookingDate";

            // Create data adapter and dataset
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            // Bind dataset to report viewer
            reportViewer.LocalReport.ReportEmbeddedResource = "ReportBookings.rdlc";
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Bookings", ds.Tables[0]));

            reportViewer.RefreshReport();
        }

        // Clients Report
        private void GenerateClientsReport()
        {
            // Connect to database
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            // Query clients
            string query = @"SELECT ClientID, ClientName, ClientAddress, ClientEmail, ClientPhone
                  FROM Clients
                  ORDER BY ClientName";

            // Create data adapter and dataset
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            // Bind dataset to report viewer
            reportViewer.LocalReport.ReportEmbeddedResource = "ReportClients.rdlc";  
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Clients", ds.Tables[0]));

            reportViewer.RefreshReport();
        }

        // Menu Report
            private void GenerateMenuReport() 
            {

             // Connect to database
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            // Query menus with pricing summary
            string query = @"SELECT m.MenuID, m.MenuName, COUNT(mi.MenuItemID) AS NumItems, 
                            AVG(mi.Price) AS AvgPrice, MAX(mi.Price) AS HighestPrice,
                            MIN(mi.Price) AS LowestPrice
                            FROM Menus m
                            INNER JOIN MenuItems mi ON m.MenuID = mi.MenuID 
                            GROUP BY m.MenuID, m.MenuName
                            ORDER BY m.MenuName";
                            
            // Create data adapter and dataset
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            // Bind dataset to report viewer
            reportViewer.LocalReport.ReportEmbeddedResource = "ReportMenus.rdlc";  
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Menus", ds.Tables[0]));

            reportViewer.RefreshReport();;

            }

        // Employees Report 
        private void GenerateEmployeesReport() 
        {
        
        SqlConnection conn = new SqlConnection(connectionString);
        conn.Open();

        // Query employees
        string query = @"SELECT EmpID, EmpName, EmpEmail, EmpPhone, EmpSalary, EmpHireDate 
                        FROM Employees
                        ORDER BY EmpName";
            

        // Create data adapter and dataset
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

        // Bind dataset to report viewer
        reportViewer.LocalReport.ReportEmbeddedResource = "ReportEmployees.rdlc";  
        reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Employees", ds.Tables[0]));
    
        reportViewer.RefreshReport();;    
        }
    }
}

