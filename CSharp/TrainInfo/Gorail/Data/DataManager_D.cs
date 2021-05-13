using TrainInfo.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TrainInfo
{
    class DataManager_D
    {
        static HttpClient client = new HttpClient();
        public static List<Train_D> trainGradeCode = new List<Train_D>();
        public static List<Train_D> TrainSttnCode = new List<Train_D>();
        public static List<Train_D> TrainInfo = new List<Train_D>();
        public static List<Train_D> AllTrainCode = new List<Train_D>();
        static string results = ""; //API 결과값 저장 변수

        public const int SEOUL = 11;
        public const int SEJOUNG = 12;
        public const int BUSAN = 21;
        public const int DAEGU = 22;
        public const int INCHUN = 23;
        public const int GWANGJU = 24;
        public const int DAEJEON = 25;
        public const int ULSAN = 26;
        public const int GYEONGGI = 31;
        public const int GANGWON = 32;
        public const int CHUNGCHEONGBUK = 33;
        public const int CHUNGCHEONGNAM = 34;
        public const int JEOLLABUK = 35;
        public const int JEOLLANAM = 36;
        public const int GYEONGSANGBUK = 37;
        public const int GYEONGSANGNAM = 38;

        public const string KTX = "00";//ktx
        public const string SAEMAEUL = "01";//새마을
        public const string MUGUNGHWA = "02";//무궁화
        public const string COMMUTER = "03";//통근열차
        public const string NURIRO = "04";//누리로
        public const string AREXDIRECT = "06";//AREX직통
        public const string KTX_SANCHUN1 = "07";//ktx 산천
        public const string ITX_SAEMAEUL = "08";//itx 새마을
        public const string ITX_CHUNGCHUN1 = "09";//itx 청춘
        public const string KTX_SANCHUN2 = "10";//ktx 산천2
        public const string ITX_CHUNGCHUN2 = "15";//itx 청춘2
        public const string KTX_LEEEM = "16";//ktx 이음
        public const string SRT = "17";//SRT

        static DataManager_D()
        {
            createDirectory();//맨 처음 여기로 이동 Arrivalinfo 에서
            getAllsttnCode();
            getCtyCodeList();
            getVhcleKndList();
        }

        //api 호출 명령어
        private static void request(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            results = string.Empty;
            HttpWebResponse response;
            using (response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                results = reader.ReadToEnd();
            }
        }

        #region api 정보 호출
        //모든 기차역 코드 정보
        public static void getAllsttnCode()
        {
            results = "";
            try
            {
               
                results = File.ReadAllText(@"./AllTrainCode.xml");
                Console.WriteLine("AllTrainCode.xml load 성공");

                XElement AllsttnCode = XElement.Parse(results);
                //도시 코드 저장
                foreach (var item in AllsttnCode.Descendants("item"))
                {
                    string tempNodeid = item.Element("nodeid").Value;
                    string tempNodename = item.Element("nodename").Value;

                    Train_D td = new Train_D()
                    {
                        nodeid = tempNodeid,
                        nodename = tempNodename
                    };

                    AllTrainCode.Add(td);
                }
                //확인용
                foreach (var item in AllTrainCode)
                {
                    Console.WriteLine(item.nodename);

                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                System.Windows.Forms.MessageBox.Show(ex.StackTrace);
                writeLog(ex.Message);
                writeLog(ex.StackTrace);

                throw;
            }
          


            
          
        }
        
        //지역 코드 정보
        public static void getCtyCodeList()
        {
            
              results = "";

            try
            {
                results = File.ReadAllText(@"./dg_xml/ctyCode.xml");
                Console.WriteLine("ctyCode.xml load 성공");
              
                XElement ctyCode = XElement.Parse(results);
                //도시 코드 저장
                foreach (var item in ctyCode.Descendants("item"))
                {
                    int tempCityCode = int.Parse(item.Element("citycode").Value);
                    string tempCtiyName = item.Element("cityname").Value;
                    
                    Train_D td = new Train_D()
                    {
                        citycode = tempCityCode,
                        cityname = tempCtiyName
                    };

                    trainGradeCode.Add(td);

                    
                }
                //확인용
                foreach (var item in trainGradeCode)
                {
                    Console.WriteLine(item.citycode);

                }
              
                
            }
            catch (Exception ex)
            {
                string url = "http://openapi.tago.go.kr/openapi/service/TrainInfoService/getCtyCodeList"; // URL
                url += "?ServiceKey=" + "0IL6R0F8vitdpbkttdCEX3Uxse07CQ1RRK3plz%2BdAkBSYkIESNMfTtVmQk%2BPUDXLPQfvB3iGXJYvPOS2brP4gQ%3D%3D"; // Service Key

                request(url);//api 호출

                XElement ctyCode = XElement.Parse(results);
                File.WriteAllText(@"./dg_xml/ctyCode.xml", ctyCode.ToString());

                writeLog(ex.Message);
                writeLog(ex.StackTrace);
                getCtyCodeList();//다시 호출
            }


        }

        //기차 종류 코드 정보
        public static void getVhcleKndList()
        {
            results = "";
            try
            {
                results = File.ReadAllText(@"./dg_xml/VhcleKnd.xml");
                Console.WriteLine("VhcleKnd.xml load 성공");
                Console.WriteLine(results);
            }
            catch(Exception ex)
            {

           
            string url = "http://openapi.tago.go.kr/openapi/service/TrainInfoService/getVhcleKndList"; // URL
            url += "?ServiceKey=" + "0IL6R0F8vitdpbkttdCEX3Uxse07CQ1RRK3plz%2BdAkBSYkIESNMfTtVmQk%2BPUDXLPQfvB3iGXJYvPOS2brP4gQ%3D%3D"; // Service Key

                request(url);//api 호출


                XElement VhcleKnd = XElement.Parse(results);
               // Console.WriteLine(VhcleKnd);
                File.WriteAllText(@"./dg_xml/VhcleKnd.xml", VhcleKnd.ToString());//Api 불러온 정보 저장


                writeLog(ex.Message);
                writeLog(ex.StackTrace);
                getVhcleKndList();//다시 호출
            }
        }
        //기차역이름 코드 정보
        public static void AcctoTrainSttnList(int city,string cityName)
        {
            results = "";

            try
            {
               
                results = File.ReadAllText(@"./dg_xml/TrainSttnList_" + cityName+".xml");
                XElement TrainSttn = XElement.Parse(results);
                Console.WriteLine("TrainSttnList.xml load 성공");
                Console.WriteLine(TrainSttn);
                
                //도시 코드 저장
                foreach (var item in TrainSttn.Descendants("item"))
                {
                    string tempNodeid = item.Element("nodeid").Value;
                    string tempNodename = item.Element("nodename").Value;

                    Train_D td = new Train_D()
                    {
                        nodeid = tempNodeid,
                        nodename = tempNodename
                    };

                    TrainSttnCode.Add(td);


                }
                //확인용
                foreach (var item in TrainSttnCode)
                {
                    Console.WriteLine(item.nodename+item.nodeid);

                }

            }
            catch (Exception ex)
            {

                string url = "http://openapi.tago.go.kr/openapi/service/TrainInfoService/getCtyAcctoTrainSttnList"; // URL
                url += "?ServiceKey=" + "0IL6R0F8vitdpbkttdCEX3Uxse07CQ1RRK3plz%2BdAkBSYkIESNMfTtVmQk%2BPUDXLPQfvB3iGXJYvPOS2brP4gQ%3D%3D"; // Service Key
                url += "&numOfRows=104";
                url += "&pageNo=1";
                url += "&cityCode=" + city;

                request(url);//api 호출


                XElement TrainSttn = XElement.Parse(results);
                File.WriteAllText(@"./dg_xml/TrainSttnList_" + cityName + ".xml",TrainSttn.ToString());
                //Console.WriteLine(TrainSttn);
                writeLog(ex.Message);
                writeLog(ex.StackTrace);

                AcctoTrainSttnList(city, cityName); // 다시 실행
            }
        
           

        }

        //출발도착정보 ALL 사용안하는중
        public static void ShowInfo(string depPlaceId, string arrPlaceId)
        {
            results = "";
            TrainInfo.Clear();

            string url = "http://openapi.tago.go.kr/openapi/service/TrainInfoService/getStrtpntAlocFndTrainInfo"; // URL
            url += "?ServiceKey=" + "0IL6R0F8vitdpbkttdCEX3Uxse07CQ1RRK3plz%2BdAkBSYkIESNMfTtVmQk%2BPUDXLPQfvB3iGXJYvPOS2brP4gQ%3D%3D"; // Service Key
            url += "&numOfRows=104";
            url += "&depPlaceId=" + depPlaceId;
            url += "&arrPlaceId=" + arrPlaceId;
            url += "&depPlandTime=" + DateTime.Now.ToString("yyyyMMdd");


            request(url);//api 호출


            XElement ShowInfo = XElement.Parse(results);
            //도시 코드 저장
            foreach (var item in ShowInfo.Descendants("item"))
            {

                string tmpTraingradename = item.Element("traingradename").Value;//차량종류명
                DateTime tmpDepplandtime = DateTime.ParseExact(item.Element("depplandtime").Value, "yyyyMMddHHmmss", null);//차량출발시간
                DateTime tmpArrplandtime = DateTime.ParseExact(item.Element("arrplandtime").Value,"yyyyMMddHHmmss", null);//도착시간
                string tmpDepplacename = item.Element("depplacename").Value;//출발지
                string tmpArrplacename = item.Element("arrplacename").Value;//도착지
                string tmpTrainno = item.Element("trainno").Value;//열차번호
                string tmpNodename = item.Element("arrplacename").Value + "역";//도착지


                //도착시간 구하는
                string test = DateTime.Now.ToString("yyyyMMddHHmmss");
                DateTime now = DateTime.ParseExact(test, "yyyyMMddHHmmss", System.Globalization.CultureInfo.InvariantCulture);
                TimeSpan timeSpan = tmpArrplandtime - now ; //
                int timeHoure = timeSpan.Hours;
                int timeMinutes = timeSpan.Minutes;
                Console.WriteLine("시간 :" + item.Element("arrplandtime"));

                Train_D td = new Train_D()
                {
                    traingradename = tmpTraingradename,
                    depplandtime = item.Element("depplandtime").Value.Substring(4, 2)+"월"+
                    item.Element("depplandtime").Value.Substring(6, 2)+"일  "+
                    item.Element("depplandtime").Value.Substring(8, 2) + ":" +
                    item.Element("depplandtime").Value.Substring(10, 2),
                    arrplandtime = item.Element("arrplandtime").Value.Substring(4, 2) + "월" +
                    item.Element("arrplandtime").Value.Substring(6, 2) + "일  " +
                    item.Element("arrplandtime").Value.Substring(8, 2) + ":" +
                    item.Element("arrplandtime").Value.Substring(10, 2),
                    // depplandtime = tmpDepplandtime.Substring(8, 2) + ":" + tmpDepplandtime.Substring(10, 2),
                    //arrplandtime = tmpArrplandtime.Substring(8, 2) + ":" + tmpArrplandtime.Substring(10, 2),
                    depplacename = tmpDepplacename,
                    arrplacename = tmpArrplacename,
                    trainno = tmpTrainno,
                    nodename = tmpNodename,
                    outTime = (timeHoure * 60) + timeMinutes + "분",
                    timeCheck = (timeHoure * 60) + timeMinutes
                };
                if ((timeHoure * 60) + timeMinutes >= 0) 
                {
                    if ((timeHoure * 60) + timeMinutes == 0)
                    {
                        td.outTime = "도착";
                    }
                    TrainInfo.Add(td);
                }
                //Console.WriteLine(ShowInfo);
                File.WriteAllText(@"./dg_xml/ShowInfo[" + depPlaceId+"]["+ arrPlaceId + "]["+ DateTime.Now.ToString("yyyyMMdd") +"].xml", ShowInfo.ToString());

            }
            TrainInfo = TrainInfo.OrderBy(x => x.timeCheck).ToList();

            //확인용
            foreach (var item in TrainInfo)
            {
                Console.WriteLine(item.timeCheck);

            }

        }

        //출발도착정보 기차종류 ALL,선택 (오버로딩)
        public static void ShowInfo(string depPlaceId, string arrPlaceId, List<string> gradeCode)
        {
            try
            {
                results = "";
                TrainInfo.Clear();

                foreach (var it in gradeCode)//gradeCode 기차코드 별 API 불러옴
                {
                    string url = "http://openapi.tago.go.kr/openapi/service/TrainInfoService/getStrtpntAlocFndTrainInfo"; // URL
                    url += "?ServiceKey=" + "0IL6R0F8vitdpbkttdCEX3Uxse07CQ1RRK3plz%2BdAkBSYkIESNMfTtVmQk%2BPUDXLPQfvB3iGXJYvPOS2brP4gQ%3D%3D"; // Service Key
                    url += "&numOfRows=104";
                    url += "&depPlaceId=" + depPlaceId;
                    url += "&arrPlaceId=" + arrPlaceId;
                    url += "&depPlandTime=" + DateTime.Now.ToString("yyyyMMdd");

                    if (it != "ALL")//ALL 아니면 기차코드 URL 입력
                    {
                        url += "&trainGradeCode=" + it;
                    }
                    Console.WriteLine(url);
                    request(url);//api 호출

                    XElement ShowInfo = XElement.Parse(results);
                    //열차정보 저장
                    foreach (var item in ShowInfo.Descendants("item"))
                    {

                        string tmpTraingradename = item.Element("traingradename").Value;//차량종류명
                        DateTime tmpDepplandtime = DateTime.ParseExact(item.Element("depplandtime").Value, "yyyyMMddHHmmss", null);//차량출발시간
                        DateTime tmpArrplandtime = DateTime.ParseExact(item.Element("arrplandtime").Value, "yyyyMMddHHmmss", null);//도착시간
                        string tmpDepplacename = item.Element("depplacename").Value;//출발지
                        string tmpArrplacename = item.Element("arrplacename").Value;//도착지
                        string tmpTrainno = item.Element("trainno").Value;//열차번호
                        string tmpNodename = item.Element("arrplacename").Value + "역";//도착지
                        //도착시간 구하는
                        string test = DateTime.Now.ToString("yyyyMMddHHmmss");
                        DateTime now = DateTime.ParseExact(test, "yyyyMMddHHmmss", System.Globalization.CultureInfo.InvariantCulture);
                        TimeSpan timeSpan = tmpArrplandtime - now;
                        int timeHoure = timeSpan.Hours;
                        int timeMinutes = timeSpan.Minutes;
                        Console.WriteLine("시간 :" + item.Element("arrplandtime"));

                        Train_D td = new Train_D()
                        {
                            traingradename = tmpTraingradename,
                            depplandtime = item.Element("depplandtime").Value.Substring(4, 2) + "월" +
                                item.Element("depplandtime").Value.Substring(6, 2) + "일  " +
                                item.Element("depplandtime").Value.Substring(8, 2) + ":" +
                                item.Element("depplandtime").Value.Substring(10, 2),
                            arrplandtime = item.Element("arrplandtime").Value.Substring(4, 2) + "월" +
                                item.Element("arrplandtime").Value.Substring(6, 2) + "일  " +
                                item.Element("arrplandtime").Value.Substring(8, 2) + ":" +
                                item.Element("arrplandtime").Value.Substring(10, 2),
                            depplacename = tmpDepplacename,
                            arrplacename = tmpArrplacename,
                            trainno = tmpTrainno,
                            nodename = tmpNodename,
                            outTime = (timeHoure * 60) + timeMinutes + "분",
                            timeCheck = (timeHoure * 60) + timeMinutes
                        };
                        if ((timeHoure * 60) + timeMinutes >= 0)
                        {
                            if ((timeHoure * 60) + timeMinutes == 0)
                            {
                                td.outTime = "도착";
                            }
                            TrainInfo.Add(td);
                        }
                        //Console.WriteLine(ShowInfo);
                      

                        url = ""; //초기화
                    }

                }
                Console.WriteLine(TrainInfo[0].depplacename);
                save(); // xml 정보저장
                writeLog("출발역:" + TrainInfo[0].depplacename + "_도착역:" + TrainInfo[0].arrplacename);
                TrainInfo = TrainInfo.OrderBy(item => item.timeCheck).ToList();

                //확인용
                foreach (var item in TrainInfo)
                {
                    Console.WriteLine(item.timeCheck);

                }
                
            }
            catch (Exception ex)
            {
                writeLog(ex.Message);
                writeLog(ex.StackTrace);

            }


        }

        #endregion api 정보호출

        public static void save()
        {
            string xmlOutput = "";
            xmlOutput += "<items>\n";
            foreach (var item in TrainInfo)
            {
                xmlOutput += "<itme>\n";
                xmlOutput += $"<traingradename>{item.traingradename}</traingradename>";
                xmlOutput += $"<depplandtime>{item.depplandtime}</depplandtime>";
                xmlOutput += $"<arrplandtime>{item.arrplandtime}</arrplandtime>";
                xmlOutput += $"<depplacename>{item.depplacename}</depplacename>";
                xmlOutput += $"<arrplacename>{item.arrplacename}</arrplacename>";
                xmlOutput += $"<trainno>{item.trainno}</trainno>";
                xmlOutput += $"<nodename>{item.nodename}</nodename>";
                xmlOutput += $"<outTime>{item.outTime}</outTime>";
                xmlOutput += "</itme>\n";
                
            }
            xmlOutput += "</items>\n";

            File.WriteAllText(@"./dg_xml/[" + DateTime.Now.ToString("yyyyMMdd") + "]ShowInfo[" + TrainInfo[0].depplacename + "][" + TrainInfo[0].arrplacename + "].xml", xmlOutput);



        }

        public static void createDirectory()
        {
            DirectoryInfo di = new DirectoryInfo("dg_xml");
            //if(di.Exists == false)
            if (!di.Exists)
            {
                di.Create();//폴더 만들기
            }
        }

        //로그저장
        //두번째 파라미터를 넣지 않으면 name에는 dg_log가 들어감
        public static void printLog(string contents, string name = "dg_log")
        {
            DirectoryInfo di = new DirectoryInfo("dg_log");
            //if(di.Exists == false)
            if (!di.Exists)
            {
                di.Create();//폴더 만들기
            }

                  using (StreamWriter writer = new StreamWriter(@"dg_log\" + name + ".txt", true))
            {
                writer.WriteLine(contents);
            }
        }

        //로그 데이터 받음
        public static void writeLog(string contens)
        {
         
            string logContens = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}]{contens}";//로그내용
            string date = $"[{DateTime.Now.ToString("yyyy_MM_dd")}]";//로그이름txt
            
            DataManager_D.printLog(logContens, date);
        }

    }

   


}
