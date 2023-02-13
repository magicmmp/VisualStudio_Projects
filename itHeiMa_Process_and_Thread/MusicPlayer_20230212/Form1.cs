using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer_20230212
{
    public partial class Form1 : Form
    {
        string[] pics;//存储图片的路径
        List<string> listLrc = new List<string>();//存储歌词，读取LRC文件分离出每句歌词和时间
        List<double> listTime = new List<double>();//存储每句歌词的播放时间，
        bool autoNextFlag = false;//在定时器里标记是否自动播放下一曲
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnPlayOrPause.Enabled = false;
            button4.Enabled = false;
            pics = Directory.GetFiles(@"E:\清水河毕业照", "*.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            //在程序加载的时候 给窗体来一张好看的皮肤
            skinEngine1.SkinFile = @"D:\VisualStudio_Projects\itHeiMa_Process_and_Thread\MusicPlayer_20230212\Winform皮肤\skin\DeepGreen.ssk";
            //取消音乐播放器的自动播放功能
            musicPlayer.settings.autoStart = false;
            //设置Url属性
            //musicPlayer.URL = @"C:\Users\SpringRain\Desktop\song\小虎队-爱.mp3";
        }
        Random r = new Random();
        //播放器换肤，只是简单改变边框颜色而已
        private void button1_Click(object sender, EventArgs e)
        {
            string[] filePath = Directory.GetFiles(@"D:\VisualStudio_Projects\itHeiMa_Process_and_Thread\MusicPlayer_20230212\Winform皮肤\skin", "*.ssk");
            skinEngine1.SkinFile = filePath[r.Next(0, filePath.Length)];
        }
        private void musicPlayer_Enter(object sender, EventArgs e)
        {
        }
        //播放或者暂停
        bool b = true;
        private void btnPlayOrPause_Click(object sender, EventArgs e)
        {
            if (btnPlayOrPause.Text == "播放")
            {
                if (b)
                {
                    int index = listBox1.SelectedIndex;
                    musicPlayer.URL = listSongs[index];
                }
                musicPlayer.Ctlcontrols.play();
                btnPlayOrPause.Text = "暂停";
                b = false;
            }
            else if (btnPlayOrPause.Text == "暂停")
            {
                musicPlayer.Ctlcontrols.pause();
                btnPlayOrPause.Text = "播放";
            }
        }
        //停止播放
        private void button4_Click(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.stop();
        }
        //存储音乐文件的全路径
        List<string> listSongs = new List<string>();
        //添加音乐文件到列表
        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"E:\音乐";
            ofd.Filter = "音乐文件|*.mp3|所有文件|*.*";
            ofd.Multiselect = true;//允许同时选择多个音乐文件
            ofd.Title = "请选择音乐文件";
            ofd.ShowDialog();
            btnPlayOrPause.Enabled = true;
            button4.Enabled = true;
            //获得在打开对话框中选择的所有音乐文件的全路径
            string[] musicFile = ofd.FileNames;
            for (int i = 0; i < musicFile.Length; i++)
            {
                //截取全路径的文件名 ，并且添加到列表中
                listBox1.Items.Add(Path.GetFileNameWithoutExtension(musicFile[i]));
                //将全路径添加到List泛型集合
                listSongs.Add(musicFile[i]);
            }
        }
        //播放
        private void button2_Click(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.play();
        }
        //暂停
        private void button3_Click(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.pause();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        //双击播放歌曲
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            musicPlayer.URL = listSongs[listBox1.SelectedIndex];
            musicPlayer.Ctlcontrols.play();

            //显示歌词
            LoadLrc();
        }
        //加载歌词
        void LoadLrc()
        {
            //获得了当前歌曲的歌词文件
            string lrcFile = listSongs[listBox1.SelectedIndex] + ".lrc";
            if (File.Exists(lrcFile))
            {
                //如果有歌词 读取歌词文件
                string[] lrcText = File.ReadAllLines(lrcFile, Encoding.UTF8);
                for(int i=0;i<lrcText.Length;i++)
                {
                    Console.WriteLine(lrcText[i]);
                }
                FormatLrc(lrcText);
            }
            else
            {
                lblLrc.Text = "--------歌词未找到--------";
            }
        }
        //这种方法可以显示歌词，但是歌词会有闪烁（解决方法：歌词没改变不必刷新显示）。
        //并且歌词格式要求严格，不能有多余字符串，否则解析出错
        void FormatLrc(string[] lrcText)
        {
            //清空之前的数据
            listLrc.Clear();
            listTime.Clear();
            for (int i = 0; i < lrcText.Length; i++)
            {
                //[00:15.57]当我和世界不一样
                string[] lrcTemp = lrcText[i].Split(new char[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
                //lrcTemp[0]:01:15.57
                //lrcTemp[1]:当我和世界不一样
                listLrc.Add(lrcTemp[1]);//当有某行字符串不按照歌词格式，则会出错
                //将时间转换成double类型
                string[] timeTemp = lrcTemp[0].Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                //获得时间的double类型值
                double time = double.Parse(timeTemp[0]) * 60 + double.Parse(timeTemp[1]);
                listTime.Add(time);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        //上一曲
        private void btnPre_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                return;
            }
            //获得当前正在播放歌曲的索引
            int index = listBox1.SelectedIndex;
            //清除所有被选中项的索引
            listBox1.SelectedIndices.Clear();
            index--;
            if (index < 0)
            {
                //回到最后一首歌
                index = listBox1.Items.Count - 1;
            }
            //将改变后的索引重新赋值给当前选中项的索引
            listBox1.SelectedIndex = index;
            //通过改变后的索引去集合中拿音乐路径
            musicPlayer.URL = listSongs[index];
            musicPlayer.Ctlcontrols.play();
        }
        //下一曲
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                return;
            }
            NextSong();
        }
        private void NextSong()
        {
            int index = listBox1.SelectedIndex;
            //清除所有被选中项的索引
            listBox1.SelectedIndices.Clear();
            index++;
            if (index == listBox1.Items.Count)
            {
                index = 0;
            }
            
            listBox1.SelectedIndex = index;
            musicPlayer.URL = listSongs[index];
            musicPlayer.Ctlcontrols.play();
        }
        //右键删除列表歌曲
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //获得要删除歌曲的数量
            int count = listBox1.SelectedIndices.Count;
            //同时在listBox1选中多个歌曲时，SelectedIndex值可能指向第一个被选中的歌曲
            //通过循环一首一首的进行删除
            for (int i = 0; i < count; i++)
            {
                //先删列表还是先删集合？
                //因为我们是根据索引进行删除，所以应该先删除集合，再删除列表
                listSongs.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
        //加大音量
        private void button6_Click(object sender, EventArgs e)
        {
            musicPlayer.settings.volume += 5;//音量最大是100
        }
        //减小音量
        private void button7_Click(object sender, EventArgs e)
        {
            musicPlayer.settings.volume -= 5;
        }
        //点击Label设置静音或者放音
        private void label1_Click(object sender, EventArgs e)
        {
            //需要先设置label1的附带数据Tag属性为1，否则出错
            if (label1.Tag.ToString() == "1")
            {
                //静音
                musicPlayer.settings.mute = true;
                label1.Tag = "2";
                label1.Text = "放音";
                label1.Image = Image.FromFile(@"D:\VisualStudio_Projects\itHeiMa_Process_and_Thread\MusicPlayer_20230212\静音.png");
            }
            else if (label1.Tag.ToString() == "2")
            {
                musicPlayer.settings.mute = false;
                label1.Tag = "1";
                label1.Text = "静音";
                label1.Image = Image.FromFile(@"D:\VisualStudio_Projects\itHeiMa_Process_and_Thread\MusicPlayer_20230212\放音.png");
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //如果音乐播放器的状态是 "正在播放中"
            if (musicPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {    //照片多时这里提示内存不足
                pictureBox1.Image = Image.FromFile(pics[r.Next(0, pics.Length)]);
                //currentPosition表示当前正在播放的时间  double类型
                //currentPositionString表示当前正在播放的时间  string类型
                //duration表示当前歌曲的总时间 double类型
                //durationString表示当前歌曲的总时间 string类型
                //显示歌曲的时间
                lblInfo.Text = musicPlayer.Ctlcontrols.currentPositionString + "/"  + musicPlayer.currentMedia.durationString;
            }
            if(autoNextFlag)
            {
                autoNextFlag = false;
                musicPlayer.Ctlcontrols.play();//播放下一曲
            }
        }
        private void musicPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            //一首歌播放依次经历4个状态：Ready ——>Playing——>Ended——>Stoped
            //如果点暂停，会有wmppsPaused状态。
            //在当前歌曲结束Ended状态中准备下一曲，然后许可定时器Time1进行播放操作。
            //问题：在这里无法调用musicPlayer.Ctlcontrols.play()播放？要在定时器才行？2023-2-13
            if (musicPlayer.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                int index = listBox1.SelectedIndex;
                //清除所有被选中项的索引
                listBox1.SelectedIndices.Clear();
                index++;
                if (index == listBox1.Items.Count)
                {
                    index = 0;
                }
                listBox1.SelectedIndex = index;
                musicPlayer.URL = listSongs[index];
                autoNextFlag = true;
            }
        }
        private void timer_ShowLRC_Tick(object sender, EventArgs e)
        {
            //获得当前播放器的时间
            double time = musicPlayer.Ctlcontrols.currentPosition;
            for (int i = 0; i < listTime.Count; i++)
            {
                if (time >= listTime[i])//时间一到就更新下一句歌词
                {
                    lblLrc.Text = listLrc[i];
                }
            }
        }
    }
}
