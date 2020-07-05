using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialPort_Test
{
    public class cmdCheckClass
    {

        public static bool isCmdCheck_Sent(string hexString,out int LoRaAddr)
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
                        isValidFlag=false;                          
                    }
                }
                //EE 19 07 01 02 18 01 01 2B 
                if (isValidFlag && sendBuffer.Length==9)
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
                    if((byte)(sumTmp&0xff) != sendBuffer[8])
                        isValidFlag = false;

                    if (isValidFlag)
                    {
                        LoRaAddr = sendBuffer[3];
                        LoRaAddr =LoRaAddr<<8;
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


        public static Dictionary<string, string> getResetResults()
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            List<byte> fakeDataGotLastSecond = new List<byte>(26);
            for (int i = 0; i < 26; i++)
                fakeDataGotLastSecond.Add(0);
            if (fakeDataGotLastSecond.Count == 26)
            {
                byte[] dataBuffer = fakeDataGotLastSecond.ToArray();
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

                stringTmp = string.Format("A路亮度: {0} %", dataBuffer[baseIdx + 15] / 2);
                result.Add("A路亮度", stringTmp);

                stringTmp = string.Format("B路亮度: {0} %", dataBuffer[baseIdx + 16] / 2);
                result.Add("B路亮度", stringTmp);
            }

            return result;
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

                dataList = new List<byte>();  //发送数据缓冲区

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

    }
}
