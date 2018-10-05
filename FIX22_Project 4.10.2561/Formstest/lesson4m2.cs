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
    public partial class lesson4m2 : UserControl
    {
        private static lesson4m2 _instance;
        public static lesson4m2 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new lesson4m2();
                return _instance;
            }
        }
        public lesson4m2()
        {
            InitializeComponent();
            flowLayoutPanel_codeL2.AutoScroll = true;
            flowLayoutPanel_codeL2.Controls.Add(code_L2);
            Bconn.Hide();
        }

        private void Bconn2_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(configL44_2.Instance))
            {
                panel2.Controls.Add(configL44_2.Instance);
                configL44_2.Instance.Dock = DockStyle.Fill;
                configL44_2.Instance.BringToFront();
            }
            else
                configL44_2.Instance.BringToFront();

            Bconn2.Hide();
            Bconn.Show();
        }

        private void Bconn_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(configL4_2.Instance))
            {
                panel2.Controls.Add(configL4_2.Instance);
                configL4_2.Instance.Dock = DockStyle.Fill;
                configL4_2.Instance.BringToFront();
            }
            else
                configL4_2.Instance.BringToFront();

            Bconn.Hide();
            Bconn2.Show();
        }
    }
}
