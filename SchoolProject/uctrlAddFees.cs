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
    public partial class uctrlAddFees : UserControl
    {
        private static uctrlAddFees _instance;

        public static uctrlAddFees Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new uctrlAddFees();
                }
                return _instance;
            }
        }

        public uctrlAddFees()
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
