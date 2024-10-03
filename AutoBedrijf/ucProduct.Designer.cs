namespace AutoBedrijf
{
    partial class ucProduct
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
            this.pnlProduct = new System.Windows.Forms.TableLayoutPanel();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.btnCheckProduct = new System.Windows.Forms.Button();
            this.pnlProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProduct
            // 
            this.pnlProduct.ColumnCount = 3;
            this.pnlProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.pnlProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlProduct.Controls.Add(this.pbPicture, 1, 1);
            this.pnlProduct.Controls.Add(this.btnCheckProduct, 1, 2);
            this.pnlProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProduct.Location = new System.Drawing.Point(0, 0);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.RowCount = 3;
            this.pnlProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.pnlProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlProduct.Size = new System.Drawing.Size(419, 238);
            this.pnlProduct.TabIndex = 0;
            // 
            // pbPicture
            // 
            this.pbPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPicture.Location = new System.Drawing.Point(65, 38);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(287, 160);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicture.TabIndex = 0;
            this.pbPicture.TabStop = false;
            // 
            // btnCheckProduct
            // 
            this.btnCheckProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCheckProduct.Location = new System.Drawing.Point(65, 204);
            this.btnCheckProduct.Name = "btnCheckProduct";
            this.btnCheckProduct.Size = new System.Drawing.Size(287, 31);
            this.btnCheckProduct.TabIndex = 1;
            this.btnCheckProduct.Text = "Order this product!";
            this.btnCheckProduct.UseVisualStyleBackColor = true;
            this.btnCheckProduct.Click += new System.EventHandler(this.btnCheckProduct_Click);
            // 
            // ucProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.pnlProduct);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(419, 238);
            this.pnlProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlProduct;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.Button btnCheckProduct;
    }
}
