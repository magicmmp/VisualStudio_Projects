using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace TrackBar
{
    

    public partial class Form1 : Form
    {
       

        private SerialPort serial = new SerialPort();
        
        
        private string receiveData;
        private byte[] receiveByteBuffer;
        private byte[] AdjustLightCmds={ 0xEE, 0x11, 0x07, 0x00, 0x00,0x00, 0x50, 0x50, 0x0};

        private int[] NewValueBytes = { 80, 80, 1 };//功率、色温、是否待发送


        static UInt32 receiveBytesCount = 0;
        static UInt32 sendBytesCount = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;//避免跨线程不能改变UI控件

            turnOnButton.BackColor = Color.Yellow;
            turnOnButton.ForeColor = Color.Purple;
            GetValuablePortName();
            if (portNamesCombobox.Items.Count > 0)
                portNamesCombobox.SelectedIndex = 0;
            autoDetectionTimer.Enabled = true;
            AutoSendCheckBox.Checked = false;
            //设置状态栏提示
            statusDisplay(true, "准备就绪");
        }

        //自动检测串口名
        private void GetValuablePortName()
        {
            //检测有效的串口并添加到combobox
            string[] serialPortName = System.IO.Ports.SerialPort.GetPortNames();

            foreach (string name in serialPortName)
            {
                portNamesCombobox.Items.Add(name);
            }
        }

        private void statusDisplay(bool isNormal, string strMsg)
        {
            statusTextBlock.Text = strMsg;
            if (isNormal)
            {
                statusTextBlock.BackColor = Color.LightYellow;
                statusTextBlock.ForeColor = Color.Blue;
            }
            else
            {
                statusTextBlock.BackColor = Color.Red;
                statusTextBlock.ForeColor = Color.Green;
            }
        }





        

        private void autoDetectionTimer_Tick(object sender, EventArgs e)
        {
            string[] serialPortName = System.IO.Ports.SerialPort.GetPortNames();

            if (turnOnButton.Checked == true)
            {
                //在找到的有效串口号中遍历当前打开的串口号
                foreach (string name in serialPortName)
                {
                    if (serial.PortName == name)
                        return;                 //找到，则返回，不操作               
                }

                //若找不到已打开的串口:表示当前打开的串口已失效
                //按钮回弹
                turnOnButton.Checked = false;
                //删除combobox中的名字
                portNamesCombobox.Items.Remove(serial.PortName);
                
                portNamesCombobox.SelectedIndex = 0;
                    //提示消息

                    statusDisplay(false, "串口已失效！");
            }
            else
            {
                //检查有效串口和combobox中的串口号个数是否不同
                if (portNamesCombobox.Items.Count != serialPortName.Length)
                {
                    //串口数不同，清空combobox
                    portNamesCombobox.Items.Clear();

                    //重新添加有效串口
                    foreach (string name in serialPortName)
                    {
                        portNamesCombobox.Items.Add(name);
                    }
                    portNamesCombobox.SelectedIndex = 0;


                    statusDisplay(true, "串口列表已更新！");

                }
            }
        }

        //使能或关闭串口配置相关的控件
        private void serialSettingControlState(bool state)
        {
            portNamesCombobox.Enabled = state;
            trackBarSetPower.Enabled = !state;
            trackBarSetColor.Enabled = !state;
            labelPower.Enabled = !state;
            labelColor.Enabled = !state;
        }

        private void autoSendTimer_Tick(object sender, EventArgs e)
        {
            SerialPortSend();
            //设置新的定时时间 
            CheckAndResetTimerInterval();
        }

        private void turnOnButton_CheckedChanged(object sender, EventArgs e)
        {
            if (portNamesCombobox.Items.Count == 0)
            {
                statusDisplay(false, "没有可用串口！");
                //按钮回弹
                turnOnButton.Checked = false;
                return;
            }

            if (turnOnButton.Checked && !serial.IsOpen)//打开串口
            {


                try
                {
                    //配置串口
                    serial.PortName = portNamesCombobox.Text;
                    serial.BaudRate = 1200;
                    serial.Parity = (System.IO.Ports.Parity)Enum.Parse(typeof(System.IO.Ports.Parity), "None");
                    serial.DataBits = Convert.ToInt16("8");
                    serial.StopBits = (System.IO.Ports.StopBits)Enum.Parse(typeof(System.IO.Ports.StopBits), "1");

                    serial.ReadTimeout = 500;
                    serial.WriteTimeout = 500;

                    //设置串口编码为default：获取操作系统的当前 ANSI 代码页的编码。
                    serial.Encoding = Encoding.Default;

                    //添加串口事件处理
                    serial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(ReceiveData);

                    //开启串口
                    serial.Open();

                    

                    //关闭串口配置面板
                    serialSettingControlState(false);


                    statusDisplay(true, "串口已开启");

                    //显示提示文字
                    turnOnButton.Text = "关闭串口";
                    turnOnButton.BackColor = Color.Green;
                    turnOnButton.ForeColor = Color.OrangeRed;

                    NewValueBytes[2] = 1;//打开后发一次调光命令初始值
                    timerSendCmd.Enabled = true;

                    //使能发送面板
                    // sendControlBorder.IsEnabled = true;


                }
                catch (System.Exception ex)
                {

                    statusDisplay(false, "配置串口出错");
                    receiveTextBox.Text = ex.ToString();

                }
            }
            else//关闭了串口
            {
                try
                {
                    //关闭定时器
                    autoSendTimer.Stop();
                    timerSendCmd.Enabled = false;
                    AutoSendCheckBox.Checked = false;
                    //使能串口配置面板
                    serialSettingControlState(true);


                    statusDisplay(true, "串口已关闭");

                    //显示提示文字
                    turnOnButton.Text = "打开串口";
                    turnOnButton.BackColor = Color.Yellow;

                    turnOnButton.ForeColor = Color.Gray;

                    System.Threading.Thread.Sleep(1000); //毫秒


                    serial.Close();





                    //使能发送面板
                    //sendControlBorder.IsEnabled = false;
                }
                catch
                {

                }
            }
        }



        private void ReceiveData(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //16进制数据接收解析有问题,读16进制字节应该用read()。2020-6-18
            if(hexadecimalDisplayCheckBox.Checked)
            {
                int byteLen = serial.BytesToRead;
                if (byteLen > 0)
                {
                    receiveByteBuffer = new byte[byteLen];
                    serial.Read(receiveByteBuffer, 0, byteLen);
                    StringBuilder sb = new StringBuilder(4 * byteLen);
                    foreach (byte b in receiveByteBuffer)
                    {
                        sb.AppendFormat("{0:X2} ", b);
                    }
                    receiveData = sb.ToString();
                }
                else
                    receiveData = "";
            }
            else
                receiveData = serial.ReadExisting();//如果正在高速收发数据，突然关了的话，会有异常？


            //receiveTextBox.AppendText(receiveData);
            ShowData(receiveData);
            //WPF中，为了使该后台线程能够访问 主线程UI控件的属性，该后台线程必须将此工作委托给与该 UI 线程关联的 Dispatcher。
            // Dispatcher.Invoke(DispatcherPriority.Send, new UpdateUiTextDelegate(ShowData), receiveData);
        }


        //显示数据
        private void ShowData(string text)
        {
            string receiveText = text;

            //更新接收字符数
            receiveBytesCount += (UInt32)receiveText.Length;
            statusReceiveByteTextBlock.Text = receiveBytesCount.ToString();

            //没有关闭数据显示
            if (stopShowingButton.Checked == false)
            {
                //字符串显示
                receiveTextBox.AppendText(receiveText);
            }

        }

        private void sendTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AutoSendCheckBox.Checked)
                CheckAndResetTimerInterval();
        }

        private void ClearReceiveButton_Click(object sender, EventArgs e)
        {
            receiveTextBox.Clear();
        }


        //发送数据
        private void SerialPortSend()
        {

            try
            {
                string sendData = sendTextBox.Text;    //复制发送数据

                //字符串发送
                if (hexadecimalSendCheckBox.Checked == false)
                {
                    serial.Write(sendData);

                    //更新发送数据计数
                    sendBytesCount += (UInt32)sendData.Length;
                    statusSendByteTextBlock.Text = sendBytesCount.ToString();
                }
                else //十六进制发送
                {
                    SendHexString(sendData);
                }

            }
            catch
            {

            }

        }



        private void SendHexString(string hexString)
        {
            try
            {

                hexString = hexString.Trim();
                hexString.Replace("0x", "");   //去掉0x
                hexString.Replace("0X", "");   //去掉0X
                                               //  sendData.


                string[] strArray = hexString.Split(new char[] { ',', '，', '\r', '\n', ' ', '\t' });
                int decNum = 0;
                int i = 0;
                byte[] sendBuffer = new byte[strArray.Length];  //发送数据缓冲区

                foreach (string str in strArray)
                {
                    try
                    {
                        decNum = Convert.ToInt16(str, 16);
                        sendBuffer[i++] = Convert.ToByte(decNum);

                    }
                    catch
                    {
                        //MessageBox.Show("字节越界，请逐个字节输入！", "Error");                          
                    }
                }

                serial.Write(sendBuffer, 0, sendBuffer.Length);


                //更新发送数据计数
                sendBytesCount += (UInt32)sendBuffer.Length;
                statusSendByteTextBlock.Text = sendBytesCount.ToString();

            }
            catch //无法转为16进制时
            {
                AutoSendCheckBox.Checked = false;//关闭自动发送

                statusDisplay(false, "当前为16进制发送模式，请输入16进制数据");
                return;
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (!serial.IsOpen)
            {

                statusDisplay(false, "请先打开串口！");
                return;
            }

            SerialPortSend();
        }


        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            NewValueBytes[0] = trackBarSetPower.Value;
            NewValueBytes[2] = 1;
            
            labelPower.Text = string.Format("功率：{0} %", trackBarSetPower.Value); ;
        }

        
        private void trackBarSetColor_ValueChanged(object sender, EventArgs e)
        {
            NewValueBytes[1] = trackBarSetColor.Value;
            NewValueBytes[2] = 1;
            labelColor.Text = string.Format("色温：{0} %", trackBarSetColor.Value); ;
        }

        private void AdjustPowerAndColor(int powerValue,int colorValue)
        {
            AdjustLightCmds[6] = (byte)(powerValue & 0xff);
            AdjustLightCmds[7] = (byte)(colorValue & 0xff);
            int tmpSum = 0;
            for (int i = 0; i < AdjustLightCmds.Length - 1; i++)
                tmpSum += AdjustLightCmds[i];
            AdjustLightCmds[AdjustLightCmds.Length - 1] = (byte)(tmpSum & 0xff);
            serial.Write(AdjustLightCmds, 0, AdjustLightCmds.Length);
            StringBuilder sb=new StringBuilder(32);
            foreach (byte b in AdjustLightCmds)
                sb.AppendFormat("{0:X2} ", b);
            sb.AppendLine();
            sendTextBox.Text = sb.ToString();
        }

        private void timerSendCmd_Tick(object sender, EventArgs e)
        {
            if(NewValueBytes[2]==1)//数据有更新
            {
                NewValueBytes[2] = 0;
                AdjustPowerAndColor(NewValueBytes[0], NewValueBytes[1]);
            }
        }

        private void AutoSendCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoSendCheckBox.Checked)
            {
                CheckAndResetTimerInterval();

                
                autoSendTimer.Enabled = true;
            }
            else
            {
                autoSendTimer.Enabled = false;
            }
        }

        private void ClearSendButton_Click(object sender, EventArgs e)
        {
            sendTextBox.Clear();
        }

        private void autoSendCycleTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void sendTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //不让输入非16进制的字符
            if (hexadecimalSendCheckBox.Checked)
            {
                bool flag = true;
                for (int i = 0; i < 6; i++)
                {
                    if (e.KeyChar == (char)('a' + i) || e.KeyChar == (char)('A' + i))
                    {
                        flag = false;
                    }
                }

                for (int i = 0; i < 10; i++)
                {
                    if (e.KeyChar == (char)('0' + i))
                    {
                        flag = false;
                    }
                }

                if (e.KeyChar == (char)8 || e.KeyChar == (char)13 || e.KeyChar == (char)32)
                {
                    flag = false;
                }
                e.Handled = flag;
            }
            
        }

        private void countClearButton_Click(object sender, EventArgs e)
        {
            //接收、发送计数清零
            receiveBytesCount = 0;
            sendBytesCount = 0;

            //更新数据显示
            statusReceiveByteTextBlock.Text = receiveBytesCount.ToString();
            statusSendByteTextBlock.Text = sendBytesCount.ToString();
        }

        private void stopShowingButton_CheckedChanged(object sender, EventArgs e)
        {
            if (stopShowingButton.Checked)
            {
                stopShowingButton.Text = "恢复显示";
            }
            else
            {
                stopShowingButton.Text = "停止显示";
            }
        }

        private void autoSendCycleTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (AutoSendCheckBox.Checked)
                CheckAndResetTimerInterval();
        }

        //避免自动发送周期设置过小
        void CheckAndResetTimerInterval()
        {
            long LMinPeriodNeeded;
            if (hexadecimalSendCheckBox.Checked)
            {
                LMinPeriodNeeded = 200;
                long curInterval = 0;
                if (!string.IsNullOrEmpty(autoSendCycleTextBox.Text))
                    curInterval = Convert.ToInt32(autoSendCycleTextBox.Text);
                if (curInterval < LMinPeriodNeeded)
                    autoSendCycleTextBox.Text = string.Format("{0}", LMinPeriodNeeded);
            }
            else
            {
                double nBitsTosend = sendTextBox.Text.Length * 32;
                double minPeriodNeeded = nBitsTosend * 1000 / Convert.ToInt32("1200");
                LMinPeriodNeeded = (long)minPeriodNeeded;
                if (LMinPeriodNeeded < 10)
                    LMinPeriodNeeded = 10;
                long curInterval = 0;
                if (!string.IsNullOrEmpty(autoSendCycleTextBox.Text))
                    curInterval = Convert.ToInt32(autoSendCycleTextBox.Text);
                if (curInterval < LMinPeriodNeeded)
                    autoSendCycleTextBox.Text = string.Format("{0}", LMinPeriodNeeded);

            }

            //设置新的定时时间 
            if (!string.IsNullOrEmpty(autoSendCycleTextBox.Text))
            {
                int tmpInterval = Convert.ToInt32(autoSendCycleTextBox.Text);

                if (tmpInterval > 0)
                    autoSendTimer.Interval = tmpInterval;
            }
            //receiveTextBox.Clear();
            //receiveTextBox.AppendText("需要最小周期：" + LMinPeriodNeeded);
        }

        

        private void receiveTextBox_TextChanged(object sender, EventArgs e)
        {
           
            if (receiveTextBox.Text.Length > 102400)
                receiveTextBox.Clear();
            else if (autoClearCheckBox.Checked == true && receiveTextBox.Lines.Length >= 100)
            {
                receiveTextBox.Clear();
            }

            

            try
            {
                receiveTextBox.ScrollToCaret();
            }
            catch
            {
            }
            
        }

       
    }
}
