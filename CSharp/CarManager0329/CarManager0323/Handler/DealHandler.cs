using CarManager0323.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0323.Handler
{
     class DealHandler
    {
        List<Deal> dealList = new List<Deal>();

        public DealHandler()
        {
            dealList.Add(new Deal("0000", null, null, null));
            //초기값이 없으면 에러 발생하기 때문에 0번쨰 공간 생성
        }
        public List<Deal> getDealList()
        {
            return dealList;
        }

        public void dealListClear()
        {
            dealList[0].Car = null;
            dealList[0].Customer = null;
            dealList[0].Seller = null;
            dealList[0].Date = "0000";

        }
    }
}
