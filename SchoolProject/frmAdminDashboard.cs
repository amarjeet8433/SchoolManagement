using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProject
{
    public partial class frmAdminDashboard : Form
    {
        public frmAdminDashboard()
        {
            InitializeComponent();
        }

        private void addStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!splitContainerAdmin.Panel2.Controls.Contains(uctrlAddSD.Instance))
            {
                splitContainerAdmin.Panel2.Controls.Add(uctrlAddSD.Instance);
                uctrlAddSD.Instance.Dock = DockStyle.Fill;
                uctrlAddSD.Instance.BringToFront();
                uctrlAddSD.Instance.Width = splitContainerAdmin.Panel2.Width;
            }
            else
            {
                uctrlAddSD.Instance.BringToFront();
            }
            //uctrlAddSD objAddSD = new uctrlAddSD();
            //splitContainer1.Panel2.Controls.Add(objAddSD);
        }

        private void editStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!splitContainerAdmin.Panel2.Controls.Contains(uctrlEditSD.Instance))
            {
                splitContainerAdmin.Panel2.Controls.Add(uctrlEditSD.Instance);
                uctrlEditSD.Instance.Dock = DockStyle.Fill;
                uctrlEditSD.Instance.BringToFront();
                uctrlEditSD.Instance.Width = splitContainerAdmin.Panel2.Width;
            }
            else
            {
                uctrlEditSD.Instance.BringToFront();
            }
            //uctrlEditSD objEditSD = new uctrlEditSD();
            //splitContainer1.Panel2.Controls.Add(objEditSD);
        }

        private void addMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!splitContainerAdmin.Panel2.Controls.Contains(uctrlAddMarks.Instance))
            {
                splitContainerAdmin.Panel2.Controls.Add(uctrlAddMarks.Instance);
                uctrlAddMarks.Instance.Dock = DockStyle.Fill;
                uctrlAddMarks.Instance.BringToFront();
                uctrlAddMarks.Instance.Width = splitContainerAdmin.Panel2.Width;
            }
            else
            {
                uctrlAddMarks.Instance.BringToFront();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!splitContainerAdmin.Panel2.Controls.Contains(uctrlEditMarks.Instance))
            {
                splitContainerAdmin.Panel2.Controls.Add(uctrlEditMarks.Instance);
                uctrlEditMarks.Instance.Dock = DockStyle.Fill;
                uctrlEditMarks.Instance.BringToFront();
                uctrlEditMarks.Instance.Width = splitContainerAdmin.Panel2.Width;
            }
            else
            {
                uctrlEditMarks.Instance.BringToFront();
            }
        }

        private void addAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!splitContainerAdmin.Panel2.Controls.Contains(uctrlAddAttend.Instance))
            {
                splitContainerAdmin.Panel2.Controls.Add(uctrlAddAttend.Instance);
                uctrlAddAttend.Instance.Dock = DockStyle.Fill;
                uctrlAddAttend.Instance.BringToFront();
                uctrlAddAttend.Instance.Width = splitContainerAdmin.Panel2.Width;
            }
            else
            {
                uctrlAddAttend.Instance.BringToFront();
            }
        }

        private void editAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!splitContainerAdmin.Panel2.Controls.Contains(uctrlEditAttend.Instance))
            {
                splitContainerAdmin.Panel2.Controls.Add(uctrlEditAttend.Instance);
                uctrlEditAttend.Instance.Dock = DockStyle.Fill;
                uctrlEditAttend.Instance.BringToFront();
                uctrlEditAttend.Instance.Width = splitContainerAdmin.Panel2.Width;
            }
            else
            {
                uctrlEditAttend.Instance.BringToFront();
            }
        }

        private void addFeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!splitContainerAdmin.Panel2.Controls.Contains(uctrlAddFees.Instance))
            {
                splitContainerAdmin.Panel2.Controls.Add(uctrlAddFees.Instance);
                uctrlAddFees.Instance.Dock = DockStyle.Fill;
                uctrlAddFees.Instance.BringToFront();
                uctrlAddFees.Instance.Width = splitContainerAdmin.Panel2.Width;
            }
            else
            {
                uctrlAddFees.Instance.BringToFront();
            }
        }

        private void editFeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!splitContainerAdmin.Panel2.Controls.Contains(uctrlEditFees.Instance))
            {
                splitContainerAdmin.Panel2.Controls.Add(uctrlEditFees.Instance);
                uctrlEditFees.Instance.Dock = DockStyle.Fill;
                uctrlEditFees.Instance.BringToFront();
                uctrlEditFees.Instance.Width = splitContainerAdmin.Panel2.Width;
            }
            else
            {
                uctrlEditFees.Instance.BringToFront();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Successfully Logged out!!", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmLogin objLogin = new frmLogin();
            objLogin.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
