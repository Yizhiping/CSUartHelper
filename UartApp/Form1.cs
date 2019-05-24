using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Timers;

namespace UartApp
{
    public partial class Form1 : Form
    {

        private long TxCounter = 0;
        private long RxCounter = 0;
        private StringBuilder sb;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //PortName.Text = "COM1";
            BaundRate.Text = "9600";
            DataBit.Text = "8";
            CheckBit.Text = "None";
            StopBit.Text = "1";

            RecBuff.Text = "";
            SndBuff.Text = "";

            PortName.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            //PortName.SelectedIndex = 0;

            string[] bauds = { "1200","2400","4800","9600","38400", "43000", "56000", "57600", "115200", "128000", "230400", "256000", "460800" };
            BaundRate.Items.AddRange(bauds);

            DataBit.Items.Add("5");
            DataBit.Items.Add("6");
            DataBit.Items.Add("7");
            DataBit.Items.Add("8");

            CheckBit.Items.Add("None");
            CheckBit.Items.Add("Odd");
            CheckBit.Items.Add("Even");
            CheckBit.Items.Add("Mask");
            CheckBit.Items.Add("Space");

            StopBit.Items.Add("1");
            StopBit.Items.Add("1.5");
            StopBit.Items.Add("2");

            
        }

        private void BtnOpenPort_Click(object sender, EventArgs e)
        {
            try
            {
                Message.Text = SndBuff.Text = RecBuff.Text = "";

                if (sp.IsOpen)
                {
                    //串口已经处于打开状态
                    sp.Close();
                    btnOpenPort.Text = "打开串口";
                    btnOpenPort.BackColor = Color.Firebrick;
                    PortName.Enabled = BaundRate.Enabled = DataBit.Enabled = CheckBit.Enabled = StopBit.Enabled = true;
                } else
                {
                    //串口处于关闭状态, 则设置好属性后打开
                    PortName.Enabled = BaundRate.Enabled = DataBit.Enabled = CheckBit.Enabled = StopBit.Enabled = false;
                    sp.PortName = PortName.Text;        //串口名称
                    sp.BaudRate = Convert.ToInt32(BaundRate.Text);      //波特率
                    sp.DataBits = Convert.ToInt32(DataBit.Text);        //数据位

                    Parity chkbit = Parity.None;        //校验位

                    switch (CheckBit.Text)
                    {
                        case "Odd":
                            chkbit = Parity.Odd;
                            break;
                        case "Even":
                            chkbit = Parity.Even;
                            break;
                        case "Mask":
                            chkbit = Parity.Mark;
                            break;
                        case "Space":
                            chkbit = Parity.Space;
                            break;
                        default:
                            chkbit = Parity.None;
                            break;
                    }
                    sp.Parity = chkbit;

                    sp.Open();
                    btnOpenPort.BackColor = Color.ForestGreen;
                    btnOpenPort.Text = "关闭串口";
                }
            } catch (Exception ex)
            {
                //捕获异常进行处理
                sp = new SerialPort();
                System.Media.SystemSounds.Beep.Play();
                Message.Text = ex.Message;
                MessageBox.Show("串口打开错误: " + ex.Message);
                btnOpenPort.BackColor = Color.Firebrick;
                PortName.Enabled = BaundRate.Enabled = DataBit.Enabled = CheckBit.Enabled = StopBit.Enabled = true;

            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (sp.IsOpen)
                {
                    sp.WriteLine(SndBuff.Text);
                    Message.Text = "发送成功.";
                } else
                {
                    MessageBox.Show("串口未开启, 无法发送.");
                }
            } catch (Exception ex)
            {
                //处理发送错误
                sp = new SerialPort();
                System.Media.SystemSounds.Beep.Play();
                Message.Text = ex.Message;
                MessageBox.Show("发送错误: " + ex.Message);
                btnOpenPort.BackColor = Color.Firebrick;
                PortName.Enabled = BaundRate.Enabled = DataBit.Enabled = CheckBit.Enabled = StopBit.Enabled = true;
            }
        }

        private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if(RecHEX.Checked)
            {
                int num = sp.BytesToRead;
                byte[] recBuff = new byte[num];

                RxCounter += num;
                sp.Read(recBuff, 0, num);
                sb.Clear();
                foreach(byte b in recBuff)
                {
                    sb.Append(b.ToString());
                }
            }

            try
            {

                this.Invoke((EventHandler)(delegate
                {
                    RecBuff.AppendText(sp.ReadExisting());
                }
   )
);

                // RecBuff.AppendText(sp.ReadExisting());
            } catch(Exception ex)
            {
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show(ex.Message);
                Message.Text= ex.Message;
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnClearRecBuff_Click(object sender, EventArgs e)
        {
            RecBuff.Text = "";
        }
    }
}
