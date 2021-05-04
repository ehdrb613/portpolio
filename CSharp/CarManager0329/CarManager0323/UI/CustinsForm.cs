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
     partial class CustinsForm : UIForm
    {
        private DaoOracle oracle;

        private DealHandler dHandler;

        public CustinsForm()
        {
            InitializeComponent();
        }

        public CustinsForm(DaoOracle oracle)
        {
            InitializeComponent();
            this.oracle = oracle;
        }

        public CustinsForm(DaoOracle oracle, DealHandler dHandler)
        {
            InitializeComponent();
            this.oracle = oracle;
            this.dHandler = dHandler;
        }

        private void addCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void custOk_Click(object sender, EventArgs e)
        {
            if (custName.Text.Trim() == "" || custAddr.Text.Trim() == "" || custTel.Text.Trim() == "" ||
                custEmail.Text.Trim() == "")
            {
                MessageBox.Show("누락된 정보가 있습니다.\n 다시 입력하세요");
                return;
            }
            List<Deal> list = dHandler.getDealList();
            try
            {
                Customer customer = new Customer(custName.Text, custAddr.Text, 
                    custTel.Text, custEmail.Text);
                list[0].Customer = customer;
                oracle.insertCustomer(customer);

                Close();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);

            }
           
        }
    }
}
