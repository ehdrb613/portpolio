

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing;
using OpenCvSharp;
using OpenCvSharp.CPlusPlus;
using OpenCvSharp.Extensions;
using System.Threading;

namespace TrainInfo
{
    public partial class Main : Form
    {
        
        //VideoFileSource videoFile;

        public Main()
        {
            InitializeComponent();
            
        }

        VideoCapture video;
        Mat frame = new Mat();
        private void Main_Load(object sender, EventArgs e)
        {
            //영상 출력 opencvsharp
            try
            {
                video = new VideoCapture(@"home3.mp4");
            }
            catch
            {
                timer1.Enabled = false;
            }
        }
        //기차영상 tick 출력
        private void timer1_Tick(object sender, EventArgs e)
        {
            video.Read(frame);
            if (video.PosFrames == video.FrameCount) //마지막 프레임일때
                video.Open(@"home3.mp4");//다시 실행
            //속도 조절
            if (video.PosFrames < (video.FrameCount / 2)*1.2) { 
                if(timer1.Interval>10)
                    timer1.Interval -= 1;
            }
            
            else { 
                if(timer1.Interval<40)
                    timer1.Interval += 1;
            }
            pictureBoxIpl1.ImageIpl = frame.ToIplImage();
        }//ToIplImage

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            frame.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InfoSearch infoSearch = new InfoSearch();
            infoSearch.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrivalInfo ai = new ArrivalInfo();
            ai.ShowDialog();
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            
            button3.ForeColor = Color.FromArgb(150, 210, 255);
            pictureBox2.Load(@"img/line2.png");

        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.FromArgb(0, 0, 0);
            pictureBox2.Load(@"img/line.png");
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.ForeColor = Color.FromArgb(150, 210, 255);
            pictureBox3.Load(@"img/line2.png");
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.FromArgb(0, 0, 0);
            pictureBox3.Load(@"img/line.png");
        }
    }
}
