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
    public partial class configL44 : UserControl
    {
        private static configL44 _instance;
        public static configL44 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new configL44();
                return _instance;
            }
        }

        bool isConnected = false;
        String[] ports;
        SerialPort port;

        public configL44()
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
            timer1.Enabled = true;
            string selectedPort = comboBox1.GetItemText(comboBox1.SelectedItem);
            port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
            port.Open(); 
            button1.Text = "Disconnect"; 

        }
        private void disconnectFromArduino()
        {
            isConnected = false;
            port.Close();
            timer1.Stop();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                timer1.Interval = 1000;
                String data = port.ReadLine().ToString();

                String[] isinem = data.Split(',');
                int humidity = (int)(Math.Round(Convert.ToDecimal(isinem[0]), 0));
                int temperature = (int)(Math.Round(Convert.ToDecimal(isinem[1]), 0));


                label3.Text = temperature.ToString() + " °C";
                label4.Text = humidity.ToString() + " %";
            }
            catch { }
        }

        private void configL44_Load(object sender, EventArgs e)
        {
            
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
                        FileName = @"D:\โปรเจค\DHT-VS2017\DHT-VS2017.ino.hex",
                        PortName = "",
                        ArduinoModel = ArduinoModel.UnoR3
                    });

                uploader.UploadSketch();
            }
            catch { }

        }
    }
}
