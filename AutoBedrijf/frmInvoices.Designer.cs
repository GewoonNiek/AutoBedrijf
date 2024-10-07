namespace AutoBedrijf
{
    partial class frmInvoices
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
            this.pnlLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pnlInvoiceList = new System.Windows.Forms.FlowLayoutPanel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLayoutPanel
            // 
            this.pnlLayoutPanel.ColumnCount = 3;
            this.pnlLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.pnlLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlLayoutPanel.Controls.Add(this.pnlInvoiceList, 1, 1);
            this.pnlLayoutPanel.Controls.Add(this.btnReturn, 1, 0);
            this.pnlLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlLayoutPanel.Name = "pnlLayoutPanel";
            this.pnlLayoutPanel.RowCount = 3;
            this.pnlLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.pnlLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlLayoutPanel.Size = new System.Drawing.Size(800, 958);
            this.pnlLayoutPanel.TabIndex = 0;
            // 
            // pnlInvoiceList
            // 
            this.pnlInvoiceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInvoiceList.Location = new System.Drawing.Point(83, 98);
            this.pnlInvoiceList.Name = "pnlInvoiceList";
            this.pnlInvoiceList.Size = new System.Drawing.Size(634, 760);
            this.pnlInvoiceList.TabIndex = 0;
            // 
            // btnReturn
            // 
            this.btnReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReturn.Location = new System.Drawing.Point(83, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(634, 89);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return to Menu";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // frmInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 958);
            this.Controls.Add(this.pnlLayoutPanel);
            this.Name = "frmInvoices";
            this.Text = "frmInvoices";
            this.Load += new System.EventHandler(this.frmInvoices_Load);
            this.pnlLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel pnlInvoiceList;
        private System.Windows.Forms.Button btnReturn;
    }
}