using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {


        public static bool isCmdCheck_Sent(string hexString, out int LoRaAddr)
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

        public static string isReplyOfCmdCheck(List<byte> DataGotLastSecond,int LoraAddr)
        {
            bool isValidFlag = true;
            string tmpString="回复正确";
            
            if (DataGotLastSecond == null)
            {
                tmpString = "错误：引用为空";
                isValidFlag = false;
            } 
            else
            {
                if(DataGotLastSecond.Count == 26)
                {
                    byte[] dataBuffer =DataGotLastSecond.ToArray();
                    if(dataBuffer[0]!=0xCC)
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
                        
                    
                    int tmpAddr ;
                    if (isValidFlag)
                    {
                        tmpAddr = dataBuffer[3];
                        tmpAddr = tmpAddr << 8;
                        tmpAddr += dataBuffer[4];
                        tmpAddr = tmpAddr << 8;
                        tmpAddr += dataBuffer[5];
                        if(tmpAddr!= LoraAddr)
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


            //return isValidFlag;
            return tmpString;
        }

        public static List<byte> ParseHexString(string hexString)
        {
            List<byte> dataList = null;
            try
            {

                hexString = hexString.Trim();
                hexString.Replace("0x", "");   //去掉0x
                hexString.Replace("0X", "");   //去掉0X
                                               //  sendData.


                string[] strArray = hexString.Split(new char[] { ',', '，', '\r', '\n', ' ', '\t' });
                int decNum = 0;
                
                dataList=new List<byte>();  //发送数据缓冲区

                foreach (string str in strArray)
                {
                    try
                    {
                        decNum = Convert.ToInt16(str, 16);
                        dataList.Add(Convert.ToByte(decNum));

                    }
                    catch
                    {
                        dataList = null;
                    }
                }
            }
            catch //无法转为16进制时
            {
                dataList = null;
            }

            return dataList;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string s1 = "ssdd";
            string s2 = "ssa";
            string s3 = "";
            textBox1.AppendText("s1= "+s1+"\r\n");
            textBox1.AppendText("s2= " + s2 + "\r\n");
            textBox1.AppendText("s1");
            if (!s1.StartsWith(s2))
            {
                textBox1.AppendText(" 不");
                s3 = "???";
            }
            else
            {
                s3 = s1.Substring(s2.Length);
            }
            textBox1.AppendText("以 s2 开始" + "\r\n");
            textBox1.AppendText("s3=" + s3 + "\r\n");

            string cmdString = "EE 19 07 01 02 18 01 01 2B";
            string replyString = "CC 19 18 01 02 18 81 73 22 01 CD 02 DA 00 00 01 50 00 00 61 00 C8 00 00 01 53";
            
            int addr; ;
            bool flag = isCmdCheck_Sent(cmdString, out addr);
            textBox1.AppendText(cmdString+" 是 "+(flag?"有效的查询命令": "无效的查询命令") + "\r\n");
            textBox1.AppendText("返回值= "+flag + "\r\n");
            textBox1.AppendText(string.Format("提取的地址= 0x{0:X6}\r\n", addr));

            textBox1.AppendText("\r\n\r\n" + replyString);
            List<byte> dataList = ParseHexString(replyString);
            StringBuilder sb = new StringBuilder();
            foreach(byte b in dataList)
            {
                sb.Append(string.Format("{0:X2} ", b));
            }
            textBox1.AppendText("\r\n转成List：" + sb.ToString() + "\r\n");
            textBox1.AppendText("\r\n" + isReplyOfCmdCheck(dataList,0x010218));
        }
    }
}
