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
    public partial class configL5 : UserControl
    {
        private static configL5 _instance;
        public static configL5 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new configL5();
                return _instance;
            }
        }
        bool isConnected = false;
        String[] ports;
        SerialPort port;
        private string data;

        public configL5()
        {
            InitializeComponent();

            getAvailableComPorts();
            comboBox1.Hide();

            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
                Console.WriteLine(port);
                if (ports[0] != null)
                {
                    comboBox1.SelectedItem = ports[0];
                }
            }
        }
        void getAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();
        }
        private void connectToArduino()
        {

            isConnected = true;
            string selectedPort = comboBox1.GetItemText(comboBox1.SelectedItem);
            port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
            port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            port.Open();
            button1.Text = "Cancel";

        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            data = port.ReadLine();
        }

        private void disconnectFromArduino()
        {
            isConnected = false;
            port.Close();
            button1.Text = "Test";

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
                        FileName = @"D:\โปรเจค\buzzer-VS2017\buzzer.ino.hex",
                        PortName = "",
                        ArduinoModel = ArduinoModel.UnoR3
                    });

                uploader.UploadSketch();
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                connectToArduino();

            }
            else
            {
                disconnectFromArduino();

            }
        }
        private void buzzer_off_Click(object sender, EventArgs e)
        {
            try
            {
                port.Write("A");
            }
            catch { }
        }

        private void buzzer_alert_Click(object sender, EventArgs e)
        {
            try
            {
                port.Write("B");
            }
            catch { }
            
        }

        private void buzzer_on_Click(object sender, EventArgs e)
        {
            try
            {
                port.Write("C");
            }
            catch { }
            
        }
    }
}
