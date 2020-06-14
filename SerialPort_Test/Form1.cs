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

namespace SerialPort_Test
{
    
    public partial class Form1 : Form
    {

        
        private SerialPort serial = new SerialPort();

        private string receiveData;

       

        static UInt32 receiveBytesCount = 0;
        static UInt32 sendBytesCount = 0;
        public Form1()
        {
            InitializeComponent();
            GetValuablePortName();
            autoDetectionTimer.Enabled = true;
            //设置状态栏提示
            statusTextBlock.Text = "准备就绪";
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


        private void timer1_UpdatePorts_Tick(object sender, EventArgs e)
        {
            // 枚举可用串口
            List<string> listPort = new List<string>();
            foreach (string portName in SerialPort.GetPortNames())
            {
                listPort.Add(portName);
            }

            if (this.portNamesCombobox.Items.Count != listPort.Count)
            {
                this.portNamesCombobox.Items.Clear();
                this.portNamesCombobox.Items.AddRange(listPort.ToArray());
                this.portNamesCombobox.SelectedIndex = (this.portNamesCombobox.Items.Count > 0) ? 0 : -1;
            }
        }

        private void comboBox_byte_size_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //到设计界面那里，双击界面后，会发现自动生成了Form1_load()，然后再进行代码编写。
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cbTimeSend_CheckedChanged(object sender, EventArgs e)
        {

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
                portNamesCombobox.SelectedIndex = 0;
                //提示消息
                statusTextBlock.Text = "串口已失效！";
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

                    statusTextBlock.Text = "串口列表已更新！";

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


        private void AutoSendTimer_Tick(object sender, EventArgs e)
        {

        }

        private void turnOnButton_CheckedChanged(object sender, EventArgs e)
        {
            if(turnOnButton.Checked)//打开串口
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

                    statusTextBlock.Text = "串口已开启";

                    //显示提示文字
                    turnOnButton.Text = "关闭串口";
                    turnOnButton.ForeColor = Color.Red;
                   

                    //使能发送面板
                    // sendControlBorder.IsEnabled = true;


                }
                catch
                {
                    statusTextBlock.Text = "配置串口出错！";
                }
            }
            else//关闭了串口
            {
                try
                {
                    serial.Close();

                    //关闭定时器
                    autoSendTimer.Stop();

                    //使能串口配置面板
                    serialSettingControlState(true);

                    statusTextBlock.Text = "串口已关闭";

                    //显示提示文字
                    turnOnButton.Text = "打开串口";

                    turnOnButton.ForeColor = Color.Gray;
                    //使能发送面板
                    //sendControlBorder.IsEnabled = false;
                }
                catch
                {

                }
            }
        }


        //接收数据
        //private delegate void UpdateUiTextDelegate(string text);
        private void ReceiveData(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            receiveData = serial.ReadExisting();
            ShowData(receiveData);
            //WPF中，为了使该后台线程能够访问 主线程UI控件的属性，该后台线程必须将此工作委托给与该 UI 线程关联的 Dispatcher。
            //Dispatcher.Invoke(DispatcherPriority.Send, new UpdateUiTextDelegate(ShowData), receiveData);
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
                if (hexadecimalDisplayCheckBox.Checked == false)
                {
                    receiveTextBox.AppendText(receiveText);

                }
                else //16进制显示
                {
                    byte[] recData = System.Text.Encoding.Default.GetBytes(receiveText);// 将接受到的字符串据转化成数组；  

                    foreach (byte str in recData)
                    {
                        receiveTextBox.AppendText(string.Format("{0:X2} ", str));
                    }
                }
            }

        }


    }
}
