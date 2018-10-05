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
    public partial class back_to_Ultrasonic_Ex : UserControl
    {
        private static back_to_Ultrasonic_Ex _instance;
        public static back_to_Ultrasonic_Ex Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new back_to_Ultrasonic_Ex();
                return _instance;
            }
        }
        public back_to_Ultrasonic_Ex()
        {
            InitializeComponent();
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
