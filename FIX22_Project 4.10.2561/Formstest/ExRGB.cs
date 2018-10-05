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
    public partial class ExRGB : UserControl
    {
        private static ExRGB _instance;
        public static ExRGB Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ExRGB();
                return _instance;
            }
        }
        public ExRGB()
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
                FileName = @"D:\โปรเจค\RGB_UNO_MIX\RGB_UNO.ino.hex",
                PortName = "",
                ArduinoModel = ArduinoModel.UnoR3
            });

            uploader.UploadSketch();
            
        }

        private void upload_Click(object sender, EventArgs e)
        {
            UploadL1 form = new UploadL1();
            form.Show();

            var uploader = new ArduinoSketchUploader(
            new ArduinoSketchUploaderOptions()
            {
                FileName = @"D:\โปรเจค\RGB_UNO_MIX\RGB_UNO.ino.hex",
                PortName = "",
                ArduinoModel = ArduinoModel.UnoR3
            });

            uploader.UploadSketch();
        }
    }
}
