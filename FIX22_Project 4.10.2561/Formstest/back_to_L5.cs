using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formstest
{
    public partial class back_to_L5 : UserControl
    {
        private static back_to_L5 _instance;
        public static back_to_L5 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new back_to_L5();
                return _instance;
            }
        }
        public back_to_L5()
        {
            InitializeComponent();
        }
    }
}
