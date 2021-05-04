
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarManager0323.DB;
using CarManager0323.UI;
using CarManager0323.Handler;
using CarManager0323.Model;

namespace CarManager0323
{
    public partial class MainForm : UIForm
    {
        DaoOracle db = new DaoOracle();
        DealHandler dHandler = new DealHandler();

        public MainForm()
        {
            InitializeComponent();
        }
        MainForm(DaoOracle oracle)
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //db.dbConnect();

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //db.dbClose();
        }

        private void creatTB_Click(object sender, EventArgs e)
        {
            db.createAllTB();
        }

        private void dropTB_Click(object sender, EventArgs e)
        {
            db.dropAllTB();
        }

        private void insertAll_Click(object sender, EventArgs e)
        {
            db.insertCar();
            db.insertCustomer();
            db.insertSeller();
            db.insertDeal();
        }

        private void insertCar_Click(object sender, EventArgs e)
        {
            new CarinsForm(db,dHandler).ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void insertCtm_Click(object sender, EventArgs e)
        {
            List<Deal> list = dHandler.getDealList();
            if(list[0].Customer != null)
            {
                MessageBox.Show("고객 정보가 이미 저장 되었습니다.");
                return;
            }
            new CustinsForm(db, dHandler).ShowDialog();
        }

        private void insertSeller_Click(object sender, EventArgs e)
        {
            List<Deal> list = dHandler.getDealList();
            if (list[0].Seller != null)
            {
                MessageBox.Show("판매자 정보가 이미 저장 되었습니다.");
                return;
            }
            new SellerinsForm(db, dHandler).ShowDialog();
        }

        private void insertDeal_Click(object sender, EventArgs e)
        {
            List<Deal> list = dHandler.getDealList();
            if(list[0].Car==null || list[0].Customer==null || list[0].Seller == null)
            {
                MessageBox.Show("구매 내역 정보가 누락되었습니다.");
                return;
            }
            db.insertDeal(list[0].Customer, list[0].Car, list[0].Seller);
            dHandler.dealListClear();
        }

        private void selectDeal_Click(object sender, EventArgs e)
        {
            /*List<Deal> list = dHandler.getDealList();

            if (list[0].Car == null || list[0].Customer == null || list[0].Seller == null)
            {
                MessageBox.Show(" 정보가 누락되었습니다.");
                return;
            }*/
            new DealView(db,dHandler).ShowDialog();
        }
    }
}
