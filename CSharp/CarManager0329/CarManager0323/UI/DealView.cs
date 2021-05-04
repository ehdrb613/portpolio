using CarManager0323.DB;
using CarManager0323.Handler;
using CarManager0323.Model;
using Oracle.ManagedDataAccess.Client;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManager0323.UI
{
     partial class DealView : UIForm
    {
        private DaoOracle oracle;
        private DealHandler dHandler;
        public DealView()
        {
            InitializeComponent();
        }

        public DealView(DaoOracle oracle,DealHandler dHandler)
        {
            InitializeComponent();
            this.oracle = oracle;
            this.dHandler = dHandler;
        }

        private void custDetail_Click(object sender, EventArgs e)
        {
            new CustDetailView().ShowDialog();
        }

        private void dealViewClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void initListView()
        {
            List<DealResult> list = oracle.selectDeal();

            /*string[] data = { "1", "홍길동", "그랜져", "40000000", "전우치", "21/3/31" };
            dealList.Items.Add(new ListViewItem(data));

            */
            if (list == null)
            {
                MessageBox.Show("데이터가 존재 하지 않습니다.");
                return;
            }

            for (int i = 0; i <list.Count; i++)
            {
                dealList.Items.Add(new ListViewItem(
                    new string[]
                    {
                       list[i].Count.ToString(), list[i].CustName, list[i].Model,
                       list[i].Price, list[i].SellName,list[i].Date
                    }
                    ));
            }


            setRowColor(dealList, Color.White, Color.LightGray);
            int index = dealList.Items.Count - 1;
            this.dealList.Items[index].Selected = true;
            dealList.Items[index].Focused = true;
            dealList.EnsureVisible(index);
        }

        public void initListView(OracleDataReader rd)
        {

            OracleDataReader read = rd;
            int count = 1;
            if(read == null)
            {
                MessageBox.Show("데이터가 존재 하지 않습니다.");
                return;
            }
            if (read.HasRows)
            {
                while (read.Read())
                {
                    string price = read["money"].ToString();
                    double dPrice = Convert.ToDouble(price);
                    NumberFormatInfo numformat =
                        new CultureInfo("ko-KR", false).NumberFormat;
                    price = dPrice.ToString("c", numformat);

                    dealList.Items.Add(new ListViewItem(
                   new string[]
                   {
                        count.ToString(),
                        read["ctmname"].ToString(),
                        read["model"].ToString(),
                        price.ToString(),
                        read["sellname"].ToString(),
                        read["trddate"].ToString()
                   }
                   ));
                    count++;

                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
           

            setRowColor(dealList, Color.White, Color.LightGray);
           /* int index = dealList.Items.Count - 1;*/
           /* this.dealList.Items[index].Selected = true;*/
           /* dealList.Items[index].Focused = true;
            dealList.EnsureVisible(index);*/

        }


        public void setRowColor(ListView list, Color color1, Color color2)
        {
            foreach (ListViewItem item in list.Items)
            {
                if ((item.Index % 2) == 0)
                {
                    item.BackColor = color1;
                }
                else
                {
                    item.BackColor = color2;
                }
            }

        }

        private void DealView_Load(object sender, EventArgs e)
        {     
            initListView(oracle.selectDeal2());
        }
    }
}
