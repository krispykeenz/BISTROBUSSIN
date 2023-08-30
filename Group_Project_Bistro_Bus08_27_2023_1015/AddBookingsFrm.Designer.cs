namespace Group_Project_Bistro_Bus
{
    partial class AddBookingsFrm
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbMenu = new System.Windows.Forms.ComboBox();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.cbIsPaid = new System.Windows.Forms.CheckBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tbEndDate = new System.Windows.Forms.TextBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.tbStartDate = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.tbVenue = new System.Windows.Forms.TextBox();
            this.tbEvent = new System.Windows.Forms.TextBox();
            this.lblVenue = new System.Windows.Forms.Label();
            this.lblEvent = new System.Windows.Forms.Label();
            this.lblMenuItem = new System.Windows.Forms.Label();
            this.lbClient = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnBack.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(70, 317);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(153, 46);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.tooltip = "Click to go back to the main menu";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(577, 317);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(153, 46);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add Booking";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.tooltip = "Click to add the new booking to the database";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel1.Controls.Add(this.cbMenu);
            this.panel1.Controls.Add(this.cbClient);
            this.panel1.Controls.Add(this.cbEmployee);
            this.panel1.Controls.Add(this.cbIsPaid);
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.tbEndDate);
            this.panel1.Controls.Add(this.lblEndDate);
            this.panel1.Controls.Add(this.tbStartDate);
            this.panel1.Controls.Add(this.lblStartDate);
            this.panel1.Controls.Add(this.tbVenue);
            this.panel1.Controls.Add(this.tbEvent);
            this.panel1.Controls.Add(this.lblVenue);
            this.panel1.Controls.Add(this.lblEvent);
            this.panel1.Controls.Add(this.lblMenuItem);
            this.panel1.Controls.Add(this.lbClient);
            this.panel1.Controls.Add(this.lblEmployee);
            this.panel1.Location = new System.Drawing.Point(70, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 240);
            this.panel1.TabIndex = 14;
            // 
            // cbMenu
            // 
            this.cbMenu.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMenu.FormattingEnabled = true;
            this.cbMenu.Items.AddRange(new object[] {
            "Pending",
            "Confirmed",
            "Cancelled"});
            this.cbMenu.Location = new System.Drawing.Point(193, 107);
            this.cbMenu.Name = "cbMenu";
            this.cbMenu.Size = new System.Drawing.Size(127, 37);
            this.cbMenu.TabIndex = 35;
            this.cbMenu.Visible = false;
            this.cbMenu.ToolTip = "Select the menu for this booking";   
            // 
            // cbClient
            // 
            this.cbClient.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Items.AddRange(new object[] {
            "Pending",
            "Confirmed",
            "Cancelled"});
            this.cbClient.Location = new System.Drawing.Point(193, 64);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(127, 37);
            this.cbClient.TabIndex = 34;
            this.cbClient.Visible = false;
            this.cbClient.ToolTip = "Select the client for this booking";
            // 
            // cbEmployee
            // 
            this.cbEmployee.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Items.AddRange(new object[] {
            "Pending",
            "Confirmed",
            "Cancelled"});
            this.cbEmployee.Location = new System.Drawing.Point(193, 21);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(127, 37);
            this.cbEmployee.TabIndex = 33;
            this.cbEmployee.Visible = false;
            this.cbEmployee.ToolTip = "Select the employee for this booking";
            // 
            // cbIsPaid
            // 
            this.cbIsPaid.AutoSize = true;
            this.cbIsPaid.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsPaid.Location = new System.Drawing.Point(532, 197);
            this.cbIsPaid.Name = "cbIsPaid";
            this.cbIsPaid.Size = new System.Drawing.Size(89, 40);
            this.cbIsPaid.TabIndex = 32;
            this.cbIsPaid.Text = "Is Paid?";
            this.cbIsPaid.UseVisualStyleBackColor = true;
            this.cbIsPaid.Visible = false;
            this.cbIsPaid.ToolTip = "Check if booking is paid";
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Pending",
            "Confirmed",
            "Cancelled"});
            this.cbStatus.Location = new System.Drawing.Point(494, 154);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(127, 37);
            this.cbStatus.TabIndex = 31;
            this.cbStatus.ToolTip = "Select the status for this booking";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(339, 155);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(65, 36);
            this.lblStatus.TabIndex = 30;
            this.lblStatus.Text = "Status:";
            // 
            // tbEndDate
            // 
            this.tbEndDate.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEndDate.Location = new System.Drawing.Point(494, 109);
            this.tbEndDate.Name = "tbEndDate";
            this.tbEndDate.Size = new System.Drawing.Size(127, 37);
            this.tbEndDate.TabIndex = 29;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(339, 110);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(87, 36);
            this.lblEndDate.TabIndex = 28;
            this.lblEndDate.Text = "End Date:";
            // 
            // tbStartDate
            // 
            this.tbStartDate.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStartDate.Location = new System.Drawing.Point(494, 66);
            this.tbStartDate.Name = "tbStartDate";
            this.tbStartDate.Size = new System.Drawing.Size(127, 37);
            this.tbStartDate.TabIndex = 27;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(339, 67);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(93, 36);
            this.lblStartDate.TabIndex = 26;
            this.lblStartDate.Text = "Start Date:";
            // 
            // tbVenue
            // 
            this.tbVenue.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVenue.Location = new System.Drawing.Point(494, 23);
            this.tbVenue.Name = "tbVenue";
            this.tbVenue.Size = new System.Drawing.Size(127, 37);
            this.tbVenue.TabIndex = 24;
            // 
            // tbEvent
            // 
            this.tbEvent.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEvent.Location = new System.Drawing.Point(193, 150);
            this.tbEvent.Name = "tbEvent";
            this.tbEvent.Size = new System.Drawing.Size(127, 37);
            this.tbEvent.TabIndex = 21;
            this.tbEvent.ToolTip = "Enter event details for this booking";
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenue.Location = new System.Drawing.Point(339, 24);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(64, 36);
            this.lblVenue.TabIndex = 19;
            this.lblVenue.Text = "Venue:";
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvent.Location = new System.Drawing.Point(35, 151);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(62, 36);
            this.lblEvent.TabIndex = 18;
            this.lblEvent.Text = "Event:";
            // 
            // lblMenuItem
            // 
            this.lblMenuItem.AutoSize = true;
            this.lblMenuItem.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuItem.Location = new System.Drawing.Point(35, 108);
            this.lblMenuItem.Name = "lblMenuItem";
            this.lblMenuItem.Size = new System.Drawing.Size(98, 36);
            this.lblMenuItem.TabIndex = 17;
            this.lblMenuItem.Text = "Menu Item:";
            // 
            // lbClient
            // 
            this.lbClient.AutoSize = true;
            this.lbClient.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClient.Location = new System.Drawing.Point(35, 65);
            this.lbClient.Name = "lbClient";
            this.lbClient.Size = new System.Drawing.Size(64, 36);
            this.lbClient.TabIndex = 16;
            this.lbClient.Text = "Client:";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(35, 22);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(90, 36);
            this.lblEmployee.TabIndex = 14;
            this.lblEmployee.Text = "Employee:";
            // 
            // AddBookingsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Group_Project_Bistro_Bus.Properties.Resources.Bookings_Background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.Name = "AddBookingsFrm";
            this.Text = "Add Booking";
            this.Load += new System.EventHandler(this.AddBookingsFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox tbVenue;
        private System.Windows.Forms.TextBox tbEvent;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Label lblMenuItem;
        private System.Windows.Forms.Label lbClient;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.TextBox tbEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.CheckBox cbIsPaid;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbMenu;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.ComboBox cbEmployee;
    }
}