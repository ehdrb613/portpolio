using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainInfo
{
    class DataManager
    {
        public static void printLog(string contents, string name = "trainHistory")
        {
            DirectoryInfo di = new DirectoryInfo("trainHistory");
            if (!di.Exists)
            {
                di.Create(); // 폴더 만들기
            }
            //앞에 @ 있으면 \ 한개만
            // @ 없으면 \\ 이렇게 해야지 1개로 인식함
            //using (StreamWriter writer = new StreamWriter(@"parkingHistory\parkingHistory.txt", true))
            using (StreamWriter writer = new StreamWriter(@"trainHistory\" + name + ".txt", true))
            {
                writer.WriteLine(contents);
            }
        }
    }
}
