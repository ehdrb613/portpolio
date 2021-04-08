using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_test_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello world");

            Random r = new Random();

            MessageBox.Show(r.Next(1, 46).ToString());

            labelNum1.Text = r.Next(10).ToString();
            labelNum2.Text = r.Next(10).ToString();
            labelNum3.Text = r.Next(10).ToString();
            labelNum4.Text = r.Next(10).ToString();
            labelNum5.Text = r.Next(10).ToString();
            labelNum6.Text = r.Next(10).ToString();

        }
    }
}
