
namespace TrainInfo
{
    partial class InfoSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Dept = new System.Windows.Forms.TextBox();
            this.textBox_Arrive = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.getUrlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchTrainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_change_dept_arrive = new System.Windows.Forms.Button();
            this.btn_search_train = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_dept_date = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.R_Tonggeun = new System.Windows.Forms.RadioButton();
            this.R_Mugoonhwa_Nuriro = new System.Windows.Forms.RadioButton();
            this.R_ITX_Chungchoon = new System.Windows.Forms.RadioButton();
            this.R_SaeMaeul_ITX_SaeMaeul = new System.Windows.Forms.RadioButton();
            this.R_KTX_SRT = new System.Windows.Forms.RadioButton();
            this.R_AllTrain = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.whatTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchTrainBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getUrlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchTrainBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchTrainBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(272, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 99;
            this.label1.Text = "출발역";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(272, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "도착역";
            // 
            // textBox_Dept
            // 
            this.textBox_Dept.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox_Dept.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_Dept.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.textBox_Dept.Location = new System.Drawing.Point(322, 59);
            this.textBox_Dept.Name = "textBox_Dept";
            this.textBox_Dept.Size = new System.Drawing.Size(100, 21);
            this.textBox_Dept.TabIndex = 2;
            this.textBox_Dept.Leave += new System.EventHandler(this.textBox_Dept_Leave);
            // 
            // textBox_Arrive
            // 
            this.textBox_Arrive.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox_Arrive.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_Arrive.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.textBox_Arrive.Location = new System.Drawing.Point(322, 114);
            this.textBox_Arrive.Name = "textBox_Arrive";
            this.textBox_Arrive.Size = new System.Drawing.Size(100, 21);
            this.textBox_Arrive.TabIndex = 3;
            this.textBox_Arrive.Leave += new System.EventHandler(this.textBox_Arrive_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(849, 332);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.durationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.searchTrainBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(843, 312);
            this.dataGridView1.TabIndex = 20;
            // 
            // btn_change_dept_arrive
            // 
            this.btn_change_dept_arrive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(212)))));
            this.btn_change_dept_arrive.ForeColor = System.Drawing.Color.White;
            this.btn_change_dept_arrive.Location = new System.Drawing.Point(351, 85);
            this.btn_change_dept_arrive.Name = "btn_change_dept_arrive";
            this.btn_change_dept_arrive.Size = new System.Drawing.Size(46, 23);
            this.btn_change_dept_arrive.TabIndex = 5;
            this.btn_change_dept_arrive.Text = "↕";
            this.btn_change_dept_arrive.UseVisualStyleBackColor = false;
            this.btn_change_dept_arrive.Click += new System.EventHandler(this.btn_change_dept_arrive_Click);
            // 
            // btn_search_train
            // 
            this.btn_search_train.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(212)))));
            this.btn_search_train.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_search_train.ForeColor = System.Drawing.Color.White;
            this.btn_search_train.Location = new System.Drawing.Point(442, 58);
            this.btn_search_train.Name = "btn_search_train";
            this.btn_search_train.Size = new System.Drawing.Size(75, 76);
            this.btn_search_train.TabIndex = 4;
            this.btn_search_train.Text = "조 회";
            this.btn_search_train.UseVisualStyleBackColor = false;
            this.btn_search_train.Click += new System.EventHandler(this.btn_search_train_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(19, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "출발일";
            // 
            // textBox_dept_date
            // 
            this.textBox_dept_date.Location = new System.Drawing.Point(68, 25);
            this.textBox_dept_date.Name = "textBox_dept_date";
            this.textBox_dept_date.Size = new System.Drawing.Size(100, 21);
            this.textBox_dept_date.TabIndex = 99;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(15, 58);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.R_Tonggeun);
            this.groupBox2.Controls.Add(this.R_Mugoonhwa_Nuriro);
            this.groupBox2.Controls.Add(this.R_ITX_Chungchoon);
            this.groupBox2.Controls.Add(this.R_SaeMaeul_ITX_SaeMaeul);
            this.groupBox2.Controls.Add(this.R_KTX_SRT);
            this.groupBox2.Controls.Add(this.R_AllTrain);
            this.groupBox2.Location = new System.Drawing.Point(595, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 189);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // R_Tonggeun
            // 
            this.R_Tonggeun.AutoSize = true;
            this.R_Tonggeun.Font = new System.Drawing.Font("나눔바른고딕", 9.75F);
            this.R_Tonggeun.Location = new System.Drawing.Point(24, 155);
            this.R_Tonggeun.Name = "R_Tonggeun";
            this.R_Tonggeun.Size = new System.Drawing.Size(73, 19);
            this.R_Tonggeun.TabIndex = 5;
            this.R_Tonggeun.Text = "통근열차";
            this.R_Tonggeun.UseVisualStyleBackColor = true;
            this.R_Tonggeun.CheckedChanged += new System.EventHandler(this.R_Tonggeun_CheckedChanged);
            // 
            // R_Mugoonhwa_Nuriro
            // 
            this.R_Mugoonhwa_Nuriro.AutoSize = true;
            this.R_Mugoonhwa_Nuriro.Font = new System.Drawing.Font("나눔바른고딕", 9.75F);
            this.R_Mugoonhwa_Nuriro.Location = new System.Drawing.Point(24, 129);
            this.R_Mugoonhwa_Nuriro.Name = "R_Mugoonhwa_Nuriro";
            this.R_Mugoonhwa_Nuriro.Size = new System.Drawing.Size(121, 19);
            this.R_Mugoonhwa_Nuriro.TabIndex = 4;
            this.R_Mugoonhwa_Nuriro.Text = "무궁화호 / 누리로";
            this.R_Mugoonhwa_Nuriro.UseVisualStyleBackColor = true;
            this.R_Mugoonhwa_Nuriro.CheckedChanged += new System.EventHandler(this.R_Mugoonhwa_Nuriro_CheckedChanged);
            // 
            // R_ITX_Chungchoon
            // 
            this.R_ITX_Chungchoon.AutoSize = true;
            this.R_ITX_Chungchoon.Font = new System.Drawing.Font("나눔바른고딕", 9.75F);
            this.R_ITX_Chungchoon.Location = new System.Drawing.Point(24, 77);
            this.R_ITX_Chungchoon.Name = "R_ITX_Chungchoon";
            this.R_ITX_Chungchoon.Size = new System.Drawing.Size(82, 19);
            this.R_ITX_Chungchoon.TabIndex = 3;
            this.R_ITX_Chungchoon.Text = "ITX - 청춘";
            this.R_ITX_Chungchoon.UseVisualStyleBackColor = true;
            this.R_ITX_Chungchoon.CheckedChanged += new System.EventHandler(this.R_ITX_Chungchoon_CheckedChanged);
            // 
            // R_SaeMaeul_ITX_SaeMaeul
            // 
            this.R_SaeMaeul_ITX_SaeMaeul.AutoSize = true;
            this.R_SaeMaeul_ITX_SaeMaeul.Font = new System.Drawing.Font("나눔바른고딕", 9.75F);
            this.R_SaeMaeul_ITX_SaeMaeul.Location = new System.Drawing.Point(24, 103);
            this.R_SaeMaeul_ITX_SaeMaeul.Name = "R_SaeMaeul_ITX_SaeMaeul";
            this.R_SaeMaeul_ITX_SaeMaeul.Size = new System.Drawing.Size(148, 19);
            this.R_SaeMaeul_ITX_SaeMaeul.TabIndex = 2;
            this.R_SaeMaeul_ITX_SaeMaeul.Text = "새마을호 / ITX-새마을";
            this.R_SaeMaeul_ITX_SaeMaeul.UseVisualStyleBackColor = true;
            this.R_SaeMaeul_ITX_SaeMaeul.CheckedChanged += new System.EventHandler(this.R_SaeMaeul_ITX_SaeMaeul_CheckedChanged);
            // 
            // R_KTX_SRT
            // 
            this.R_KTX_SRT.AutoSize = true;
            this.R_KTX_SRT.Font = new System.Drawing.Font("나눔바른고딕", 9.75F);
            this.R_KTX_SRT.Location = new System.Drawing.Point(24, 51);
            this.R_KTX_SRT.Name = "R_KTX_SRT";
            this.R_KTX_SRT.Size = new System.Drawing.Size(85, 19);
            this.R_KTX_SRT.TabIndex = 1;
            this.R_KTX_SRT.Text = "KTX / SRT";
            this.R_KTX_SRT.UseVisualStyleBackColor = true;
            this.R_KTX_SRT.CheckedChanged += new System.EventHandler(this.R_KTX_SRT_CheckedChanged);
            // 
            // R_AllTrain
            // 
            this.R_AllTrain.AutoSize = true;
            this.R_AllTrain.Checked = true;
            this.R_AllTrain.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.R_AllTrain.Location = new System.Drawing.Point(24, 25);
            this.R_AllTrain.Name = "R_AllTrain";
            this.R_AllTrain.Size = new System.Drawing.Size(49, 19);
            this.R_AllTrain.TabIndex = 0;
            this.R_AllTrain.TabStop = true;
            this.R_AllTrain.Text = "전체";
            this.R_AllTrain.UseVisualStyleBackColor = true;
            this.R_AllTrain.CheckedChanged += new System.EventHandler(this.R_AllTrain_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whatTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 583);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(875, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // whatTime
            // 
            this.whatTime.Name = "whatTime";
            this.whatTime.Size = new System.Drawing.Size(12, 17);
            this.whatTime.Text = "-";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 60000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "adultcharge";
            this.dataGridViewTextBoxColumn1.HeaderText = "남은 시간";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "depplacename";
            this.dataGridViewTextBoxColumn2.HeaderText = "출발 역";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 95;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "depplandtime";
            this.dataGridViewTextBoxColumn3.HeaderText = "출발 시간";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 110;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "arrplacename";
            this.dataGridViewTextBoxColumn4.HeaderText = "도착 역";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 95;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "arrplandtime";
            this.dataGridViewTextBoxColumn5.HeaderText = "도착 시간";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 110;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "traingradename";
            this.dataGridViewTextBoxColumn6.HeaderText = "기차 종류";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "trainno";
            this.dataGridViewTextBoxColumn7.HeaderText = "기차 번호";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "소요 시간";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.Width = 110;
            // 
            // searchTrainBindingSource1
            // 
            this.searchTrainBindingSource1.DataSource = typeof(TrainInfo.SearchTrain);
            // 
            // InfoSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(875, 605);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textBox_dept_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_search_train);
            this.Controls.Add(this.btn_change_dept_arrive);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_Arrive);
            this.Controls.Add(this.textBox_Dept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InfoSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "열차 조회";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getUrlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchTrainBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchTrainBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Dept;
        private System.Windows.Forms.TextBox textBox_Arrive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_change_dept_arrive;
        private System.Windows.Forms.Button btn_search_train;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_dept_date;
        private System.Windows.Forms.BindingSource searchTrainBindingSource;
        private System.Windows.Forms.BindingSource getUrlBindingSource;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton R_Tonggeun;
        private System.Windows.Forms.RadioButton R_Mugoonhwa_Nuriro;
        private System.Windows.Forms.RadioButton R_ITX_Chungchoon;
        private System.Windows.Forms.RadioButton R_SaeMaeul_ITX_SaeMaeul;
        private System.Windows.Forms.RadioButton R_KTX_SRT;
        private System.Windows.Forms.RadioButton R_AllTrain;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel whatTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.DataGridViewTextBoxColumn adultchargeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depplacenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depplandtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrplacenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrplandtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn traingradenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource searchTrainBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
    }
}

