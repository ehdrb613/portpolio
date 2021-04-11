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

namespace Lotto2
{
    public partial class Form1 : Form
    {
        DataManager dm = new DataManager();
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
        }
       

       

       

        private void lottoJsonBtn_Click(object sender, EventArgs e)
        {
            dm.urlJsonLoad();
            
           
           
        }

        private void JsonLoadBtn_Click(object sender, EventArgs e)
        {
            dm.LoadJson();
            dm.numCount();
            for (int i = 0; i < dm.numCount().Length; i++)
            {
                Console.WriteLine($"번호 {i + 1} 나온 횟수 : {dm.numCount()[i]}개");
            }
            for (int i = 0; i < dm.numCount().Length; i++)
            {
                
                lottoNumlist.Items[i].Text="번호"+(i+1)+" : "+dm.numCount()[i] + "개";
            }
        }

        public void lottoWin()
        {

        }
    }
}

