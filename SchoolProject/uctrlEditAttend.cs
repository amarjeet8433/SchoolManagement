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
    public partial class uctrlEditAttend : UserControl
    {
        private static uctrlEditAttend _instance;

        public static uctrlEditAttend Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new uctrlEditAttend();
                }
                return _instance;
            }
        }

        public uctrlEditAttend()
        {
            InitializeComponent();
        }
    }
}
