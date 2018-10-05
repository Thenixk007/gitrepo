using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using ArduinoUploader;
using ArduinoUploader.Hardware;

namespace Formstest
{
    public partial class configL44_2 : UserControl
    {
        private static configL44_2 _instance;
        public static configL44_2 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new configL44_2();
                return _instance;
            }
        }

        bool isConnected = false;
        String[] ports;
        SerialPort port;
        delegate void SetTextDelegate(string value);

        public configL44_2()
        {
            InitializeComponent();
            getAvailableComPorts();

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
            button1.Text = "Disconnect";

        }
        private void disconnectFromArduino()
        {
            isConnected = false;
            port.Close();
            button1.Text = "Connect";

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

        public void SetText(string value)
        {
            if (InvokeRequired)
                try
                {
                    Invoke(new SetTextDelegate(SetText), value);
                }
                catch { }
            else
                label3.Text = value + " cm";
        }
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            String data = port.ReadLine();
            SetText(data);
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
                        FileName = @"D:\โปรเจค\Ultrasonic-VS2017\Ultrasonic.ino.hex",
                        PortName = "",
                        ArduinoModel = ArduinoModel.UnoR3
                    });

                uploader.UploadSketch();
            }
            catch { }
        }
    }
}
