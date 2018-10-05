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
    public partial class lesson3m : UserControl
    {
        private static lesson3m _instance;
        public static lesson3m Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new lesson3m();
                return _instance;
            }
        }
        public lesson3m()
        {
            InitializeComponent();

            Bconn2.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Bconn_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(SelectColor.Instance))
            {
                panel.Controls.Add(SelectColor.Instance);
                SelectColor.Instance.Dock = DockStyle.Fill;
                SelectColor.Instance.BringToFront();
            }
            else
                SelectColor.Instance.BringToFront();

            Bconn.Hide();
            Bconn2.Show();
        }

        private void Bconn2_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(configL3.Instance))
            {
                panel.Controls.Add(configL3.Instance);
                configL3.Instance.Dock = DockStyle.Fill;
                configL3.Instance.BringToFront();
            }
            else
                configL3.Instance.BringToFront();

            Bconn2.Hide();
            Bconn.Show();
        }
    }
}
