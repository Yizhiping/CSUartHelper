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
        private StringBuilder sb = new StringBuilder();
        private DateTime current_time = DateTime.Now;

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
            string SendBuff = SndBuff.Text;
            
            if(SndHEX.Checked)
            {
                SendBuff = SendBuff.Replace(" ", "");       //删除空格
                if (SendBuff.Length % 2 != 0) SendBuff = "0" + SendBuff;    //单数个字符的时候自动添加前置0
                byte[] SndArr = new byte[SendBuff.Length / 2];

                for (int i = 0; i< SendBuff.Length / 2; i++)
                {
                    SndArr[i] = Convert.ToByte(SendBuff.Substring(i * 2, 2),16);
                }

                SendBuff = System.Text.Encoding.Default.GetString(SndArr);
            }

            if (SndNewLine.Checked) SendBuff += "\n";       //自动发送回车

            TxCounter += SendBuff.Length;


            try
            {
                if (sp.IsOpen)
                {

                    sp.Write(SendBuff);
                    TxCountShow.Text = string.Format("TX: {0} Bytes", TxCounter);
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
            //计数
            int num = sp.BytesToRead;
            RxCounter += num;
            string ShowBuff = "";

            //接收数据
            byte[] recBuff = new byte[num];
            sp.Read(recBuff, 0, num);
            sb.Clear();


            //转换十六进制
            if (RecHEX.Checked)      
            {
                //ShowBuff = recBuff.ToString("X2");
                foreach(int b in recBuff)
                {
                    ShowBuff += b.ToString("X2") + " ";
                }
            } else
            {
                ShowBuff = Encoding.ASCII.GetString(recBuff);
            }

            //显示接收时间
            if(ShowRecTime.Checked)
            {
                current_time = DateTime.Now;
                ShowBuff = current_time.ToString("[HH:mm:ss.fff]") + " \n" + ShowBuff + "\n"; 
            }

            //自动转行
            if(addNewlineReceved.Checked)
            {
                ShowBuff += "\n"; 
            }


            try
            {

                this.Invoke((EventHandler)(delegate
                {
                    RxCountShow.Text = string.Format("RX: {0} Bytes", RxCounter);       //更新接收字节数
                    RecBuff.AppendText(ShowBuff);   //更新显示内容
                    
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

        private void BtnResetCounter_Click(object sender, EventArgs e)
        {
            RxCounter = TxCounter = 0;
            RxCountShow.Text = "RX: 0 Bytes";
            TxCountShow.Text = "TX: 0 Bytes";
        }

        private void addNowLine(object sender, EventArgs e)
        {
            if(ShowRecTime.Checked)
            {
                RecBuff.AppendText("\n");
            }
        }

        private void BtnClearSndBuff_Click(object sender, EventArgs e)
        {
            SndBuff.Text = "";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            BtnSend_Click(BtnSend, new EventArgs());
        }

        private void AutoSend_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoSend.Checked)
            {
                timer1.Interval = (int)(AutoSendDelay.Value);
                btnClearSndBuff.Enabled = BtnSend.Enabled = SndBuff.Enabled =  AutoSendDelay.Enabled = false;
                timer1.Start();
                Message.Text = "自动发送中....";
            } else
            {
                timer1.Stop();
                Message.Text = "自动发送停止....";
                btnClearSndBuff.Enabled = BtnSend.Enabled = SndBuff.Enabled = AutoSendDelay.Enabled = true;
            }
        }
    }
}
