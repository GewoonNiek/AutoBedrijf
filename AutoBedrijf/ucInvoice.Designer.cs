namespace AutoBedrijf
{
    partial class ucInvoice
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCheckInvoice = new System.Windows.Forms.Button();
            this.lblInvoiceID = new System.Windows.Forms.Label();
            this.lblInvoiceID2 = new System.Windows.Forms.Label();
            this.lblTotalPrice2 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheckInvoice
            // 
            this.btnCheckInvoice.Location = new System.Drawing.Point(481, 20);
            this.btnCheckInvoice.Name = "btnCheckInvoice";
            this.btnCheckInvoice.Size = new System.Drawing.Size(125, 41);
            this.btnCheckInvoice.TabIndex = 0;
            this.btnCheckInvoice.Text = "Check";
            this.btnCheckInvoice.UseVisualStyleBackColor = true;
            this.btnCheckInvoice.Click += new System.EventHandler(this.btnCheckInvoice_Click);
            // 
            // lblInvoiceID
            // 
            this.lblInvoiceID.AutoSize = true;
            this.lblInvoiceID.Location = new System.Drawing.Point(25, 36);
            this.lblInvoiceID.Name = "lblInvoiceID";
            this.lblInvoiceID.Size = new System.Drawing.Size(100, 25);
            this.lblInvoiceID.TabIndex = 1;
            this.lblInvoiceID.Text = "InvoiceID";
            // 
            // lblInvoiceID2
            // 
            this.lblInvoiceID2.AutoSize = true;
            this.lblInvoiceID2.Location = new System.Drawing.Point(25, 9);
            this.lblInvoiceID2.Name = "lblInvoiceID2";
            this.lblInvoiceID2.Size = new System.Drawing.Size(112, 25);
            this.lblInvoiceID2.TabIndex = 2;
            this.lblInvoiceID2.Text = "Invoice ID:";
            // 
            // lblTotalPrice2
            // 
            this.lblTotalPrice2.AutoSize = true;
            this.lblTotalPrice2.Location = new System.Drawing.Point(261, 9);
            this.lblTotalPrice2.Name = "lblTotalPrice2";
            this.lblTotalPrice2.Size = new System.Drawing.Size(119, 25);
            this.lblTotalPrice2.TabIndex = 3;
            this.lblTotalPrice2.Text = "Total price:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(261, 36);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(109, 25);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "TotalPrice";
            // 
            // ucInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblTotalPrice2);
            this.Controls.Add(this.lblInvoiceID2);
            this.Controls.Add(this.lblInvoiceID);
            this.Controls.Add(this.btnCheckInvoice);
            this.Name = "ucInvoice";
            this.Size = new System.Drawing.Size(634, 78);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckInvoice;
        private System.Windows.Forms.Label lblInvoiceID;
        private System.Windows.Forms.Label lblInvoiceID2;
        private System.Windows.Forms.Label lblTotalPrice2;
        private System.Windows.Forms.Label lblTotalPrice;
    }
}
