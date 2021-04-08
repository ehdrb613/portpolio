using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Lotto.json
{
    class LottoNumJson
    {

        public void JsParse()
        {

            using (WebClient wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                string jsonURL = "https://www.dhlottery.co.kr/common.do?method=getLottoNumber&drwNo=957";

            }
        }
    }

  

}
