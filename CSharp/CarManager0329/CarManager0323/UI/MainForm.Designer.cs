
namespace CarManager0323
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.creatTB = new CxFlatUI.Controls.CxFlatButton();
            this.dropTB = new CxFlatUI.Controls.CxFlatButton();
            this.cxFlatPictureBox1 = new CxFlatUI.CxFlatPictureBox();
            this.cxFlatPictureBox2 = new CxFlatUI.CxFlatPictureBox();
            this.insertAll = new CxFlatUI.Controls.CxFlatButton();
            this.insertCar = new CxFlatUI.Controls.CxFlatButton();
            this.insertCtm = new CxFlatUI.Controls.CxFlatButton();
            this.insertSeller = new CxFlatUI.Controls.CxFlatButton();
            this.insertDeal = new CxFlatUI.Controls.CxFlatButton();
            this.exit = new CxFlatUI.Controls.CxFlatButton();
            this.selectDeal = new CxFlatUI.Controls.CxFlatButton();
            this.appHelp = new CxFlatUI.Controls.CxFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // creatTB
            // 
            this.creatTB.ButtonType = CxFlatUI.ButtonType.Default;
            this.creatTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.creatTB.Location = new System.Drawing.Point(263, 340);
            this.creatTB.Name = "creatTB";
            this.creatTB.Size = new System.Drawing.Size(156, 34);
            this.creatTB.TabIndex = 0;
            this.creatTB.Text = "테이블생성";
            this.creatTB.TextColor = System.Drawing.Color.White;
            this.creatTB.Click += new System.EventHandler(this.creatTB_Click);
            // 
            // dropTB
            // 
            this.dropTB.ButtonType = CxFlatUI.ButtonType.Default;
            this.dropTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dropTB.Location = new System.Drawing.Point(263, 380);
            this.dropTB.Name = "dropTB";
            this.dropTB.Size = new System.Drawing.Size(156, 34);
            this.dropTB.TabIndex = 0;
            this.dropTB.Text = "테이블삭제";
            this.dropTB.TextColor = System.Drawing.Color.White;
            this.dropTB.Click += new System.EventHandler(this.dropTB_Click);
            // 
            // cxFlatPictureBox1
            // 
            this.cxFlatPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.cxFlatPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("cxFlatPictureBox1.Image")));
            this.cxFlatPictureBox1.Location = new System.Drawing.Point(70, 332);
            this.cxFlatPictureBox1.Name = "cxFlatPictureBox1";
            this.cxFlatPictureBox1.Size = new System.Drawing.Size(176, 89);
            this.cxFlatPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cxFlatPictureBox1.TabIndex = 1;
            this.cxFlatPictureBox1.TabStop = false;
            // 
            // cxFlatPictureBox2
            // 
            this.cxFlatPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.cxFlatPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("cxFlatPictureBox2.Image")));
            this.cxFlatPictureBox2.Location = new System.Drawing.Point(53, 35);
            this.cxFlatPictureBox2.Name = "cxFlatPictureBox2";
            this.cxFlatPictureBox2.Size = new System.Drawing.Size(396, 352);
            this.cxFlatPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cxFlatPictureBox2.TabIndex = 2;
            this.cxFlatPictureBox2.TabStop = false;
            // 
            // insertAll
            // 
            this.insertAll.ButtonType = CxFlatUI.ButtonType.Default;
            this.insertAll.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.insertAll.Location = new System.Drawing.Point(525, 50);
            this.insertAll.Name = "insertAll";
            this.insertAll.Size = new System.Drawing.Size(205, 37);
            this.insertAll.TabIndex = 3;
            this.insertAll.Text = "모두클릭";
            this.insertAll.TextColor = System.Drawing.Color.White;
            this.insertAll.Click += new System.EventHandler(this.insertAll_Click);
            // 
            // insertCar
            // 
            this.insertCar.ButtonType = CxFlatUI.ButtonType.Default;
            this.insertCar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.insertCar.Location = new System.Drawing.Point(525, 93);
            this.insertCar.Name = "insertCar";
            this.insertCar.Size = new System.Drawing.Size(205, 37);
            this.insertCar.TabIndex = 3;
            this.insertCar.Text = "차량 정보 추가";
            this.insertCar.TextColor = System.Drawing.Color.White;
            this.insertCar.Click += new System.EventHandler(this.insertCar_Click);
            // 
            // insertCtm
            // 
            this.insertCtm.ButtonType = CxFlatUI.ButtonType.Default;
            this.insertCtm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.insertCtm.Location = new System.Drawing.Point(525, 136);
            this.insertCtm.Name = "insertCtm";
            this.insertCtm.Size = new System.Drawing.Size(205, 37);
            this.insertCtm.TabIndex = 3;
            this.insertCtm.Text = "고객 정보 추가";
            this.insertCtm.TextColor = System.Drawing.Color.White;
            this.insertCtm.Click += new System.EventHandler(this.insertCtm_Click);
            // 
            // insertSeller
            // 
            this.insertSeller.ButtonType = CxFlatUI.ButtonType.Default;
            this.insertSeller.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.insertSeller.Location = new System.Drawing.Point(525, 179);
            this.insertSeller.Name = "insertSeller";
            this.insertSeller.Size = new System.Drawing.Size(205, 37);
            this.insertSeller.TabIndex = 3;
            this.insertSeller.Text = "판매자 정보 추가";
            this.insertSeller.TextColor = System.Drawing.Color.White;
            this.insertSeller.Click += new System.EventHandler(this.insertSeller_Click);
            // 
            // insertDeal
            // 
            this.insertDeal.ButtonType = CxFlatUI.ButtonType.Default;
            this.insertDeal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.insertDeal.Location = new System.Drawing.Point(525, 222);
            this.insertDeal.Name = "insertDeal";
            this.insertDeal.Size = new System.Drawing.Size(205, 37);
            this.insertDeal.TabIndex = 3;
            this.insertDeal.Text = "거래 정보 추가";
            this.insertDeal.TextColor = System.Drawing.Color.White;
            this.insertDeal.Click += new System.EventHandler(this.insertDeal_Click);
            // 
            // exit
            // 
            this.exit.ButtonType = CxFlatUI.ButtonType.Default;
            this.exit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.exit.Location = new System.Drawing.Point(525, 351);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(205, 37);
            this.exit.TabIndex = 3;
            this.exit.Text = "프로그램 종료";
            this.exit.TextColor = System.Drawing.Color.White;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // selectDeal
            // 
            this.selectDeal.ButtonType = CxFlatUI.ButtonType.Default;
            this.selectDeal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.selectDeal.Location = new System.Drawing.Point(525, 265);
            this.selectDeal.Name = "selectDeal";
            this.selectDeal.Size = new System.Drawing.Size(205, 37);
            this.selectDeal.TabIndex = 3;
            this.selectDeal.Text = "거래 정보 보기";
            this.selectDeal.TextColor = System.Drawing.Color.White;
            this.selectDeal.Click += new System.EventHandler(this.selectDeal_Click);
            // 
            // appHelp
            // 
            this.appHelp.ButtonType = CxFlatUI.ButtonType.Default;
            this.appHelp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.appHelp.Location = new System.Drawing.Point(525, 308);
            this.appHelp.Name = "appHelp";
            this.appHelp.Size = new System.Drawing.Size(205, 37);
            this.appHelp.TabIndex = 3;
            this.appHelp.Text = "도움말";
            this.appHelp.TextColor = System.Drawing.Color.White;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.appHelp);
            this.Controls.Add(this.selectDeal);
            this.Controls.Add(this.insertDeal);
            this.Controls.Add(this.insertSeller);
            this.Controls.Add(this.insertCtm);
            this.Controls.Add(this.insertCar);
            this.Controls.Add(this.insertAll);
            this.Controls.Add(this.cxFlatPictureBox1);
            this.Controls.Add(this.dropTB);
            this.Controls.Add(this.creatTB);
            this.Controls.Add(this.cxFlatPictureBox2);
            this.Name = "MainForm";
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "차량 고객 관리프로그램 v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.Controls.CxFlatButton creatTB;
        private CxFlatUI.Controls.CxFlatButton dropTB;
        private CxFlatUI.CxFlatPictureBox cxFlatPictureBox1;
        private CxFlatUI.CxFlatPictureBox cxFlatPictureBox2;
        private CxFlatUI.Controls.CxFlatButton insertAll;
        private CxFlatUI.Controls.CxFlatButton insertCar;
        private CxFlatUI.Controls.CxFlatButton insertCtm;
        private CxFlatUI.Controls.CxFlatButton insertSeller;
        private CxFlatUI.Controls.CxFlatButton insertDeal;
        private CxFlatUI.Controls.CxFlatButton exit;
        private CxFlatUI.Controls.CxFlatButton selectDeal;
        private CxFlatUI.Controls.CxFlatButton appHelp;
    }
}

