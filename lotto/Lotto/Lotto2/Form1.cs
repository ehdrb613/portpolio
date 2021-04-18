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
                DataManager.numCount();
                timer1.Interval = 100;      // 0.1초
               
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Start();
               
            }
            else 
            {
             
                new Loading().ShowDialog();//로딩화면
            }
          



            int count = DataManager.lottoNums.Count - 1; //최신 회차

            winNum.Text = $"{DataManager.lottoNums[count].drwNo} 회차  " +
                $"{DataManager.lottoNums[count].drwtNo1}," +
                $"{DataManager.lottoNums[count].drwtNo2}," +
                $"{DataManager.lottoNums[count].drwtNo3}," +
                $"{DataManager.lottoNums[count].drwtNo4}," +
                $"{DataManager.lottoNums[count].drwtNo5}," +
                $"{DataManager.lottoNums[count].drwtNo6}" +
                $" 보너스:{DataManager.lottoNums[count].bnusNo}" +
                $" (날짜 :{DataManager.lottoNums[count].drwNoDate})";

            
        }






        private void lottoJsonBtn_Click(object sender, EventArgs e)
        {
            new Loading().ShowDialog();

            DataManager.LoadJson();
            DataManager.numCount();



            lottoNumlist.Items.Clear();
            lottoChart.Series[0].Points.Clear();//초기화

          

            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();




            int count = DataManager.lottoNums.Count - 1;

            winNum.Text = $"{DataManager.lottoNums[count].drwNo} 회차  " +
                $"{DataManager.lottoNums[count].drwtNo1}," +
                $"{DataManager.lottoNums[count].drwtNo2}," +
                $"{DataManager.lottoNums[count].drwtNo3}," +
                $"{DataManager.lottoNums[count].drwtNo4}," +
                $"{DataManager.lottoNums[count].drwtNo5}," +
                $"{DataManager.lottoNums[count].drwtNo6}" +
                $" 보너스:{DataManager.lottoNums[count].bnusNo}" +
                $" (날짜 :{DataManager.lottoNums[count].drwNoDate})";
            
        }

        private void JsonLoadBtn_Click(object sender, EventArgs e)
        {
            



            lottoNumlist.Items.Clear();
            lottoNumlist.Items.Clear();
            lottoChart.Series[0].Points.Clear();//초기화




            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();




            int count = DataManager.lottoNums.Count - 1;

            winNum.Text = $"{DataManager.lottoNums[count].drwNo} 회차  " +
                $"{DataManager.lottoNums[count].drwtNo1}," +
                $"{DataManager.lottoNums[count].drwtNo2}," +
                $"{DataManager.lottoNums[count].drwtNo3}," +
                $"{DataManager.lottoNums[count].drwtNo4}," +
                $"{DataManager.lottoNums[count].drwtNo5}," +
                $"{DataManager.lottoNums[count].drwtNo6}" +
                $" 보너스:{DataManager.lottoNums[count].bnusNo}" +
                $" (날짜 :{DataManager.lottoNums[count].drwNoDate})";



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

            //Thread.Sleep(500);

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

