namespace Group_Project_Bistro_Bus
{
    partial class AddMenuItemFrm
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
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbMenuItemDescription = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblMenuItemDescription = new System.Windows.Forms.Label();
            this.tbMenuItem = new System.Windows.Forms.TextBox();
            this.lblMenuItem = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            //
            // add tooltips
            //
            this.tbMenuItem.ToolTip = "Enter menu item name";
            this.tbMenuItemDescription.ToolTip = "Enter description for menu item";
            this.tbPrice.ToolTip = "Enter price for menu item";
            this.btnAdd.ToolTip = "Click to add new menu item";
            this.btnBack.ToolTip = "Click to go back to previous form";
            //
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(237, 64);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(127, 37);
            this.tbPrice.TabIndex = 22;
            // 
            // tbMenuItemDescription
            // 
            this.tbMenuItemDescription.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMenuItemDescription.Location = new System.Drawing.Point(237, 107);
            this.tbMenuItemDescription.Name = "tbMenuItemDescription";
            this.tbMenuItemDescription.Size = new System.Drawing.Size(393, 37);
            this.tbMenuItemDescription.TabIndex = 23;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(38, 65);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(71, 36);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "Price: R";
            // 
            // lblMenuItemDescription
            // 
            this.lblMenuItemDescription.AutoSize = true;
            this.lblMenuItemDescription.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuItemDescription.Location = new System.Drawing.Point(38, 108);
            this.lblMenuItemDescription.Name = "lblMenuItemDescription";
            this.lblMenuItemDescription.Size = new System.Drawing.Size(184, 36);
            this.lblMenuItemDescription.TabIndex = 16;
            this.lblMenuItemDescription.Text = "Menu Item Description:";
            // 
            // tbMenuItem
            // 
            this.tbMenuItem.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMenuItem.Location = new System.Drawing.Point(237, 21);
            this.tbMenuItem.Name = "tbMenuItem";
            this.tbMenuItem.Size = new System.Drawing.Size(127, 37);
            this.tbMenuItem.TabIndex = 21;
            // 
            // lblMenuItem
            // 
            this.lblMenuItem.AutoSize = true;
            this.lblMenuItem.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuItem.Location = new System.Drawing.Point(38, 22);
            this.lblMenuItem.Name = "lblMenuItem";
            this.lblMenuItem.Size = new System.Drawing.Size(98, 36);
            this.lblMenuItem.TabIndex = 14;
            this.lblMenuItem.Text = "Menu Item:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Bisque;
            this.btnBack.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(66, 289);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(153, 46);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Bisque;
            this.btnAdd.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(573, 289);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(153, 46);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add Menu Item";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.tbPrice);
            this.panel1.Controls.Add(this.tbMenuItemDescription);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.lblMenuItemDescription);
            this.panel1.Controls.Add(this.tbMenuItem);
            this.panel1.Controls.Add(this.lblMenuItem);
            this.panel1.Location = new System.Drawing.Point(66, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 167);
            this.panel1.TabIndex = 14;
            // 
            // AddMenuItemFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Group_Project_Bistro_Bus.Properties.Resources.Menu_Items_Background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.Name = "AddMenuItemFrm";
            this.Text = "Add Menu Item";
            this.Load += new System.EventHandler(this.AddMenuItemFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbMenuItemDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblMenuItemDescription;
        private System.Windows.Forms.TextBox tbMenuItem;
        private System.Windows.Forms.Label lblMenuItem;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
    }
}