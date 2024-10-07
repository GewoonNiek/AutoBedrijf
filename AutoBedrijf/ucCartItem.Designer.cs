namespace AutoBedrijf
{
    partial class ucCartItem
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
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.lblPrice2 = new System.Windows.Forms.Label();
            this.lblAmount2 = new System.Windows.Forms.Label();
            this.lblName2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(363, 49);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(167, 31);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Item Amount";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(48, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(146, 31);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Item Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(643, 49);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(133, 31);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Item price";
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(876, 13);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(280, 67);
            this.btnRemoveItem.TabIndex = 3;
            this.btnRemoveItem.Text = "Remove from cart";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // lblPrice2
            // 
            this.lblPrice2.AutoSize = true;
            this.lblPrice2.Location = new System.Drawing.Point(644, 13);
            this.lblPrice2.Name = "lblPrice2";
            this.lblPrice2.Size = new System.Drawing.Size(67, 25);
            this.lblPrice2.TabIndex = 4;
            this.lblPrice2.Text = "Price:";
            // 
            // lblAmount2
            // 
            this.lblAmount2.AutoSize = true;
            this.lblAmount2.Location = new System.Drawing.Point(364, 13);
            this.lblAmount2.Name = "lblAmount2";
            this.lblAmount2.Size = new System.Drawing.Size(91, 25);
            this.lblAmount2.TabIndex = 5;
            this.lblAmount2.Text = "Amount:";
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Location = new System.Drawing.Point(49, 13);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(151, 25);
            this.lblName2.TabIndex = 6;
            this.lblName2.Text = "Product name:";
            // 
            // ucCartItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblName2);
            this.Controls.Add(this.lblAmount2);
            this.Controls.Add(this.lblPrice2);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAmount);
            this.Name = "ucCartItem";
            this.Size = new System.Drawing.Size(1254, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Label lblPrice2;
        private System.Windows.Forms.Label lblAmount2;
        private System.Windows.Forms.Label lblName2;
    }
}
