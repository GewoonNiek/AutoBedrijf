namespace AutoBedrijf
{
    partial class frmAddProduct
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
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbKilometers = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblKilometers = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.pbProductImage = new System.Windows.Forms.PictureBox();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tbType
            // 
            this.tbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbType.Location = new System.Drawing.Point(191, 103);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(255, 44);
            this.tbType.TabIndex = 0;
            // 
            // tbYear
            // 
            this.tbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbYear.Location = new System.Drawing.Point(191, 189);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(255, 44);
            this.tbYear.TabIndex = 1;
            // 
            // numAmount
            // 
            this.numAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAmount.Location = new System.Drawing.Point(191, 279);
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(255, 44);
            this.numAmount.TabIndex = 2;
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(191, 368);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(255, 44);
            this.tbPrice.TabIndex = 3;
            // 
            // tbKilometers
            // 
            this.tbKilometers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKilometers.Location = new System.Drawing.Point(191, 447);
            this.tbKilometers.Name = "tbKilometers";
            this.tbKilometers.Size = new System.Drawing.Size(255, 44);
            this.tbKilometers.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFile.Location = new System.Drawing.Point(191, 545);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(255, 61);
            this.btnSelectFile.TabIndex = 5;
            this.btnSelectFile.Text = "select file";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(42, 711);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(585, 142);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Add product";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblKilometers
            // 
            this.lblKilometers.AutoSize = true;
            this.lblKilometers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKilometers.Location = new System.Drawing.Point(9, 450);
            this.lblKilometers.Name = "lblKilometers";
            this.lblKilometers.Size = new System.Drawing.Size(176, 37);
            this.lblKilometers.TabIndex = 7;
            this.lblKilometers.Text = "Kilometers:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(9, 286);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(138, 37);
            this.lblAmount.TabIndex = 8;
            this.lblAmount.Text = "Amount:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(9, 371);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(98, 37);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(9, 196);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(94, 37);
            this.lblYear.TabIndex = 10;
            this.lblYear.Text = "Year:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(9, 110);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(96, 37);
            this.lblType.TabIndex = 11;
            this.lblType.Text = "Type:";
            // 
            // pbProductImage
            // 
            this.pbProductImage.Location = new System.Drawing.Point(474, 246);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(177, 184);
            this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProductImage.TabIndex = 12;
            this.pbProductImage.TabStop = false;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(474, 21);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(183, 67);
            this.btnReturn.TabIndex = 13;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(663, 881);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.pbProductImage);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblKilometers);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.tbKilometers);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.numAmount);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.tbType);
            this.Name = "frmAddProduct";
            this.Text = "Add product";
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbKilometers;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblKilometers;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.PictureBox pbProductImage;
        private System.Windows.Forms.Button btnReturn;
    }
}