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
    public partial class uctrlAddAttend : UserControl
    {
        private static uctrlAddAttend _instance;

        public static uctrlAddAttend Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new uctrlAddAttend();
                }
                return _instance;
            }
        }

        public uctrlAddAttend()
        {
            InitializeComponent();
        }
    }
}
