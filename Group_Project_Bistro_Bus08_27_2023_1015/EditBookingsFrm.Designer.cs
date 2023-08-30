namespace Group_Project_Bistro_Bus
{
    partial class EditBookingsFrm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbIsPaid = new System.Windows.Forms.CheckBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.tbEndDate = new System.Windows.Forms.TextBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.tbStartDate = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tbVenue = new System.Windows.Forms.TextBox();
            this.lblVenue = new System.Windows.Forms.Label();
            this.tbEventName = new System.Windows.Forms.TextBox();
            this.lblEventName = new System.Windows.Forms.Label();
            this.tbBookingNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvViewBookings = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewBookings)).BeginInit();
            this.SuspendLayout();
            //
            // add tooltips
            this.tbBookingNumber.ToolTip = "Enter the booking number to search"; 
            this.tbEventName.ToolTip = "Displays the event name for the booking";
            this.tbVenue.ToolTip = "Displays the venue for the booking";
            this.tbStartDate.ToolTip = "Displays the start date for the booking";
            this.tbEndDate.ToolTip = "Displays the end date for the booking";
            this.cbStatus.ToolTip = "Displays the status of the booking";
            this.cbIsPaid.ToolTip = "Check if the booking has been paid";
            this.btnFind.ToolTip = "Click to find the booking details";
            this.btnUpdate.ToolTip = "Click to update the booking details"; 
            this.btnBack.ToolTip = "Click to go back to the previous form";
            //
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel1.Controls.Add(this.cbIsPaid);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Controls.Add(this.tbEndDate);
            this.panel1.Controls.Add(this.lblEndDate);
            this.panel1.Controls.Add(this.tbStartDate);
            this.panel1.Controls.Add(this.lblStartDate);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.tbVenue);
            this.panel1.Controls.Add(this.lblVenue);
            this.panel1.Controls.Add(this.tbEventName);
            this.panel1.Controls.Add(this.lblEventName);
            this.panel1.Controls.Add(this.tbBookingNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(26, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 165);
            this.panel1.TabIndex = 13;
            // 
            // cbIsPaid
            // 
            this.cbIsPaid.AutoSize = true;
            this.cbIsPaid.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsPaid.Location = new System.Drawing.Point(645, 108);
            this.cbIsPaid.Name = "cbIsPaid";
            this.cbIsPaid.Size = new System.Drawing.Size(89, 40);
            this.cbIsPaid.TabIndex = 19;
            this.cbIsPaid.Text = "Is Paid?";
            this.cbIsPaid.UseVisualStyleBackColor = true;
            this.cbIsPaid.Visible = false;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(27, 101);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(153, 46);
            this.btnFind.TabIndex = 10;
            this.btnFind.Text = "Find Booking";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Pending",
            "Confirmed",
            "Cancelled"});
            this.cbStatus.Location = new System.Drawing.Point(390, 111);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(100, 37);
            this.cbStatus.TabIndex = 18;
            this.cbStatus.Visible = false;
            // 
            // tbEndDate
            // 
            this.tbEndDate.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEndDate.Location = new System.Drawing.Point(634, 70);
            this.tbEndDate.Name = "tbEndDate";
            this.tbEndDate.Size = new System.Drawing.Size(100, 37);
            this.tbEndDate.TabIndex = 16;
            this.tbEndDate.Visible = false;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(506, 71);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(87, 36);
            this.lblEndDate.TabIndex = 15;
            this.lblEndDate.Text = "End Date:";
            this.lblEndDate.Visible = false;
            // 
            // tbStartDate
            // 
            this.tbStartDate.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStartDate.Location = new System.Drawing.Point(634, 25);
            this.tbStartDate.Name = "tbStartDate";
            this.tbStartDate.Size = new System.Drawing.Size(100, 37);
            this.tbStartDate.TabIndex = 14;
            this.tbStartDate.Visible = false;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(506, 26);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(93, 36);
            this.lblStartDate.TabIndex = 13;
            this.lblStartDate.Text = "Start Date:";
            this.lblStartDate.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(262, 113);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(65, 36);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status:";
            this.lblStatus.Visible = false;
            // 
            // tbVenue
            // 
            this.tbVenue.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVenue.Location = new System.Drawing.Point(390, 68);
            this.tbVenue.Name = "tbVenue";
            this.tbVenue.Size = new System.Drawing.Size(100, 37);
            this.tbVenue.TabIndex = 10;
            this.tbVenue.Visible = false;
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenue.Location = new System.Drawing.Point(262, 69);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(64, 36);
            this.lblVenue.TabIndex = 9;
            this.lblVenue.Text = "Venue:";
            this.lblVenue.Visible = false;
            // 
            // tbEventName
            // 
            this.tbEventName.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEventName.Location = new System.Drawing.Point(390, 23);
            this.tbEventName.Name = "tbEventName";
            this.tbEventName.Size = new System.Drawing.Size(100, 37);
            this.tbEventName.TabIndex = 8;
            this.tbEventName.Visible = false;
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.Location = new System.Drawing.Point(262, 24);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(107, 36);
            this.lblEventName.TabIndex = 7;
            this.lblEventName.Text = "Event Name:";
            this.lblEventName.Visible = false;
            // 
            // tbBookingNumber
            // 
            this.tbBookingNumber.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBookingNumber.Location = new System.Drawing.Point(149, 22);
            this.tbBookingNumber.Name = "tbBookingNumber";
            this.tbBookingNumber.Size = new System.Drawing.Size(100, 37);
            this.tbBookingNumber.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Booking Number:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnBack.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(26, 381);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(153, 46);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnUpdate.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(621, 381);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(153, 46);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update Info";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvViewBookings
            // 
            this.dgvViewBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewBookings.Location = new System.Drawing.Point(26, 23);
            this.dgvViewBookings.Name = "dgvViewBookings";
            this.dgvViewBookings.Size = new System.Drawing.Size(748, 181);
            this.dgvViewBookings.TabIndex = 10;
            // 
            // EditBookingsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Group_Project_Bistro_Bus.Properties.Resources.Bookings_Background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvViewBookings);
            this.Name = "EditBookingsFrm";
            this.Text = "Edit Booking";
            this.Load += new System.EventHandler(this.EditBookingsFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewBookings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox tbEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.TextBox tbStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox tbVenue;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.TextBox tbEventName;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.TextBox tbBookingNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvViewBookings;
        private System.Windows.Forms.CheckBox cbIsPaid;
    }
}