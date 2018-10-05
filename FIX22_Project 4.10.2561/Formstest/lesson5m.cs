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
    public partial class lesson5m : UserControl
    {
        private static lesson5m _instance;
        public static lesson5m Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new lesson5m();
                return _instance;
            }
        }
        public lesson5m()
        {
            InitializeComponent();
           
            Bconn2.Hide();
        }

        private void Bconn2_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(back_to_L5.Instance))
            {
                panel.Controls.Add(back_to_L5.Instance);
                back_to_L5.Instance.Dock = DockStyle.Fill;
                back_to_L5.Instance.BringToFront();
            }
            else
                back_to_L5.Instance.BringToFront();

            Bconn2.Hide();
            Bconn.Show();
            
        }

        private void Bconn_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(configL5.Instance))
            {
                panel.Controls.Add(configL5.Instance);
                configL5.Instance.Dock = DockStyle.Fill;
                configL5.Instance.BringToFront();
            }
            else
                configL5.Instance.BringToFront();

            Bconn.Hide();
            Bconn2.Show();
        }
    }
}
