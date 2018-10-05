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
    public partial class lesson2m : UserControl
    {
        private static lesson2m _instance;
        public static lesson2m Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new lesson2m();
                return _instance;
            }
        }
        public lesson2m()
        {
            InitializeComponent();
        }

        private bool addled_click = false;
        private bool addB_click = false;

        private void lesson2m_Load(object sender, EventArgs e)
        {
            condl2.Hide();
        }

        private void up_Click_1(object sender, EventArgs e)
        {
            try
            {

                UploadL1 form = new UploadL1();
                form.Show();

                var uploader = new ArduinoSketchUploader(
                new ArduinoSketchUploaderOptions()
                {
                    FileName = @"D:\โปรเจค\LedButton uno\LedButton.ino.hex",
                    PortName = "",
                    ArduinoModel = ArduinoModel.UnoR3
                });

                uploader.UploadSketch();
            }
            catch { }
        }

       

        private void Bconn2_Click(object sender, EventArgs e)
        {
            condl2.Show();
            Bconn.Show();
            Bconn2.Hide();
        }

        private void Bconn_Click(object sender, EventArgs e)
        {
            condl2.Hide();
            Bconn.Hide();
            Bconn2.Show();
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
                    FileName = @"D:\โปรเจค\LedButton uno\LedButton.ino.hex",
                    PortName = "",
                    ArduinoModel = ArduinoModel.UnoR3
                });

                uploader.UploadSketch();
            }
            catch { }
           
        }
    }
}
