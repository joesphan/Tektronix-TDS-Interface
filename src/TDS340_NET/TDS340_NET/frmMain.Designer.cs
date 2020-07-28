namespace TDS340_NET
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comPortNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cboBaudRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLogText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGetDeviceID = new System.Windows.Forms.Button();
            this.btnSaveSerialSettings = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustomCommand = new System.Windows.Forms.TextBox();
            this.btnSendCustomCommand = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblBytesCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrUpdateBytesCount = new System.Windows.Forms.Timer(this.components);
            this.btnMeasureCH1Freq = new System.Windows.Forms.Button();
            this.btnMeasureCH2Freq = new System.Windows.Forms.Button();
            this.btnCh1Waveform = new System.Windows.Forms.Button();
            this.btnCh2Waveform = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEventLog = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.picHardCopy = new System.Windows.Forms.PictureBox();
            this.btnGetScreenshot = new System.Windows.Forms.Button();
            this.btnClearPicture = new System.Windows.Forms.Button();
            this.chkSaveOriginalColor = new System.Windows.Forms.CheckBox();
            this.tmrSaveBitmap = new System.Windows.Forms.Timer(this.components);
            this.btnSaveBitmap = new System.Windows.Forms.Button();
            this.btnFFTWaveform = new System.Windows.Forms.Button();
            this.btnRef1Waveform = new System.Windows.Forms.Button();
            this.btnRef2Waveform = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.comPortNum)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHardCopy)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 19200;
            this.serialPort1.DtrEnable = true;
            this.serialPort1.RtsEnable = true;
            this.serialPort1.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialPort1_ErrorReceived);
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM Port:";
            // 
            // comPortNum
            // 
            this.comPortNum.Location = new System.Drawing.Point(101, 13);
            this.comPortNum.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.comPortNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.comPortNum.Name = "comPortNum";
            this.comPortNum.Size = new System.Drawing.Size(81, 20);
            this.comPortNum.TabIndex = 1;
            this.comPortNum.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(300, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baud rate (bps):";
            // 
            // cboBaudRate
            // 
            this.cboBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBaudRate.FormattingEnabled = true;
            this.cboBaudRate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400"});
            this.cboBaudRate.Location = new System.Drawing.Point(388, 10);
            this.cboBaudRate.Name = "cboBaudRate";
            this.cboBaudRate.Size = new System.Drawing.Size(111, 21);
            this.cboBaudRate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(486, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Other oscilloscope serial settings should be 8-bit, no parity, 1 stop bit, CR EOL" +
    ", no hardware or software handshaking. A cross-over serial cable should be used." +
    "";
            // 
            // txtLogText
            // 
            this.txtLogText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogText.Location = new System.Drawing.Point(12, 700);
            this.txtLogText.Multiline = true;
            this.txtLogText.Name = "txtLogText";
            this.txtLogText.ReadOnly = true;
            this.txtLogText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogText.Size = new System.Drawing.Size(862, 124);
            this.txtLogText.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.Location = new System.Drawing.Point(13, 671);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Log:";
            // 
            // btnGetDeviceID
            // 
            this.btnGetDeviceID.Location = new System.Drawing.Point(16, 104);
            this.btnGetDeviceID.Name = "btnGetDeviceID";
            this.btnGetDeviceID.Size = new System.Drawing.Size(104, 23);
            this.btnGetDeviceID.TabIndex = 7;
            this.btnGetDeviceID.Text = "Device ID";
            this.btnGetDeviceID.UseVisualStyleBackColor = true;
            this.btnGetDeviceID.Click += new System.EventHandler(this.btnGetDeviceID_Click);
            // 
            // btnSaveSerialSettings
            // 
            this.btnSaveSerialSettings.Location = new System.Drawing.Point(16, 76);
            this.btnSaveSerialSettings.Name = "btnSaveSerialSettings";
            this.btnSaveSerialSettings.Size = new System.Drawing.Size(104, 23);
            this.btnSaveSerialSettings.TabIndex = 8;
            this.btnSaveSerialSettings.Text = "Open Port";
            this.btnSaveSerialSettings.UseVisualStyleBackColor = true;
            this.btnSaveSerialSettings.Click += new System.EventHandler(this.btnSaveSerialSettings_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.Location = new System.Drawing.Point(13, 643);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Custom command:";
            // 
            // txtCustomCommand
            // 
            this.txtCustomCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomCommand.Location = new System.Drawing.Point(136, 643);
            this.txtCustomCommand.MaxLength = 64;
            this.txtCustomCommand.Name = "txtCustomCommand";
            this.txtCustomCommand.Size = new System.Drawing.Size(618, 20);
            this.txtCustomCommand.TabIndex = 13;
            // 
            // btnSendCustomCommand
            // 
            this.btnSendCustomCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendCustomCommand.Location = new System.Drawing.Point(770, 643);
            this.btnSendCustomCommand.Name = "btnSendCustomCommand";
            this.btnSendCustomCommand.Size = new System.Drawing.Size(104, 23);
            this.btnSendCustomCommand.TabIndex = 14;
            this.btnSendCustomCommand.Text = "Send";
            this.btnSendCustomCommand.UseVisualStyleBackColor = true;
            this.btnSendCustomCommand.Click += new System.EventHandler(this.btnSendCustomCommand_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblBytesCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 827);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(884, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(138, 17);
            this.lblStatus.Text = "COM port is not opened.";
            // 
            // lblBytesCount
            // 
            this.lblBytesCount.Name = "lblBytesCount";
            this.lblBytesCount.Size = new System.Drawing.Size(162, 17);
            this.lblBytesCount.Text = "0 bytes sent, 0 bytes received.";
            // 
            // tmrUpdateBytesCount
            // 
            this.tmrUpdateBytesCount.Enabled = true;
            this.tmrUpdateBytesCount.Tick += new System.EventHandler(this.tmrUpdateBytesCount_Tick);
            // 
            // btnMeasureCH1Freq
            // 
            this.btnMeasureCH1Freq.Location = new System.Drawing.Point(16, 133);
            this.btnMeasureCH1Freq.Name = "btnMeasureCH1Freq";
            this.btnMeasureCH1Freq.Size = new System.Drawing.Size(104, 23);
            this.btnMeasureCH1Freq.TabIndex = 17;
            this.btnMeasureCH1Freq.Text = "CH1 Freq";
            this.btnMeasureCH1Freq.UseVisualStyleBackColor = true;
            this.btnMeasureCH1Freq.Click += new System.EventHandler(this.btnMeasureCH1Freq_Click);
            // 
            // btnMeasureCH2Freq
            // 
            this.btnMeasureCH2Freq.Location = new System.Drawing.Point(16, 159);
            this.btnMeasureCH2Freq.Name = "btnMeasureCH2Freq";
            this.btnMeasureCH2Freq.Size = new System.Drawing.Size(104, 23);
            this.btnMeasureCH2Freq.TabIndex = 18;
            this.btnMeasureCH2Freq.Text = "CH2 Freq";
            this.btnMeasureCH2Freq.UseVisualStyleBackColor = true;
            this.btnMeasureCH2Freq.Click += new System.EventHandler(this.btnMeasureCH2Freq_Click);
            // 
            // btnCh1Waveform
            // 
            this.btnCh1Waveform.Location = new System.Drawing.Point(16, 186);
            this.btnCh1Waveform.Name = "btnCh1Waveform";
            this.btnCh1Waveform.Size = new System.Drawing.Size(104, 23);
            this.btnCh1Waveform.TabIndex = 19;
            this.btnCh1Waveform.Text = "CH1 Waveform";
            this.btnCh1Waveform.UseVisualStyleBackColor = true;
            this.btnCh1Waveform.Click += new System.EventHandler(this.btnCh1Waveform_Click);
            // 
            // btnCh2Waveform
            // 
            this.btnCh2Waveform.Location = new System.Drawing.Point(16, 213);
            this.btnCh2Waveform.Name = "btnCh2Waveform";
            this.btnCh2Waveform.Size = new System.Drawing.Size(104, 23);
            this.btnCh2Waveform.TabIndex = 20;
            this.btnCh2Waveform.Text = "CH2 Waveform";
            this.btnCh2Waveform.UseVisualStyleBackColor = true;
            this.btnCh2Waveform.Click += new System.EventHandler(this.btnCh2Waveform_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(770, 671);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 23);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEventLog
            // 
            this.btnEventLog.Location = new System.Drawing.Point(16, 326);
            this.btnEventLog.Name = "btnEventLog";
            this.btnEventLog.Size = new System.Drawing.Size(104, 23);
            this.btnEventLog.TabIndex = 10;
            this.btnEventLog.Text = "Event Log";
            this.btnEventLog.UseVisualStyleBackColor = true;
            this.btnEventLog.Click += new System.EventHandler(this.btnEventLog_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "waveform.txt";
            this.saveFileDialog1.Title = "Enter a filename";
            // 
            // picHardCopy
            // 
            this.picHardCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picHardCopy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHardCopy.Location = new System.Drawing.Point(181, 74);
            this.picHardCopy.Name = "picHardCopy";
            this.picHardCopy.Size = new System.Drawing.Size(693, 490);
            this.picHardCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picHardCopy.TabIndex = 22;
            this.picHardCopy.TabStop = false;
            // 
            // btnGetScreenshot
            // 
            this.btnGetScreenshot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetScreenshot.Location = new System.Drawing.Point(554, 576);
            this.btnGetScreenshot.Name = "btnGetScreenshot";
            this.btnGetScreenshot.Size = new System.Drawing.Size(104, 23);
            this.btnGetScreenshot.TabIndex = 23;
            this.btnGetScreenshot.Text = "Screenshot";
            this.btnGetScreenshot.UseVisualStyleBackColor = true;
            this.btnGetScreenshot.Click += new System.EventHandler(this.btnGetScreenshot_Click);
            // 
            // btnClearPicture
            // 
            this.btnClearPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearPicture.Location = new System.Drawing.Point(799, 576);
            this.btnClearPicture.Name = "btnClearPicture";
            this.btnClearPicture.Size = new System.Drawing.Size(75, 23);
            this.btnClearPicture.TabIndex = 26;
            this.btnClearPicture.Text = "Clear";
            this.btnClearPicture.UseVisualStyleBackColor = true;
            this.btnClearPicture.Click += new System.EventHandler(this.btnClearPicture_Click);
            // 
            // chkSaveOriginalColor
            // 
            this.chkSaveOriginalColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSaveOriginalColor.AutoSize = true;
            this.chkSaveOriginalColor.Location = new System.Drawing.Point(759, 606);
            this.chkSaveOriginalColor.Name = "chkSaveOriginalColor";
            this.chkSaveOriginalColor.Size = new System.Drawing.Size(115, 17);
            this.chkSaveOriginalColor.TabIndex = 27;
            this.chkSaveOriginalColor.Text = "Show original color";
            this.chkSaveOriginalColor.UseVisualStyleBackColor = true;
            this.chkSaveOriginalColor.CheckedChanged += new System.EventHandler(this.chkSaveOriginalColor_CheckedChanged);
            // 
            // tmrSaveBitmap
            // 
            this.tmrSaveBitmap.Interval = 1000;
            this.tmrSaveBitmap.Tick += new System.EventHandler(this.tmrSaveBitmap_Tick);
            // 
            // btnSaveBitmap
            // 
            this.btnSaveBitmap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveBitmap.Location = new System.Drawing.Point(689, 577);
            this.btnSaveBitmap.Name = "btnSaveBitmap";
            this.btnSaveBitmap.Size = new System.Drawing.Size(75, 23);
            this.btnSaveBitmap.TabIndex = 28;
            this.btnSaveBitmap.Text = "Save";
            this.btnSaveBitmap.UseVisualStyleBackColor = true;
            this.btnSaveBitmap.Click += new System.EventHandler(this.btnSaveBitmap_Click);
            // 
            // btnFFTWaveform
            // 
            this.btnFFTWaveform.Location = new System.Drawing.Point(16, 242);
            this.btnFFTWaveform.Name = "btnFFTWaveform";
            this.btnFFTWaveform.Size = new System.Drawing.Size(104, 23);
            this.btnFFTWaveform.TabIndex = 29;
            this.btnFFTWaveform.Text = "Math Waveform";
            this.btnFFTWaveform.UseVisualStyleBackColor = true;
            this.btnFFTWaveform.Click += new System.EventHandler(this.btnFFTWaveform_Click);
            // 
            // btnRef1Waveform
            // 
            this.btnRef1Waveform.Location = new System.Drawing.Point(16, 270);
            this.btnRef1Waveform.Name = "btnRef1Waveform";
            this.btnRef1Waveform.Size = new System.Drawing.Size(104, 23);
            this.btnRef1Waveform.TabIndex = 30;
            this.btnRef1Waveform.Text = "Ref1 Waveform";
            this.btnRef1Waveform.UseVisualStyleBackColor = true;
            this.btnRef1Waveform.Click += new System.EventHandler(this.btnRef1Waveform_Click);
            // 
            // btnRef2Waveform
            // 
            this.btnRef2Waveform.Location = new System.Drawing.Point(16, 299);
            this.btnRef2Waveform.Name = "btnRef2Waveform";
            this.btnRef2Waveform.Size = new System.Drawing.Size(104, 23);
            this.btnRef2Waveform.TabIndex = 31;
            this.btnRef2Waveform.Text = "Ref2 Waveform";
            this.btnRef2Waveform.UseVisualStyleBackColor = true;
            this.btnRef2Waveform.Click += new System.EventHandler(this.btnRef2Waveform_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 849);
            this.Controls.Add(this.btnRef2Waveform);
            this.Controls.Add(this.btnRef1Waveform);
            this.Controls.Add(this.btnFFTWaveform);
            this.Controls.Add(this.btnSaveBitmap);
            this.Controls.Add(this.chkSaveOriginalColor);
            this.Controls.Add(this.btnClearPicture);
            this.Controls.Add(this.btnGetScreenshot);
            this.Controls.Add(this.picHardCopy);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCh2Waveform);
            this.Controls.Add(this.btnCh1Waveform);
            this.Controls.Add(this.btnMeasureCH2Freq);
            this.Controls.Add(this.btnMeasureCH1Freq);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSendCustomCommand);
            this.Controls.Add(this.txtCustomCommand);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEventLog);
            this.Controls.Add(this.btnSaveSerialSettings);
            this.Controls.Add(this.btnGetDeviceID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLogText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboBaudRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comPortNum);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Tektronix TDS Oscilloscope Control";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comPortNum)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHardCopy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown comPortNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboBaudRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLogText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGetDeviceID;
        private System.Windows.Forms.Button btnSaveSerialSettings;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustomCommand;
        private System.Windows.Forms.Button btnSendCustomCommand;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Timer tmrUpdateBytesCount;
        private System.Windows.Forms.Button btnMeasureCH1Freq;
        private System.Windows.Forms.Button btnMeasureCH2Freq;
        private System.Windows.Forms.Button btnCh1Waveform;
        private System.Windows.Forms.Button btnCh2Waveform;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEventLog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripStatusLabel lblBytesCount;
        private System.Windows.Forms.PictureBox picHardCopy;
        private System.Windows.Forms.Button btnGetScreenshot;
        private System.Windows.Forms.Button btnClearPicture;
        private System.Windows.Forms.CheckBox chkSaveOriginalColor;
        private System.Windows.Forms.Timer tmrSaveBitmap;
        private System.Windows.Forms.Button btnSaveBitmap;
        private System.Windows.Forms.Button btnFFTWaveform;
        private System.Windows.Forms.Button btnRef1Waveform;
        private System.Windows.Forms.Button btnRef2Waveform;
    }
}

