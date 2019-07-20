using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProject
{
    public partial class uctrlEditFees : UserControl
    {
        private static uctrlEditFees _instance;

        public static uctrlEditFees Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new uctrlEditFees();
                }
                return _instance;
            }
        }

        public uctrlEditFees()
        {
            InitializeComponent();
        }

        private void btnReciept_Click(object sender, EventArgs e)
        {
            frmFeeReceipt objFeeReceipt = new frmFeeReceipt();
            objFeeReceipt.Show();
        }
    }
}
