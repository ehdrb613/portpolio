using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainInfo
{
    public partial class InfoSearch : Form
    {
        static HttpClient client = new HttpClient();
        GetUrl get = new GetUrl();
        List<String> nodename = new List<string>();
        private void autoComplete(TextBox textBox)
        {
            var source = new AutoCompleteStringCollection();
            foreach (var item in get.getAllTrain())
            {
                nodename.Add(item.Value);
            }
            String[] nodeNameArr = nodename.ToArray();
            source.AddRange(nodeNameArr);
            textBox.AutoCompleteCustomSource = source;

            textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        public InfoSearch()
        {
            InitializeComponent();
            autoComplete(textBox_Dept);
            autoComplete(textBox_Arrive);
            textBox_dept_date.Text = monthCalendar1.SelectionRange.Start.ToString("yyyy.MM.dd");
        }


        private void btn_change_dept_arrive_Click(object sender, EventArgs e)
        {
            try
            {
                String temp_string = "";
                temp_string = textBox_Dept.Text;
                textBox_Dept.Text = textBox_Arrive.Text;
                textBox_Arrive.Text = temp_string;
                textBox_Dept_Leave(this, e);
                textBox_Arrive_Leave(this, e);
            }
            catch (Exception ex)
            {
                writeLog(ex.Message);
                writeLog(ex.StackTrace);

            }

        }

        String deptNodeId = "";
        String arrNodeId = "";


        private void searchTrain()
        {
            try
            {
                if (deptNodeId != "" && arrNodeId != "")
                {
                    string date = textBox_dept_date.Text.Replace(".", "");
                    get.getStrtpntAlocFndTrainInfo(date, deptNodeId, arrNodeId, trainFilter());
                    dataGridView1.DataSource = null;
                    if (GetUrl.st.Count == 0) MessageBox.Show("선택하신 경로의 기차는 없습니다.");
                    dataGridView1.DataSource = GetUrl.st;
                }
                else
                {
                    MessageBox.Show("출발역 및 도착역을 입력하세요");
                }

            }
            catch (Exception ex)
            {
                writeLog(ex.Message);
                writeLog(ex.StackTrace);
            }


        }
        private string[] trainFilter()
        {
            try
            {
                string[] trainName = new string[2];

                if (R_AllTrain.Checked)
                {
                    trainName[0] = "all";
                    trainName[1] = "all";
                }
                else if (R_KTX_SRT.Checked)
                {
                    trainName[0] = "KTX";
                    trainName[1] = "SRT";
                }
                else if (R_Mugoonhwa_Nuriro.Checked)
                {
                    trainName[0] = "무궁화호";
                    trainName[1] = "누리로";
                }
                else if (R_ITX_Chungchoon.Checked)
                {
                    trainName[0] = "ITX-청춘";
                    trainName[1] = " ";

                }
                else if (R_SaeMaeul_ITX_SaeMaeul.Checked)
                {
                    trainName[0] = "새마을";
                    trainName[1] = "ITX-새마을";
                }
                else if (R_Tonggeun.Checked)
                {
                    trainName[0] = "통근열차";
                    trainName[1] = " ";

                }
                return trainName;
            }
            catch (Exception ex)
            {
                string[] trainName = new string[2];
                writeLog(ex.Message);
                writeLog(ex.StackTrace);
                return trainName;
            }

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            try
            {
                textBox_dept_date.Text = monthCalendar1.SelectionRange.Start.ToString("yyyy.MM.dd");
            }
            catch (Exception ex)
            {
                writeLog(ex.Message);
                writeLog(ex.StackTrace);
            }
        }

        private void textBox_Dept_Leave(object sender, EventArgs e)
        {
            try
            {
                var node = get.getAllTrain().FirstOrDefault(x => x.Value == textBox_Dept.Text).Key;
                Console.WriteLine(node);
                deptNodeId = node;
            }
            catch (Exception ex)
            {
                writeLog(ex.Message);
                writeLog(ex.StackTrace);
            }

        }

        private void textBox_Arrive_Leave(object sender, EventArgs e)
        {
            try
            {
                var node = get.getAllTrain().FirstOrDefault(x => x.Value == textBox_Arrive.Text).Key;
                Console.WriteLine(node);
                arrNodeId = node;
            }
            catch (Exception ex)
            {
                writeLog(ex.Message);
                writeLog(ex.StackTrace);
            }

        }

        private void btn_search_train_Click(object sender, EventArgs e)
        {
            try
            {
                searchTrain();
            }
            catch (Exception ex)
            {
                writeLog(ex.Message);
                writeLog(ex.StackTrace);
            }

        }

        private void R_AllTrain_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                // radioBtn checkChanged 하면 중복 호출됨으로 조건문 걸어줌
                if (R_AllTrain.Checked) searchTrain();
            }
            catch (Exception ex)
            {
                writeLog(ex.Message);
                writeLog(ex.StackTrace);
            }

        }

        private void R_KTX_SRT_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (R_KTX_SRT.Checked) searchTrain();
            }
            catch (Exception ex)
            {
                writeLog(ex.Message);
                writeLog(ex.StackTrace);
            }

        }

        private void R_ITX_Chungchoon_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (R_ITX_Chungchoon.Checked) searchTrain();
            }
            catch (Exception ex)
            {
                writeLog(ex.Message);
                writeLog(ex.StackTrace);
            }


        }

        private void R_SaeMaeul_ITX_SaeMaeul_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (R_SaeMaeul_ITX_SaeMaeul.Checked) searchTrain();
            }
            catch (Exception ex)
            {
                writeLog(ex.Message);
                writeLog(ex.StackTrace);
            }


        }

        private void R_Mugoonhwa_Nuriro_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (R_Mugoonhwa_Nuriro.Checked) searchTrain();
            }
            catch (Exception ex)
            {
                writeLog(ex.Message);
                writeLog(ex.StackTrace);
            }


        }

        private void R_Tonggeun_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (R_Tonggeun.Checked) searchTrain();
            }
            catch (Exception ex)
            {
                writeLog(ex.Message);
                writeLog(ex.StackTrace);
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            whatTime.Text = "현재 시각 : " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
        private void writeLog(string contents)
        {
            string logContents = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}] {contents}";
            //listBox1.Items.Add(logContents);
            //옛날 것이 가장 위에 올라가는 방식

            //새로운 것이 가장 위에 올라가는 방식
            DataManager.printLog(logContents);
        }

        //1분마다 datagrid 재호출
        private void timer2_Tick(object sender, EventArgs e)
        {
            searchTrain();
        }
    }
}
