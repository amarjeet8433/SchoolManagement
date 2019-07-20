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
    public partial class uctrlAddMarks : UserControl
    {
        private static uctrlAddMarks _instance;

        public static uctrlAddMarks Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new uctrlAddMarks();
                }
                return _instance;
            }
        }

        public uctrlAddMarks()
        {
            InitializeComponent();
        }
    }
}
