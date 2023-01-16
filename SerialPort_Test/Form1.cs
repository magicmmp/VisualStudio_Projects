using System;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Windows.Threading;

namespace SerialPort_Test
{



    public partial class Form1 : Form
    {

        
        private SerialPort serial = new SerialPort();

        private string receiveData;
        Dictionary<string, Label> statusDisplayLabels;//显示查询指令返回的状态


        private string cmdLineSent_1s_before="";//1秒前发送的指令
        private List<byte> DataGotLastSecond=new List<byte>();//串口上一秒接收的字节数据，是1秒前发送的指令 的回复
        private string cmdAndReplyTmp="";//临时变量，非必要
        private bool isLoRaCmdAllSentFlag = false;//最后一条指令发送后一秒，认为本次任务正式结束。
        private bool isLoRaCmdSendingFlag = false;//处于正在发送和接收LoRa指令的过程


        private byte[] receiveByteBuffer;//存放收到的16进制字节
        private int serialUsageMode = 0;//用途分类
        
        private byte[] arrayLoraCmdSetAddr = { 0xEE, 0x16, 0x08, 0x00, 0x00, 0x00, 0x80, 0x00, 0x21, 0xAD };
        private byte[] arrayLoraCmdCheck   = { 0xEE, 0x19, 0x07, 0x80, 0x00, 0x21, 0x01, 0x01, 0x01 };
        private byte[] arrayLoraCmdOff = { 0xEE, 0x11, 0x07, 0x80, 0x00, 0x21, 0x00, 0x00, 0x6a };  //EE 11 07 02 00 01 00 00 09
        private byte[] arrayLoraCmdON  = { 0xEE, 0x11, 0x07, 0x80, 0x00, 0x21, 0x64, 0x64, 0x6a };//EE 11 07 01 00 01 64 50 BC
        private string[] HexCmdLines;//指令数组，一串指令一行
        private int nCmdLinesTosend = 0;//余下多少行命令要发送
        private int n485ResendTimes = 1;
        private int LoraAddr = 0x010218;
        private int LoraPreAddr = 0x010101;//要修改的原始地址
        private int HexCmdLinesIndex = 0;

        //EE 15 06 80 00 21 01 AB 


        static UInt32 receiveBytesCount = 0;
        static UInt32 sendBytesCount = 0;
        public Form1()
        {
            InitializeComponent();
            statusDisplayLabels = InitDisplayLabels();//把这些标签的引用放入字典里，方便遍历
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


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


       

        private void comboBox_byte_size_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //到设计界面那里，双击界面后，会发现自动生成了Form1_load()，然后再进行代码编写。
        private void Form1_Load(object sender, EventArgs e)
        {
            //取消跨线程的检查,避免跨线程不能改变UI控件
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;

            turnOnButton.BackColor = Color.Yellow;
            turnOnButton.ForeColor = Color.Purple;
            GetValuablePortName();
            autoDetectionTimer.Enabled = true;
            AutoSendCheckBox.Checked = false;
            //设置状态栏提示
            statusDisplay(true, "准备就绪");
            
            foreach (string labelNname in statusDisplayLabels.Keys)
                SetLoraLabelColor(labelNname, true);

            LoRaSettingControlState(false);
            n485SettingControlState(false);
            //textBoxLoraAddr.Text = string.Format("{0:X6}",LoraAddr);

            if(portNamesCombobox.Items.Count>0)
                portNamesCombobox.SelectedIndex = 0;
            baudRateCombobox.SelectedIndex = 11;
            parityCombobox.SelectedIndex = 0;
            dataBitsCombobox.SelectedIndex = 3;
            stopBitsCombobox.SelectedIndex = 0;

            

           // receiveTextBox.Text = "串口个数是：" + portNamesCombobox.Items.Count;
        }

        private void statusDisplay(bool isNormal,string strMsg)
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

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        //自动检测串口时间到
        private void AutoDectionTimer_Tick(object sender, EventArgs e)
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
                //portNamesCombobox.SelectedIndex = 0;
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
            baudRateCombobox.Enabled = state;
            parityCombobox.Enabled = state;
            dataBitsCombobox.Enabled = state;
            stopBitsCombobox.Enabled = state;
        }

        //使能或关闭LoRa配置相关的控件
        private void LoRaSettingControlState(bool state)
        {
            checkBoxOnlySendCheckCmd.Enabled = state;
            label10.Enabled = state;
            textBoxLoraAddr.Enabled = state;
            checkBoxAutoAddr.Enabled = state;
            buttonPreAddr.Enabled = state;
            buttonNextAddr.Enabled = state;
            textBoxPreAddr.Enabled = state;
            label_LoRaPreAddr.Enabled = state;

            foreach(Label label in statusDisplayLabels.Values)
            {
                label.Enabled = state;
            }
        }

        //使能或关闭485配置相关的控件
        private void n485SettingControlState(bool state)
        {
            label11.Enabled = state;
            label12.Enabled = state;
            textBox485ResendTimes.Enabled = state;
            
        }

        /**
     *  private string receiveTextBox_Text_1s_before;//1秒前接收框的文本
        private string cmdLineSent_1s_before;//1秒前发送的指令
        private string cmdLineReply_1s_before;//1秒前发送指令的回复，即是接收框字符串比1秒前增加的内容
        private string cmdAndReplyTmp;
     */

        private void AutoSendTimer_Tick(object sender, EventArgs e)
        {
            //发送数据
            if(serialUsageMode==0)
                SerialPortSend();
            else
            {

                
                if(serialUsageMode == 1)
                {
                   
                    

                    if(isLoRaCmdSendingFlag && nCmdLinesTosend<HexCmdLines.Length)//至少发送一条命令1秒之后
                    {

                        string StringReplytmp="无回复";
                        int loraAddrTmp;
                        if(isCmdCheck_Sent(cmdLineSent_1s_before,out loraAddrTmp))
                        {
                            if(false)//仅用于测试2020-7-5
                            {
                                Dictionary<string, string> results =cmdCheckClass.getResetResults();
                                
                                foreach (string labelName in results.Keys)//使所有标签显示数据为0
                                {
                                    statusDisplayLabels[labelName].Text = results[labelName];
                                    
                                }

                                string fakeLoraReply = "CC 19 18 01 02 18 81 73 22 01 CD 02 DA 00 00 01 50 00 00 61 00 C8 00 00 01 53";
                                List<byte> listTmp = cmdCheckClass.ParseHexString(fakeLoraReply);
                                DataGotLastSecond.Clear();
                                DataGotLastSecond.AddRange(listTmp);

                            }
                            


                            if (DataGotLastSecond.Count > 0 && isReplyOfCmdCheck(DataGotLastSecond,loraAddrTmp))
                            {
                                Dictionary<string, string> results = GetResults(DataGotLastSecond);
                                StringBuilder sb = new StringBuilder(4 * DataGotLastSecond.Count);
                                foreach (string labelName in results.Keys)
                                {
                                    statusDisplayLabels[labelName].Text = results[labelName];
                                    sb.Append(results[labelName] + "\r\n");
                                }

                                foreach (string labelNname in statusDisplayLabels.Keys)
                                    SetLoraLabelColor(labelNname, true);


                                StringReplytmp = sb.ToString();
                            }
                            else
                            {
                                
                                foreach (string labelNname in statusDisplayLabels.Keys)
                                    SetLoraLabelColor(labelNname, false);
                            }
                                
                        }

                        if (DataGotLastSecond.Count > 0)
                        {
                            StringBuilder sb = new StringBuilder(DataGotLastSecond.Count*4);
                            foreach(byte b in DataGotLastSecond)
                            {
                                sb.AppendFormat("{0:X2} ", b);
                            }
                            StringReplytmp = sb.ToString();
                        }
                        else
                            StringReplytmp = "无回复";

                        cmdAndReplyTmp += "\r\n" + cmdLineSent_1s_before + " 对应回复:  " + StringReplytmp;

                        if (isLoRaCmdAllSentFlag)//发送完成1秒后
                        {

                            isLoRaCmdSendingFlag = false;//不再处于命令发送或接收状态
                            isLoRaCmdAllSentFlag = false;
                            labelLoraStaus.Text = "发送完成√";
                            receiveTextBox.AppendText("\r\n" + cmdAndReplyTmp);
                        }
                    }
                    
                }
                

                if (nCmdLinesTosend > 0)//如果还有几行命令要发送
                {
                    if (nCmdLinesTosend == HexCmdLines.Length)
                        cmdAndReplyTmp = "";//开始发送前先置空字符串。

                    cmdLineSent_1s_before = HexCmdLines[HexCmdLinesIndex];
                    
  
                    SendHexString(HexCmdLines[HexCmdLinesIndex]);
                    HexCmdLinesIndex = (HexCmdLinesIndex + 1) % HexCmdLines.Length;
                    nCmdLinesTosend--;
                    label12.Text = "剩余行数： " + (nCmdLinesTosend );
                    

                    if (serialUsageMode == 1 && nCmdLinesTosend == 0)//如果是LoRA指令且要处理地址自动递增
                    {
                        if (radioButtonLora.Checked && checkBoxAutoAddr.Checked)
                        {
                            LoraAddr++;
                            textBoxLoraAddr.Text = string.Format("{0:X6}", LoraAddr);
                            sendTextBox.Text = generateLoraCmds(LoraAddr);
                        }
                        isLoRaCmdAllSentFlag = true;//指令刚发完
                    }
                }


              
            }

            DataGotLastSecond.Clear();//清空上一秒收的的字节数据
            //设置新的定时时间 
            CheckAndResetSendCycleTextBox();
                
        }

        private void turnOnButton_CheckedChanged(object sender, EventArgs e)
        {
            //测试清空combobox
            //portNamesCombobox.Items.Clear();

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
                    serial.BaudRate = Convert.ToInt32(baudRateCombobox.Text);
                    serial.Parity = (System.IO.Ports.Parity)Enum.Parse(typeof(System.IO.Ports.Parity), parityCombobox.Text);
                    serial.DataBits = Convert.ToInt16(dataBitsCombobox.Text);
                    serial.StopBits = (System.IO.Ports.StopBits)Enum.Parse(typeof(System.IO.Ports.StopBits), stopBitsCombobox.Text);

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

                    radioButtonPort.Checked = true;//默认使用普通串口模式

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


        //接收数据
       //public delegate void UpdateUiTextDelegate(string text);
        private void ReceiveData(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //16进制数据接收解析有问题,读16进制字节应该用read()。2020-6-18
            //16进制数据接收解析有问题,读16进制字节应该用read()。2020-6-18
            if (hexadecimalDisplayCheckBox.Checked)
            {
                int byteLen = serial.BytesToRead;
                if (byteLen > 0)
                {
                    receiveByteBuffer = new byte[byteLen];
                    serial.Read(receiveByteBuffer, 0, byteLen);
                    DataGotLastSecond.AddRange(receiveByteBuffer);
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

            //更新接收字节数
            receiveBytesCount += (UInt32)receiveText.Length;
            statusReceiveByteTextBlock.Text = receiveBytesCount.ToString();

            //没有关闭数据显示
            if (stopShowingButton.Checked == false)
            {
                //字符串显示
                receiveTextBox.AppendText(receiveText);
            }

        }

        private void receiveTextBox_TextChanged(object sender, EventArgs e)
        {

            if (receiveTextBox.Text.Length > 102400) 
                receiveTextBox.Clear();
            else if (autoClearCheckBox.Checked == true && receiveTextBox.Lines.Length >= 100)
            {
                    receiveTextBox.Clear();       
            }

            label13.Text = "字数： " + receiveTextBox.Text.Length;

            try
            {
                receiveTextBox.ScrollToCaret();
            }
            catch
            {
            }
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


        /**
         * else if(nCmdLinesTosend>0 && HexCmdLinesIndex< HexCmdLines.Length)
            {
                SendHexString(HexCmdLines[HexCmdLinesIndex++]);
                nCmdTosend--;
            }
         */
        private void SendButton_Click(object sender, EventArgs e)
        {
            if (!serial.IsOpen)
            {

                statusDisplay(false, "请先打开串口！");
                return;
            }

            


            if (serialUsageMode == 0)
                SerialPortSend();
            else if(nCmdLinesTosend==0)//发完上一组指令才能再发别的
            {
                //AutoSendCheckBox.Checked = true;//自动发送多组指令需要使用定时器
                //autoSendTimer.Enabled = true;
                receiveTextBox.Text = "";
                string CmdLines = sendTextBox.Text;
                HexCmdLines = CmdLines.Split(new string[] { "\r\n" },
                                   StringSplitOptions.RemoveEmptyEntries);
                HexCmdLinesIndex = 0;
                if (serialUsageMode == 1)//如果是LoRa测试
                {
                    
                    foreach (string labelNname in statusDisplayLabels.Keys)
                        SetLoraLabelColor(labelNname, true);
                    nCmdLinesTosend = HexCmdLines.Length;
                    if(nCmdLinesTosend>0)
                        labelLoraStaus.Text = "正在发送LoRa指令...";
                }
                
                else
                    nCmdLinesTosend = HexCmdLines.Length*n485ResendTimes;
                isLoRaCmdSendingFlag = true;
                isLoRaCmdAllSentFlag = false;
            }
            else
            {
                //autoSendTimer.Enabled = false;
                nCmdLinesTosend = 0;
                isLoRaCmdSendingFlag = false;
                isLoRaCmdAllSentFlag = false;
                receiveTextBox.AppendText("\r\n\r\n已停止当前发送操作。\r\n\r\n");
                if (serialUsageMode == 1)//如果是LoRa测试
                {
                    labelLoraStaus.Text = "发送操作已取消";
                }
            }
            DataGotLastSecond.Clear();//把之前收到的数据清空
        }

        private void AutoSendCheckBox_CheckStateChanged(object sender, EventArgs e)
        {

        }

        //自动发送开关
        private void AutoSendCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if(AutoSendCheckBox.Checked)
            {
                CheckAndResetSendCycleTextBox();

                autoSendTimer.Interval = Convert.ToInt32(autoSendCycleTextBox.Text);
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

        //不让输入非16进制的字符
        private void sendTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
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
            if(stopShowingButton.Checked)
            {
                stopShowingButton.Text = "恢复显示";
            }
            else
            {
                stopShowingButton.Text = "停止显示";
            }
        }

        private void textBoxLoraAddr_KeyPress(object sender, KeyPressEventArgs e)
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

                if (e.KeyChar == (char)8)
                {
                    flag = false;
                }
                e.Handled = flag;
            
        }


        void howToUse()
        {
            StringBuilder sb = new StringBuilder(256);
            int LineWidth = 100;
            for (int i = 0; i < LineWidth; i++)
                sb.Append('*');
            sb.Append("\r\n");
            for (int i = 0; i < LineWidth/2-5; i++)
                sb.Append(' ');
            sb.Append("串口使用说明\r\n");
            sb.Append("  1、用作“普通串口”时，使用方法和其他串口软件相同。\r\n");
            sb.Append("  2、填写16进制数字时，各个数字间以空格或逗号分隔。可以省略0x前缀。\r\n");
            sb.Append("  3、Lora测试：更改“下一个LoRa地址”或“原始地址”后，鼠标点一下输入框，本次地址相关的命令将自动填写。\r\n");
            sb.Append("              这些命令将以“自动发送周期”的间隔逐条发出。\r\n");
            sb.Append("  4、485测试：可以将多条命令写入发送框，每行一条。这些命令将逐行发出。\r\n");
            receiveTextBox.Clear();
            receiveTextBox.Text = sb.ToString();
        }


        private void radioButtonPort_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonPort.Checked)
            {
                serialUsageMode = 0;
                AutoSendCheckBox.Checked = false;
                hexadecimalDisplayCheckBox.Checked = false;
                hexadecimalSendCheckBox.Checked = false;
            }
            else
            {
                
                
                
                hexadecimalDisplayCheckBox.Checked = true;
                hexadecimalSendCheckBox.Checked = true;
                autoSendCycleTextBox.Text = string.Format("{0}", 1500);//默认一秒发一条命令
                howToUse();
            }
            nCmdLinesTosend = 0;
        }

        private void radioButtonLora_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLora.Checked)
            {
                AutoSendCheckBox.Checked = true;
                LoRaSettingControlState(true);
                textBoxLoraAddr.Text = string.Format("{0:X6}", LoraAddr);
                textBoxPreAddr.Text  = string.Format("{0:X6}", LoraPreAddr);
                sendTextBox.Text = generateLoraCmds(LoraAddr);
                serialUsageMode = 1;
            }
            else
            {
                LoRaSettingControlState(false);
                
                
                nCmdLinesTosend = 0;
                isLoRaCmdSendingFlag = false;
                isLoRaCmdAllSentFlag = false;
            }
        }

        private void radioButton485_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton485.Checked)
            {
                AutoSendCheckBox.Checked = true;
                sendTextBox.Text = generate485Cmds();
                n485SettingControlState(true);
                textBox485ResendTimes.Text= string.Format("{0}", n485ResendTimes);
                serialUsageMode = 2;

            }
            else
            {
                n485SettingControlState(false);
                nCmdLinesTosend = 0;
                isLoRaCmdSendingFlag = false;
                isLoRaCmdAllSentFlag = false;
                
            }
        }

        /**
         *  private byte[] arrayLoraCmdSetAddr = { 0xEE, 0x16, 0x08, 0x00, 0x00, 0x00, 0x80, 0x00, 0x21, 0xAD };
            private byte[] arrayLoraCmdCheck   = { 0xEE, 0x15, 0x06, 0x80, 0x00, 0x21, 0x01, 0xAB};
           
            private byte[] arrayLoraCmdOff = { 0xEE, 0x11, 0x07, 0x80, 0x00, 0x21, 0x00, 0x00,0x6a}; 
            private byte[] arrayLoraCmdON  = { 0xEE, 0x11, 0x07, 0x80, 0x00, 0x21, 0x64, 0x64, 0x6a };
         * */

        //根据LoRa地址自动生成多条命令
        private string generateLoraCmds(int addrInt)
        {
            int i;
            int sumTmp;
            StringBuilder sb = new StringBuilder(128);

            arrayLoraCmdSetAddr[5] = (byte)(LoraPreAddr & 0xff);
            arrayLoraCmdSetAddr[4] = (byte)(LoraPreAddr >> 8 & 0xff);
            arrayLoraCmdSetAddr[3] = (byte)(LoraPreAddr >> 16 & 0xff);

            arrayLoraCmdSetAddr[8] = (byte)(addrInt & 0xff);
            arrayLoraCmdSetAddr[7] = (byte)(addrInt >> 8 & 0xff);
            arrayLoraCmdSetAddr[6] = (byte)(addrInt >> 16 & 0xff);
            for (i = 0, sumTmp = 0; i < arrayLoraCmdSetAddr.Length - 1; i++)
            {
                sumTmp += arrayLoraCmdSetAddr[i];
            }
            arrayLoraCmdSetAddr[arrayLoraCmdSetAddr.Length - 1] = (byte)(sumTmp & 0xff);


            arrayLoraCmdCheck[5] = (byte)(addrInt & 0xff);
            arrayLoraCmdCheck[4] = (byte)(addrInt >> 8 & 0xff);
            arrayLoraCmdCheck[3] = (byte)(addrInt >> 16 & 0xff);
            for (i = 0, sumTmp = 0; i < arrayLoraCmdCheck.Length - 1; i++)
            {
                sumTmp += arrayLoraCmdCheck[i];
            }
            arrayLoraCmdCheck[arrayLoraCmdCheck.Length - 1] = (byte)(sumTmp & 0xff);


            arrayLoraCmdOff[5] = (byte)(addrInt & 0xff);
            arrayLoraCmdOff[4] = (byte)(addrInt >> 8 & 0xff);
            arrayLoraCmdOff[3] = (byte)(addrInt >> 16 & 0xff);
            for (i = 0, sumTmp = 0; i < arrayLoraCmdOff.Length - 1; i++)
            {
                sumTmp += arrayLoraCmdOff[i];
            }
            arrayLoraCmdOff[arrayLoraCmdOff.Length - 1] = (byte)(sumTmp & 0xff);


            arrayLoraCmdON[5] = (byte)(addrInt & 0xff);
            arrayLoraCmdON[4] = (byte)(addrInt >> 8 & 0xff);
            arrayLoraCmdON[3] = (byte)(addrInt >> 16 & 0xff);
            for (i = 0, sumTmp = 0; i < arrayLoraCmdON.Length - 1; i++)
            {
                sumTmp += arrayLoraCmdON[i];
            }
            arrayLoraCmdON[arrayLoraCmdON.Length - 1] = (byte)(sumTmp & 0xff);



            

            if (!checkBoxOnlySendCheckCmd.Checked)
            {
                foreach (byte b in arrayLoraCmdSetAddr)
                {
                    sb.AppendFormat("{0:X2} ", b);
                }
                sb.Append("\r\n");

                foreach (byte b in arrayLoraCmdOff)
                {
                    sb.AppendFormat("{0:X2} ", b);
                }
                sb.Append("\r\n");

                foreach (byte b in arrayLoraCmdCheck)
                {
                    sb.AppendFormat("{0:X2} ", b);
                }
                sb.Append("\r\n");

                foreach (byte b in arrayLoraCmdCheck)
                {
                    sb.AppendFormat("{0:X2} ", b);
                }
                sb.Append("\r\n");

                foreach (byte b in arrayLoraCmdON)
                {
                    sb.AppendFormat("{0:X2} ", b);
                }
                sb.Append("\r\n");

            }




            foreach (byte b in arrayLoraCmdCheck)
            {
                sb.AppendFormat("{0:X2} ", b);
            }
            sb.Append("\r\n");

            return sb.ToString();  
        }

        private string generate485Cmds()
        {
            StringBuilder sb = new StringBuilder(128);

            sb.Append("EE 15 06 01 00 01 01 0C\r\n");//查询指令
            sb.Append("ee 11 07 00 00 00 01 64 6b\r\n");
            sb.Append("ee 11 07 00 00 00 64 3C A6\r\n");
            sb.Append("ee 11 07 00 00 00 64 28 92\r\n");
            sb.Append("ee 11 07 00 00 00 64 14 7E\r\n");
            sb.Append("ee 11 07 00 00 00 64 00 6A\r\n");
            sb.Append("ee 11 07 00 00 00 00 64 6a\r\n");
            //sb.Append("");
            return sb.ToString();
        }

        private void textBoxLoraAddr_Validating(object sender, CancelEventArgs e)
        {
            //if(radioButtonLora.Checked)
            if (!string.IsNullOrEmpty(textBoxLoraAddr.Text))
            {
                LoraAddr = Convert.ToInt32(textBoxLoraAddr.Text, 16);
                sendTextBox.Text = generateLoraCmds(LoraAddr);
            }
            


        }

        private void textBox485ResendTimes_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox485ResendTimes.Text))
            {
                int tmp= Convert.ToInt32(textBox485ResendTimes.Text, 10);
                if(tmp!= n485ResendTimes && tmp >0)
                {
                    n485ResendTimes = Convert.ToInt32(textBox485ResendTimes.Text, 10);
                    if (HexCmdLines != null)
                        nCmdLinesTosend = HexCmdLines.Length * n485ResendTimes;
                }
                
                //receiveTextBox.Text = n485ResendTimes+"";
            }
        }

        private void autoSendCycleTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (AutoSendCheckBox.Checked)
                CheckAndResetSendCycleTextBox();
        }

        private void sendTextBox_TextChanged(object sender, EventArgs e)
        {
            if(AutoSendCheckBox.Checked)
                CheckAndResetSendCycleTextBox();
        }


        //避免自动发送周期设置过小
        void CheckAndResetSendCycleTextBox()
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
                double minPeriodNeeded = nBitsTosend * 1500 / Convert.ToInt32(baudRateCombobox.Text);
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

        
        private void label13_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonPreAddr_Click(object sender, EventArgs e)
        {
            LoraAddr--;
            textBoxLoraAddr.Text = string.Format("{0:X6}", LoraAddr);
            sendTextBox.Text = generateLoraCmds(LoraAddr);
        }

        private void buttonNextAddr_Click(object sender, EventArgs e)
        {
            LoraAddr++;
            textBoxLoraAddr.Text = string.Format("{0:X6}", LoraAddr);
            sendTextBox.Text = generateLoraCmds(LoraAddr);
        }

        private void textBoxPreAddr_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxPreAddr.Text))
            {
                LoraPreAddr = Convert.ToInt32(textBoxPreAddr.Text, 16);
                if (nCmdLinesTosend == 0)
                    sendTextBox.Text = generateLoraCmds(LoraAddr);
            }
        }




        public  bool isCmdCheck_Sent(string hexString, out int LoRaAddr)
        {
            bool isValidFlag = true;
            LoRaAddr = 0xfffffff;
            try
            {

                hexString = hexString.Trim();
                hexString.Replace("0x", "");   //去掉0x
                hexString.Replace("0X", "");   //去掉0X

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
                        isValidFlag = false;
                    }
                }
                //EE 19 07 01 02 18 01 01 2B 
                if (isValidFlag && sendBuffer.Length == 9)
                {
                    if (sendBuffer[0] != 0xEE)
                        isValidFlag = false;
                    if (sendBuffer[1] != 0x19)
                        isValidFlag = false;
                    if (sendBuffer[2] != 0x07)
                        isValidFlag = false;
                    if (sendBuffer[6] != 0x01)
                        isValidFlag = false;
                    if (sendBuffer[7] != 0x01)
                        isValidFlag = false;
                    int sumTmp = 0;
                    foreach (byte b in sendBuffer)
                        sumTmp += b;
                    sumTmp -= sendBuffer[8];
                    if ((byte)(sumTmp & 0xff) != sendBuffer[8])
                        isValidFlag = false;

                    if (isValidFlag)
                    {
                        LoRaAddr = sendBuffer[3];
                        LoRaAddr = LoRaAddr << 8;
                        LoRaAddr += sendBuffer[4];
                        LoRaAddr = LoRaAddr << 8;
                        LoRaAddr += sendBuffer[5];
                    }
                }
                else
                    isValidFlag = false;
            }
            catch //无法转为16进制时
            {
                isValidFlag = false;
            }

            return isValidFlag;
        }

        public  bool isReplyOfCmdCheck(List<byte> DataGotLastSecond, int LoraAddr)
        {
            bool isValidFlag = true;
            string tmpString = "回复正确";

            if (DataGotLastSecond == null)
            {
                tmpString = "错误：引用为空";
                isValidFlag = false;
            }
            else
            {
                if (DataGotLastSecond.Count == 26)
                {
                    byte[] dataBuffer = DataGotLastSecond.ToArray();
                    if (dataBuffer[0] != 0xCC)
                        isValidFlag = false;
                    if (dataBuffer[1] != 0x19)
                        isValidFlag = false;
                    if (dataBuffer[2] != 0x18)
                        isValidFlag = false;
                    if (dataBuffer[6] != 0x81)
                        isValidFlag = false;
                    int tmpSum = 0;
                    foreach (byte b in dataBuffer)
                        tmpSum += b;
                    tmpSum -= dataBuffer[25];
                    if ((byte)(tmpSum & 0xff) != dataBuffer[25])
                    {
                        isValidFlag = false;
                    }

                    int tmpAddr;
                    if (isValidFlag)
                    {
                        tmpAddr = dataBuffer[3];
                        tmpAddr = tmpAddr << 8;
                        tmpAddr += dataBuffer[4];
                        tmpAddr = tmpAddr << 8;
                        tmpAddr += dataBuffer[5];
                        if (tmpAddr != LoraAddr)
                        {
                            tmpString = "错误：地址错";
                            isValidFlag = false;
                        }

                    }
                    else
                        tmpString = "错误：数据格式错";
                }
                else
                {
                    tmpString = "错误：数据长度不对";
                    isValidFlag = false;
                }
            }

            return isValidFlag;
            //return tmpString;
        }

        public  Dictionary<string, string> GetResults(List<byte> DataGotLastSecond)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            if (DataGotLastSecond.Count == 26)
            {
                byte[] dataBuffer = DataGotLastSecond.ToArray();
                sbyte sbyteTmp;
                int IntTmp;
                int baseIdx = 6;
                string stringTmp;
                stringTmp = string.Format("数据标识: 0x{0:X2}", dataBuffer[baseIdx + 0]);
                result.Add("数据标识", stringTmp);


                stringTmp = string.Format("设备类型: 0x{0:X2}", dataBuffer[baseIdx + 1]);
                if (dataBuffer[baseIdx + 1] >= 0x70 && dataBuffer[baseIdx + 1] <= 0x7F)
                {
                    stringTmp = "设备类型: 路灯控制器";
                    if (dataBuffer[baseIdx + 1] == 0x73)
                        stringTmp = "设备类型: 500W单灯控制器";
                    else if (dataBuffer[baseIdx + 1] == 0x7A)
                        stringTmp = "设备类型: 500W双灯控制器";
                }
                result.Add("设备类型", stringTmp);

                sbyteTmp = (sbyte)dataBuffer[baseIdx + 2];
                stringTmp = string.Format("温度: {0} ℃", sbyteTmp);
                result.Add("温度", stringTmp);

                IntTmp = dataBuffer[baseIdx + 3];
                IntTmp <<= 8;
                IntTmp += dataBuffer[baseIdx + 4];
                stringTmp = string.Format("输入电压: {0} V", IntTmp * 0.1);
                result.Add("输入电压", stringTmp);

                IntTmp = dataBuffer[baseIdx + 5];
                IntTmp <<= 8;
                IntTmp += dataBuffer[baseIdx + 6];
                stringTmp = string.Format("A路输入电流: {0} mA", IntTmp);
                result.Add("A路输入电流", stringTmp);

                IntTmp = dataBuffer[baseIdx + 7];
                IntTmp <<= 8;
                IntTmp += dataBuffer[baseIdx + 8];
                stringTmp = string.Format("B路输入电流: {0} mA", IntTmp);
                result.Add("B路输入电流", stringTmp);

                IntTmp = dataBuffer[baseIdx + 9];
                IntTmp <<= 8;
                IntTmp += dataBuffer[baseIdx + 10];
                stringTmp = string.Format("A路有功功率: {0} W", IntTmp * 0.1);
                result.Add("A路有功功率", stringTmp);

                IntTmp = dataBuffer[baseIdx + 11];
                IntTmp <<= 8;
                IntTmp += dataBuffer[baseIdx + 12];
                stringTmp = string.Format("B路有功功率: {0} W", IntTmp * 0.1);
                result.Add("B路有功功率", stringTmp);

                stringTmp = string.Format("A路功率因素: {0} %", dataBuffer[baseIdx + 13]);
                result.Add("A路功率因素", stringTmp);

                stringTmp = string.Format("B路功率因素: {0} %", dataBuffer[baseIdx + 14]);
                result.Add("B路功率因素", stringTmp);

                stringTmp = string.Format("A路亮度: {0} %", dataBuffer[baseIdx + 15]/2);
                result.Add("A路亮度", stringTmp);

                stringTmp = string.Format("B路亮度: {0} %", dataBuffer[baseIdx + 16]/2);
                result.Add("B路亮度", stringTmp);
            }

            return result;
        }

        private Dictionary<string,Label> InitDisplayLabels()
        {
            Dictionary<string, Label> DisplayLabels = new Dictionary<string, Label>();
            DisplayLabels.Add("数据标识", labelDataCode);
            DisplayLabels.Add("设备类型", labelDeviceType);
            DisplayLabels.Add("温度", labelTemperature);
            DisplayLabels.Add("输入电压", labelInputVoltage);
            DisplayLabels.Add("A路输入电流", label_A_InputCurrent);
            DisplayLabels.Add("B路输入电流", label_B_InputCurrent);
            DisplayLabels.Add("A路有功功率", label_A_Power);
            DisplayLabels.Add("B路有功功率", label_B_Power);

            DisplayLabels.Add("A路功率因素", label_A_PowerFactor);
            DisplayLabels.Add("B路功率因素", label_B_PowerFactor);
            DisplayLabels.Add("A路亮度", label_A_luminosity);
            DisplayLabels.Add("B路亮度", label_B_luminosity);
            DisplayLabels.Add("Lora命令发送状态", labelLoraStaus);
            return DisplayLabels;
        }

        /**
         * 
         * if (isNormal)
            {
                statusTextBlock.BackColor = Color.LightYellow;
                statusTextBlock.ForeColor = Color.Blue;
            }
            else
            {
                statusTextBlock.BackColor = Color.Red;
                statusTextBlock.ForeColor = Color.Green;
            }
         */
        private void SetLoraLabelColor(string labelName,bool isNormal)
        {
            if(isNormal)
            {
                statusDisplayLabels[labelName].BackColor = Color.LightYellow;
                statusDisplayLabels[labelName].ForeColor = Color.Blue;
            }
            else
            {
                statusDisplayLabels[labelName].BackColor = Color.Red;
                statusDisplayLabels[labelName].ForeColor = Color.Green;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxOnlySendCheckCmd_CheckedChanged(object sender, EventArgs e)
        {
            sendTextBox.Text = generateLoraCmds(LoraAddr);
        }
    }
}
