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
    public partial class uctrlAddSD : UserControl
    {
        private static uctrlAddSD _instance;

        public static uctrlAddSD Instance
        {
            get
            {
                if(_instance==null)
                {
                    _instance = new uctrlAddSD();
                }
                return _instance;
            }
        }

        public uctrlAddSD()
        {
            InitializeComponent();
        }
    }
}
