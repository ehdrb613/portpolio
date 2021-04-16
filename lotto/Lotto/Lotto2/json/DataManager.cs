using Lotto2.model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;//webclient 사용
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto2.json
{
    class DataManager
    {
       public static List<LottoNum> lottoNums = new List<LottoNum>();
      




        public static void urlJsonLoad()
        {
            lottoNums.Clear();
            using (WebClient wc = new WebClient())
            {

                int[] ltNum = new int[45];
                for (int i = 0; i < ltNum.Length; i++)
                    ltNum[i] = i + 1;
                int[] NumCount = new int[45];
                int start = 1; // 회차
                int icount = 0 + start;


                var addJson = "{\"Lotto\":[";//하나의 변수에 json 모두 저장
                var json = "";
                JObject jArray = new JObject();
                string[] ldlabel = { "", ".", "..","..." };//로딩중 ...
                int labelcount = 0;
                // 몇회 까지 있는지 먼저 확인
                Loading.loading.loadLabel1.Refresh();
                Loading.loading.loadLabel2.Refresh();
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

                    if (icount % 10 == 0)
                    {
                        Loading.loading.loadLabel1.Text = "로딩중" + ldlabel[labelcount];
                        Loading.loading.loadLabel1.Refresh();
                        labelcount++;
                        if (labelcount == 4)
                            labelcount = 0;
                    }

                }
                double percent = Math.Truncate((100.0 / icount)*10)/10;
                double sumpercent = percent;
                //Console.WriteLine(icount);
                //json 파일 저장 
                Console.WriteLine(percent);
                for (int i = start; i < icount; i++)
                {
                    wc.Encoding = Encoding.UTF8;
                    json = wc.DownloadString("https://www.dhlottery.co.kr/common.do?method=getLottoNumber&drwNo=" + i);

                    jArray = JObject.Parse(json);
                    if (i == icount - 1)
                    {
                        Loading.loading.loadLabel2.Text =  "100%";
                        Loading.loading.loadLabel2.Refresh();
                    }
                    else
                    {
                        Loading.loading.loadLabel2.Text = (int)sumpercent + "%";
                        Loading.loading.loadLabel2.Refresh();
                        if (i % 10 == 0) { 
                            Loading.loading.loadLabel1.Text = "저장중" + ldlabel[labelcount];
                            Loading.loading.loadLabel1.Refresh();
                            labelcount++;
                        }
                        if (labelcount == 4)
                            labelcount = 0;
                       
                        sumpercent += percent;
                    }
                    
                    Console.WriteLine(sumpercent);
                    //string.IsNullOrEmpty()//값이 null 이면 true

                    addJson += jArray;    // 하나의 텍스트에 다넣고 싶은데 .. 흠 나중에 불러올때 어떻게 해야 하는지 모르겠다...
                    //Console.WriteLine(addJson);
                    if (i < icount - 1)
                    {
                        addJson += ",\n";
                    }
                    
                    //Console.WriteLine(jArray);

                    /*string num1 = null;

                    num1 = jArray["drwtNo1"].ToString();
                    Console.WriteLine(num1);*/
                }


                addJson += "]\n}";

                //Console.WriteLine(addJson);
                File.WriteAllText(@"./LottoNum.json", addJson);
                MessageBox.Show("폴더에 json파일 저장이 완료되었습니다.");

                Loading.loading.Close();
                LoadJson();
            }
        }
       
        //경로에 있는 json 파일 불러오기
        public static void LoadJson()
        {
           

            //wc.DownloadFile("");
            try
            {
                lottoNums.Clear();
                string strLottoJson = File.ReadAllText(@"./LottoNum.json");
                JObject jsonObjectLotto = JObject.Parse(strLottoJson);

                //방법 1
               /* lottoNums = (from item in jsonObjectLotto["Lotto"]
                             select new LottoNum()
                             {
                                 drwtNo1 = int.Parse(item["drwtNo1"].ToString()),
                                 drwtNo2 = int.Parse(item["drwtNo2"].ToString()),
                                 drwtNo3 = int.Parse(item["drwtNo3"].ToString()),
                                 drwtNo4 = int.Parse(item["drwtNo4"].ToString()),
                                 drwtNo5 = int.Parse(item["drwtNo5"].ToString()),
                                 drwtNo6 = int.Parse(item["drwtNo6"].ToString()),
                                 bnusNo = int.Parse(item["bnusNo"].ToString()),
                                 drwNo = int.Parse(item["drwNo"].ToString()),
                                 drwNoDate = item["drwNoDate"].ToString()
                             }).ToList<LottoNum>();*/

                //방법 2
                foreach (var item in jsonObjectLotto["Lotto"])
                {
                    LottoNum tempLottoNum = new LottoNum() {

                        drwtNo1 = int.Parse(item["drwtNo1"].ToString()),
                        drwtNo2 = int.Parse(item["drwtNo2"].ToString()),
                        drwtNo3 = int.Parse(item["drwtNo3"].ToString()),
                        drwtNo4 = int.Parse(item["drwtNo4"].ToString()),
                        drwtNo5 = int.Parse(item["drwtNo5"].ToString()),
                        drwtNo6 = int.Parse(item["drwtNo6"].ToString()),
                        bnusNo = int.Parse(item["bnusNo"].ToString()),
                        drwNo = int.Parse(item["drwNo"].ToString()),
                        drwNoDate = item["drwNoDate"].ToString()
                    };
                    lottoNums.Add(tempLottoNum);
                }




                //drwNoDate


                /* for (int i = 0; i < lottoNums.Count; i++)
                 {
                     Console.WriteLine("---------------------");
                     Console.WriteLine(lottoNums[i].drwtNo1);
                     Console.WriteLine(lottoNums[i].drwtNo2);
                     Console.WriteLine(lottoNums[i].drwtNo3);
                     Console.WriteLine(lottoNums[i].drwtNo4);
                     Console.WriteLine(lottoNums[i].drwtNo5);
                     Console.WriteLine(lottoNums[i].drwtNo6);
                     Console.WriteLine(lottoNums[i].bnusNo);
                     Console.WriteLine(lottoNums[i].drwNo);
                     Console.WriteLine(lottoNums[i].drwNoDate);

                     Console.WriteLine("---------------------");
                 }
                lottoWin();*/
            }
            catch (Exception)
            {
                MessageBox.Show("LottoNum 파일이 누락되었습니다!!!");
                // CreateFile(); //파일 새로 만들기
                //SaveJson();
                //LoadJson();
            }

        }
        //Probability

        // 로또 번호별 당첨 횟수
        public int[] numCount()
        {
            int[] numct = new int[45];
            
            for (int i = 0; i < numct.Length; i++)
            {

                for (int j= 0; j < lottoNums.Count; j++)
                {
                   
                    if (lottoNums[j].drwtNo1 == (i + 1) || lottoNums[j].drwtNo2 == (i + 1) || lottoNums[j].drwtNo3 == (i + 1)
                        || lottoNums[j].drwtNo4 == (i + 1) || lottoNums[j].drwtNo5 == (i + 1)|| lottoNums[j].drwtNo6 == (i + 1)
                        || lottoNums[j].bnusNo==(i + 1))
                        numct[i] += 1;
                   
                }

            }
           /* for (int i = 0; i < numct.Length; i++)
            {
                Console.WriteLine($"번호 {i+1} 나온 횟수 : {numct[i]}개");
            }*/
            return numct;
        }

        //확인용
        public static void lottoWin()
        {
            //Console.Write(lottoNums[lottoNums.Count-1].drwNo + "회차");
            //Console.Write(lottoNums[lottoNums.Count - 1].drwtNo1 + ",");
            //Console.Write(lottoNums[lottoNums.Count - 1].drwtNo2 + ",");
            //Console.Write(lottoNums[lottoNums.Count - 1].drwtNo3 + ",");
            //Console.Write(lottoNums[lottoNums.Count - 1].drwtNo4 + ",");
            //Console.Write(lottoNums[lottoNums.Count - 1].drwtNo5 + ",");
            //Console.WriteLine(lottoNums[lottoNums.Count - 1].drwtNo6);

          
        }
    }
}
