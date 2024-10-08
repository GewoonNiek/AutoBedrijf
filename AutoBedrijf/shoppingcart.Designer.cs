﻿namespace AutoBedrijf
{
    partial class frmShoppingCart
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
            this.pnlCartItems = new System.Windows.Forms.FlowLayoutPanel();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
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
            this.pnlLayoutPanel.Controls.Add(this.pnlCartItems, 1, 1);
            this.pnlLayoutPanel.Controls.Add(this.btnConfirmOrder, 1, 2);
            this.pnlLayoutPanel.Controls.Add(this.btnReturn, 2, 0);
            this.pnlLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlLayoutPanel.Name = "pnlLayoutPanel";
            this.pnlLayoutPanel.RowCount = 3;
            this.pnlLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.pnlLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlLayoutPanel.Size = new System.Drawing.Size(1576, 929);
            this.pnlLayoutPanel.TabIndex = 0;
            // 
            // pnlCartItems
            // 
            this.pnlCartItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCartItems.Location = new System.Drawing.Point(160, 95);
            this.pnlCartItems.Name = "pnlCartItems";
            this.pnlCartItems.Size = new System.Drawing.Size(1254, 737);
            this.pnlCartItems.TabIndex = 0;
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfirmOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmOrder.Location = new System.Drawing.Point(160, 838);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(1254, 88);
            this.btnConfirmOrder.TabIndex = 1;
            this.btnConfirmOrder.Text = "Confirm Order";
            this.btnConfirmOrder.UseVisualStyleBackColor = true;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReturn.Location = new System.Drawing.Point(1420, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(153, 86);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // frmShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1576, 929);
            this.Controls.Add(this.pnlLayoutPanel);
            this.Name = "frmShoppingCart";
            this.Text = "Shoppingcart";
            this.Load += new System.EventHandler(this.frmShoppingCart_Load);
            this.pnlLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel pnlCartItems;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.Button btnReturn;
    }
}