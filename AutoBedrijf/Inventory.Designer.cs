namespace AutoBedrijf
{
    partial class frmInventory
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
            this.pnlProducts = new System.Windows.Forms.Panel();
            this.pnlLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLayoutPanel
            // 
            this.pnlLayoutPanel.ColumnCount = 3;
            this.pnlLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.pnlLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlLayoutPanel.Controls.Add(this.pnlProducts, 1, 1);
            this.pnlLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlLayoutPanel.Name = "pnlLayoutPanel";
            this.pnlLayoutPanel.RowCount = 3;
            this.pnlLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.pnlLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlLayoutPanel.Size = new System.Drawing.Size(2007, 1217);
            this.pnlLayoutPanel.TabIndex = 0;
            // 
            // pnlProducts
            // 
            this.pnlProducts.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProducts.Location = new System.Drawing.Point(404, 246);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Size = new System.Drawing.Size(1198, 724);
            this.pnlProducts.TabIndex = 0;
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(2007, 1217);
            this.Controls.Add(this.pnlLayoutPanel);
            this.Name = "frmInventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.frmInventory_Load);
            this.pnlLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlLayoutPanel;
        private System.Windows.Forms.Panel pnlProducts;
    }
}