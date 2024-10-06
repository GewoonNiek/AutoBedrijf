namespace AutoBedrijf
{
    partial class frmAdminPanel
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
            this.lblAddInventory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbInventory = new System.Windows.Forms.PictureBox();
            this.pbRemoveUsers = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemoveUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddInventory
            // 
            this.lblAddInventory.AutoSize = true;
            this.lblAddInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddInventory.Location = new System.Drawing.Point(484, 227);
            this.lblAddInventory.Name = "lblAddInventory";
            this.lblAddInventory.Size = new System.Drawing.Size(391, 67);
            this.lblAddInventory.TabIndex = 0;
            this.lblAddInventory.Text = "Add inventory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 67);
            this.label1.TabIndex = 1;
            this.label1.Text = "Remove users";
            // 
            // pbInventory
            // 
            this.pbInventory.Image = global::AutoBedrijf.Properties.Resources.add_1_icon__flatastic_1_iconset__custom_icon_design_0;
            this.pbInventory.Location = new System.Drawing.Point(496, 363);
            this.pbInventory.Name = "pbInventory";
            this.pbInventory.Size = new System.Drawing.Size(349, 349);
            this.pbInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInventory.TabIndex = 2;
            this.pbInventory.TabStop = false;
            this.pbInventory.Click += new System.EventHandler(this.pbInventory_Click);
            // 
            // pbRemoveUsers
            // 
            this.pbRemoveUsers.Image = global::AutoBedrijf.Properties.Resources._3276535;
            this.pbRemoveUsers.Location = new System.Drawing.Point(53, 363);
            this.pbRemoveUsers.Name = "pbRemoveUsers";
            this.pbRemoveUsers.Size = new System.Drawing.Size(349, 349);
            this.pbRemoveUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRemoveUsers.TabIndex = 3;
            this.pbRemoveUsers.TabStop = false;
            this.pbRemoveUsers.Click += new System.EventHandler(this.pbRemoveUsers_Click);
            // 
            // frmAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(914, 1213);
            this.Controls.Add(this.pbRemoveUsers);
            this.Controls.Add(this.pbInventory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAddInventory);
            this.Name = "frmAdminPanel";
            this.Text = "Admin Panel";
            ((System.ComponentModel.ISupportInitialize)(this.pbInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemoveUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddInventory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbInventory;
        private System.Windows.Forms.PictureBox pbRemoveUsers;
    }
}