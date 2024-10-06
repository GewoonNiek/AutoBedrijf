namespace AutoBedrijf
{
    partial class frmChangeAmount
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
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.pbProductPhoto = new System.Windows.Forms.PictureBox();
            this.lblAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // numAmount
            // 
            this.numAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAmount.Location = new System.Drawing.Point(219, 762);
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(407, 62);
            this.numAmount.TabIndex = 0;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(219, 877);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(407, 144);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // pbProductPhoto
            // 
            this.pbProductPhoto.Location = new System.Drawing.Point(156, 74);
            this.pbProductPhoto.Name = "pbProductPhoto";
            this.pbProductPhoto.Size = new System.Drawing.Size(553, 424);
            this.pbProductPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProductPhoto.TabIndex = 2;
            this.pbProductPhoto.TabStop = false;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(209, 668);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(350, 55);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Amount to add:";
            // 
            // frmChangeAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(916, 1050);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.pbProductPhoto);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.numAmount);
            this.Name = "frmChangeAmount";
            this.Text = "ChangeAmount";
            this.Load += new System.EventHandler(this.ChangeAmount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.PictureBox pbProductPhoto;
        private System.Windows.Forms.Label lblAmount;
    }
}