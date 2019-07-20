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
    public partial class uctrlEditSD : UserControl
    {
        private static uctrlEditSD _instance;

        public static uctrlEditSD Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new uctrlEditSD();
                }
                return _instance;
            }
        }

        public uctrlEditSD()
        {
            InitializeComponent();
        }
    }
}
