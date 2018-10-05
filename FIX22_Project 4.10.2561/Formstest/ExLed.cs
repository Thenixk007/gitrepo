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
    public partial class ExLed : UserControl
    {
        private static ExLed _instance;
        public static ExLed Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ExLed();
                return _instance;
            }
        }
        public ExLed()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UploadL1 form = new UploadL1();
            form.Show();

            var uploader = new ArduinoSketchUploader(
            new ArduinoSketchUploaderOptions()
            {
                FileName = @"D:\โปรเจค\LedLoop3 uno\led_3_high.ino.hex",
                PortName = "",
                ArduinoModel = ArduinoModel.UnoR3
            });

            uploader.UploadSketch();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            UploadL1 form = new UploadL1();
            form.Show();

            var uploader = new ArduinoSketchUploader(
            new ArduinoSketchUploaderOptions()
            {
                FileName = @"D:\โปรเจค\LedLoop3 uno\led_3_high.ino.hex",
                PortName = "",
                ArduinoModel = ArduinoModel.UnoR3
            });

            uploader.UploadSketch();
        }
    }
}
