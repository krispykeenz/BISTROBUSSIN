namespace Group_Project_Bistro_Bus
{
    partial class EditMenuItemFrm
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
            this.btnFind = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tbMenuItemDescription = new System.Windows.Forms.TextBox();
            this.lblMenuItemDescription = new System.Windows.Forms.Label();
            this.tbMenuItem = new System.Windows.Forms.TextBox();
            this.lblMenuItem = new System.Windows.Forms.Label();
            this.tbMenuItemNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvViewMenuItems = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewMenuItems)).BeginInit();
            this.SuspendLayout();
            //
            //add tooltips
            this.tbMenuItemNumber.ToolTip = "Enter menu item number to search";
            this.btnFind.ToolTip = "Click to find menu item";
            this.tbMenuItem.ToolTip = "Edit menu item name";
            this.tbMenuItemDescription.ToolTip = "Edit description for menu item";
            this.tbPrice.ToolTip = "Edit price for menu item";
            this.btnUpdate.ToolTip = "Click to update menu item";
            this.btnBack.ToolTip = "Click to go back to previous form";
            //
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.tbPrice);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.tbMenuItemDescription);
            this.panel1.Controls.Add(this.lblMenuItemDescription);
            this.panel1.Controls.Add(this.tbMenuItem);
            this.panel1.Controls.Add(this.lblMenuItem);
            this.panel1.Controls.Add(this.tbMenuItemNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(26, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 148);
            this.panel1.TabIndex = 13;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(26, 82);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(153, 46);
            this.btnFind.TabIndex = 10;
            this.btnFind.Text = "Find Menu Item";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(447, 58);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 32);
            this.tbPrice.TabIndex = 12;
            this.tbPrice.Visible = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(291, 63);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(58, 29);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "Price: R";
            this.lblPrice.Visible = false;
            // 
            // tbMenuItemDescription
            // 
            this.tbMenuItemDescription.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMenuItemDescription.Location = new System.Drawing.Point(447, 94);
            this.tbMenuItemDescription.Name = "tbMenuItemDescription";
            this.tbMenuItemDescription.Size = new System.Drawing.Size(281, 32);
            this.tbMenuItemDescription.TabIndex = 10;
            this.tbMenuItemDescription.Visible = false;
            // 
            // lblMenuItemDescription
            // 
            this.lblMenuItemDescription.AutoSize = true;
            this.lblMenuItemDescription.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuItemDescription.Location = new System.Drawing.Point(291, 99);
            this.lblMenuItemDescription.Name = "lblMenuItemDescription";
            this.lblMenuItemDescription.Size = new System.Drawing.Size(148, 29);
            this.lblMenuItemDescription.TabIndex = 9;
            this.lblMenuItemDescription.Text = "Menu Item Description:";
            this.lblMenuItemDescription.Visible = false;
            // 
            // tbMenuItem
            // 
            this.tbMenuItem.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMenuItem.Location = new System.Drawing.Point(447, 20);
            this.tbMenuItem.Name = "tbMenuItem";
            this.tbMenuItem.Size = new System.Drawing.Size(100, 32);
            this.tbMenuItem.TabIndex = 8;
            this.tbMenuItem.Visible = false;
            // 
            // lblMenuItem
            // 
            this.lblMenuItem.AutoSize = true;
            this.lblMenuItem.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuItem.Location = new System.Drawing.Point(291, 25);
            this.lblMenuItem.Name = "lblMenuItem";
            this.lblMenuItem.Size = new System.Drawing.Size(79, 29);
            this.lblMenuItem.TabIndex = 7;
            this.lblMenuItem.Text = "Menu Item:";
            this.lblMenuItem.Visible = false;
            // 
            // tbMenuItemNumber
            // 
            this.tbMenuItemNumber.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMenuItemNumber.Location = new System.Drawing.Point(149, 22);
            this.tbMenuItemNumber.Name = "tbMenuItemNumber";
            this.tbMenuItemNumber.Size = new System.Drawing.Size(100, 32);
            this.tbMenuItemNumber.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Menu Item Number:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Bisque;
            this.btnUpdate.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(621, 381);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(153, 46);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update Info";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Bisque;
            this.btnBack.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(26, 381);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(153, 46);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvViewMenuItems
            // 
            this.dgvViewMenuItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewMenuItems.Location = new System.Drawing.Point(26, 23);
            this.dgvViewMenuItems.Name = "dgvViewMenuItems";
            this.dgvViewMenuItems.Size = new System.Drawing.Size(748, 179);
            this.dgvViewMenuItems.TabIndex = 10;
            // 
            // EditMenuItemFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Group_Project_Bistro_Bus.Properties.Resources.Menu_Items_Background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvViewMenuItems);
            this.Name = "EditMenuItemFrm";
            this.Text = "Edit Menu Item";
            this.Load += new System.EventHandler(this.EditMenuItemFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewMenuItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox tbMenuItemDescription;
        private System.Windows.Forms.Label lblMenuItemDescription;
        private System.Windows.Forms.TextBox tbMenuItem;
        private System.Windows.Forms.Label lblMenuItem;
        private System.Windows.Forms.TextBox tbMenuItemNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvViewMenuItems;
    }
}