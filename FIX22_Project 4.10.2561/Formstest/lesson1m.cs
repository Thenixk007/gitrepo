using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArduinoUploader;
using ArduinoUploader.Hardware;

namespace Formstest
{
    public partial class lesson1m : UserControl
    {
        private static lesson1m _instance;
        public static lesson1m Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new lesson1m();
                return _instance;
            }
        }

        private bool button1_click = true;
        private bool button2_click = true;

        public lesson1m()
        {
            InitializeComponent();
            condl1.Hide();

          /*  flowLayoutPanel_codeL2.AutoScroll = true;
            flowLayoutPanel_codeL2.Controls.Add();
            */

        }
        
        private void lesson1m_Load(object sender, EventArgs e)
        {
            
        }

        private void Bconn2_Click(object sender, EventArgs e)
        {
            condl1.Show();
            Bconn.Show();
            Bconn2.Hide();
        }

        private void Bconn_Click(object sender, EventArgs e)
        {
            condl1.Hide();
            Bconn.Hide();
            Bconn2.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            try
            {
                UploadL1 form = new UploadL1();
                form.Show();

                var uploader = new ArduinoSketchUploader(
                new ArduinoSketchUploaderOptions()
                {
                    FileName = @"D:\โปรเจค\led1 uno\led_1_high.ino.hex",
                    PortName = "",
                    ArduinoModel = ArduinoModel.UnoR3
                });

                uploader.UploadSketch();
            }
            catch
            {

            }
        }
    }
       
}

