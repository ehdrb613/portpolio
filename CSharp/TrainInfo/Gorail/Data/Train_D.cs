using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainInfo.Data
{
    class Train_D
    {
        public string cityname { set; get; }//도시이름
        public int citycode { set; get; }//도시코드

        public string nodeid { set; get; }//기차역ID
        public string nodename { set; get; }//기차역명
        public string vehiclekndid { set; get; }//차량종류코드
        public string vehiclekndnm { set; get; }//차량종류명
      
        public string traingradename { set; get; } //차량종류명
        public string depplandtime { set; get; } //차량출발시간
        public string arrplandtime { set; get; } //도착시간
        public string depplacename { set; get; } //출발지
        public string arrplacename { set; get; } //도착지
        public string adultcharge { set; get; } //운임
        public string trainno { set; get; } //열차번호

        public string outTime { set; get; } //도착시간
        public int timeCheck { set; get; } //정렬용
    }
}
