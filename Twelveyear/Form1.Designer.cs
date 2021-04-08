
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.year = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.month = new System.Windows.Forms.TextBox();
            this.day = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.calendarButton = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(124, 59);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(107, 29);
            this.year.TabIndex = 0;
            this.year.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.year.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HY동녘M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(25, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "태어난 년도";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("HY산B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(267, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 70);
            this.label2.TabIndex = 2;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox.Location = new System.Drawing.Point(469, 35);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(331, 415);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HY동녘M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(237, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "년";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar.Location = new System.Drawing.Point(48, 203);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 4;
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(28, 102);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(40, 29);
            this.month.TabIndex = 5;
            this.month.TextChanged += new System.EventHandler(this.month_TextChanged);
            // 
            // day
            // 
            this.day.Location = new System.Drawing.Point(104, 102);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(42, 29);
            this.day.TabIndex = 5;
            this.day.TextChanged += new System.EventHandler(this.day_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HY동녘M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(74, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "월";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("HY동녘M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(152, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "일";
            // 
            // calendarButton
            // 
            this.calendarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calendarButton.FillColor = System.Drawing.Color.Silver;
            this.calendarButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.calendarButton.Location = new System.Drawing.Point(182, 102);
            this.calendarButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.calendarButton.Name = "calendarButton";
            this.calendarButton.RectColor = System.Drawing.Color.Transparent;
            this.calendarButton.Size = new System.Drawing.Size(79, 29);
            this.calendarButton.Style = Sunny.UI.UIStyle.Custom;
            this.calendarButton.TabIndex = 6;
            this.calendarButton.Text = "찾기";
            this.calendarButton.Click += new System.EventHandler(this.calendarButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calendarButton);
            this.Controls.Add(this.day);
            this.Controls.Add(this.month);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.year);
            this.Name = "Form1";
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "띠 확인하기";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.TextBox month;
        private System.Windows.Forms.TextBox day;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Sunny.UI.UISymbolButton calendarButton;
    }
}

