using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace TDS340_NET
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /*
         Interface the TDS340 oscilloscope with the PC via the serial port.
          
         Maximum serial settings: 19200bps 8N1 with no hardware/softwate handshaking for TDS340. TDS340A supports 38400bps baud rate.    
         Line break: CR
         * 
         SerialPort component must have DtrEnable and RtsEnable properties set to TRUE, otherwise the oscilloscope won't response. 
         Handshake property should be set to FALSE.
         */

        private long bytesSent = 0;
        private long bytesReceived = 0;

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.cboBaudRate.SelectedIndex = 2; // select 38400
            string[] ports = SerialPort.GetPortNames();
            try
            {
                this.comPortNum.Value = int.Parse(ports[0].Substring(3));       //auto select com ports
            }
            catch (IndexOutOfRangeException)
            {
                this.comPortNum.Value = 1;      //if no com ports available
            }
        }

        private void btnSaveSerialSettings_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (this.serialPort1.IsOpen)
                    this.serialPort1.Close();

                bytesSent = 0;
                bytesReceived = 0;

                this.serialPort1.BaudRate = Convert.ToInt32(this.cboBaudRate.SelectedItem.ToString());
                this.serialPort1.PortName = "COM" + this.comPortNum.Value.ToString();
                this.serialPort1.Open();

                string msg = "Port " + this.serialPort1.PortName + " opened successfully (" + this.cboBaudRate.SelectedItem.ToString() + " bps).";
                this.lblStatus.Text = msg;

                Cursor.Current = Cursors.Default;

                MessageBox.Show(msg);
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;

                this.lblStatus.Text = ex.Message;
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGetDeviceID_Click(object sender, EventArgs e)
        {
            isLastCommandWaveFormInfo = false;
            isLastCommandWaveFormData = false;
            isWaitingHardCopy = false;

            sendCommand("ID?");
        }

        private void btnEventLog_Click(object sender, EventArgs e)
        {
            isLastCommandWaveFormInfo = false;
            isLastCommandWaveFormData = false;
            isWaitingHardCopy = false;

            sendCommand("*ESR?");
            sendCommand("ALLE?");
        }

        private void btnMessageLog_Click(object sender, EventArgs e)
        {
            isLastCommandWaveFormInfo = false;
            isLastCommandWaveFormData = false;
            isWaitingHardCopy = false;

            sendCommand("EVM?");
        }

        private void btnMeasureCH1Freq_Click(object sender, EventArgs e)
        {
            isLastCommandWaveFormInfo = false;
            isLastCommandWaveFormData = false;
            isWaitingHardCopy = false;

            sendCommand("MEASU:IMM:SOURCE CH1");
            sendCommand("MEASU:IMM:TYPE FREQ");
            sendCommand("MEASU:IMM:VAL?");
        }

        private void btnMeasureCH2Freq_Click(object sender, EventArgs e)
        {
            isLastCommandWaveFormInfo = false;
            isLastCommandWaveFormData = false;
            isWaitingHardCopy = false;

            sendCommand("MEASU:IMM:SOURCE CH2");
            sendCommand("MEASU:IMM:TYPE FREQ");
            sendCommand("MEASU:IMM:VAL?");
        }

        private void requestWaveform()
        {
            waveFormPreamble = "";
            waveFormData = "";

            sendCommand("DAT:ENC ASCI");    // ASCII format
            sendCommand("DAT:WID 2");       // 2 bytes
            sendCommand("DAT:STAR 1");      // first point
            sendCommand("DAT:STOP 1000");   // last data point (1000th)
            isLastCommandWaveFormInfo = true;
            isLastCommandWaveFormData = true;
            isWaitingHardCopy = false;
            sendCommand("WFMPR?");          // transfer waveform preamble information
            sendCommand("CURV?");           // get waveform data
        }

        private void btnCh1Waveform_Click(object sender, EventArgs e)
        {
            sendCommand("DAT:SOU CH1");
            requestWaveform();
        }

        private void btnCh2Waveform_Click(object sender, EventArgs e)
        {
            sendCommand("DAT:SOU CH2");
            requestWaveform();
        }

        private void btnFFTWaveform_Click(object sender, EventArgs e)
        {
            sendCommand("DAT:SOU MATH");
            requestWaveform();
        }


        private void btnRef1Waveform_Click(object sender, EventArgs e)
        {
            sendCommand("DAT:SOU REF1");
            requestWaveform();
        }

        private void btnRef2Waveform_Click(object sender, EventArgs e)
        {
            sendCommand("DAT:SOU REF2");
            requestWaveform();
        }

        private bool isWaitingHardCopy = false;
        private MemoryStream hardCopyStream = null;
        private void btnGetScreenshot_Click(object sender, EventArgs e)
        {
            isLastCommandWaveFormInfo = false;
            isLastCommandWaveFormData = false;
            isWaitingHardCopy = false;

            sendCommand("HARDC ABO");           // abort any existing hard copy
            sendCommand("HARDC:FORM BMP");      // set hard copy format to BMP
            sendCommand("HARDC:PORT RS232");    // hard copy port to RS232
            isWaitingHardCopy = true;
            hardCopyStream = new MemoryStream();
            sendCommand("HARDC STAR");         // start hard copy
        }

        private void btnSendCustomCommand_Click(object sender, EventArgs e)
        {
            if (this.txtCustomCommand.Text != "")
            {
                isLastCommandWaveFormInfo = false;
                isLastCommandWaveFormData = false;
                isWaitingHardCopy = false;

                sendCommand(this.txtCustomCommand.Text);

                this.txtCustomCommand.Text = "";
            }
        }

        private string lastCommand = "";
        private bool isLastCommandWaveFormInfo = false;
        private bool isLastCommandWaveFormData = false;
        private void sendCommand(string command)
        {
            try
            {
                this.Invoke(new writeToLogDelegate(writeToLog), true, false, command);
                this.serialPort1.Write(command + "\r");
                bytesSent += command.Length + 1;

                lastCommand = command;

                // wait for command to be executed
                Thread.Sleep(200);
            }
            catch (Exception ex)
            {
                //this.lblStatus.Text = ex.Message;
                //MessageBox.Show(ex.Message);
            }
        }

        private delegate void saveWaveFormDelegate();
        private void saveWaveForm()
        {
            this.saveFileDialog1.FileName = "waveform_" + DateTime.Now.Ticks.ToString() + ".txt";
            if (this.saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    System.IO.File.WriteAllText(this.saveFileDialog1.FileName, waveFormData);

                    MessageBox.Show("File saved successfully: " + this.saveFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tmrSaveBitmap_Tick(object sender, EventArgs e)
        {
            tmrSaveBitmap.Enabled = false;

            saveHardcopy();
        }

        private Bitmap invertBitmap(Bitmap hardCopyBitmap, bool toGreen)
        {
            // show green-on-black color, as if it's from the screen
            Bitmap modifiedBmp = new Bitmap(hardCopyBitmap.Width, hardCopyBitmap.Height);

            for (int i = 0; i < hardCopyBitmap.Width; i++)
                for (int j = 0; j < hardCopyBitmap.Height; j++)
                {
                    Color pixel = hardCopyBitmap.GetPixel(i, j);

                    if (toGreen) //printable to green
                    {
                        if (pixel.R == 0xFF && pixel.G == 0xFF && pixel.B == 0xFF)
                        {
                            // white (background) to black
                            modifiedBmp.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                        }
                        else
                            // other color (foreground) to green
                            modifiedBmp.SetPixel(i, j, Color.FromArgb(0, 0xFF, 0));
                    }
                    else // green to printable
                    {
                        if (pixel.R == 0x00 && pixel.G == 0xFF && pixel.B == 0x00)
                        {
                            // green (foreground) to black
                            modifiedBmp.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                        }
                        else
                            // other color (foreground) to white
                            modifiedBmp.SetPixel(i, j, Color.FromArgb(0xFF, 0xFF, 0xFF));
                    }

                }

            return modifiedBmp;
        }

        private void saveHardcopy()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                Bitmap hardCopyBitmap = new Bitmap(hardCopyStream);

                if (this.chkSaveOriginalColor.Checked)
                {
                    Bitmap modifiedBmp = invertBitmap(hardCopyBitmap, true);
                    this.picHardCopy.Image = modifiedBmp;
                }
                else
                {
                    // show black-on-white color as from the oscilloscope output, suitable for printout
                    this.picHardCopy.Image = hardCopyBitmap;
                }

                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveBitmap_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.FileName = "hardcopy_" + DateTime.Now.Ticks.ToString() + ".bmp";
            if (this.picHardCopy.Image != null && this.saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.picHardCopy.Image.Save(this.saveFileDialog1.FileName);
            }
        }

        private delegate void writeToLogDelegate(bool isSend, bool isError, string message);
        private void writeToLog(bool isSend, bool isError, string message)
        {
            string msgFlag = "";
            if (!isError)
                msgFlag = isSend ? "Sent: " : "Received: ";
            else
                msgFlag = "Error: ";

            string logText = DateTime.Now.ToString() + " - " + msgFlag + message + Environment.NewLine;

            // automatic scroll to bottom
            this.txtLogText.AppendText(logText);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtLogText.Text = "";
        }

        private void serialPort1_ErrorReceived(object sender, System.IO.Ports.SerialErrorReceivedEventArgs e)
        {
            this.Invoke(new writeToLogDelegate(writeToLog), false, true, e.EventType.ToString());
        }

        private delegate void toggleTimerDelegate(bool isOn);
        private void toggleTimer(bool isOn)
        {
            this.tmrSaveBitmap.Enabled = isOn;
        }

        private string dataReceived = "";
        private string waveFormPreamble = "";
        private string waveFormData = "";
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (isWaitingHardCopy)
            {
                while (this.serialPort1.BytesToRead > 0)
                {
                    int b = this.serialPort1.ReadByte();

                    if (b != -1)
                    {
                        this.Invoke(new toggleTimerDelegate(toggleTimer), false);

                        hardCopyStream.WriteByte((byte)b);

                        // schedule to save the bitmap 2 seconds from the last data received
                        // toggle the Enable property will move the timer next launch to 2 seconds from now.
                        this.Invoke(new toggleTimerDelegate(toggleTimer), true);


                        bytesReceived++;
                    }
                }
            }
            else
            {
                // we buffer the response received until a CR (end of response is received)
                string buf = this.serialPort1.ReadExisting();
                dataReceived += buf;
                bytesReceived += buf.Length;

                int crIndex = dataReceived.IndexOf("\r");
                if (crIndex >= 0) // oscilloscope separate responses by a CR as per settings
                {
                    // old data received
                    if (crIndex > 0)
                    {
                        string curData = dataReceived.Substring(0, crIndex);
                        this.Invoke(new writeToLogDelegate(writeToLog), false, false, curData);

                        if (isLastCommandWaveFormInfo)
                        {
                            isLastCommandWaveFormInfo = false;
                            waveFormPreamble = curData;
                        }
                        else if (isLastCommandWaveFormData)
                        {
                            isLastCommandWaveFormData = false;
                            waveFormData = waveFormPreamble + Environment.NewLine + curData;

                            this.BeginInvoke(new saveWaveFormDelegate(saveWaveForm));
                        }
                    }

                    // new data in buffer
                    if (crIndex < dataReceived.Length - 1)
                        dataReceived = dataReceived.Substring(crIndex);
                    else
                        dataReceived = "";
                }
            }
        }

        private void tmrUpdateBytesCount_Tick(object sender, EventArgs e)
        {
            this.lblBytesCount.Text = String.Format("{0} bytes sent, {1} bytes received.", bytesSent, bytesReceived);
        }

        private void btnClearPicture_Click(object sender, EventArgs e)
        {
            this.picHardCopy.Image = null;
        }

        private void btnSavePicture_Click(object sender, EventArgs e)
        {
            Image bmp = this.picHardCopy.Image;
            if (bmp != null)
            {
                string fn = "IMG" + (DateTime.Now.Ticks % 100000).ToString() + ".bmp";
                this.saveFileDialog1.FileName = fn;
                if (this.saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    bmp.Save(this.saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp);

                    MessageBox.Show("File saved successfully: " + this.saveFileDialog1.FileName);
                }
            }
        }

        private void chkSaveOriginalColor_CheckedChanged(object sender, EventArgs e)
        {
            if (this.picHardCopy.Image != null)
            {
                Cursor.Current = Cursors.WaitCursor;

                Bitmap modifiedBmp = invertBitmap((Bitmap)this.picHardCopy.Image, this.chkSaveOriginalColor.Checked);
                this.picHardCopy.Image = modifiedBmp;

                Cursor.Current = Cursors.Default;
            }
        }
    }
}
