using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Windows.Forms;


namespace Lotto
{
    public partial class Form1 : Form
    {
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




             public static List<LottoNum> loadLtNum = new List<LottoNum>();

         

            using (WebClient wc = new WebClient()) 
            {
                int[] ltNum = new int[45];
                for (int i = 0; i < ltNum.Length; i++)
                    ltNum[i] = i + 1;
                
                
                int[] NumCount = new int[45];

                int start = 900; // 회차
                int icount = 0+start;
                var addJson ="{\"Lotto\":[";//하나의 변수에 json 모두 저장
                var json = "";
                JObject jArray = new JObject();

                // 몇회 까지 있는지 먼저 확인
                while (true)
                {
                    json = wc.DownloadString("https://www.dhlottery.co.kr/common.do?method=getLottoNumber&drwNo=" + (icount++));
                    jArray = JObject.Parse(json);
                    if (jArray["returnValue"].ToString() == "fail")
                    {
                        icount--;
                        json = "";
                        break;
                    }
                    
                }

                Console.WriteLine(icount);
                //json 파일 저장 

                for (int i = start; i < icount; i++)
                {
                    wc.Encoding = Encoding.UTF8;
                    json = wc.DownloadString("https://www.dhlottery.co.kr/common.do?method=getLottoNumber&drwNo=" + i);

                    jArray = JObject.Parse(json);

                    //string.IsNullOrEmpty()//값이 null 이면 true

                    addJson += jArray;    // 하나의 텍스트에 다넣고 싶은데 .. 흠 나중에 불러올때 어떻게 해야 하는지 모르겠다...
                    Console.WriteLine(addJson);
                    if (i < icount-1)
                    {
                        addJson += ",\n";
                    }

                    //Console.WriteLine(jArray);
                    
                     /*string num1 = null;
                    
                     num1 = jArray["drwtNo1"].ToString();
                     Console.WriteLine(num1);*/
                }
           

                addJson += "]\n}";
                    
                    Console.WriteLine(addJson);
                File.WriteAllText(@"./LottoNum.json", addJson);



                
            }

            public void LoadJson()
            {
                try
                {
                    string strCarValueJson = File.ReadAllText(@"./LottoNum.json");
                    JObject jsonObjectCar = JObject.Parse(strCarValueJson);
                    Cars = (from item in jsonObjectCar["Lotto"]
                            select new ParkingCar()
                            {
                                ParkingSpot = int.Parse(item["parkingSpot"].ToString()),
                                CarNumber = item["carNumber"].ToString().Replace("{", "").Replace("}", ""),
                                DriverName = item["driverName"].ToString().Replace("{", "").Replace("}", ""),
                                PhoneNumber = item["phoneNumber"].ToString().Replace("{", "").Replace("}", ""),
                                ParkingTime = item["parkingTime"].ToString().Replace("{", "").Replace("}", "") == "" ? DateTime.Now : DateTime.Parse(item["parkingTime"].ToString())
                            }).ToList<ParkingCar>();
                }
                catch (Exception)
                {
                    MessageBox.Show("Cars 파일이 누락되었습니다!!!");
                    CreateFile(); //파일 새로 만들기
                    SaveJson();
                    LoadJson();
                }

            }


        }

           

    }
}

