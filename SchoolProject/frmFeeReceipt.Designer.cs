namespace SchoolProject
{
    partial class frmFeeReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFeeReceipt));
            this.lblSchoolName = new System.Windows.Forms.Label();
            this.lblSchoolAddress = new System.Windows.Forms.Label();
            this.lblFeeReceipt = new System.Windows.Forms.Label();
            this.lblStudName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblNameDB = new System.Windows.Forms.Label();
            this.lblClassDB = new System.Windows.Forms.Label();
            this.lblDateDB = new System.Windows.Forms.Label();
            this.lblAmountDB = new System.Windows.Forms.Label();
            this.lblManagerAccounts = new System.Windows.Forms.Label();
            this.lblSignatureImg = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // lblSchoolName
            // 
            this.lblSchoolName.AutoSize = true;
            this.lblSchoolName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchoolName.Location = new System.Drawing.Point(103, 9);
            this.lblSchoolName.Name = "lblSchoolName";
            this.lblSchoolName.Size = new System.Drawing.Size(335, 31);
            this.lblSchoolName.TabIndex = 0;
            this.lblSchoolName.Text = "Guru Nanak High School";
            // 
            // lblSchoolAddress
            // 
            this.lblSchoolAddress.AutoSize = true;
            this.lblSchoolAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchoolAddress.Location = new System.Drawing.Point(171, 40);
            this.lblSchoolAddress.Name = "lblSchoolAddress";
            this.lblSchoolAddress.Size = new System.Drawing.Size(208, 17);
            this.lblSchoolAddress.TabIndex = 1;
            this.lblSchoolAddress.Text = "Khar (W), Mumbai - 400052";
            // 
            // lblFeeReceipt
            // 
            this.lblFeeReceipt.AutoSize = true;
            this.lblFeeReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeeReceipt.Location = new System.Drawing.Point(207, 106);
            this.lblFeeReceipt.Name = "lblFeeReceipt";
            this.lblFeeReceipt.Size = new System.Drawing.Size(127, 25);
            this.lblFeeReceipt.TabIndex = 2;
            this.lblFeeReceipt.Text = "Fee Receipt";
            // 
            // lblStudName
            // 
            this.lblStudName.AutoSize = true;
            this.lblStudName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudName.Location = new System.Drawing.Point(70, 152);
            this.lblStudName.Name = "lblStudName";
            this.lblStudName.Size = new System.Drawing.Size(106, 17);
            this.lblStudName.TabIndex = 3;
            this.lblStudName.Text = "Student Name :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(70, 219);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(106, 17);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date                :";
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountPaid.Location = new System.Drawing.Point(70, 253);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(108, 17);
            this.lblAmountPaid.TabIndex = 5;
            this.lblAmountPaid.Text = "Amount Paid    :";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(70, 185);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(106, 17);
            this.lblClass.TabIndex = 6;
            this.lblClass.Text = "Class               :";
            // 
            // lblNameDB
            // 
            this.lblNameDB.AutoSize = true;
            this.lblNameDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameDB.Location = new System.Drawing.Point(209, 152);
            this.lblNameDB.Name = "lblNameDB";
            this.lblNameDB.Size = new System.Drawing.Size(78, 17);
            this.lblNameDB.TabIndex = 7;
            this.lblNameDB.Text = "lblNameDB";
            // 
            // lblClassDB
            // 
            this.lblClassDB.AutoSize = true;
            this.lblClassDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassDB.Location = new System.Drawing.Point(209, 185);
            this.lblClassDB.Name = "lblClassDB";
            this.lblClassDB.Size = new System.Drawing.Size(75, 17);
            this.lblClassDB.TabIndex = 8;
            this.lblClassDB.Text = "lblClassDB";
            // 
            // lblDateDB
            // 
            this.lblDateDB.AutoSize = true;
            this.lblDateDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDB.Location = new System.Drawing.Point(209, 219);
            this.lblDateDB.Name = "lblDateDB";
            this.lblDateDB.Size = new System.Drawing.Size(71, 17);
            this.lblDateDB.TabIndex = 9;
            this.lblDateDB.Text = "lblDateDB";
            // 
            // lblAmountDB
            // 
            this.lblAmountDB.AutoSize = true;
            this.lblAmountDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountDB.Location = new System.Drawing.Point(209, 253);
            this.lblAmountDB.Name = "lblAmountDB";
            this.lblAmountDB.Size = new System.Drawing.Size(89, 17);
            this.lblAmountDB.TabIndex = 10;
            this.lblAmountDB.Text = "lblAmountDB";
            // 
            // lblManagerAccounts
            // 
            this.lblManagerAccounts.AutoSize = true;
            this.lblManagerAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerAccounts.Location = new System.Drawing.Point(384, 336);
            this.lblManagerAccounts.Name = "lblManagerAccounts";
            this.lblManagerAccounts.Size = new System.Drawing.Size(159, 20);
            this.lblManagerAccounts.TabIndex = 11;
            this.lblManagerAccounts.Text = "Manager Accounts";
            // 
            // lblSignatureImg
            // 
            this.lblSignatureImg.AutoSize = true;
            this.lblSignatureImg.Font = new System.Drawing.Font("Abadi MT Condensed", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignatureImg.Location = new System.Drawing.Point(398, 308);
            this.lblSignatureImg.Name = "lblSignatureImg";
            this.lblSignatureImg.Size = new System.Drawing.Size(123, 24);
            this.lblSignatureImg.TabIndex = 12;
            this.lblSignatureImg.Text = "Signature Image";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(73, 319);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmFeeReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 372);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblSignatureImg);
            this.Controls.Add(this.lblManagerAccounts);
            this.Controls.Add(this.lblAmountDB);
            this.Controls.Add(this.lblDateDB);
            this.Controls.Add(this.lblClassDB);
            this.Controls.Add(this.lblNameDB);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblAmountPaid);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblStudName);
            this.Controls.Add(this.lblFeeReceipt);
            this.Controls.Add(this.lblSchoolAddress);
            this.Controls.Add(this.lblSchoolName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmFeeReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fee Receipt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSchoolName;
        private System.Windows.Forms.Label lblSchoolAddress;
        private System.Windows.Forms.Label lblFeeReceipt;
        private System.Windows.Forms.Label lblStudName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblNameDB;
        private System.Windows.Forms.Label lblClassDB;
        private System.Windows.Forms.Label lblDateDB;
        private System.Windows.Forms.Label lblAmountDB;
        private System.Windows.Forms.Label lblManagerAccounts;
        private System.Windows.Forms.Label lblSignatureImg;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}