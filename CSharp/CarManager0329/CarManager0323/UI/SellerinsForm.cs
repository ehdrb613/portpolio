using CarManager0323.DB;
using CarManager0323.Handler;
using CarManager0323.Model;
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

namespace CarManager0323.UI
{
    partial class SellerinsForm : UIForm
    {
       private DaoOracle oracle;
        private DealHandler dHandler;
        public SellerinsForm()
        {
            InitializeComponent();
        }

        public SellerinsForm(DaoOracle oracle)
        {
            InitializeComponent();
            this.oracle = oracle;
        }

        public SellerinsForm(DaoOracle oracle, DealHandler dHandler)
        {
            InitializeComponent();
            this.oracle = oracle;
            this.dHandler = dHandler;
        }
        private void addCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sellerOk_Click(object sender, EventArgs e)
        {

            if (sellName.Text.Trim() == "" || sellTel.Text.Trim() == "" || sellEmail.Text.Trim() == "" ||
               sellAgent.Text.Trim() == "" || sellPosition.Text.Trim() == "")
            {
                MessageBox.Show("누락된 정보가 있습니다.\n 다시 입력하세요");
                return;
            }
            /*  else
              {
                  Car car = new Car(carYear.Text, Int32.Parse(carMoney.Text), carModel.Text, carColor.Text);
                  oracle.insertCar(car);
              }*/
            List<Deal> list = dHandler.getDealList();
            try
            {
                Seller seller = new Seller(sellName.Text, sellTel.Text, sellEmail.Text,
               sellAgent.Text, sellPosition.Text);
                list[0].Seller = seller;
                oracle.insertSeller(seller);
                Close();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);

            }
           
        }
    }
}
