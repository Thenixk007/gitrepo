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
    public partial class configL4 : UserControl
    {
        private static configL4 _instance;
        public static configL4 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new configL4();
                return _instance;
            }
        }
        public configL4()
        {
            InitializeComponent();
        }
    }
}
