using Formstest.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formstest
{
    public partial class Form1 : Form
    {
         
        private bool bunifuFlatButton4_click;
        private bool DDL1;
        private bool DDL2;
        private bool DDL3;
        private bool DDL4;
        private bool DDL5;
        private bool DDL6;
        public Form1()
        {
            InitializeComponent();
            
            home1.BringToFront();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void home1_Load(object sender, EventArgs e)
        {

        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            home1.BringToFront();
        }

       

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            timer2.Start();
            
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            timer4.Start();
            
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (!panel.Controls.Contains(lesson1m.Instance))
            {
                panel.Controls.Add(lesson1m.Instance);
                lesson1m.Instance.Dock = DockStyle.Fill;
                lesson1m.Instance.BringToFront();
            }
            else
                lesson1m.Instance.BringToFront();
            if (DDL1)
            {
                bunifuFlatButton2.Iconimage_right = Resources.dd2;
                panelL1.Width += 10;
                if (panelL1.Size == panelL1.MaximumSize)
                {
                    timer1.Stop();
                    DDL1 = false;
                }
            }
            else
            {
                bunifuFlatButton2.Iconimage_right = Resources.dd1;
                panelL1.Width -= 10;
                if (panelL1.Size == panelL1.MinimumSize)
                {
                    timer1.Stop();
                    DDL1 = true;
                }

            }
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (!panel.Controls.Contains(ExLed.Instance))
            {
                panel.Controls.Add(ExLed.Instance);
                ExLed.Instance.Dock = DockStyle.Fill;
                ExLed.Instance.BringToFront();
            }
            else
                ExLed.Instance.BringToFront();
            if (DDL1)
            {
                bunifuFlatButton2.Iconimage_right = Resources.dd2;
                panelL1.Width += 10;
                if (panelL1.Size == panelL1.MaximumSize)
                {
                    timer1.Stop();
                    DDL1 = false;
                }
            }
            else
            {
                bunifuFlatButton2.Iconimage_right = Resources.dd1;
                panelL1.Width -= 10;
                if (panelL1.Size == panelL1.MinimumSize)
                {
                    timer1.Stop();
                    DDL1 = true;
                }

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DDL1)
            {
                bunifuFlatButton2.Iconimage_right = Resources.dd2;
                panelL1.Width += 10;
                if(panelL1.Size == panelL1.MaximumSize)
                {
                    timer1.Stop();
                    DDL1 = false;
                }
            }
            else
            {
                bunifuFlatButton2.Iconimage_right = Resources.dd1;
                panelL1.Width -= 10;
                if (panelL1.Size == panelL1.MinimumSize)
                {
                    timer1.Stop();
                    DDL1 = true;
                }

            }
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            timer2.Start();
            if (!panel.Controls.Contains(lesson2m.Instance))
            {
                panel.Controls.Add(lesson2m.Instance);
                lesson2m.Instance.Dock = DockStyle.Fill;
                lesson2m.Instance.BringToFront();
            }
            else
                lesson2m.Instance.BringToFront();
            if (DDL2)
            {
                bunifuFlatButton3.Iconimage_right = Resources.dd2;
                panelL2.Width += 10;
                if (panelL2.Size == panelL2.MaximumSize)
                {
                    timer2.Stop();
                    DDL2 = false;
                }
            }
            else
            {
                bunifuFlatButton3.Iconimage_right = Resources.dd1;
                panelL2.Width -= 10;
                if (panelL2.Size == panelL2.MinimumSize)
                {
                    timer2.Stop();
                    DDL2 = true;
                }

            }
        }
        private void bunifuFlatButton12_Click_1(object sender, EventArgs e)
        {
            timer2.Start();
            if (!panel.Controls.Contains(ExButton.Instance))
            {
                panel.Controls.Add(ExButton.Instance);
                ExButton.Instance.Dock = DockStyle.Fill;
                ExButton.Instance.BringToFront();
            }
            else
                ExButton.Instance.BringToFront();
            if (DDL2)
            {
                bunifuFlatButton3.Iconimage_right = Resources.dd2;
                panelL2.Width += 10;
                if (panelL2.Size == panelL2.MaximumSize)
                {
                    timer2.Stop();
                    DDL2 = false;
                }
            }
            else
            {
                bunifuFlatButton3.Iconimage_right = Resources.dd1;
                panelL2.Width -= 10;
                if (panelL2.Size == panelL2.MinimumSize)
                {
                    timer2.Stop();
                    DDL2 = true;
                }

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (DDL2)
            {
                bunifuFlatButton3.Iconimage_right = Resources.dd2;
                panelL2.Width += 10;
                if (panelL2.Size == panelL2.MaximumSize)
                {
                    timer2.Stop();
                    DDL2 = false;
                }
            }
            else
            {
                bunifuFlatButton3.Iconimage_right = Resources.dd1;
                panelL2.Width -= 10;
                if (panelL2.Size == panelL2.MinimumSize)
                {
                    timer2.Stop();
                    DDL2 = true;
                }

            }
        }

        private void bunifuFlatButton13_Click(object sender, EventArgs e)
        {
            timer3.Start();
            if (!panel.Controls.Contains(lesson3m.Instance))
            {
                panel.Controls.Add(lesson3m.Instance);
                lesson3m.Instance.Dock = DockStyle.Fill;
                lesson3m.Instance.BringToFront();
            }
            else
                lesson3m.Instance.BringToFront();
            if (DDL3)
            {
                bunifuFlatButton4.Iconimage_right = Resources.dd2;
                panelL3.Width += 10;
                if (panelL3.Size == panelL3.MaximumSize)
                {
                    timer3.Stop();
                    DDL3 = false;
                }
            }
            else
            {
                bunifuFlatButton4.Iconimage_right = Resources.dd1;
                panelL3.Width -= 10;
                if (panelL3.Size == panelL3.MinimumSize)
                {
                    timer3.Stop();
                    DDL3 = true;
                }

            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (DDL3)
            {
                bunifuFlatButton4.Iconimage_right = Resources.dd2;
                panelL3.Width += 10;
                if (panelL3.Size == panelL3.MaximumSize)
                {
                    timer3.Stop();
                    DDL3 = false;
                }
            }
            else
            {
                bunifuFlatButton4.Iconimage_right = Resources.dd1;
                panelL3.Width -= 10;
                if (panelL3.Size == panelL3.MinimumSize)
                {
                    timer3.Stop();
                    DDL3 = true;
                }

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (DDL4)
            {
                bunifuFlatButton25.Iconimage_right = Resources.dd2;
                panelL4.Width += 10;
                if (panelL4.Size == panelL4.MaximumSize)
                {
                    timer4.Stop();
                    DDL4 = false;
                }
            }
            else
            {
                bunifuFlatButton25.Iconimage_right = Resources.dd1;
                panelL4.Width -= 10;
                if (panelL4.Size == panelL4.MinimumSize)
                {
                    timer4.Stop();
                    DDL4 = true;
                }

            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (DDL5)
            {
                bunifuFlatButton6.Iconimage_right = Resources.dd2;
                panelL5.Width += 10;
                if (panelL5.Size == panelL5.MaximumSize)
                {
                    timer5.Stop();
                    DDL5 = false;
                }
            }
            else
            {
                bunifuFlatButton6.Iconimage_right = Resources.dd1;
                panelL5.Width -= 10;
                if (panelL5.Size == panelL5.MinimumSize)
                {
                    timer5.Stop();
                    DDL5 = true;
                }

            }
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            timer5.Start();
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (DDL6)
            {
                bunifuFlatButton7.Iconimage_right = Resources.dd2;
                panelL6.Width += 10;
                if (panelL6.Size == panelL6.MaximumSize)
                {
                    timer6.Stop();
                    DDL6 = false;
                }
            }
            else
            {
                bunifuFlatButton7.Iconimage_right = Resources.dd1;
                panelL6.Width -= 10;
                if (panelL6.Size == panelL6.MinimumSize)
                {
                    timer6.Stop();
                    DDL6 = true;
                }

            }
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            timer6.Start();
        }

        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            timer3.Start();
            if (!panel.Controls.Contains(ExRGB.Instance))
            {
                panel.Controls.Add(ExRGB.Instance);
                ExRGB.Instance.Dock = DockStyle.Fill;
                ExRGB.Instance.BringToFront();
            }
            else
                ExRGB.Instance.BringToFront();
            if (DDL3)
            {
                bunifuFlatButton4.Iconimage_right = Resources.dd2;
                panelL3.Width += 10;
                if (panelL3.Size == panelL3.MaximumSize)
                {
                    timer3.Stop();
                    DDL3 = false;
                }
            }
            else
            {
                bunifuFlatButton4.Iconimage_right = Resources.dd1;
                panelL3.Width -= 10;
                if (panelL3.Size == panelL3.MinimumSize)
                {
                    timer3.Stop();
                    DDL3 = true;
                }

            }
        }

        private void bunifuFlatButton15_Click(object sender, EventArgs e)
        {
            timer4.Start();
            if (!panel.Controls.Contains(lesson4m.Instance))
            {
                panel.Controls.Add(lesson4m.Instance);
                lesson4m.Instance.Dock = DockStyle.Fill;
                lesson4m.Instance.BringToFront();
            }
            else
                lesson4m.Instance.BringToFront();
            if (DDL4)
            {
                bunifuFlatButton25.Iconimage_right = Resources.dd2;
                panelL4.Width += 10;
                if (panelL4.Size == panelL4.MaximumSize)
                {
                    timer4.Stop();
                    DDL4 = false;
                }
            }
            else
            {
                bunifuFlatButton25.Iconimage_right = Resources.dd1;
                panelL4.Width -= 10;
                if (panelL4.Size == panelL4.MinimumSize)
                {
                    timer4.Stop();
                    DDL4 = true;
                }

            }
        }

        private void bunifuFlatButton16_Click(object sender, EventArgs e)
        {
            timer4.Start();
            if (!panel.Controls.Contains(ExDHT.Instance))
            {
                panel.Controls.Add(ExDHT.Instance);
                ExDHT.Instance.Dock = DockStyle.Fill;
                ExDHT.Instance.BringToFront();
            }
            else
                ExDHT.Instance.BringToFront();
            if (DDL3)
            {
                bunifuFlatButton4.Iconimage_right = Resources.dd2;
                panelL4.Width += 10;
                if (panelL4.Size == panelL4.MaximumSize)
                {
                    timer4.Stop();
                    DDL3 = false;
                }
            }
            else
            {
                bunifuFlatButton4.Iconimage_right = Resources.dd1;
                panelL4.Width -= 10;
                if (panelL4.Size == panelL4.MinimumSize)
                {
                    timer4.Stop();
                    DDL3 = true;
                }

            }
        }

        private void bunifuFlatButton25_Click(object sender, EventArgs e)
        {
            timer4.Start();
        }

        private void bunifuFlatButton23_Click(object sender, EventArgs e)
        {
            timer4.Start();
            if (!panel.Controls.Contains(lesson4m.Instance))
            {
                panel.Controls.Add(lesson4m.Instance);
                lesson4m.Instance.Dock = DockStyle.Fill;
                lesson4m.Instance.BringToFront();
            }
            else
                lesson4m.Instance.BringToFront();
            if (DDL4)
            {
                bunifuFlatButton25.Iconimage_right = Resources.dd2;
                panelL4.Width += 10;
                if (panelL4.Size == panelL4.MaximumSize)
                {
                    timer4.Stop();
                    DDL4 = false;
                }
            }
            else
            {
                bunifuFlatButton25.Iconimage_right = Resources.dd1;
                panelL4.Width -= 10;
                if (panelL4.Size == panelL4.MinimumSize)
                {
                    timer4.Stop();
                    DDL4 = true;
                }

            }
        }

        private void bunifuFlatButton24_Click(object sender, EventArgs e)
        {
            timer4.Start();
            if (!panel.Controls.Contains(ExDHT.Instance))
            {
                panel.Controls.Add(ExDHT.Instance);
                ExDHT.Instance.Dock = DockStyle.Fill;
                ExDHT.Instance.BringToFront();
            }
            else
                ExDHT.Instance.BringToFront();
            if (DDL3)
            {
                bunifuFlatButton4.Iconimage_right = Resources.dd2;
                panelL4.Width += 10;
                if (panelL4.Size == panelL4.MaximumSize)
                {
                    timer4.Stop();
                    DDL3 = false;
                }
            }
            else
            {
                bunifuFlatButton4.Iconimage_right = Resources.dd1;
                panelL4.Width -= 10;
                if (panelL4.Size == panelL4.MinimumSize)
                {
                    timer4.Stop();
                    DDL3 = true;
                }

            }
        }

        private void bunifuFlatButton21_Click(object sender, EventArgs e)
        {
            timer4.Start();
            if (!panel.Controls.Contains(lesson4m2.Instance))
            {
                panel.Controls.Add(lesson4m2.Instance);
                lesson4m2.Instance.Dock = DockStyle.Fill;
                lesson4m2.Instance.BringToFront();
            }
            else
                lesson4m2.Instance.BringToFront();
            if (DDL4)
            {
                bunifuFlatButton25.Iconimage_right = Resources.dd2;
                panelL4.Width += 10;
                if (panelL4.Size == panelL4.MaximumSize)
                {
                    timer4.Stop();
                    DDL4 = false;
                }
            }
            else
            {
                bunifuFlatButton25.Iconimage_right = Resources.dd1;
                panelL4.Width -= 10;
                if (panelL4.Size == panelL4.MinimumSize)
                {
                    timer4.Stop();
                    DDL4 = true;
                }

            }
        }

        private void bunifuFlatButton22_Click(object sender, EventArgs e)
        {
            timer4.Start();
            if (!panel.Controls.Contains(ExUltrasonic.Instance))
            {
                panel.Controls.Add(ExUltrasonic.Instance);
                ExUltrasonic.Instance.Dock = DockStyle.Fill;
                ExUltrasonic.Instance.BringToFront();
            }
            else
                ExUltrasonic.Instance.BringToFront();
            if (DDL4)
            {
                bunifuFlatButton25.Iconimage_right = Resources.dd2;
                panelL4.Width += 10;
                if (panelL4.Size == panelL4.MaximumSize)
                {
                    timer4.Stop();
                    DDL4 = false;
                }
            }
            else
            {
                bunifuFlatButton25.Iconimage_right = Resources.dd1;
                panelL4.Width -= 10;
                if (panelL4.Size == panelL4.MinimumSize)
                {
                    timer4.Stop();
                    DDL4 = true;
                }

            }

        }

        private void bunifuFlatButton17_Click(object sender, EventArgs e)
        {
            timer5.Start();
            if (!panel.Controls.Contains(lesson5m.Instance))
            {
                panel.Controls.Add(lesson5m.Instance);
                lesson5m.Instance.Dock = DockStyle.Fill;
                lesson5m.Instance.BringToFront();
            }
            else
                lesson5m.Instance.BringToFront();
            if (DDL5)
            {
                bunifuFlatButton6.Iconimage_right = Resources.dd2;
                panelL5.Width += 10;
                if (panelL5.Size == panelL5.MaximumSize)
                {
                    timer5.Stop();
                    DDL5 = false;
                }
            }
            else
            {
                bunifuFlatButton6.Iconimage_right = Resources.dd1;
                panelL5.Width -= 10;
                if (panelL5.Size == panelL5.MinimumSize)
                {
                    timer5.Stop();
                    DDL5 = true;
                }

            }
        }
    }
 }


