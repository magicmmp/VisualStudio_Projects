using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //1、程序加载的时候添加年份
            int year = DateTime.Now.Year;
            for (int i = year; i >= 1949; i--)
            {
                comboBox_year.Items.Add(i + "年");
            }

        }

        private void comboBox_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            //在添加数据之前，应该先将之前的数据清空
            comboBox_month.Items.Clear();
            //当选择年份后 加载月份
            for (int i = 1; i <= 12; i++)
            {
                comboBox_month.Items.Add(i + "月");
            }
        }

        private void comboBox_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            //在给日期添加数据之前，先清空之前的数据
            comboBox_day.Items.Clear();

            //当选择完月份后，添加日期

            //获得当前选择的年份
            string strYear = comboBox_year.SelectedItem.ToString().Split(new char[] { '年' }, StringSplitOptions.RemoveEmptyEntries)[0];

            //获得当前选择的月份
            string strMonth = comboBox_month.SelectedItem.ToString().Split(new char[] { '月' }, StringSplitOptions.RemoveEmptyEntries)[0];

            //类型转换
            int year = Convert.ToInt32(strYear);
            int month = Convert.ToInt32(strMonth);

            int day = 0;//存储当月的天数
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    day = 31;
                    break;
                case 2:
                    if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                    {
                        day = 29;
                    }
                    else
                    {
                        day = 28;
                    }
                    break;
                default:
                    day = 30;//4 6 9 11
                    break;
            }

            //将天数添加到日期下拉框中
            for (int i = 1; i <= day; i++)
            {
                comboBox_day.Items.Add(i + "日");
            }
        }

    }
}
