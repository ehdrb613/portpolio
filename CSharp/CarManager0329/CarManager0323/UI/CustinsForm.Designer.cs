
namespace CarManager0323.UI
{
    partial class CustinsForm
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
            this.custOk = new Sunny.UI.UISymbolButton();
            this.custEmail = new CxFlatUI.CxFlatTextBox();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.custTel = new CxFlatUI.CxFlatTextBox();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.custAddr = new CxFlatUI.CxFlatTextBox();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.custName = new CxFlatUI.CxFlatTextBox();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.SuspendLayout();
            // 
            // addCancel
            // 
            this.addCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCancel.Location = new System.Drawing.Point(410, 327);
            this.addCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCancel.Name = "addCancel";
            this.addCancel.Size = new System.Drawing.Size(198, 35);
            this.addCancel.TabIndex = 22;
            this.addCancel.TabStop = false;
            this.addCancel.Text = "취소";
            this.addCancel.Click += new System.EventHandler(this.addCancel_Click);
            // 
            // custOk
            // 
            this.custOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custOk.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custOk.Location = new System.Drawing.Point(193, 327);
            this.custOk.MinimumSize = new System.Drawing.Size(1, 1);
            this.custOk.Name = "custOk";
            this.custOk.Size = new System.Drawing.Size(198, 35);
            this.custOk.TabIndex = 23;
            this.custOk.TabStop = false;
            this.custOk.Text = "확인";
            this.custOk.Click += new System.EventHandler(this.custOk_Click);
            // 
            // custEmail
            // 
            this.custEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.custEmail.Hint = "";
            this.custEmail.Location = new System.Drawing.Point(326, 250);
            this.custEmail.MaxLength = 32767;
            this.custEmail.Multiline = false;
            this.custEmail.Name = "custEmail";
            this.custEmail.PasswordChar = '\0';
            this.custEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.custEmail.SelectedText = "";
            this.custEmail.SelectionLength = 0;
            this.custEmail.SelectionStart = 0;
            this.custEmail.Size = new System.Drawing.Size(282, 38);
            this.custEmail.TabIndex = 4;
            this.custEmail.TabStop = false;
            this.custEmail.UseSystemPasswordChar = false;
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel4.Font = new System.Drawing.Font("HY동녘M", 14.25F);
            this.uiSymbolLabel4.Location = new System.Drawing.Point(193, 250);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(107, 35);
            this.uiSymbolLabel4.Symbol = 61664;
            this.uiSymbolLabel4.SymbolSize = 26;
            this.uiSymbolLabel4.TabIndex = 14;
            this.uiSymbolLabel4.TabStop = false;
            this.uiSymbolLabel4.Text = "이 메 일";
            // 
            // custTel
            // 
            this.custTel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.custTel.Hint = "";
            this.custTel.Location = new System.Drawing.Point(326, 196);
            this.custTel.MaxLength = 32767;
            this.custTel.Multiline = false;
            this.custTel.Name = "custTel";
            this.custTel.PasswordChar = '\0';
            this.custTel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.custTel.SelectedText = "";
            this.custTel.SelectionLength = 0;
            this.custTel.SelectionStart = 0;
            this.custTel.Size = new System.Drawing.Size(282, 38);
            this.custTel.TabIndex = 3;
            this.custTel.TabStop = false;
            this.custTel.UseSystemPasswordChar = false;
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("HY동녘M", 14.25F);
            this.uiSymbolLabel3.Location = new System.Drawing.Point(193, 196);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(34, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(107, 35);
            this.uiSymbolLabel3.Symbol = 61461;
            this.uiSymbolLabel3.SymbolSize = 30;
            this.uiSymbolLabel3.TabIndex = 15;
            this.uiSymbolLabel3.TabStop = false;
            this.uiSymbolLabel3.Text = "전 화";
            // 
            // custAddr
            // 
            this.custAddr.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.custAddr.Hint = "";
            this.custAddr.Location = new System.Drawing.Point(326, 142);
            this.custAddr.MaxLength = 32767;
            this.custAddr.Multiline = false;
            this.custAddr.Name = "custAddr";
            this.custAddr.PasswordChar = '\0';
            this.custAddr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.custAddr.SelectedText = "";
            this.custAddr.SelectionLength = 0;
            this.custAddr.SelectionStart = 0;
            this.custAddr.Size = new System.Drawing.Size(282, 38);
            this.custAddr.TabIndex = 2;
            this.custAddr.TabStop = false;
            this.custAddr.UseSystemPasswordChar = false;
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("HY동녘M", 14.25F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(193, 142);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(107, 35);
            this.uiSymbolLabel2.Symbol = 61589;
            this.uiSymbolLabel2.SymbolSize = 26;
            this.uiSymbolLabel2.TabIndex = 16;
            this.uiSymbolLabel2.TabStop = false;
            this.uiSymbolLabel2.Text = "주 소";
            // 
            // custName
            // 
            this.custName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.custName.Hint = "";
            this.custName.Location = new System.Drawing.Point(326, 88);
            this.custName.MaxLength = 32767;
            this.custName.Multiline = false;
            this.custName.Name = "custName";
            this.custName.PasswordChar = '\0';
            this.custName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.custName.SelectedText = "";
            this.custName.SelectionLength = 0;
            this.custName.SelectionStart = 0;
            this.custName.Size = new System.Drawing.Size(282, 38);
            this.custName.TabIndex = 1;
            this.custName.TabStop = false;
            this.custName.UseSystemPasswordChar = false;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("HY동녘M", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiSymbolLabel1.Location = new System.Drawing.Point(193, 88);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(107, 35);
            this.uiSymbolLabel1.Symbol = 62142;
            this.uiSymbolLabel1.SymbolSize = 26;
            this.uiSymbolLabel1.TabIndex = 17;
            this.uiSymbolLabel1.TabStop = false;
            this.uiSymbolLabel1.Text = "이 름";
            // 
            // CustinsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addCancel);
            this.Controls.Add(this.custOk);
            this.Controls.Add(this.custEmail);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.custTel);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.custAddr);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.custName);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Name = "CustinsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "고객 정보";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton addCancel;
        private Sunny.UI.UISymbolButton custOk;
        private CxFlatUI.CxFlatTextBox custEmail;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private CxFlatUI.CxFlatTextBox custTel;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private CxFlatUI.CxFlatTextBox custAddr;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private CxFlatUI.CxFlatTextBox custName;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
    }
}