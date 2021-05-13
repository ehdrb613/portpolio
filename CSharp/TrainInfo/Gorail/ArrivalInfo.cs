using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainInfo
{
    public partial class ArrivalInfo : Form
    {
        public ArrivalInfo()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {

            DataManager_D.writeLog("대구 선택함");
            DataManager_D.AcctoTrainSttnList(DataManager_D.DAEGU, "DAEGU");
            InfoView_D id = new InfoView_D();
            id.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataManager_D.writeLog("전체 선택함");
            InfoView_D id = new InfoView_D();
            id.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataManager_D.writeLog("서울 선택함");
            DataManager_D.AcctoTrainSttnList(DataManager_D.SEOUL, "SEOUL");
            InfoView_D id = new InfoView_D();
            id.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            DataManager_D.writeLog("인천 선택함");
            DataManager_D.AcctoTrainSttnList(DataManager_D.INCHUN, "INCHUN");
            InfoView_D id = new InfoView_D();
            id.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataManager_D.writeLog("대전 선택함");
            DataManager_D.AcctoTrainSttnList(DataManager_D.DAEJEON, "DAEJEON");
            InfoView_D id = new InfoView_D();
            id.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataManager_D.writeLog("부산 선택함");
            DataManager_D.AcctoTrainSttnList(DataManager_D.BUSAN, "BUSAN");
            InfoView_D id = new InfoView_D();
            id.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataManager_D.writeLog("울산 선택함");
            DataManager_D.AcctoTrainSttnList(DataManager_D.ULSAN, "ULSAN");
            InfoView_D id = new InfoView_D();
            id.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataManager_D.writeLog("광주 선택함");
            DataManager_D.AcctoTrainSttnList(DataManager_D.GWANGJU, "GWANGJU");
            InfoView_D id = new InfoView_D();
            id.ShowDialog();
        }
    }
}
