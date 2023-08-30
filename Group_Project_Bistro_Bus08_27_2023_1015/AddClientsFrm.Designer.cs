namespace Group_Project_Bistro_Bus
{
    partial class AddClientsFrm
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
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbClientAdress = new System.Windows.Forms.TextBox();
            this.tbClientCellPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblClientCellPhone = new System.Windows.Forms.Label();
            this.lbEmpEmail = new System.Windows.Forms.Label();
            this.lblClientAdress = new System.Windows.Forms.Label();
            this.tbClientName = new System.Windows.Forms.TextBox();
            this.lblClientName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBack.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(74, 256);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(153, 46);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.ToolTip = "Click to go back";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAdd.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(581, 256);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(153, 46);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add Client";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.ToolTip = "Click to add new client";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.tbClientAdress);
            this.panel1.Controls.Add(this.tbClientCellPhoneNumber);
            this.panel1.Controls.Add(this.lblClientCellPhone);
            this.panel1.Controls.Add(this.lbEmpEmail);
            this.panel1.Controls.Add(this.lblClientAdress);
            this.panel1.Controls.Add(this.tbClientName);
            this.panel1.Controls.Add(this.lblClientName);
            this.panel1.Location = new System.Drawing.Point(74, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 137);
            this.panel1.TabIndex = 14;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(497, 23);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(127, 37);
            this.tbEmail.TabIndex = 23;
            // 
            // tbClientAdress
            // 
            this.tbClientAdress.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClientAdress.Location = new System.Drawing.Point(183, 65);
            this.tbClientAdress.Name = "tbClientAdress";
            this.tbClientAdress.Size = new System.Drawing.Size(127, 37);
            this.tbClientAdress.TabIndex = 22;
            // 
            // tbClientCellPhoneNumber
            // 
            this.tbClientCellPhoneNumber.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClientCellPhoneNumber.Location = new System.Drawing.Point(497, 66);
            this.tbClientCellPhoneNumber.Name = "tbClientCellPhoneNumber";
            this.tbClientCellPhoneNumber.Size = new System.Drawing.Size(127, 37);
            this.tbClientCellPhoneNumber.TabIndex = 24;
            // 
            // lblClientCellPhone
            // 
            this.lblClientCellPhone.AutoSize = true;
            this.lblClientCellPhone.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCellPhone.Location = new System.Drawing.Point(339, 67);
            this.lblClientCellPhone.Name = "lblClientCellPhone";
            this.lblClientCellPhone.Size = new System.Drawing.Size(153, 36);
            this.lblClientCellPhone.TabIndex = 18;
            this.lblClientCellPhone.Text = "Cellphone Number:";
            // 
            // lbEmpEmail
            // 
            this.lbEmpEmail.AutoSize = true;
            this.lbEmpEmail.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpEmail.Location = new System.Drawing.Point(342, 24);
            this.lbEmpEmail.Name = "lbEmpEmail";
            this.lbEmpEmail.Size = new System.Drawing.Size(62, 36);
            this.lbEmpEmail.TabIndex = 17;
            this.lbEmpEmail.Text = "Email:";
            // 
            // lblClientAdress
            // 
            this.lblClientAdress.AutoSize = true;
            this.lblClientAdress.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientAdress.Location = new System.Drawing.Point(28, 66);
            this.lblClientAdress.Name = "lblClientAdress";
            this.lblClientAdress.Size = new System.Drawing.Size(68, 36);
            this.lblClientAdress.TabIndex = 16;
            this.lblClientAdress.Text = "Adress:";
            // 
            // tbClientName
            // 
            this.tbClientName.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClientName.Location = new System.Drawing.Point(183, 22);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(127, 37);
            this.tbClientName.TabIndex = 21;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(28, 23);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(61, 36);
            this.lblClientName.TabIndex = 14;
            this.lblClientName.Text = "Name:";
            // 
            // AddClientsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Group_Project_Bistro_Bus.Properties.Resources.Clients_Background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.Name = "AddClientsFrm";
            this.Text = "Add Client";
            this.Load += new System.EventHandler(this.AddClientsFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbClientAdress;
        private System.Windows.Forms.TextBox tbClientCellPhoneNumber;
        private System.Windows.Forms.Label lblClientCellPhone;
        private System.Windows.Forms.Label lbEmpEmail;
        private System.Windows.Forms.Label lblClientAdress;
        private System.Windows.Forms.TextBox tbClientName;
        private System.Windows.Forms.Label lblClientName;
    }
}