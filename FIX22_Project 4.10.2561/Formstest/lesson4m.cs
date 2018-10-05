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
    public partial class lesson4m : UserControl
    {
        private static lesson4m _instance;
        public static lesson4m Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new lesson4m();
                return _instance;
            }
        }
        public lesson4m()
        {
            InitializeComponent();

            Bconn.Hide();

        }
        

        private void Bconn2_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(configL44.Instance))
            {
                panel.Controls.Add(configL44.Instance);
                configL44.Instance.Dock = DockStyle.Fill;
                configL44.Instance.BringToFront();
            }
            else
                configL44.Instance.BringToFront();

            Bconn2.Hide();
            Bconn.Show();
        }

        private void Bconn_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(configL4.Instance))
            {
                panel.Controls.Add(configL4.Instance);
                configL4.Instance.Dock = DockStyle.Fill;
                configL4.Instance.BringToFront();
            }
            else
                configL4.Instance.BringToFront();

            Bconn.Hide();
            Bconn2.Show();
        }
    }
}
