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
         

            dataGridView1.DataSource = Datamanager.Cars;
            textBox1.Text = Datamanager.Cars[0].parkingSpot.ToString();
            textBox2.Text = Datamanager.Cars[0].carNumber.ToString();
            textBox3.Text = Datamanager.Cars[0].driverName.ToString();
            textBox4.Text = Datamanager.Cars[0].phoneNumber.ToString();


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
            writeLog("주차 버튼 클릭");
            if (textBox1.Text.Trim() == "")//Trim 공백 제거 함수
            {
                MessageBox.Show("주차공간을 입력해라");
                writeLog("주차공간을 입력해라");
            }
            else if(textBox2.Text.Trim() == "")//차량번호를 입력하지 않은 경우
            {
                MessageBox.Show("차번호를 입력하세요");
            }
            else
            {
                try
                {
                    parkingcar car = Datamanager.Cars.Single((x) => x.parkingSpot.ToString() == textBox1.Text);
                    if (car.carNumber.Trim() != "")// 이미 차 정보가 저장되어 있음
                    {
                        MessageBox.Show("해당 공간에는 이미 차 있어요" + textBox1.Text);
                        writeLog("해당 공간에는 이미 차 있어요" + textBox1.Text);
                    }
                    else//아직 차 정보 없음
                    {

                        car.parkingSpot = int.Parse(textBox1.Text);
                        car.carNumber = textBox2.Text;
                        car.driverName = textBox3.Text;
                        car.phoneNumber = textBox4.Text;
                        car.parkingTime = DateTime.Now;

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = Datamanager.Cars;
                        Datamanager.Save();

                        string contents = $"주차 공간 {textBox1.Text}에 {textBox2}차를 주차함";
                        MessageBox.Show(contents);
                        writeLog(contents, DateTime.Now.ToString("yyyy_MM_dd"));

                    }
                }
                catch(Exception ex)
                {
                    string contents = "주차 할 수 없습니다." + textBox1.Text;
                    MessageBox.Show( contents);
                    writeLog(contents);
                    writeLog(ex.Message);
                    writeLog(ex.StackTrace);
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            writeLog("출차 버튼 클릭");
            if(textBox1.Text.Trim() == "")
            {
                MessageBox.Show("주차 공간 번호를 입력해주세요!");
                return;
            }
            //Single 없이 조회 하고 해당하는 데이터 변경
            try
            {
                for (int i = 0; i < Datamanager.Cars.Count; i++)
                {
                    if (Datamanager.Cars[i].parkingSpot.ToString() == textBox1.Text)
                    {
                        if(Datamanager.Cars[i].carNumber.Trim() == "")
                        {
                            MessageBox.Show("아직 차 없음");
                            writeLog("아직 차 없음");
                            break;
                        }
                        else
                        {
                            Datamanager.Cars[i].carNumber = "";
                            Datamanager.Cars[i].driverName = "";
                            Datamanager.Cars[i].phoneNumber = "";
                            Datamanager.Cars[i].parkingTime = new DateTime();
                            string contents = $"주차 공간 {textBox1.Text}에 {textBox2}차량 출차";
                            MessageBox.Show(contents);
                            writeLog(contents, DateTime.Now.ToString("yyyy_MM_dd"));
                            dataGridView1.DataSource = null;    //datagridview 의 데이터를 한번 지워주고
                            dataGridView1.DataSource = Datamanager.Cars; //다시 리셋
                            Datamanager.Save();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                writeLog("출차 안 됨");
                writeLog(ex.Message);
                writeLog(ex.StackTrace);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            try
            {
                string contents = "";
                parkingcar car = Datamanager.Cars.Single((x) => x.parkingSpot.ToString() == textBox5.Text);
                if (car.carNumber.Trim() == "")// 이미 차 정보가 저장되어 있음
                {
                    contents = $"{car.parkingSpot}번 주차 공간 있음 \n";
             
                    writeLog("조회-공간있음" + car.parkingSpot+ "번");
                }
                else 
                { 
                    contents = $"{car.parkingSpot}번 주차 공간 \n" +
                        $" 차 번호: {car.carNumber} \n" +
                        $" 차 주: {car.driverName}\n" +
                        $" 전화번호 : {car.phoneNumber}";
                }
                MessageBox.Show(contents);
                writeLog(contents, DateTime.Now.ToString("yyyy_MM_dd"));
            }
            catch (Exception ex)
            {
                writeLog("값이 없음");
                writeLog(ex.Message);
                writeLog(ex.StackTrace);

            }
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
           

            Datamanager.printLog(logContens);
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


            Datamanager.printLog(logContens, date);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                parkingcar temp = dataGridView1.CurrentRow.DataBoundItem as parkingcar; 
                //그리드뷰에 있는 데이터를 parkingcar로 자동으로 형변환 해서 넣어줌
                textBox1.Text = temp.parkingSpot.ToString();
                textBox2.Text = temp.carNumber;
                textBox3.Text = temp.driverName;
                textBox4.Text = temp.phoneNumber;
                textBox5.Text = temp.parkingSpot.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                writeLog(ex.Message);
                writeLog(ex.StackTrace);
                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'car_managerDataSet.park_car_db' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.park_car_dbTableAdapter.Fill(this.car_managerDataSet.park_car_db);

        }

        private void dbConnect_Click(object sender, EventArgs e)
        {
            MSDBHelper.DBConnect();
        }
    }
}
