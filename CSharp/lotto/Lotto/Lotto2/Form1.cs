using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lotto2.model;
using System.IO;
using Lotto2.json;
using System.Threading;

namespace Lotto2
{
    public partial class Form1 : Form
    {
        DataManager dm = new DataManager();
        int i = 0; //차트 번호
        bool isLoad = false;
        public Form1()
        {
            InitializeComponent();

        }

        private void button_test_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello world");

            Random r = new Random();

            MessageBox.Show(r.Next(1, 46).ToString());

            labelNum1.Text = r.Next(10).ToString();
            labelNum2.Text = r.Next(10).ToString();
            labelNum3.Text = r.Next(10).ToString();
            labelNum4.Text = r.Next(10).ToString();
            labelNum5.Text = r.Next(10).ToString();
            labelNum6.Text = r.Next(10).ToString();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileInfo File_Check = new FileInfo(@"./LottoNum.json");//json 파일 있나 확인 후 url 저장할껀지
            if (File_Check.Exists)
            {
                DataManager.LoadJson();
                writeLog("Lottonum.json 불러오기 완료", DateTime.Now.ToString("yyyy_MM_dd"));
                DataManager.numCount();
                writeLog("번호 별 나온 횟수 계산", DateTime.Now.ToString("yyyy_MM_dd"));

                timer1.Interval = 100;      // 0.1초
                
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Start();
           
               
            }
            else 
            {
             
                new Loading().ShowDialog();//로딩화면
                writeLog("Lottonum.json 저장 완료", DateTime.Now.ToString("yyyy_MM_dd"));


            }



            int count = DataManager.lottoNums.Count - 1; //최신 회차

            winNum.Text = $"{DataManager.lottoNums[count].drwNo} 회차 " +
                $" (날짜 :{DataManager.lottoNums[count].drwNoDate})";

   
            pBoxLuckNum1.Load(@"./Nimg/num" + DataManager.lottoNums[count].drwtNo1 + ".png");
            pBoxLuckNum1.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxLuckNum2.Load(@"./Nimg/num" + DataManager.lottoNums[count].drwtNo2 + ".png");
            pBoxLuckNum2.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxLuckNum3.Load(@"./Nimg/num" + DataManager.lottoNums[count].drwtNo3 + ".png");
            pBoxLuckNum3.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxLuckNum4.Load(@"./Nimg/num" + DataManager.lottoNums[count].drwtNo4 + ".png");
            pBoxLuckNum4.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxLuckNum5.Load(@"./Nimg/num" + DataManager.lottoNums[count].drwtNo5 + ".png");
            pBoxLuckNum5.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxLuckNum6.Load(@"./Nimg/num" + DataManager.lottoNums[count].drwtNo6 + ".png");
            pBoxLuckNum6.SizeMode = PictureBoxSizeMode.StretchImage;



        }






       

        private void JsonLoadBtn_Click(object sender, EventArgs e)
        {
            
           
            lottoNumlist.Items.Clear();
            lottoChart.Series[0].Points.Clear();//초기화

            isLoad = true;
            if (isLoad)
            {
                i = 0;
                timer1.Interval = 100;
                timer1.Stop();
                timer1.Start();
            }
            else
            {
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Start();

            }



            /* 
            int count = DataManager.lottoNums.Count - 1;

           winNum.Text = $"{DataManager.lottoNums[count].drwNo} 회차  " +
                $"{DataManager.lottoNums[count].drwtNo1}," +
                $"{DataManager.lottoNums[count].drwtNo2}," +
                $"{DataManager.lottoNums[count].drwtNo3}," +
                $"{DataManager.lottoNums[count].drwtNo4}," +
                $"{DataManager.lottoNums[count].drwtNo5}," +
                $"{DataManager.lottoNums[count].drwtNo6}" +
                $" 보너스:{DataManager.lottoNums[count].bnusNo}" +
                $" (날짜 :{DataManager.lottoNums[count].drwNoDate})";*/



        }

        private void newSaveJsonBtn_Click(object sender, EventArgs e)
        {
            new Loading().ShowDialog();

            DataManager.LoadJson();
            DataManager.numCount();
           


            lottoNumlist.Items.Clear();
            lottoChart.Series[0].Points.Clear();//초기화

            isLoad = true;
            if (isLoad)
            {

                i = 0;
                timer1.Interval = 100;
                timer1.Stop();
                timer1.Start();
            }
            else
            {
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Start();

            }

           

        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            // if (lottoChart.Series[0] > 10) // x축은 10개까지만 값을 출력하게 한다.

            if (i >= DataManager.numCount().Length)
            {
                i = 0; //다시 누를때 차트번호 초기화
                timer1.Stop();
                return;
            }
            
           
            if(lottoChart.Series[0].Points.Count < 45)
            {

                // Console.WriteLine($"번호 {i + 1} 나온 횟수 : {dm.numCount()[i]}개");

                lottoNumlist.Items.Add(i.ToString()).Text ="번호" + (i + 1) + " : " + DataManager.numCount()[i] + "개";
            
                lottoChart.Series[0].Points.AddXY(i + 1, DataManager.numCount()[i]);

                i++;
            }

           //Thread.Sleep(50);

        }
        private void writeLog(string contens, string date)
        {
            //int a = 1;
            //MessageBox.Show(a.ToString("00"));//01 이라고 출력됨, 3자리 이상 그대로 출력
            string logContens = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}]{contens}";

            
            DataManager.printLog(logContens, date);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

       private void timerReset()
        {

        }
    }
}

