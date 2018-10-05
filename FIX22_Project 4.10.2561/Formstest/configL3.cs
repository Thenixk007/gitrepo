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
    public partial class configL3 : UserControl
    {
        private static configL3 _instance;
        public static configL3 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new configL3();
                return _instance;
            }
        }
        public configL3()
        {
            InitializeComponent();
        }
    }
}
