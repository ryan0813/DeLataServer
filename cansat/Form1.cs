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

/*
 * Required Input Format: Gxxx,Hyy,Izzzz..,
 * Tag: G, H, I,...
 * Delimiter: ,
 */

namespace cansat
{
    public partial class Form1 : Form
    {
        // COM PORT
        bool comPortSelected = false;
        string comPort;

        // START FRAME
        //private int startFramePos = 0;
        //private string startFrameText;

        // STOP FRAME
        //private int stopFramePos = 0;
        // private string stopFrameText;

        // DELIMITER
        //private int delimiterPos = 0;
        //private string delimiterText;

        // INDEX
        private const uint buffer_size = 2048;
        private byte[] rxbuffer = new byte[buffer_size];
        //private byte previousbyte = 0;
        //private int rxpos = 0;
        private int rx_in = 0;
        private int rx_out = 0;

        //private int AApos = 0;
        //private int BBpos = 0;

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

            //String raw = System.Text.Encoding.UTF8.GetString(buffer);
            //Console.WriteLine(raw);

            int i = 0;
            for (i = 0; i < buffer.Length; i++) {
                byte rxbyte = buffer[i];

                rxbuffer[rx_in++] = rxbyte;
                if (rx_in >= rxbuffer.Length)
                    rx_in = 0;
            }
            //Console.Write("RX_IN:");
            //Console.WriteLine(rx_in);

            // count the receive bytes
            int size = rx_in - rx_out;
            if (size < 0)
                size += (int)buffer_size;

            //Console.Write("SIZE:");
            //Console.WriteLine(size);
            
            if (size > 1)
            {
                // temporary pos
                int pos = rx_out;
                byte[] line = new byte[size];
                for (i = 0; i < size; i++)
                {
                    //Console.Write("POS:");
                    //Console.WriteLine(size);

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

                        //Console.Write(rx_in); Console.Write("-");
                        //Console.Write(pos); Console.Write("-");
                        //Console.WriteLine(rx_out);
                        //Console.WriteLine(size);
                        Console.WriteLine(BitConverter.ToString(line));
                        String data = System.Text.Encoding.UTF8.GetString(line);

                        Console.WriteLine("---");
                        Console.WriteLine(data);
                        break;
                    }

                    //Console.Write("RAW:");
                    //String data = System.Text.Encoding.UTF8.GetString(line);
                    //Console.WriteLine(data);
                    //Console.WriteLine(BitConverter.ToString(line));

                    //if (rx == 10) // if has new line
                    //{
                    //    String data = System.Text.Encoding.UTF8.GetString(line);
                    //    Console.WriteLine(data);
                    //    rx_out = pos;
                    //    break;
                    //}
                }
            }
            
            

            /*
            if (BBpos - AApos == 12) {
                byte[] line = new byte[10];
                for (int i = 0; i < line.Length; i++) {
                    line[i] = rxbuffer[AApos + 1 + i];
                }
                
                this.Invoke(this.myDelegate, line);
                //Console.WriteLine(BitConverter.ToString(line));
            }*/
        }

        private void AddDataMethod(byte[] data) {
            textPower.BackColor = Color.LimeGreen;

            int adc1 = (data[0] * 256 + data[1]) / 64;
            int adc2 = (data[2] * 256 + data[3]) / 64;
            int adc3 = (data[4] * 256 + data[5]) / 64;
            int adc4 = (data[6] * 256 + data[7]) / 64;
            int adc5 = (data[8] * 256 + data[9]) / 64;

            textSensor1.Text = adc1.ToString();
            textSensor2.Text = adc2.ToString();
            textSensor3.Text = adc3.ToString();
            textSensor4.Text = adc4.ToString();
            textSensor5.Text = adc5.ToString();
            
            textUpdated.Text = DateTime.Now.ToString();
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
            if (!comPortSelected /*|| textStartFrame.Text.Length <= 0 || textStopFrame.Text.Length <= 0 || textDelimiter.Text.Length <= 0*/) {
                MessageBox.Show("Please complete all fields.");
            } else {
                //startFrameText = textStartFrame.Text.ToString();
                //stopFrameText = textStopFrame.Text.ToString();
                //delimiterText = textDelimiter.Text.ToString();
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
