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
    public partial class configL4_2 : UserControl
    {
        private static configL4_2 _instance;
        public static configL4_2 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new configL4_2();
                return _instance;
            }
        }
        public configL4_2()
        {
            InitializeComponent();
        }
    }
}
