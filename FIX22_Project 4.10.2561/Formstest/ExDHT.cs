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
using System.IO.Ports;

namespace Formstest
{
    public partial class ExDHT : UserControl
    {
        private static ExDHT _instance;
        public static ExDHT Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ExDHT();
                return _instance;
            }
        }

        bool isConnected = false;
        String[] ports;
        SerialPort port;

        public ExDHT()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!panel7.Controls.Contains(TestDHT_Ex.Instance))
            {
                panel7.Controls.Add(TestDHT_Ex.Instance);
                TestDHT_Ex.Instance.Dock = DockStyle.Fill;
                TestDHT_Ex.Instance.BringToFront();
            }
            else
                TestDHT_Ex.Instance.BringToFront();

            button2.Hide();
            button3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!panel7.Controls.Contains(back_to_DHT_Ex.Instance))
            {
                panel7.Controls.Add(back_to_DHT_Ex.Instance);
                back_to_DHT_Ex.Instance.Dock = DockStyle.Fill;
                back_to_DHT_Ex.Instance.BringToFront();
            }
            else
                back_to_DHT_Ex.Instance.BringToFront();

            button2.Show();
            button3.Hide();
        }

        private void upload_Click_1(object sender, EventArgs e)
        {
            try
            {
                UploadL1 form = new UploadL1();
                form.Show();

                var uploader = new ArduinoSketchUploader(
                new ArduinoSketchUploaderOptions()
                {
                    FileName = @"D:\โปรเจค\DHT-LEDv2-VS2017\DHT-LEDv2-VS2017.ino.hex",
                    PortName = "",
                    ArduinoModel = ArduinoModel.UnoR3
                });

                uploader.UploadSketch();
            }
            catch { }
        }
    }
}
