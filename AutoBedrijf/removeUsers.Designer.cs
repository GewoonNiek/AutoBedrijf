namespace AutoBedrijf
{
    partial class frmRemoveUsers
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
            this.pnllayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pnlUserlist = new System.Windows.Forms.FlowLayoutPanel();
            this.pnllayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnllayoutPanel
            // 
            this.pnllayoutPanel.ColumnCount = 3;
            this.pnllayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnllayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.pnllayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnllayoutPanel.Controls.Add(this.pnlUserlist, 1, 1);
            this.pnllayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnllayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.pnllayoutPanel.Name = "pnllayoutPanel";
            this.pnllayoutPanel.RowCount = 3;
            this.pnllayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnllayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.pnllayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnllayoutPanel.Size = new System.Drawing.Size(762, 1026);
            this.pnllayoutPanel.TabIndex = 0;
            // 
            // pnlUserlist
            // 
            this.pnlUserlist.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlUserlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserlist.Location = new System.Drawing.Point(79, 105);
            this.pnlUserlist.Name = "pnlUserlist";
            this.pnlUserlist.Size = new System.Drawing.Size(603, 814);
            this.pnlUserlist.TabIndex = 0;
            // 
            // frmRemoveUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(762, 1026);
            this.Controls.Add(this.pnllayoutPanel);
            this.Name = "frmRemoveUsers";
            this.Text = "removeUsers";
            this.Load += new System.EventHandler(this.frmRemoveUsers_Load);
            this.pnllayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnllayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel pnlUserlist;
    }
}