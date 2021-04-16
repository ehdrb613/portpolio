using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Managing_Car_Program
{
    public partial class Form1 : Form
    {
      


        public Form1()
        {
            InitializeComponent();
         

            dataGridView1.DataSource = Datamanger.Cars;
            textBox1.Text = Datamanger.Cars[0].parkingSpot.ToString();
            textBox2.Text = Datamanger.Cars[0].carNumber.ToString();
            textBox3.Text = Datamanger.Cars[0].driverName.ToString();
            textBox4.Text = Datamanger.Cars[0].phoneNumber.ToString();


            //List<parkingcar> cars = new List<parkingcar>();
            //cars.Add(new parkingcar() { parkingspot = 1,carnumber="30고9484",drivername="이동준",phonenumber="010-2940-1613",
            //parkingtime=DateTime.Now});

            //dataGridView1.DataSource = Cars;

            //cars.Add(new parkingcar());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StripLabel.Text= "지금은 : " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "입니다.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            writeLog("1번 버튼클릭");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            writeLog("2번 버튼클릭");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            writeLog("3번 버튼클릭",DateTime.Now.ToString("yyyy/MM/dd"));

        }

        private void writeLog(string contens)
        {
            //int a = 1;
            //MessageBox.Show(a.ToString("00"));//01 이라고 출력됨, 3자리 이상 그대로 출력
            string logContens = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}]{contens}";

            // 옛날 것이 가장 위에 올라가는 방식
            // 새로운 내용이 뒤에 추가가 되어서, 새로운 내용을 보려면
            // 밑으로 내려가야 함
            // listBox1.Items.Add(logContens);

            // 새로운 것이 가장 위에 올라가는 방식
            listBox1.Items.Insert(0, logContens);
           

            Datamanger.printLog(logContens);
        }

        private void writeLog(string contens, string date)
        {
            //int a = 1;
            //MessageBox.Show(a.ToString("00"));//01 이라고 출력됨, 3자리 이상 그대로 출력
            string logContens = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}]{contens}";

            // 옛날 것이 가장 위에 올라가는 방식
            // 새로운 내용이 뒤에 추가가 되어서, 새로운 내용을 보려면
            // 밑으로 내려가야 함
            // listBox1.Items.Add(logContens);

            // 새로운 것이 가장 위에 올라가는 방식
            listBox1.Items.Insert(0, logContens);


            Datamanger.printLog(logContens, date);
        }
    }
}
