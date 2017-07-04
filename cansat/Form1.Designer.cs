namespace cansat
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textPower = new System.Windows.Forms.TextBox();
            this.labelPower = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textSensor10 = new System.Windows.Forms.TextBox();
            this.textSensor9 = new System.Windows.Forms.TextBox();
            this.textSensor8 = new System.Windows.Forms.TextBox();
            this.textSensor7 = new System.Windows.Forms.TextBox();
            this.textSensor6 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelReceived = new System.Windows.Forms.Label();
            this.textUpdated = new System.Windows.Forms.TextBox();
            this.textSensor2 = new System.Windows.Forms.TextBox();
            this.textSensor3 = new System.Windows.Forms.TextBox();
            this.textSensor4 = new System.Windows.Forms.TextBox();
            this.textSensor5 = new System.Windows.Forms.TextBox();
            this.textSensor1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupSettings = new System.Windows.Forms.GroupBox();
            this.comboPort = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.labelPort = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textPacket = new System.Windows.Forms.TextBox();
            this.textTID = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.textGSat = new System.Windows.Forms.TextBox();
            this.textGAlt = new System.Windows.Forms.TextBox();
            this.textGAngle = new System.Windows.Forms.TextBox();
            this.textGSpeed = new System.Windows.Forms.TextBox();
            this.textGLong = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textGTime = new System.Windows.Forms.TextBox();
            this.textGFix = new System.Windows.Forms.TextBox();
            this.textGLat = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM7";
            // 
            // textPower
            // 
            this.textPower.Location = new System.Drawing.Point(18, 56);
            this.textPower.Margin = new System.Windows.Forms.Padding(6);
            this.textPower.Name = "textPower";
            this.textPower.ReadOnly = true;
            this.textPower.Size = new System.Drawing.Size(54, 31);
            this.textPower.TabIndex = 0;
            // 
            // labelPower
            // 
            this.labelPower.AutoSize = true;
            this.labelPower.Location = new System.Drawing.Point(88, 63);
            this.labelPower.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPower.Name = "labelPower";
            this.labelPower.Size = new System.Drawing.Size(139, 25);
            this.labelPower.TabIndex = 1;
            this.labelPower.Text = "Power Status";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textSensor10);
            this.groupBox1.Controls.Add(this.textSensor9);
            this.groupBox1.Controls.Add(this.textSensor8);
            this.groupBox1.Controls.Add(this.textSensor7);
            this.groupBox1.Controls.Add(this.textSensor6);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.labelReceived);
            this.groupBox1.Controls.Add(this.textUpdated);
            this.groupBox1.Controls.Add(this.textSensor2);
            this.groupBox1.Controls.Add(this.textSensor3);
            this.groupBox1.Controls.Add(this.textSensor4);
            this.groupBox1.Controls.Add(this.textSensor5);
            this.groupBox1.Controls.Add(this.textSensor1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(888, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(427, 656);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sensor Values";
            // 
            // textSensor10
            // 
            this.textSensor10.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textSensor10.Location = new System.Drawing.Point(166, 556);
            this.textSensor10.Margin = new System.Windows.Forms.Padding(6);
            this.textSensor10.Name = "textSensor10";
            this.textSensor10.ReadOnly = true;
            this.textSensor10.Size = new System.Drawing.Size(196, 31);
            this.textSensor10.TabIndex = 36;
            this.textSensor10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textSensor9
            // 
            this.textSensor9.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textSensor9.Location = new System.Drawing.Point(166, 502);
            this.textSensor9.Margin = new System.Windows.Forms.Padding(6);
            this.textSensor9.Name = "textSensor9";
            this.textSensor9.ReadOnly = true;
            this.textSensor9.Size = new System.Drawing.Size(196, 31);
            this.textSensor9.TabIndex = 35;
            this.textSensor9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textSensor8
            // 
            this.textSensor8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textSensor8.Location = new System.Drawing.Point(166, 451);
            this.textSensor8.Margin = new System.Windows.Forms.Padding(6);
            this.textSensor8.Name = "textSensor8";
            this.textSensor8.ReadOnly = true;
            this.textSensor8.Size = new System.Drawing.Size(196, 31);
            this.textSensor8.TabIndex = 34;
            this.textSensor8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textSensor7
            // 
            this.textSensor7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textSensor7.Location = new System.Drawing.Point(166, 398);
            this.textSensor7.Margin = new System.Windows.Forms.Padding(6);
            this.textSensor7.Name = "textSensor7";
            this.textSensor7.ReadOnly = true;
            this.textSensor7.Size = new System.Drawing.Size(196, 31);
            this.textSensor7.TabIndex = 33;
            this.textSensor7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textSensor6
            // 
            this.textSensor6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textSensor6.Location = new System.Drawing.Point(166, 344);
            this.textSensor6.Margin = new System.Windows.Forms.Padding(6);
            this.textSensor6.Name = "textSensor6";
            this.textSensor6.ReadOnly = true;
            this.textSensor6.Size = new System.Drawing.Size(196, 31);
            this.textSensor6.TabIndex = 32;
            this.textSensor6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 559);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 25);
            this.label12.TabIndex = 31;
            this.label12.Text = "Sensor 10";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 508);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 25);
            this.label10.TabIndex = 30;
            this.label10.Text = "Sensor 09";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 457);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 25);
            this.label9.TabIndex = 29;
            this.label9.Text = "Sensor 08";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 404);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 25);
            this.label7.TabIndex = 28;
            this.label7.Text = "Sensor 07";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 350);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Sensor 06";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 613);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Updated";
            // 
            // labelReceived
            // 
            this.labelReceived.AutoSize = true;
            this.labelReceived.Location = new System.Drawing.Point(191, 49);
            this.labelReceived.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelReceived.Name = "labelReceived";
            this.labelReceived.Size = new System.Drawing.Size(153, 25);
            this.labelReceived.TabIndex = 24;
            this.labelReceived.Text = "Received Data";
            // 
            // textUpdated
            // 
            this.textUpdated.BackColor = System.Drawing.SystemColors.Control;
            this.textUpdated.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUpdated.Location = new System.Drawing.Point(116, 614);
            this.textUpdated.Margin = new System.Windows.Forms.Padding(6);
            this.textUpdated.Name = "textUpdated";
            this.textUpdated.ReadOnly = true;
            this.textUpdated.Size = new System.Drawing.Size(260, 24);
            this.textUpdated.TabIndex = 22;
            // 
            // textSensor2
            // 
            this.textSensor2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textSensor2.Location = new System.Drawing.Point(168, 140);
            this.textSensor2.Margin = new System.Windows.Forms.Padding(6);
            this.textSensor2.Name = "textSensor2";
            this.textSensor2.ReadOnly = true;
            this.textSensor2.Size = new System.Drawing.Size(196, 31);
            this.textSensor2.TabIndex = 13;
            this.textSensor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textSensor3
            // 
            this.textSensor3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textSensor3.Location = new System.Drawing.Point(166, 192);
            this.textSensor3.Margin = new System.Windows.Forms.Padding(6);
            this.textSensor3.Name = "textSensor3";
            this.textSensor3.ReadOnly = true;
            this.textSensor3.Size = new System.Drawing.Size(196, 31);
            this.textSensor3.TabIndex = 12;
            this.textSensor3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textSensor4
            // 
            this.textSensor4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textSensor4.Location = new System.Drawing.Point(166, 242);
            this.textSensor4.Margin = new System.Windows.Forms.Padding(6);
            this.textSensor4.Name = "textSensor4";
            this.textSensor4.ReadOnly = true;
            this.textSensor4.Size = new System.Drawing.Size(196, 31);
            this.textSensor4.TabIndex = 11;
            this.textSensor4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textSensor5
            // 
            this.textSensor5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textSensor5.Location = new System.Drawing.Point(166, 292);
            this.textSensor5.Margin = new System.Windows.Forms.Padding(6);
            this.textSensor5.Name = "textSensor5";
            this.textSensor5.ReadOnly = true;
            this.textSensor5.Size = new System.Drawing.Size(196, 31);
            this.textSensor5.TabIndex = 10;
            this.textSensor5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textSensor1
            // 
            this.textSensor1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textSensor1.Location = new System.Drawing.Point(168, 90);
            this.textSensor1.Margin = new System.Windows.Forms.Padding(6);
            this.textSensor1.Name = "textSensor1";
            this.textSensor1.ReadOnly = true;
            this.textSensor1.Size = new System.Drawing.Size(196, 31);
            this.textSensor1.TabIndex = 3;
            this.textSensor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 143);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Sensor 02";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 193);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Sensor 03";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 245);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sensor 04";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 297);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sensor 05";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sensor 01";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(363, 453);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "ece197";
            // 
            // groupSettings
            // 
            this.groupSettings.Controls.Add(this.comboPort);
            this.groupSettings.Controls.Add(this.btnConnect);
            this.groupSettings.Controls.Add(this.labelPort);
            this.groupSettings.Controls.Add(this.labelPower);
            this.groupSettings.Controls.Add(this.textPower);
            this.groupSettings.Location = new System.Drawing.Point(15, 15);
            this.groupSettings.Margin = new System.Windows.Forms.Padding(6);
            this.groupSettings.Name = "groupSettings";
            this.groupSettings.Padding = new System.Windows.Forms.Padding(6);
            this.groupSettings.Size = new System.Drawing.Size(410, 248);
            this.groupSettings.TabIndex = 29;
            this.groupSettings.TabStop = false;
            this.groupSettings.Text = "Settings";
            // 
            // comboPort
            // 
            this.comboPort.FormattingEnabled = true;
            this.comboPort.Location = new System.Drawing.Point(130, 109);
            this.comboPort.Margin = new System.Windows.Forms.Padding(6);
            this.comboPort.Name = "comboPort";
            this.comboPort.Size = new System.Drawing.Size(250, 33);
            this.comboPort.TabIndex = 1;
            this.comboPort.SelectedIndexChanged += new System.EventHandler(this.comboPort_SelectedIndexChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(130, 182);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(6);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(150, 44);
            this.btnConnect.TabIndex = 31;
            this.btnConnect.Text = "Start";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnStartClick);
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(12, 112);
            this.labelPort.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(106, 25);
            this.labelPort.TabIndex = 30;
            this.labelPort.Text = "COM Port";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(15, 451);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 137);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AllowDrop = true;
            this.label13.Location = new System.Drawing.Point(18, 611);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(410, 60);
            this.label13.TabIndex = 31;
            this.label13.Text = "ECE 197S: Introduction to Satellite and Space Systems Engineering";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textPacket);
            this.groupBox2.Controls.Add(this.textTID);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Location = new System.Drawing.Point(443, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(427, 170);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mission Info";
            // 
            // textPacket
            // 
            this.textPacket.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textPacket.Location = new System.Drawing.Point(226, 104);
            this.textPacket.Margin = new System.Windows.Forms.Padding(6);
            this.textPacket.Name = "textPacket";
            this.textPacket.ReadOnly = true;
            this.textPacket.Size = new System.Drawing.Size(138, 31);
            this.textPacket.TabIndex = 13;
            this.textPacket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textTID
            // 
            this.textTID.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textTID.Location = new System.Drawing.Point(226, 54);
            this.textTID.Margin = new System.Windows.Forms.Padding(6);
            this.textTID.Name = "textTID";
            this.textTID.ReadOnly = true;
            this.textTID.Size = new System.Drawing.Size(138, 31);
            this.textTID.TabIndex = 3;
            this.textTID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(49, 107);
            this.label21.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(141, 25);
            this.label21.TabIndex = 4;
            this.label21.Text = "Packet Count";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(49, 57);
            this.label25.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(92, 25);
            this.label25.TabIndex = 0;
            this.label25.Text = "Team ID";
            // 
            // textGSat
            // 
            this.textGSat.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textGSat.Location = new System.Drawing.Point(168, 414);
            this.textGSat.Margin = new System.Windows.Forms.Padding(6);
            this.textGSat.Name = "textGSat";
            this.textGSat.ReadOnly = true;
            this.textGSat.Size = new System.Drawing.Size(196, 31);
            this.textGSat.TabIndex = 36;
            this.textGSat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textGAlt
            // 
            this.textGAlt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textGAlt.Location = new System.Drawing.Point(168, 360);
            this.textGAlt.Margin = new System.Windows.Forms.Padding(6);
            this.textGAlt.Name = "textGAlt";
            this.textGAlt.ReadOnly = true;
            this.textGAlt.Size = new System.Drawing.Size(196, 31);
            this.textGAlt.TabIndex = 35;
            this.textGAlt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textGAngle
            // 
            this.textGAngle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textGAngle.Location = new System.Drawing.Point(168, 309);
            this.textGAngle.Margin = new System.Windows.Forms.Padding(6);
            this.textGAngle.Name = "textGAngle";
            this.textGAngle.ReadOnly = true;
            this.textGAngle.Size = new System.Drawing.Size(196, 31);
            this.textGAngle.TabIndex = 34;
            this.textGAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textGSpeed
            // 
            this.textGSpeed.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textGSpeed.Location = new System.Drawing.Point(168, 256);
            this.textGSpeed.Margin = new System.Windows.Forms.Padding(6);
            this.textGSpeed.Name = "textGSpeed";
            this.textGSpeed.ReadOnly = true;
            this.textGSpeed.Size = new System.Drawing.Size(196, 31);
            this.textGSpeed.TabIndex = 33;
            this.textGSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textGLong
            // 
            this.textGLong.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textGLong.Location = new System.Drawing.Point(168, 202);
            this.textGLong.Margin = new System.Windows.Forms.Padding(6);
            this.textGLong.Name = "textGLong";
            this.textGLong.ReadOnly = true;
            this.textGLong.Size = new System.Drawing.Size(196, 31);
            this.textGLong.TabIndex = 32;
            this.textGLong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(51, 417);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 25);
            this.label14.TabIndex = 31;
            this.label14.Text = "Satellites";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(51, 366);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 25);
            this.label15.TabIndex = 30;
            this.label15.Text = "Altitude";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(51, 315);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 25);
            this.label16.TabIndex = 29;
            this.label16.Text = "Angle";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(51, 262);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 25);
            this.label17.TabIndex = 28;
            this.label17.Text = "Speed";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(51, 208);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 25);
            this.label18.TabIndex = 27;
            this.label18.Text = "Longitude";
            // 
            // textGTime
            // 
            this.textGTime.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textGTime.Location = new System.Drawing.Point(168, 50);
            this.textGTime.Margin = new System.Windows.Forms.Padding(6);
            this.textGTime.Name = "textGTime";
            this.textGTime.ReadOnly = true;
            this.textGTime.Size = new System.Drawing.Size(196, 31);
            this.textGTime.TabIndex = 12;
            this.textGTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textGFix
            // 
            this.textGFix.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textGFix.Location = new System.Drawing.Point(168, 100);
            this.textGFix.Margin = new System.Windows.Forms.Padding(6);
            this.textGFix.Name = "textGFix";
            this.textGFix.ReadOnly = true;
            this.textGFix.Size = new System.Drawing.Size(196, 31);
            this.textGFix.TabIndex = 11;
            this.textGFix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textGLat
            // 
            this.textGLat.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textGLat.Location = new System.Drawing.Point(168, 150);
            this.textGLat.Margin = new System.Windows.Forms.Padding(6);
            this.textGLat.Name = "textGLat";
            this.textGLat.ReadOnly = true;
            this.textGLat.Size = new System.Drawing.Size(196, 31);
            this.textGLat.TabIndex = 10;
            this.textGLat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(51, 51);
            this.label22.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 25);
            this.label22.TabIndex = 3;
            this.label22.Text = "Time";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(51, 103);
            this.label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(41, 25);
            this.label.TabIndex = 2;
            this.label.Text = "Fix";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(51, 155);
            this.label24.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(89, 25);
            this.label24.TabIndex = 1;
            this.label24.Text = "Latitude";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textGSat);
            this.groupBox3.Controls.Add(this.textGTime);
            this.groupBox3.Controls.Add(this.textGFix);
            this.groupBox3.Controls.Add(this.textGAlt);
            this.groupBox3.Controls.Add(this.textGLat);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.textGAngle);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.textGSpeed);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label);
            this.groupBox3.Controls.Add(this.textGLong);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(443, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(427, 474);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "GPS Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1946, 690);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupSettings);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Cansat Server";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupSettings.ResumeLayout(false);
            this.groupSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textPower;
        private System.Windows.Forms.Label labelPower;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelReceived;
        private System.Windows.Forms.TextBox textUpdated;
        private System.Windows.Forms.TextBox textSensor2;
        private System.Windows.Forms.TextBox textSensor3;
        private System.Windows.Forms.TextBox textSensor4;
        private System.Windows.Forms.TextBox textSensor5;
        private System.Windows.Forms.TextBox textSensor1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupSettings;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox comboPort;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSensor10;
        private System.Windows.Forms.TextBox textSensor9;
        private System.Windows.Forms.TextBox textSensor8;
        private System.Windows.Forms.TextBox textSensor7;
        private System.Windows.Forms.TextBox textSensor6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textPacket;
        private System.Windows.Forms.TextBox textTID;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textGSat;
        private System.Windows.Forms.TextBox textGAlt;
        private System.Windows.Forms.TextBox textGAngle;
        private System.Windows.Forms.TextBox textGSpeed;
        private System.Windows.Forms.TextBox textGLong;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textGTime;
        private System.Windows.Forms.TextBox textGFix;
        private System.Windows.Forms.TextBox textGLat;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

