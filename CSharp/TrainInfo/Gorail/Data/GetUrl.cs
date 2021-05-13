using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TrainInfo
{
    class GetUrl
    {

        public Dictionary<string, string> getAllTrain()
        {
            String allTrain = File.ReadAllText(@"./AllTrainCode.xml");
            XElement carXElement = XElement.Parse(allTrain);


            Dictionary<string, string> allTrains = new Dictionary<string, string>();

            foreach (var item in carXElement.Descendants("item"))
            {
                allTrains.Add(item.Element("nodeid").Value, item.Element("nodename").Value);
            }

            return allTrains;

        }


        public XElement request(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            string results = string.Empty;
            HttpWebResponse response;
            using (response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                results = reader.ReadToEnd();
            }
            XElement resultsXElement = XElement.Parse(results);
            return resultsXElement;
        }

        public static List<SearchTrain> st = new List<SearchTrain>();


        public void getStrtpntAlocFndTrainInfo(string date, string depPlaceId, string arrPlaceId, string[] trainName)
        {
            string url = "http://openapi.tago.go.kr/openapi/service/TrainInfoService/getStrtpntAlocFndTrainInfo"; // URL
            url += "?ServiceKey=gsClkYQY5L7abfYL7oyicjcCbDBXKny%2BiAx8pSuSBvevP%2B9XASascNCaoWJz%2F89mmb%2BHM53e2xibO743Dr%2BVVQ%3D%3D"; // Service Key
            url += "&numOfRows=500";
            url += "&pageNo=1";
            url += "&depPlaceId=" + depPlaceId;
            url += "&arrPlaceId=" + arrPlaceId;
            url += "&depPlandTime=" + date;

            st.Clear();
            foreach (var item in request(url).Descendants("item"))
            {
                // 현재 시간 부터 출발 시간 까지 남은 시간
                long remainTimeDay = long.Parse(item.Element("depplandtime").Value.Substring(6, 2)) - long.Parse(DateTime.Now.ToString("dd"));
                long remainTimeHour = long.Parse(item.Element("depplandtime").Value.Substring(8, 2)) - long.Parse(DateTime.Now.ToString("HH"));
                long remainTimeMin = long.Parse(item.Element("depplandtime").Value.Substring(10, 2)) - long.Parse(DateTime.Now.ToString("mm"));
                String remainTime;
                if (remainTimeDay == 0)
                {
                    if (remainTimeMin < 0)
                    {
                        remainTimeHour--;
                        remainTimeMin += 60;
                    }
                    if (remainTimeHour != 0)
                    {
                        remainTime = remainTimeHour + " 시간 " + remainTimeMin + " 분";
                    }
                    else
                    {
                        remainTime = remainTimeMin + " 분";
                    }
                }
                else
                {
                    if (remainTimeDay == 0)
                    {
                        if (remainTimeMin < 0)
                        {
                            remainTimeHour--;
                            remainTimeMin += 60;
                        }
                        if (remainTimeHour != 0)
                        {
                            remainTime = remainTimeHour + " 시간 " + remainTimeMin + " 분";
                        }
                        else
                        {
                            remainTime = remainTimeMin + " 분";
                        }
                    }
                    else
                    {
                            remainTimeHour += remainTimeDay * 24;

                        if (remainTimeMin < 0)
                        {
                            remainTimeHour--;
                            remainTimeMin += 60;
                        }
                        if (remainTimeHour != 0)
                        {
                            remainTime = remainTimeHour + " 시간 " + remainTimeMin + " 분";
                        }
                        else
                        {
                            remainTime = remainTimeMin + " 분";
                        }
                    }
                }


                // 소요 시간 (도착 시간 - 출발 시간)
                long durationHour = long.Parse(item.Element("arrplandtime").Value.Substring(8, 2)) - long.Parse(item.Element("depplandtime").Value.Substring(8, 2));
                long durationMin = long.Parse(item.Element("arrplandtime").Value.Substring(10, 2)) - long.Parse(item.Element("depplandtime").Value.Substring(10, 2));
                if (durationMin < 0)
                {
                    durationHour--;
                    durationMin += 60;
                }
                if (durationHour < 0)
                {
                    durationHour += 24;
                }
                String duration;
                if (durationHour != 0)
                {
                    duration = durationHour + " 시간 " + durationMin + " 분";
                }

                else
                {
                    duration = durationMin + " 분";
                }

                string tempAdultcharge = item.Element("adultcharge").Value;
                string tempArrplacename = item.Element("arrplacename").Value;
                string tempArrplandtime = item.Element("arrplandtime").Value.Substring(8, 2) + " : " + item.Element("arrplandtime").Value.Substring(10, 2);
                string tempDepplacename = item.Element("depplacename").Value;
                string tempDepplandtime = item.Element("depplandtime").Value.Substring(8, 2) + " : " + item.Element("depplandtime").Value.Substring(10, 2);
                string tempTraingradename = item.Element("traingradename").Value;
                string tempTrainno = item.Element("trainno").Value;
                string tempDuration = duration;
                if (trainName[0] == "all" || trainName[1] == "all")
                {
                    if (long.Parse(item.Element("depplandtime").Value) >= long.Parse(DateTime.Now.ToString("yyyyMMddHHmmss")))
                    {
                        SearchTrain tempSearchTrain = new SearchTrain()
                        {
                            adultcharge = remainTime,
                            arrplacename = tempArrplacename,
                            arrplandtime = tempArrplandtime,
                            depplacename = tempDepplacename,
                            depplandtime = tempDepplandtime,
                            traingradename = tempTraingradename,
                            trainno = tempTrainno,
                            duration = tempDuration

                        };
                        st.Add(tempSearchTrain);
                    }

                }
                else
                {
                    if ((tempTraingradename.Contains(trainName[0])) || (tempTraingradename.Contains(trainName[1])))
                    {
                        if (long.Parse(item.Element("depplandtime").Value) >= long.Parse(DateTime.Now.ToString("yyyyMMddHHmmss")))
                        {
                            SearchTrain tempSearchTrain = new SearchTrain()
                            {
                                adultcharge = remainTime,
                                arrplacename = tempArrplacename,
                                arrplandtime = tempArrplandtime,
                                depplacename = tempDepplacename,
                                depplandtime = tempDepplandtime,
                                traingradename = tempTraingradename,
                                trainno = tempTrainno,
                                duration = tempDuration
                            };
                            st.Add(tempSearchTrain);
                        }
                    }

                }

            }
        }


        public Dictionary<string, string> getCtyCodeList()
        {
            string url = "http://openapi.tago.go.kr/openapi/service/TrainInfoService/getCtyCodeList"; // URL
            url += "?ServiceKey=gsClkYQY5L7abfYL7oyicjcCbDBXKny%2BiAx8pSuSBvevP%2B9XASascNCaoWJz%2F89mmb%2BHM53e2xibO743Dr%2BVVQ%3D%3D"; // Service Key

            Dictionary<string, string> city = new Dictionary<string, string>();

            foreach (var item in request(url).Descendants("item"))
            {
                city.Add(item.Element("citycode").Value, item.Element("cityname").Value);
            }

            return city;

        }

        public Dictionary<string, string> getCtyAcctoTrainSttnList(string cityCode)
        {
            string url = "http://openapi.tago.go.kr/openapi/service/TrainInfoService/getCtyAcctoTrainSttnList"; // URL
            url += "?ServiceKey=gsClkYQY5L7abfYL7oyicjcCbDBXKny%2BiAx8pSuSBvevP%2B9XASascNCaoWJz%2F89mmb%2BHM53e2xibO743Dr%2BVVQ%3D%3D"; // Service Key
            url += "&numOfRows=200";
            url += "&pageNo=1";
            url += "&cityCode=" + cityCode;

            Dictionary<string, string> node = new Dictionary<string, string>();

            foreach (var item in request(url).Descendants("item"))
            {
                node.Add(item.Element("nodeid").Value, item.Element("nodename").Value);
            }
            
            return node;

        }

        public Dictionary<string, string> getVhcleKndList()
        {
            string url = "http://openapi.tago.go.kr/openapi/service/TrainInfoService/getVhcleKndList"; // URL
            url += "?ServiceKey=gsClkYQY5L7abfYL7oyicjcCbDBXKny%2BiAx8pSuSBvevP%2B9XASascNCaoWJz%2F89mmb%2BHM53e2xibO743Dr%2BVVQ%3D%3D"; // Service Key


            Console.WriteLine(request(url));
            Dictionary<string, string> vehicle = new Dictionary<string, string>();
            foreach (var item in request(url).Descendants("item"))
            {
                vehicle.Add(item.Element("vehiclekndid").Value, item.Element("vehiclekndnm").Value);
            }
            return vehicle;
        }
    }
}