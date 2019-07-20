namespace SchoolProject
{
    partial class frmAdminDashboard
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
            this.splitContainerAdmin = new System.Windows.Forms.SplitContainer();
            this.mnuLogout = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReport = new System.Windows.Forms.MenuStrip();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marksReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFees = new System.Windows.Forms.MenuStrip();
            this.feesDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editFeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAttend = new System.Windows.Forms.MenuStrip();
            this.attendaceDetalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMarks = new System.Windows.Forms.MenuStrip();
            this.marksDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSD = new System.Windows.Forms.MenuStrip();
            this.studentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdmin)).BeginInit();
            this.splitContainerAdmin.Panel1.SuspendLayout();
            this.splitContainerAdmin.SuspendLayout();
            this.mnuLogout.SuspendLayout();
            this.mnuExit.SuspendLayout();
            this.mnuReport.SuspendLayout();
            this.mnuFees.SuspendLayout();
            this.mnuAttend.SuspendLayout();
            this.mnuMarks.SuspendLayout();
            this.mnuSD.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerAdmin
            // 
            this.splitContainerAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAdmin.IsSplitterFixed = true;
            this.splitContainerAdmin.Location = new System.Drawing.Point(0, 0);
            this.splitContainerAdmin.Name = "splitContainerAdmin";
            // 
            // splitContainerAdmin.Panel1
            // 
            this.splitContainerAdmin.Panel1.Controls.Add(this.mnuLogout);
            this.splitContainerAdmin.Panel1.Controls.Add(this.mnuExit);
            this.splitContainerAdmin.Panel1.Controls.Add(this.mnuReport);
            this.splitContainerAdmin.Panel1.Controls.Add(this.mnuFees);
            this.splitContainerAdmin.Panel1.Controls.Add(this.mnuAttend);
            this.splitContainerAdmin.Panel1.Controls.Add(this.mnuMarks);
            this.splitContainerAdmin.Panel1.Controls.Add(this.mnuSD);
            this.splitContainerAdmin.Size = new System.Drawing.Size(544, 372);
            this.splitContainerAdmin.SplitterDistance = 121;
            this.splitContainerAdmin.TabIndex = 0;
            // 
            // mnuLogout
            // 
            this.mnuLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mnuLogout.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.mnuLogout.Location = new System.Drawing.Point(0, 324);
            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.Size = new System.Drawing.Size(121, 24);
            this.mnuLogout.TabIndex = 6;
            this.mnuLogout.Text = "mnuLogout";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mnuExit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.mnuExit.Location = new System.Drawing.Point(0, 348);
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(121, 24);
            this.mnuExit.TabIndex = 5;
            this.mnuExit.Text = "mnuExit";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mnuReport
            // 
            this.mnuReport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportToolStripMenuItem});
            this.mnuReport.Location = new System.Drawing.Point(0, 96);
            this.mnuReport.Name = "mnuReport";
            this.mnuReport.Size = new System.Drawing.Size(121, 24);
            this.mnuReport.TabIndex = 0;
            this.mnuReport.Text = "mnuReport";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentReportToolStripMenuItem,
            this.marksReportToolStripMenuItem,
            this.attendanceReportToolStripMenuItem,
            this.feeReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // studentReportToolStripMenuItem
            // 
            this.studentReportToolStripMenuItem.Name = "studentReportToolStripMenuItem";
            this.studentReportToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.studentReportToolStripMenuItem.Text = "Student Report";
            // 
            // marksReportToolStripMenuItem
            // 
            this.marksReportToolStripMenuItem.Name = "marksReportToolStripMenuItem";
            this.marksReportToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.marksReportToolStripMenuItem.Text = "Marks Report";
            // 
            // attendanceReportToolStripMenuItem
            // 
            this.attendanceReportToolStripMenuItem.Name = "attendanceReportToolStripMenuItem";
            this.attendanceReportToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.attendanceReportToolStripMenuItem.Text = "Attendance Report";
            // 
            // feeReportToolStripMenuItem
            // 
            this.feeReportToolStripMenuItem.Name = "feeReportToolStripMenuItem";
            this.feeReportToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.feeReportToolStripMenuItem.Text = "Fee Report";
            // 
            // mnuFees
            // 
            this.mnuFees.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.feesDetailsToolStripMenuItem});
            this.mnuFees.Location = new System.Drawing.Point(0, 72);
            this.mnuFees.Name = "mnuFees";
            this.mnuFees.Size = new System.Drawing.Size(121, 24);
            this.mnuFees.TabIndex = 1;
            this.mnuFees.Text = "mnuFees";
            // 
            // feesDetailsToolStripMenuItem
            // 
            this.feesDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFeesToolStripMenuItem,
            this.editFeesToolStripMenuItem});
            this.feesDetailsToolStripMenuItem.Name = "feesDetailsToolStripMenuItem";
            this.feesDetailsToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.feesDetailsToolStripMenuItem.Text = "Fees Details";
            // 
            // addFeesToolStripMenuItem
            // 
            this.addFeesToolStripMenuItem.Name = "addFeesToolStripMenuItem";
            this.addFeesToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.addFeesToolStripMenuItem.Text = "Add Fees";
            this.addFeesToolStripMenuItem.Click += new System.EventHandler(this.addFeesToolStripMenuItem_Click);
            // 
            // editFeesToolStripMenuItem
            // 
            this.editFeesToolStripMenuItem.Name = "editFeesToolStripMenuItem";
            this.editFeesToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.editFeesToolStripMenuItem.Text = "Edit Fees";
            this.editFeesToolStripMenuItem.Click += new System.EventHandler(this.editFeesToolStripMenuItem_Click);
            // 
            // mnuAttend
            // 
            this.mnuAttend.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attendaceDetalsToolStripMenuItem});
            this.mnuAttend.Location = new System.Drawing.Point(0, 48);
            this.mnuAttend.Name = "mnuAttend";
            this.mnuAttend.Size = new System.Drawing.Size(121, 24);
            this.mnuAttend.TabIndex = 2;
            this.mnuAttend.Text = "mnuAttend";
            // 
            // attendaceDetalsToolStripMenuItem
            // 
            this.attendaceDetalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAttendanceToolStripMenuItem,
            this.editAttendanceToolStripMenuItem});
            this.attendaceDetalsToolStripMenuItem.Name = "attendaceDetalsToolStripMenuItem";
            this.attendaceDetalsToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.attendaceDetalsToolStripMenuItem.Text = "Attendace Details";
            // 
            // addAttendanceToolStripMenuItem
            // 
            this.addAttendanceToolStripMenuItem.Name = "addAttendanceToolStripMenuItem";
            this.addAttendanceToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.addAttendanceToolStripMenuItem.Text = "Add Attendance";
            this.addAttendanceToolStripMenuItem.Click += new System.EventHandler(this.addAttendanceToolStripMenuItem_Click);
            // 
            // editAttendanceToolStripMenuItem
            // 
            this.editAttendanceToolStripMenuItem.Name = "editAttendanceToolStripMenuItem";
            this.editAttendanceToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.editAttendanceToolStripMenuItem.Text = "Edit Attendance";
            this.editAttendanceToolStripMenuItem.Click += new System.EventHandler(this.editAttendanceToolStripMenuItem_Click);
            // 
            // mnuMarks
            // 
            this.mnuMarks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marksDetailsToolStripMenuItem});
            this.mnuMarks.Location = new System.Drawing.Point(0, 24);
            this.mnuMarks.Name = "mnuMarks";
            this.mnuMarks.Size = new System.Drawing.Size(121, 24);
            this.mnuMarks.TabIndex = 3;
            this.mnuMarks.Text = "mnuMarks";
            // 
            // marksDetailsToolStripMenuItem
            // 
            this.marksDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMarksToolStripMenuItem,
            this.editToolStripMenuItem});
            this.marksDetailsToolStripMenuItem.Name = "marksDetailsToolStripMenuItem";
            this.marksDetailsToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.marksDetailsToolStripMenuItem.Text = "Marks Details";
            // 
            // addMarksToolStripMenuItem
            // 
            this.addMarksToolStripMenuItem.Name = "addMarksToolStripMenuItem";
            this.addMarksToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.addMarksToolStripMenuItem.Text = "Add Marks";
            this.addMarksToolStripMenuItem.Click += new System.EventHandler(this.addMarksToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.editToolStripMenuItem.Text = "Edit Marks";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // mnuSD
            // 
            this.mnuSD.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentDetailsToolStripMenuItem});
            this.mnuSD.Location = new System.Drawing.Point(0, 0);
            this.mnuSD.Name = "mnuSD";
            this.mnuSD.Size = new System.Drawing.Size(121, 24);
            this.mnuSD.TabIndex = 4;
            this.mnuSD.Text = "mnuSD";
            // 
            // studentDetailsToolStripMenuItem
            // 
            this.studentDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentsToolStripMenuItem,
            this.editStudentsToolStripMenuItem});
            this.studentDetailsToolStripMenuItem.Name = "studentDetailsToolStripMenuItem";
            this.studentDetailsToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.studentDetailsToolStripMenuItem.Text = "Student Details";
            // 
            // addStudentsToolStripMenuItem
            // 
            this.addStudentsToolStripMenuItem.Name = "addStudentsToolStripMenuItem";
            this.addStudentsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.addStudentsToolStripMenuItem.Text = "Add Students";
            this.addStudentsToolStripMenuItem.Click += new System.EventHandler(this.addStudentsToolStripMenuItem_Click);
            // 
            // editStudentsToolStripMenuItem
            // 
            this.editStudentsToolStripMenuItem.Name = "editStudentsToolStripMenuItem";
            this.editStudentsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.editStudentsToolStripMenuItem.Text = "Edit Students";
            this.editStudentsToolStripMenuItem.Click += new System.EventHandler(this.editStudentsToolStripMenuItem_Click);
            // 
            // frmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 372);
            this.Controls.Add(this.splitContainerAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuReport;
            this.MaximizeBox = false;
            this.Name = "frmAdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.splitContainerAdmin.Panel1.ResumeLayout(false);
            this.splitContainerAdmin.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdmin)).EndInit();
            this.splitContainerAdmin.ResumeLayout(false);
            this.mnuLogout.ResumeLayout(false);
            this.mnuLogout.PerformLayout();
            this.mnuExit.ResumeLayout(false);
            this.mnuExit.PerformLayout();
            this.mnuReport.ResumeLayout(false);
            this.mnuReport.PerformLayout();
            this.mnuFees.ResumeLayout(false);
            this.mnuFees.PerformLayout();
            this.mnuAttend.ResumeLayout(false);
            this.mnuAttend.PerformLayout();
            this.mnuMarks.ResumeLayout(false);
            this.mnuMarks.PerformLayout();
            this.mnuSD.ResumeLayout(false);
            this.mnuSD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerAdmin;
        private System.Windows.Forms.MenuStrip mnuReport;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marksReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feeReportToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mnuFees;
        private System.Windows.Forms.ToolStripMenuItem feesDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editFeesToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mnuAttend;
        private System.Windows.Forms.ToolStripMenuItem attendaceDetalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAttendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAttendanceToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mnuMarks;
        private System.Windows.Forms.ToolStripMenuItem marksDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMarksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mnuSD;
        private System.Windows.Forms.ToolStripMenuItem studentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editStudentsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mnuLogout;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mnuExit;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}