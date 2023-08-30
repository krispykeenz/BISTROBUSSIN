namespace Group_Project_Bistro_Bus
{
    partial class EditEmployeesFrm
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
            this.dgvViewEmployees = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFind = new System.Windows.Forms.Button();
            this.cbEmployeeRole = new System.Windows.Forms.ComboBox();
            this.lblEmployeeRole = new System.Windows.Forms.Label();
            this.tbTaxNumber = new System.Windows.Forms.TextBox();
            this.lblTaxNumber = new System.Windows.Forms.Label();
            this.tbCell = new System.Windows.Forms.TextBox();
            this.lblCell = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbEmployeeNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewEmployees)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            //
            //add tooltips
            this.tbEmployeeNumber.ToolTip = "Enter employee number to search";
            this.tbFirstName.ToolTip = "First name of employee";
            this.tbLastName.ToolTip = "Last name of employee";
            this.tbEmail.ToolTip = "Email address of employee";
            this.tbCell.ToolTip = "Cell phone number of employee";
            this.tbTaxNumber.ToolTip = "Tax number of employee";
            this.cbEmployeeRole.ToolTip = "Select new role for employee";
            this.btnFind.ToolTip = "Click to find employee record";
            this.btnUpdate.ToolTip = "Click to update employee record";
            this.btnBack.ToolTip = "Click to go back to previous screen";
            //
            // dgvViewEmployees
            // 
            this.dgvViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewEmployees.Location = new System.Drawing.Point(26, 23);
            this.dgvViewEmployees.Name = "dgvViewEmployees";
            this.dgvViewEmployees.Size = new System.Drawing.Size(748, 179);
            this.dgvViewEmployees.TabIndex = 4;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBack.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(26, 381);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(153, 46);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(621, 381);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(153, 46);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update Info";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.cbEmployeeRole);
            this.panel1.Controls.Add(this.lblEmployeeRole);
            this.panel1.Controls.Add(this.tbTaxNumber);
            this.panel1.Controls.Add(this.lblTaxNumber);
            this.panel1.Controls.Add(this.tbCell);
            this.panel1.Controls.Add(this.lblCell);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.tbLastName);
            this.panel1.Controls.Add(this.lblLastName);
            this.panel1.Controls.Add(this.tbFirstName);
            this.panel1.Controls.Add(this.lblFirstName);
            this.panel1.Controls.Add(this.tbEmployeeNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(26, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 148);
            this.panel1.TabIndex = 9;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(26, 82);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(153, 46);
            this.btnFind.TabIndex = 10;
            this.btnFind.Text = "Find Employee";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // cbEmployeeRole
            // 
            this.cbEmployeeRole.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmployeeRole.FormattingEnabled = true;
            this.cbEmployeeRole.Items.AddRange(new object[] {
            "Administrator",
            "Sales Manager",
            "Sales Representative"});
            this.cbEmployeeRole.Location = new System.Drawing.Point(631, 98);
            this.cbEmployeeRole.Name = "cbEmployeeRole";
            this.cbEmployeeRole.Size = new System.Drawing.Size(100, 33);
            this.cbEmployeeRole.TabIndex = 18;
            this.cbEmployeeRole.Visible = false;
            // 
            // lblEmployeeRole
            // 
            this.lblEmployeeRole.AutoSize = true;
            this.lblEmployeeRole.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeRole.Location = new System.Drawing.Point(503, 101);
            this.lblEmployeeRole.Name = "lblEmployeeRole";
            this.lblEmployeeRole.Size = new System.Drawing.Size(102, 29);
            this.lblEmployeeRole.TabIndex = 17;
            this.lblEmployeeRole.Text = "Employee Role:";
            this.lblEmployeeRole.Visible = false;
            // 
            // tbTaxNumber
            // 
            this.tbTaxNumber.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTaxNumber.Location = new System.Drawing.Point(631, 59);
            this.tbTaxNumber.Name = "tbTaxNumber";
            this.tbTaxNumber.Size = new System.Drawing.Size(100, 32);
            this.tbTaxNumber.TabIndex = 16;
            this.tbTaxNumber.Visible = false;
            // 
            // lblTaxNumber
            // 
            this.lblTaxNumber.AutoSize = true;
            this.lblTaxNumber.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxNumber.Location = new System.Drawing.Point(503, 60);
            this.lblTaxNumber.Name = "lblTaxNumber";
            this.lblTaxNumber.Size = new System.Drawing.Size(86, 29);
            this.lblTaxNumber.TabIndex = 15;
            this.lblTaxNumber.Text = "Tax Number:";
            this.lblTaxNumber.Visible = false;
            // 
            // tbCell
            // 
            this.tbCell.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCell.Location = new System.Drawing.Point(631, 19);
            this.tbCell.Name = "tbCell";
            this.tbCell.Size = new System.Drawing.Size(100, 32);
            this.tbCell.TabIndex = 14;
            this.tbCell.Visible = false;
            // 
            // lblCell
            // 
            this.lblCell.AutoSize = true;
            this.lblCell.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCell.Location = new System.Drawing.Point(503, 20);
            this.lblCell.Name = "lblCell";
            this.lblCell.Size = new System.Drawing.Size(123, 29);
            this.lblCell.TabIndex = 13;
            this.lblCell.Text = "Cellphone Number:";
            this.lblCell.Visible = false;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(387, 98);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 32);
            this.tbEmail.TabIndex = 12;
            this.tbEmail.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(259, 99);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 29);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email:";
            this.lblEmail.Visible = false;
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.Location = new System.Drawing.Point(387, 57);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 32);
            this.tbLastName.TabIndex = 10;
            this.tbLastName.Visible = false;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(259, 58);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(77, 29);
            this.lblLastName.TabIndex = 9;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.Visible = false;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.Location = new System.Drawing.Point(387, 17);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 32);
            this.tbFirstName.TabIndex = 8;
            this.tbFirstName.Visible = false;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(259, 18);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(80, 29);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.Visible = false;
            this.lblFirstName.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbEmployeeNumber
            // 
            this.tbEmployeeNumber.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmployeeNumber.Location = new System.Drawing.Point(149, 22);
            this.tbEmployeeNumber.Name = "tbEmployeeNumber";
            this.tbEmployeeNumber.Size = new System.Drawing.Size(100, 32);
            this.tbEmployeeNumber.TabIndex = 6;
            this.tbEmployeeNumber.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Employee Number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EditEmployeesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Group_Project_Bistro_Bus.Properties.Resources.EmployeeView_Background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvViewEmployees);
            this.Name = "EditEmployeesFrm";
            this.Text = "Edit Employee";
            this.Load += new System.EventHandler(this.EditEmployeesFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewEmployees)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvViewEmployees;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbEmployeeNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmployeeRole;
        private System.Windows.Forms.TextBox tbTaxNumber;
        private System.Windows.Forms.Label lblTaxNumber;
        private System.Windows.Forms.TextBox tbCell;
        private System.Windows.Forms.Label lblCell;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox cbEmployeeRole;
    }
}