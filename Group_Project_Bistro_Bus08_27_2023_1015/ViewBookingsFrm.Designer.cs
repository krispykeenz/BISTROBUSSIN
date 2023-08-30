namespace Group_Project_Bistro_Bus
{
    partial class ViewBookingsFrm
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
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.btnNextWeek = new System.Windows.Forms.Button();
            this.btnAllBookings = new System.Windows.Forms.Button();
            this.dgvViewBookings = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnBack.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(26, 382);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(153, 46);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnNextMonth.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextMonth.Location = new System.Drawing.Point(621, 382);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(153, 46);
            this.btnNextMonth.TabIndex = 8;
            this.btnNextMonth.Text = "Next Month";
            this.btnNextMonth.UseVisualStyleBackColor = false;
            // 
            // btnNextWeek
            // 
            this.btnNextWeek.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnNextWeek.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextWeek.Location = new System.Drawing.Point(462, 382);
            this.btnNextWeek.Name = "btnNextWeek";
            this.btnNextWeek.Size = new System.Drawing.Size(153, 46);
            this.btnNextWeek.TabIndex = 7;
            this.btnNextWeek.Text = "Next Week";
            this.btnNextWeek.UseVisualStyleBackColor = false;
            // 
            // btnAllBookings
            // 
            this.btnAllBookings.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnAllBookings.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllBookings.Location = new System.Drawing.Point(303, 382);
            this.btnAllBookings.Name = "btnAllBookings";
            this.btnAllBookings.Size = new System.Drawing.Size(153, 46);
            this.btnAllBookings.TabIndex = 6;
            this.btnAllBookings.Text = "All Bookings";
            this.btnAllBookings.UseVisualStyleBackColor = false;
            // 
            // dgvViewBookings
            // 
            this.dgvViewBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewBookings.Location = new System.Drawing.Point(26, 23);
            this.dgvViewBookings.Name = "dgvViewBookings";
            this.dgvViewBookings.Size = new System.Drawing.Size(748, 340);
            this.dgvViewBookings.TabIndex = 5;
            // 
            // ViewBookingsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Group_Project_Bistro_Bus.Properties.Resources.Bookings_Background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNextMonth);
            this.Controls.Add(this.btnNextWeek);
            this.Controls.Add(this.btnAllBookings);
            this.Controls.Add(this.dgvViewBookings);
            this.Name = "ViewBookingsFrm";
            this.Text = "View Bookings";
            this.Load += new System.EventHandler(this.ViewBookingsFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewBookings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNextMonth;
        private System.Windows.Forms.Button btnNextWeek;
        private System.Windows.Forms.Button btnAllBookings;
        private System.Windows.Forms.DataGridView dgvViewBookings;
    }
}