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
    public partial class frmFeeReceipt : Form
    {
        public frmFeeReceipt()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(objBmp, 0, 0);
        }

        Bitmap objBmp;

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Graphics objGraphics = this.CreateGraphics();
            objBmp = new Bitmap(this.Size.Width, this.Size.Height, objGraphics);
            Graphics objGraphicsImg = Graphics.FromImage(objBmp);
            objGraphicsImg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }
    }
}
