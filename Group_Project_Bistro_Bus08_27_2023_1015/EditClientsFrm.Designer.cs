namespace Group_Project_Bistro_Bus
{
    partial class EditClientsFrm
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
            this.dgvViewClients = new System.Windows.Forms.DataGridView();
            this.btnFind = new System.Windows.Forms.Button();
            this.tbClientAdress = new System.Windows.Forms.TextBox();
            this.lblClientAdress = new System.Windows.Forms.Label();
            this.tbClientName = new System.Windows.Forms.TextBox();
            this.lblClientName = new System.Windows.Forms.Label();
            this.tbClientNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbCellphoneNumber = new System.Windows.Forms.TextBox();
            this.lblCellphoneNumber = new System.Windows.Forms.Label();
            this.tbClientEmail = new System.Windows.Forms.TextBox();
            this.lblClientEmail = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewClients)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            //
            //add tooltips
            this.tbClientNumber.ToolTip = "Enter client number to search";
            this.btnFind.ToolTip = "Click to find client record";
            this.tbClientName.ToolTip = "Edit client name here";
            this.tbClientAdress.ToolTip = "Edit client address here";
            this.tbCellphoneNumber.ToolTip = "Edit client cellphone number here";
            this.tbClientEmail.ToolTip = "Edit client email here";
            this.btnUpdate.ToolTip = "Click to update client record";
            this.btnBack.ToolTip = "Click to go back to previous form";
            //
            // dgvViewClients
            // 
            this.dgvViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewClients.Location = new System.Drawing.Point(26, 23);
            this.dgvViewClients.Name = "dgvViewClients";
            this.dgvViewClients.Size = new System.Drawing.Size(748, 194);
            this.dgvViewClients.TabIndex = 14;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(28, 65);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(153, 46);
            this.btnFind.TabIndex = 10;
            this.btnFind.Text = "Find Client";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tbClientAdress
            // 
            this.tbClientAdress.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClientAdress.Location = new System.Drawing.Point(369, 60);
            this.tbClientAdress.Name = "tbClientAdress";
            this.tbClientAdress.Size = new System.Drawing.Size(100, 32);
            this.tbClientAdress.TabIndex = 12;
            this.tbClientAdress.Visible = false;
            // 
            // lblClientAdress
            // 
            this.lblClientAdress.AutoSize = true;
            this.lblClientAdress.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientAdress.Location = new System.Drawing.Point(275, 65);
            this.lblClientAdress.Name = "lblClientAdress";
            this.lblClientAdress.Size = new System.Drawing.Size(54, 29);
            this.lblClientAdress.TabIndex = 11;
            this.lblClientAdress.Text = "Adress:";
            this.lblClientAdress.Visible = false;
            // 
            // tbClientName
            // 
            this.tbClientName.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClientName.Location = new System.Drawing.Point(369, 22);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(100, 32);
            this.tbClientName.TabIndex = 8;
            this.tbClientName.Visible = false;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(275, 27);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(50, 29);
            this.lblClientName.TabIndex = 7;
            this.lblClientName.Text = "Name:";
            this.lblClientName.Visible = false;
            // 
            // tbClientNumber
            // 
            this.tbClientNumber.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClientNumber.Location = new System.Drawing.Point(151, 24);
            this.tbClientNumber.Name = "tbClientNumber";
            this.tbClientNumber.Size = new System.Drawing.Size(100, 32);
            this.tbClientNumber.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Client Number:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.tbCellphoneNumber);
            this.panel1.Controls.Add(this.lblCellphoneNumber);
            this.panel1.Controls.Add(this.tbClientEmail);
            this.panel1.Controls.Add(this.lblClientEmail);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.tbClientAdress);
            this.panel1.Controls.Add(this.lblClientAdress);
            this.panel1.Controls.Add(this.tbClientName);
            this.panel1.Controls.Add(this.lblClientName);
            this.panel1.Controls.Add(this.tbClientNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(26, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 128);
            this.panel1.TabIndex = 17;
            // 
            // tbCellphoneNumber
            // 
            this.tbCellphoneNumber.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCellphoneNumber.Location = new System.Drawing.Point(621, 60);
            this.tbCellphoneNumber.Name = "tbCellphoneNumber";
            this.tbCellphoneNumber.Size = new System.Drawing.Size(100, 32);
            this.tbCellphoneNumber.TabIndex = 16;
            this.tbCellphoneNumber.Visible = false;
            // 
            // lblCellphoneNumber
            // 
            this.lblCellphoneNumber.AutoSize = true;
            this.lblCellphoneNumber.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellphoneNumber.Location = new System.Drawing.Point(489, 65);
            this.lblCellphoneNumber.Name = "lblCellphoneNumber";
            this.lblCellphoneNumber.Size = new System.Drawing.Size(123, 29);
            this.lblCellphoneNumber.TabIndex = 15;
            this.lblCellphoneNumber.Text = "Cellphone Number:";
            this.lblCellphoneNumber.Visible = false;
            // 
            // tbClientEmail
            // 
            this.tbClientEmail.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClientEmail.Location = new System.Drawing.Point(621, 22);
            this.tbClientEmail.Name = "tbClientEmail";
            this.tbClientEmail.Size = new System.Drawing.Size(100, 32);
            this.tbClientEmail.TabIndex = 14;
            this.tbClientEmail.Visible = false;
            // 
            // lblClientEmail
            // 
            this.lblClientEmail.AutoSize = true;
            this.lblClientEmail.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientEmail.Location = new System.Drawing.Point(489, 27);
            this.lblClientEmail.Name = "lblClientEmail";
            this.lblClientEmail.Size = new System.Drawing.Size(51, 29);
            this.lblClientEmail.TabIndex = 13;
            this.lblClientEmail.Text = "Email:";
            this.lblClientEmail.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(621, 381);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(153, 46);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update Info";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBack.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(26, 381);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(153, 46);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // EditClientsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Group_Project_Bistro_Bus.Properties.Resources.Clients_Background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvViewClients);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBack);
            this.Name = "EditClientsFrm";
            this.Text = "Edit Client";
            this.Load += new System.EventHandler(this.EditClientsFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewClients)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewClients;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox tbClientAdress;
        private System.Windows.Forms.Label lblClientAdress;
        private System.Windows.Forms.TextBox tbClientName;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.TextBox tbClientNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox tbCellphoneNumber;
        private System.Windows.Forms.Label lblCellphoneNumber;
        private System.Windows.Forms.TextBox tbClientEmail;
        private System.Windows.Forms.Label lblClientEmail;
    }
}