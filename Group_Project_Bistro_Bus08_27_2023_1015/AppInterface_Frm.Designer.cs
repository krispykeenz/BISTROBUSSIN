namespace Group_Project_Bistro_Bus
{
    partial class AppInterface_Frm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tsm1 = new System.Windows.Forms.MenuStrip();
            this.TsmEmp = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmEmp_existing = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmEmp_View = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmEmp_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmEmp_Remove = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmEmp_AddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmMenu_existing = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmMenu_View = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmMenu_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmMenu_AddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmClients = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmClients_existing = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmClients_View = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmClients_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmClients_AddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmBookings = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmBookings_existing = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmBookings_View = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmBookings_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmBookings_AddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmReports = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmReports_Emp = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmReports_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmReports_Client = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmReports_Booking = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMenuGreeting = new System.Windows.Forms.Label();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tsm1
            // 
            this.Tsm1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.Tsm1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmEmp,
            this.TsmMenu,
            this.TsmClients,
            this.TsmBookings,
            this.TsmReports,
            this.signOutToolStripMenuItem});
            this.Tsm1.Location = new System.Drawing.Point(0, 0);
            this.Tsm1.Name = "Tsm1";
            this.Tsm1.Size = new System.Drawing.Size(824, 24);
            this.Tsm1.TabIndex = 0;
            this.Tsm1.Text = "menuStrip1";
            // 
            // TsmEmp
            // 
            this.TsmEmp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmEmp_existing,
            this.TsmEmp_AddNew});
            this.TsmEmp.Name = "TsmEmp";
            this.TsmEmp.Size = new System.Drawing.Size(76, 20);
            this.TsmEmp.Text = "Employees";
            // 
            // TsmEmp_existing
            // 
            this.TsmEmp_existing.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmEmp_View,
            this.TsmEmp_Edit,
            this.TsmEmp_Remove});
            this.TsmEmp_existing.Name = "TsmEmp_existing";
            this.TsmEmp_existing.Size = new System.Drawing.Size(176, 22);
            this.TsmEmp_existing.Text = "Existing Employees";
            // 
            // TsmEmp_View
            // 
            this.TsmEmp_View.Name = "TsmEmp_View";
            this.TsmEmp_View.Size = new System.Drawing.Size(117, 22);
            this.TsmEmp_View.Text = "View ";
            this.TsmEmp_View.Click += new System.EventHandler(this.TsmEmp_View_Click);
            // 
            // TsmEmp_Edit
            // 
            this.TsmEmp_Edit.Name = "TsmEmp_Edit";
            this.TsmEmp_Edit.Size = new System.Drawing.Size(117, 22);
            this.TsmEmp_Edit.Text = "Edit";
            this.TsmEmp_Edit.Click += new System.EventHandler(this.TsmEmp_Edit_Click);
            // 
            // TsmEmp_Remove
            // 
            this.TsmEmp_Remove.Name = "TsmEmp_Remove";
            this.TsmEmp_Remove.Size = new System.Drawing.Size(117, 22);
            this.TsmEmp_Remove.Text = "Remove";
            this.TsmEmp_Remove.Click += new System.EventHandler(this.TsmEmp_Remove_Click);
            // 
            // TsmEmp_AddNew
            // 
            this.TsmEmp_AddNew.Name = "TsmEmp_AddNew";
            this.TsmEmp_AddNew.Size = new System.Drawing.Size(176, 22);
            this.TsmEmp_AddNew.Text = "Add new Employee";
            this.TsmEmp_AddNew.Click += new System.EventHandler(this.TsmEmp_AddNew_Click);
            // 
            // TsmMenu
            // 
            this.TsmMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmMenu_existing,
            this.TsmMenu_AddNew});
            this.TsmMenu.Name = "TsmMenu";
            this.TsmMenu.Size = new System.Drawing.Size(50, 20);
            this.TsmMenu.Text = "Menu";
            // 
            // TsmMenu_existing
            // 
            this.TsmMenu_existing.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmMenu_View,
            this.TsmMenu_Edit});
            this.TsmMenu_existing.Name = "TsmMenu_existing";
            this.TsmMenu_existing.Size = new System.Drawing.Size(150, 22);
            this.TsmMenu_existing.Text = "Existing Items";
            // 
            // TsmMenu_View
            // 
            this.TsmMenu_View.Name = "TsmMenu_View";
            this.TsmMenu_View.Size = new System.Drawing.Size(99, 22);
            this.TsmMenu_View.Text = "View";
            this.TsmMenu_View.Click += new System.EventHandler(this.TsmMenu_View_Click);
            // 
            // TsmMenu_Edit
            // 
            this.TsmMenu_Edit.Name = "TsmMenu_Edit";
            this.TsmMenu_Edit.Size = new System.Drawing.Size(99, 22);
            this.TsmMenu_Edit.Text = "Edit";
            this.TsmMenu_Edit.Click += new System.EventHandler(this.TsmMenu_Edit_Click);
            // 
            // TsmMenu_AddNew
            // 
            this.TsmMenu_AddNew.Name = "TsmMenu_AddNew";
            this.TsmMenu_AddNew.Size = new System.Drawing.Size(150, 22);
            this.TsmMenu_AddNew.Text = "Add New Item";
            this.TsmMenu_AddNew.Click += new System.EventHandler(this.TsmMenu_AddNew_Click);
            // 
            // TsmClients
            // 
            this.TsmClients.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmClients_existing,
            this.TsmClients_AddNew});
            this.TsmClients.Name = "TsmClients";
            this.TsmClients.Size = new System.Drawing.Size(55, 20);
            this.TsmClients.Text = "Clients";
            // 
            // TsmClients_existing
            // 
            this.TsmClients_existing.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmClients_View,
            this.TsmClients_Edit});
            this.TsmClients_existing.Name = "TsmClients_existing";
            this.TsmClients_existing.Size = new System.Drawing.Size(162, 22);
            this.TsmClients_existing.Text = "Existing Clients";
            // 
            // TsmClients_View
            // 
            this.TsmClients_View.Name = "TsmClients_View";
            this.TsmClients_View.Size = new System.Drawing.Size(99, 22);
            this.TsmClients_View.Text = "View";
            this.TsmClients_View.Click += new System.EventHandler(this.TsmClients_View_Click);
            // 
            // TsmClients_Edit
            // 
            this.TsmClients_Edit.Name = "TsmClients_Edit";
            this.TsmClients_Edit.Size = new System.Drawing.Size(99, 22);
            this.TsmClients_Edit.Text = "Edit";
            this.TsmClients_Edit.Click += new System.EventHandler(this.TsmClients_Edit_Click);
            // 
            // TsmClients_AddNew
            // 
            this.TsmClients_AddNew.Name = "TsmClients_AddNew";
            this.TsmClients_AddNew.Size = new System.Drawing.Size(162, 22);
            this.TsmClients_AddNew.Text = "Add New Clients";
            this.TsmClients_AddNew.Click += new System.EventHandler(this.TsmClients_AddNew_Click);
            // 
            // TsmBookings
            // 
            this.TsmBookings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmBookings_existing,
            this.TsmBookings_AddNew});
            this.TsmBookings.Name = "TsmBookings";
            this.TsmBookings.Size = new System.Drawing.Size(68, 20);
            this.TsmBookings.Text = "Bookings";
            // 
            // TsmBookings_existing
            // 
            this.TsmBookings_existing.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmBookings_View,
            this.TsmBookings_Edit});
            this.TsmBookings_existing.Name = "TsmBookings_existing";
            this.TsmBookings_existing.Size = new System.Drawing.Size(175, 22);
            this.TsmBookings_existing.Text = "Existing Bookings";
            // 
            // TsmBookings_View
            // 
            this.TsmBookings_View.Name = "TsmBookings_View";
            this.TsmBookings_View.Size = new System.Drawing.Size(99, 22);
            this.TsmBookings_View.Text = "View";
            this.TsmBookings_View.Click += new System.EventHandler(this.TsmBookings_View_Click);
            // 
            // TsmBookings_Edit
            // 
            this.TsmBookings_Edit.Name = "TsmBookings_Edit";
            this.TsmBookings_Edit.Size = new System.Drawing.Size(99, 22);
            this.TsmBookings_Edit.Text = "Edit";
            this.TsmBookings_Edit.Click += new System.EventHandler(this.TsmBookings_Edit_Click);
            // 
            // TsmBookings_AddNew
            // 
            this.TsmBookings_AddNew.Name = "TsmBookings_AddNew";
            this.TsmBookings_AddNew.Size = new System.Drawing.Size(175, 22);
            this.TsmBookings_AddNew.Text = "Add New Bookings";
            this.TsmBookings_AddNew.Click += new System.EventHandler(this.TsmBookings_AddNew_Click);
            // 
            // TsmReports
            // 
            this.TsmReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmReports_Emp,
            this.TsmReports_Menu,
            this.TsmReports_Client,
            this.TsmReports_Booking});
            this.TsmReports.Name = "TsmReports";
            this.TsmReports.Size = new System.Drawing.Size(59, 20);
            this.TsmReports.Text = "Reports";
            // 
            // TsmReports_Emp
            // 
            this.TsmReports_Emp.Name = "TsmReports_Emp";
            this.TsmReports_Emp.Size = new System.Drawing.Size(180, 22);
            this.TsmReports_Emp.Text = "Employee Reports";
            this.TsmReports_Emp.Click += new System.EventHandler(this.TsmReports_Emp_Click);
            // 
            // TsmReports_Menu
            // 
            this.TsmReports_Menu.Name = "TsmReports_Menu";
            this.TsmReports_Menu.Size = new System.Drawing.Size(180, 22);
            this.TsmReports_Menu.Text = "Menu Reports";
            this.TsmReports_Menu.Click += new System.EventHandler(this.TsmReports_Menu_Click);
            // 
            // TsmReports_Client
            // 
            this.TsmReports_Client.Name = "TsmReports_Client";
            this.TsmReports_Client.Size = new System.Drawing.Size(180, 22);
            this.TsmReports_Client.Text = "Client Reports";
            this.TsmReports_Client.Click += new System.EventHandler(this.TsmReports_Client_Click);
            // 
            // TsmReports_Booking
            // 
            this.TsmReports_Booking.Name = "TsmReports_Booking";
            this.TsmReports_Booking.Size = new System.Drawing.Size(180, 22);
            this.TsmReports_Booking.Text = "Booking Reports";
            this.TsmReports_Booking.Click += new System.EventHandler(this.TsmReports_Booking_Click);
            // 
            // lblMenuGreeting
            // 
            this.lblMenuGreeting.AutoSize = true;
            this.lblMenuGreeting.BackColor = System.Drawing.Color.Transparent;
            this.lblMenuGreeting.Font = new System.Drawing.Font("Javanese Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuGreeting.ForeColor = System.Drawing.Color.White;
            this.lblMenuGreeting.Location = new System.Drawing.Point(405, 74);
            this.lblMenuGreeting.Name = "lblMenuGreeting";
            this.lblMenuGreeting.Size = new System.Drawing.Size(0, 62);
            this.lblMenuGreeting.TabIndex = 9;
            this.lblMenuGreeting.Click += new System.EventHandler(this.label3_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // AppInterface_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Group_Project_Bistro_Bus.Properties.Resources.Main_Menu_Background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(824, 521);
            this.Controls.Add(this.lblMenuGreeting);
            this.Controls.Add(this.Tsm1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Tsm1;
            this.Name = "AppInterface_Frm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.AppInterface_Frm_Load);
            this.Tsm1.ResumeLayout(false);
            this.Tsm1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Tsm1;
        private System.Windows.Forms.ToolStripMenuItem TsmEmp;
        private System.Windows.Forms.ToolStripMenuItem TsmEmp_existing;
        private System.Windows.Forms.ToolStripMenuItem TsmEmp_View;
        private System.Windows.Forms.ToolStripMenuItem TsmEmp_Edit;
        private System.Windows.Forms.ToolStripMenuItem TsmEmp_Remove;
        private System.Windows.Forms.ToolStripMenuItem TsmEmp_AddNew;
        private System.Windows.Forms.ToolStripMenuItem TsmMenu;
        private System.Windows.Forms.ToolStripMenuItem TsmMenu_existing;
        private System.Windows.Forms.ToolStripMenuItem TsmMenu_View;
        private System.Windows.Forms.ToolStripMenuItem TsmMenu_Edit;
        private System.Windows.Forms.ToolStripMenuItem TsmMenu_AddNew;
        private System.Windows.Forms.ToolStripMenuItem TsmClients;
        private System.Windows.Forms.ToolStripMenuItem TsmClients_existing;
        private System.Windows.Forms.ToolStripMenuItem TsmClients_View;
        private System.Windows.Forms.ToolStripMenuItem TsmClients_Edit;
        private System.Windows.Forms.ToolStripMenuItem TsmClients_AddNew;
        private System.Windows.Forms.ToolStripMenuItem TsmBookings;
        private System.Windows.Forms.ToolStripMenuItem TsmBookings_existing;
        private System.Windows.Forms.ToolStripMenuItem TsmBookings_View;
        private System.Windows.Forms.ToolStripMenuItem TsmBookings_Edit;
        private System.Windows.Forms.ToolStripMenuItem TsmBookings_AddNew;
        private System.Windows.Forms.ToolStripMenuItem TsmReports;
        private System.Windows.Forms.ToolStripMenuItem TsmReports_Emp;
        private System.Windows.Forms.ToolStripMenuItem TsmReports_Menu;
        private System.Windows.Forms.ToolStripMenuItem TsmReports_Client;
        private System.Windows.Forms.ToolStripMenuItem TsmReports_Booking;
        private System.Windows.Forms.Label lblMenuGreeting;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
    }
}