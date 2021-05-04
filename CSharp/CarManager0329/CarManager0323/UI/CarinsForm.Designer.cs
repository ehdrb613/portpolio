
namespace CarManager0323.UI
{
    partial class CarinsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addCancel = new Sunny.UI.UISymbolButton();
            this.CarOk = new Sunny.UI.UISymbolButton();
            this.carColor = new CxFlatUI.CxFlatTextBox();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.carMoney = new CxFlatUI.CxFlatTextBox();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.carYear = new CxFlatUI.CxFlatTextBox();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.carModel = new CxFlatUI.CxFlatTextBox();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.SuspendLayout();
            // 
            // addCancel
            // 
            this.addCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCancel.Location = new System.Drawing.Point(361, 325);
            this.addCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCancel.Name = "addCancel";
            this.addCancel.Size = new System.Drawing.Size(198, 35);
            this.addCancel.TabIndex = 12;
            this.addCancel.TabStop = false;
            this.addCancel.Text = "취소";
            this.addCancel.Click += new System.EventHandler(this.addCancel_Click);
            // 
            // CarOk
            // 
            this.CarOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CarOk.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.CarOk.Location = new System.Drawing.Point(144, 325);
            this.CarOk.MinimumSize = new System.Drawing.Size(1, 1);
            this.CarOk.Name = "CarOk";
            this.CarOk.Size = new System.Drawing.Size(198, 35);
            this.CarOk.TabIndex = 13;
            this.CarOk.TabStop = false;
            this.CarOk.Text = "확인";
            this.CarOk.Click += new System.EventHandler(this.CarOk_Click);
            // 
            // carColor
            // 
            this.carColor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.carColor.Hint = "";
            this.carColor.Location = new System.Drawing.Point(277, 248);
            this.carColor.MaxLength = 32767;
            this.carColor.Multiline = false;
            this.carColor.Name = "carColor";
            this.carColor.PasswordChar = '\0';
            this.carColor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.carColor.SelectedText = "";
            this.carColor.SelectionLength = 0;
            this.carColor.SelectionStart = 0;
            this.carColor.Size = new System.Drawing.Size(282, 38);
            this.carColor.TabIndex = 4;
            this.carColor.TabStop = false;
            this.carColor.UseSystemPasswordChar = false;
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel4.Font = new System.Drawing.Font("HY동녘M", 14.25F);
            this.uiSymbolLabel4.Location = new System.Drawing.Point(144, 248);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(107, 35);
            this.uiSymbolLabel4.Symbol = 61664;
            this.uiSymbolLabel4.SymbolSize = 26;
            this.uiSymbolLabel4.TabIndex = 4;
            this.uiSymbolLabel4.TabStop = false;
            this.uiSymbolLabel4.Text = "색 상";
            // 
            // carMoney
            // 
            this.carMoney.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.carMoney.Hint = "";
            this.carMoney.Location = new System.Drawing.Point(277, 194);
            this.carMoney.MaxLength = 32767;
            this.carMoney.Multiline = false;
            this.carMoney.Name = "carMoney";
            this.carMoney.PasswordChar = '\0';
            this.carMoney.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.carMoney.SelectedText = "";
            this.carMoney.SelectionLength = 0;
            this.carMoney.SelectionStart = 0;
            this.carMoney.Size = new System.Drawing.Size(282, 38);
            this.carMoney.TabIndex = 3;
            this.carMoney.TabStop = false;
            this.carMoney.UseSystemPasswordChar = false;
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("HY동녘M", 14.25F);
            this.uiSymbolLabel3.Location = new System.Drawing.Point(144, 194);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(34, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(107, 35);
            this.uiSymbolLabel3.Symbol = 61461;
            this.uiSymbolLabel3.SymbolSize = 30;
            this.uiSymbolLabel3.TabIndex = 5;
            this.uiSymbolLabel3.TabStop = false;
            this.uiSymbolLabel3.Text = "가 격";
            // 
            // carYear
            // 
            this.carYear.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.carYear.Hint = "";
            this.carYear.Location = new System.Drawing.Point(277, 140);
            this.carYear.MaxLength = 32767;
            this.carYear.Multiline = false;
            this.carYear.Name = "carYear";
            this.carYear.PasswordChar = '\0';
            this.carYear.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.carYear.SelectedText = "";
            this.carYear.SelectionLength = 0;
            this.carYear.SelectionStart = 0;
            this.carYear.Size = new System.Drawing.Size(282, 38);
            this.carYear.TabIndex = 2;
            this.carYear.TabStop = false;
            this.carYear.UseSystemPasswordChar = false;
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("HY동녘M", 14.25F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(144, 140);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(107, 35);
            this.uiSymbolLabel2.Symbol = 61589;
            this.uiSymbolLabel2.SymbolSize = 26;
            this.uiSymbolLabel2.TabIndex = 6;
            this.uiSymbolLabel2.TabStop = false;
            this.uiSymbolLabel2.Text = "연 식";
            // 
            // carModel
            // 
            this.carModel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.carModel.Hint = "";
            this.carModel.Location = new System.Drawing.Point(277, 86);
            this.carModel.MaxLength = 32767;
            this.carModel.Multiline = false;
            this.carModel.Name = "carModel";
            this.carModel.PasswordChar = '\0';
            this.carModel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.carModel.SelectedText = "";
            this.carModel.SelectionLength = 0;
            this.carModel.SelectionStart = 0;
            this.carModel.Size = new System.Drawing.Size(282, 38);
            this.carModel.TabIndex = 1;
            this.carModel.TabStop = false;
            this.carModel.UseSystemPasswordChar = false;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("HY동녘M", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiSymbolLabel1.Location = new System.Drawing.Point(144, 86);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(107, 35);
            this.uiSymbolLabel1.Symbol = 62142;
            this.uiSymbolLabel1.SymbolSize = 26;
            this.uiSymbolLabel1.TabIndex = 7;
            this.uiSymbolLabel1.TabStop = false;
            this.uiSymbolLabel1.Text = "모 델";
            // 
            // CarinsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addCancel);
            this.Controls.Add(this.CarOk);
            this.Controls.Add(this.carColor);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.carMoney);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.carYear);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.carModel);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Name = "CarinsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "차량 정보 추가";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton addCancel;
        private Sunny.UI.UISymbolButton CarOk;
        private CxFlatUI.CxFlatTextBox carColor;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private CxFlatUI.CxFlatTextBox carMoney;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private CxFlatUI.CxFlatTextBox carYear;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private CxFlatUI.CxFlatTextBox carModel;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
    }
}