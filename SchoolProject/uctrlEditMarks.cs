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
    public partial class uctrlEditMarks : UserControl
    {
        private static uctrlEditMarks _instance;

        public static uctrlEditMarks Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new uctrlEditMarks();
                }
                return _instance;
            }
        }

        public uctrlEditMarks()
        {
            InitializeComponent();
        }
    }
}
