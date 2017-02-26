using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

/*
 * Baud Rate: Fixed at 9600
 * Required Input Format: Gxxx,Hyy,Izzzz..,
 * Tag: G, H, I,... (Max 10 data)
 * Delimiter: ,
 * 
 * Output CSV stored in local folder
 */

namespace cansat
{
    public partial class Form1 : Form
    {
        // COM PORT
        bool comPortSelected = false;
        string comPort;

        // INDEX
        private const uint buffer_size = 2048;
        private byte[] rxbuffer = new byte[buffer_size];

        private int rx_in = 0;
        private int rx_out = 0;
        
        private string filePath = @"data.csv";

        public delegate void AddDataDelegate(byte[] data);
        public AddDataDelegate myDelegate;

        public Form1()
        {
            InitializeComponent();
            string[] ports = SerialPort.GetPortNames();
            
            comboPort.Items.AddRange(ports);
            this.myDelegate = new AddDataDelegate(AddDataMethod);
        }
        
        void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e) {

            //Initialize a buffer to hold the received data 
            byte[] buffer = new byte[serialPort1.BytesToRead];
            int bytesRead = serialPort1.Read(buffer, 0, buffer.Length);
            
            int i = 0;
            for (i = 0; i < buffer.Length; i++) {
                byte rxbyte = buffer[i];

                rxbuffer[rx_in++] = rxbyte;
                if (rx_in >= rxbuffer.Length)
                    rx_in = 0;
            }
            
            // count the receive bytes
            int size = rx_in - rx_out;
            if (size < 0)
                size += (int)buffer_size;
                        
            if (size > 1)
            {
                // temporary pos
                int pos = rx_out;
                byte[] line = new byte[size];
                for (i = 0; i < size; i++)
                {
                    byte rx = rxbuffer[pos++];
                    if (pos >= buffer_size)
                        pos -= (int)buffer_size;

                    if (rx > 32)
                    { // if readable character
                        line[i] = rx;
                    }
                    else 
                    {
                        rx_out = pos;
                        this.Invoke(this.myDelegate, line);
                        break;
                    }
                }
            }
        }

        private void AddDataMethod(byte[] line) {
            textPower.BackColor = Color.LimeGreen;

            String now = DateTime.Now.ToString();
            textUpdated.Text = now;

            String data = System.Text.Encoding.UTF8.GetString(line).TrimEnd('\0');
            File.AppendAllText(filePath, now + ","+ data + "\r\n");

            String[] values = data.Split(',');

            for (int i = 0; i < values.Length; i++)
            {
                String value = values[i];
                switch(value[0])
                {
                    case 'G':
                        textSensor1.Text = values[i].Substring(1);
                        break;
                    case 'H':
                        textSensor2.Text = values[i].Substring(1);
                        break;
                    case 'I':
                        textSensor3.Text = values[i].Substring(1);
                        break;
                    case 'J':
                        textSensor4.Text = values[i].Substring(1);
                        break;
                    case 'K':
                        textSensor5.Text = values[i].Substring(1);
                        break;
                    case 'L':
                        textSensor6.Text = values[i].Substring(1);
                        break;
                    case 'M':
                        textSensor7.Text = values[i].Substring(1);
                        break;
                    case 'N':
                        textSensor8.Text = values[i].Substring(1);
                        break;
                    case 'O':
                        textSensor9.Text = values[i].Substring(1);
                        break;
                    case 'P':
                        textSensor10.Text = values[i].Substring(1);
                        break;
                }
            }
        }

        /*************************************************************************
         * Settings
         ************************************************************************/

        /* Store COM Port Selected and Update Flag */
        private void comboPort_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboPort.SelectedItem == null) {
                comPortSelected = false;
                return;
            }
            comPort = comboPort.SelectedItem.ToString();
            comPortSelected = true;
        }

        /* Check Requirements Before Proceeding */
        private void btnStartClick(object sender, EventArgs e) {
            if (!comPortSelected) {
                MessageBox.Show("Please select a COM PORT.");
            } else {
                Open();
            }
        }

        /* Open COM Port */
        public bool Open() {
            try {
                serialPort1.PortName = comPort;
                serialPort1.BaudRate = 9600;
                serialPort1.DataBits = 8;
                serialPort1.Handshake = Handshake.None;
                serialPort1.Parity = Parity.None;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Open();
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(_serialPort_DataReceived);
                btnConnect.Enabled = false;
            } catch {
                return false;
            }
            return true;
        }
    }
}
