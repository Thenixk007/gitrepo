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
    public partial class ExButton : UserControl
    {
        private static ExButton _instance;
        public static ExButton Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ExButton();
                return _instance;
            }
        }
        public ExButton()
        {
            InitializeComponent();
        }

        private void upload_Click(object sender, EventArgs e)
        {
            UploadL1 form = new UploadL1();
            form.Show();

            var uploader = new ArduinoSketchUploader(
            new ArduinoSketchUploaderOptions()
            {
                FileName = @"D:\โปรเจค\button-ex\button-ex.ino.hex",
                PortName = "",
                ArduinoModel = ArduinoModel.UnoR3
            });

            uploader.UploadSketch();
        }
    }
}
