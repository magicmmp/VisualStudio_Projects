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

namespace SerialPort_Test
{
    public partial class Form1 : Form
    {

        private SerialPort commPort;//串口引用
        public Form1()
        {
            InitializeComponent();
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

            if (this.comboBox_port.Items.Count != listPort.Count)
            {
                this.comboBox_port.Items.Clear();
                this.comboBox_port.Items.AddRange(listPort.ToArray());
                this.comboBox_port.SelectedIndex = (this.comboBox_port.Items.Count > 0) ? 0 : -1;
            }
        }

        private void comboBox_byte_size_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
