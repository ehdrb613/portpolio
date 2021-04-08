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

namespace WindowsFormsApp1
{
    public partial class Form1 : UIForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (!System.Text.RegularExpressions.Regex.IsMatch(year.Text, "^[0-9]"))
            {
                year.Text = "";
            }
            else {

                Twelveyear();
                
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            //{
            //    e.Handled = true;
            //}

            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

            if (year.Text == "")
            {
                Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
                pictureBox.Image = bitmap;
                pictureBox.Invalidate();
                label2.Text = " ";
            }
        }

        public void Twelveyear()
        {

            int image = 13;

            string[] a = { "원숭이", "닭", "개", "돼지", "쥐", "소", "호랑이", "토끼", "용", "뱀", "말", "양" };

            string[] b = { "./img/9.png", "./img/10.png", "./img/11.png", "./img/12.png", "./img/1.png", "./img/2.png"
                , "./img/3.png", "./img/4.png", "./img/5.png", "./img/6.png", "./img/7.png", "./img/8.png",""};
            if (year.Text.Length > 0)
            {

                try
                {

                    int num = int.Parse(year.Text) % 12;
                    image = num;
                    label2.Text = a[num];
                    
                    //monthCalendar.SelectionRange.Start;

                }
                catch (Exception ee)
                {
                    year.Text = "";
                    MessageBox.Show("숫자만 입력해주세요");
                    return;
                }

            }
            else
            {
                MessageBox.Show("년도를 입력해주세요");
            }

            
            pictureBox.Load(@b[image]);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void month_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(month.Text, "^[1-9]"))
            {
                month.Text = "";
            }
        }

        private void calendarButton_Click(object sender, EventArgs e)
        {

            //달력 날짜 선택 캘린더 범위 넘어 가면 매세지
            try
            {
                if (year.Text.Trim().Length > 0 && month.Text.Trim().Length > 0 && day.Text.Trim().Length > 0)
                {

                    DateTime projectStart = new DateTime(int.Parse(year.Text), int.Parse(month.Text), int.Parse(day.Text));
                    DateTime projectEnd = new DateTime(int.Parse(year.Text), int.Parse(month.Text), int.Parse(day.Text));
                    monthCalendar.SelectionRange = new SelectionRange(projectStart, projectEnd);
                }
                else
                {
                    MessageBox.Show("비어있는 값이 있습니다");
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);

            }
        }

        private void day_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(day.Text, "^[0-9]"))
            {
                day.Text = "";
            }
        }
    }
}
