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
    public partial class ExUltrasonic : UserControl
    {
        private static ExUltrasonic _instance;
        public static ExUltrasonic Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ExUltrasonic();
                return _instance;
            }
        }
        public ExUltrasonic()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!panel7.Controls.Contains(testUltrasonic_Ex.Instance))
            {
                panel7.Controls.Add(testUltrasonic_Ex.Instance);
                testUltrasonic_Ex.Instance.Dock = DockStyle.Fill;
                testUltrasonic_Ex.Instance.BringToFront();
            }
            else
                testUltrasonic_Ex.Instance.BringToFront();

            button2.Hide();
            button3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!panel7.Controls.Contains(back_to_Ultrasonic_Ex.Instance))
            {
                panel7.Controls.Add(back_to_Ultrasonic_Ex.Instance);
                back_to_Ultrasonic_Ex.Instance.Dock = DockStyle.Fill;
                back_to_Ultrasonic_Ex.Instance.BringToFront();
            }
            else
                back_to_Ultrasonic_Ex.Instance.BringToFront();

            button2.Show();
            button3.Hide();
        }

        private void upload_Click(object sender, EventArgs e)
        {
            try
            {
                UploadL1 form = new UploadL1();
                form.Show();

                var uploader = new ArduinoSketchUploader(
                new ArduinoSketchUploaderOptions()
                {
                    FileName = @"D:\โปรเจค\Ultrasonic-LED-VS2017\Ultrasonic-LED-VS2017.ino.hex",
                    PortName = "",
                    ArduinoModel = ArduinoModel.UnoR3
                });

                uploader.UploadSketch();
            }
            catch { }
        }
    }
}
