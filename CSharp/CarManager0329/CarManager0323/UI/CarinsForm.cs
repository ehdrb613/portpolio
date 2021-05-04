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
     partial class CarinsForm : UIForm
    {
        private DaoOracle oracle;
        private DealHandler dHandler;
        public CarinsForm()
        {
            InitializeComponent();
        }
       public CarinsForm(DaoOracle oracle)
        {
            InitializeComponent();
            this.oracle = oracle;
        }

        public CarinsForm(DaoOracle oracle,DealHandler dHandler)
        {
            InitializeComponent();
            this.oracle = oracle;
            this.dHandler = dHandler;
        }


        private void addCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        

        private void CarOk_Click(object sender, EventArgs e)
        {
            if (carModel.Text.Trim() == "" || carMoney.Text.Trim() == "" || carColor.Text.Trim() == "" ||
                carColor.Text.Trim() == "")
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
                Car car = new Car(carYear.Text, 
                    Int32.Parse(carMoney.Text), 
                    carModel.Text, carColor.Text);
                if(list[0].Car == null) {
                    list[0].Car = car;
                    oracle.insertCar(car);
                }
                else 
                {
                    MessageBox.Show("차량 정보가 이미 저장 되었습니다.");
                }
                Close();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                
            }
           
        }
    }
}
