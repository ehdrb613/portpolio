﻿
namespace Lotto2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelNum6 = new System.Windows.Forms.Label();
            this.labelNum5 = new System.Windows.Forms.Label();
            this.labelNum4 = new System.Windows.Forms.Label();
            this.labelNum3 = new System.Windows.Forms.Label();
            this.labelNum2 = new System.Windows.Forms.Label();
            this.labelNum1 = new System.Windows.Forms.Label();
            this.button_test = new System.Windows.Forms.Button();
            this.lottoJsonBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lottoNumlist = new System.Windows.Forms.ListView();
            this.JsonLoadBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.winNum = new System.Windows.Forms.Label();
            this.lottoChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lottoChart)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNum6
            // 
            this.labelNum6.AutoSize = true;
            this.labelNum6.Location = new System.Drawing.Point(564, 32);
            this.labelNum6.Name = "labelNum6";
            this.labelNum6.Size = new System.Drawing.Size(11, 12);
            this.labelNum6.TabIndex = 10;
            this.labelNum6.Text = "-";
            // 
            // labelNum5
            // 
            this.labelNum5.AutoSize = true;
            this.labelNum5.Location = new System.Drawing.Point(497, 32);
            this.labelNum5.Name = "labelNum5";
            this.labelNum5.Size = new System.Drawing.Size(11, 12);
            this.labelNum5.TabIndex = 11;
            this.labelNum5.Text = "-";
            // 
            // labelNum4
            // 
            this.labelNum4.AutoSize = true;
            this.labelNum4.Location = new System.Drawing.Point(430, 32);
            this.labelNum4.Name = "labelNum4";
            this.labelNum4.Size = new System.Drawing.Size(11, 12);
            this.labelNum4.TabIndex = 12;
            this.labelNum4.Text = "-";
            // 
            // labelNum3
            // 
            this.labelNum3.AutoSize = true;
            this.labelNum3.Location = new System.Drawing.Point(363, 32);
            this.labelNum3.Name = "labelNum3";
            this.labelNum3.Size = new System.Drawing.Size(11, 12);
            this.labelNum3.TabIndex = 13;
            this.labelNum3.Text = "-";
            // 
            // labelNum2
            // 
            this.labelNum2.AutoSize = true;
            this.labelNum2.Location = new System.Drawing.Point(296, 32);
            this.labelNum2.Name = "labelNum2";
            this.labelNum2.Size = new System.Drawing.Size(11, 12);
            this.labelNum2.TabIndex = 14;
            this.labelNum2.Text = "-";
            // 
            // labelNum1
            // 
            this.labelNum1.AutoSize = true;
            this.labelNum1.Location = new System.Drawing.Point(229, 32);
            this.labelNum1.Name = "labelNum1";
            this.labelNum1.Size = new System.Drawing.Size(11, 12);
            this.labelNum1.TabIndex = 15;
            this.labelNum1.Text = "-";
            // 
            // button_test
            // 
            this.button_test.Location = new System.Drawing.Point(34, 21);
            this.button_test.Name = "button_test";
            this.button_test.Size = new System.Drawing.Size(176, 23);
            this.button_test.TabIndex = 9;
            this.button_test.Text = "테스트";
            this.button_test.UseVisualStyleBackColor = true;
            this.button_test.Click += new System.EventHandler(this.button_test_Click);
            // 
            // lottoJsonBtn
            // 
            this.lottoJsonBtn.Location = new System.Drawing.Point(871, 619);
            this.lottoJsonBtn.Name = "lottoJsonBtn";
            this.lottoJsonBtn.Size = new System.Drawing.Size(237, 44);
            this.lottoJsonBtn.TabIndex = 18;
            this.lottoJsonBtn.Text = "최신 데이터 저장 ";
            this.lottoJsonBtn.UseVisualStyleBackColor = true;
            this.lottoJsonBtn.Click += new System.EventHandler(this.lottoJsonBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 30);
            this.label1.TabIndex = 19;
            this.label1.Text = "번호별 나온 횟수";
            // 
            // lottoNumlist
            // 
            this.lottoNumlist.BackColor = System.Drawing.Color.White;
            this.lottoNumlist.HideSelection = false;
            this.lottoNumlist.Location = new System.Drawing.Point(871, 135);
            this.lottoNumlist.Name = "lottoNumlist";
            this.lottoNumlist.Size = new System.Drawing.Size(250, 395);
            this.lottoNumlist.TabIndex = 20;
            this.lottoNumlist.UseCompatibleStateImageBehavior = false;
            this.lottoNumlist.View = System.Windows.Forms.View.SmallIcon;
            // 
            // JsonLoadBtn
            // 
            this.JsonLoadBtn.Location = new System.Drawing.Point(871, 557);
            this.JsonLoadBtn.Name = "JsonLoadBtn";
            this.JsonLoadBtn.Size = new System.Drawing.Size(237, 56);
            this.JsonLoadBtn.TabIndex = 21;
            this.JsonLoadBtn.Text = "저장된 json 불러오기";
            this.JsonLoadBtn.UseVisualStyleBackColor = true;
            this.JsonLoadBtn.Click += new System.EventHandler(this.JsonLoadBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Location = new System.Drawing.Point(239, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "당첨번호";
            // 
            // winNum
            // 
            this.winNum.AutoSize = true;
            this.winNum.Location = new System.Drawing.Point(310, 358);
            this.winNum.Name = "winNum";
            this.winNum.Size = new System.Drawing.Size(11, 12);
            this.winNum.TabIndex = 23;
            this.winNum.Text = "-";
            // 
            // lottoChart
            // 
            this.lottoChart.BackColor = System.Drawing.Color.Azure;
            this.lottoChart.BorderlineColor = System.Drawing.Color.Transparent;
            this.lottoChart.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.lottoChart.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            this.lottoChart.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            this.lottoChart.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.Name = "ChartArea1";
            this.lottoChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.lottoChart.Legends.Add(legend1);
            this.lottoChart.Location = new System.Drawing.Point(12, 388);
            this.lottoChart.Name = "lottoChart";
            this.lottoChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            series1.BackSecondaryColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.LabelBorderColor = System.Drawing.Color.Transparent;
            series1.Legend = "Legend1";
            series1.MarkerSize = 1;
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.lottoChart.Series.Add(series1);
            this.lottoChart.Size = new System.Drawing.Size(816, 284);
            this.lottoChart.TabIndex = 24;
            this.lottoChart.Text = "번호별 통계";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(1046, 21);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 25;
            this.exit.Text = "닫기";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1143, 684);
            this.ControlBox = false;
            this.Controls.Add(this.exit);
            this.Controls.Add(this.lottoChart);
            this.Controls.Add(this.winNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.JsonLoadBtn);
            this.Controls.Add(this.lottoNumlist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lottoJsonBtn);
            this.Controls.Add(this.labelNum6);
            this.Controls.Add(this.labelNum5);
            this.Controls.Add(this.labelNum4);
            this.Controls.Add(this.labelNum3);
            this.Controls.Add(this.labelNum2);
            this.Controls.Add(this.labelNum1);
            this.Controls.Add(this.button_test);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.lottoChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNum6;
        private System.Windows.Forms.Label labelNum5;
        private System.Windows.Forms.Label labelNum4;
        private System.Windows.Forms.Label labelNum3;
        private System.Windows.Forms.Label labelNum2;
        private System.Windows.Forms.Label labelNum1;
        private System.Windows.Forms.Button button_test;
        private System.Windows.Forms.Button lottoJsonBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lottoNumlist;
        private System.Windows.Forms.Button JsonLoadBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label winNum;
        private System.Windows.Forms.DataVisualization.Charting.Chart lottoChart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button exit;
    }
}
