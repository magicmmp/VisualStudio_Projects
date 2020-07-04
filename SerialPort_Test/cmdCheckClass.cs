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



    }
}
