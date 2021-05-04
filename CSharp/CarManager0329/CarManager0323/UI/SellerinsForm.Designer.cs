
namespace CarManager0323.UI
{
    partial class SellerinsForm
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
            this.sellerOk = new Sunny.UI.UISymbolButton();
            this.sellAgent = new CxFlatUI.CxFlatTextBox();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.sellEmail = new CxFlatUI.CxFlatTextBox();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.sellTel = new CxFlatUI.CxFlatTextBox();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.sellName = new CxFlatUI.CxFlatTextBox();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel5 = new Sunny.UI.UISymbolLabel();
            this.sellPosition = new CxFlatUI.CxFlatTextBox();
            this.SuspendLayout();
            // 
            // addCancel
            // 
            this.addCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCancel.Location = new System.Drawing.Point(410, 378);
            this.addCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCancel.Name = "addCancel";
            this.addCancel.Size = new System.Drawing.Size(198, 35);
            this.addCancel.TabIndex = 7;
            this.addCancel.TabStop = false;
            this.addCancel.Text = "취소";
            this.addCancel.Click += new System.EventHandler(this.addCancel_Click);
            // 
            // sellerOk
            // 
            this.sellerOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sellerOk.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.sellerOk.Location = new System.Drawing.Point(193, 378);
            this.sellerOk.MinimumSize = new System.Drawing.Size(1, 1);
            this.sellerOk.Name = "sellerOk";
            this.sellerOk.Size = new System.Drawing.Size(198, 35);
            this.sellerOk.TabIndex = 6;
            this.sellerOk.TabStop = false;
            this.sellerOk.Text = "확인";
            this.sellerOk.Click += new System.EventHandler(this.sellerOk_Click);
            // 
            // sellAgent
            // 
            this.sellAgent.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.sellAgent.Hint = "";
            this.sellAgent.Location = new System.Drawing.Point(326, 250);
            this.sellAgent.MaxLength = 32767;
            this.sellAgent.Multiline = false;
            this.sellAgent.Name = "sellAgent";
            this.sellAgent.PasswordChar = '\0';
            this.sellAgent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sellAgent.SelectedText = "";
            this.sellAgent.SelectionLength = 0;
            this.sellAgent.SelectionStart = 0;
            this.sellAgent.Size = new System.Drawing.Size(282, 38);
            this.sellAgent.TabIndex = 4;
            this.sellAgent.TabStop = false;
            this.sellAgent.UseSystemPasswordChar = false;
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel4.Enabled = false;
            this.uiSymbolLabel4.Font = new System.Drawing.Font("HY동녘M", 14.25F);
            this.uiSymbolLabel4.Location = new System.Drawing.Point(193, 196);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(107, 35);
            this.uiSymbolLabel4.Symbol = 61664;
            this.uiSymbolLabel4.SymbolSize = 26;
            this.uiSymbolLabel4.TabIndex = 24;
            this.uiSymbolLabel4.Text = "이 메 일";
            // 
            // sellEmail
            // 
            this.sellEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.sellEmail.Hint = "";
            this.sellEmail.Location = new System.Drawing.Point(326, 196);
            this.sellEmail.MaxLength = 32767;
            this.sellEmail.Multiline = false;
            this.sellEmail.Name = "sellEmail";
            this.sellEmail.PasswordChar = '\0';
            this.sellEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sellEmail.SelectedText = "";
            this.sellEmail.SelectionLength = 0;
            this.sellEmail.SelectionStart = 0;
            this.sellEmail.Size = new System.Drawing.Size(282, 38);
            this.sellEmail.TabIndex = 3;
            this.sellEmail.TabStop = false;
            this.sellEmail.UseSystemPasswordChar = false;
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Enabled = false;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("HY동녘M", 14.25F);
            this.uiSymbolLabel3.Location = new System.Drawing.Point(193, 253);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(34, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(107, 35);
            this.uiSymbolLabel3.Symbol = 61461;
            this.uiSymbolLabel3.SymbolSize = 30;
            this.uiSymbolLabel3.TabIndex = 25;
            this.uiSymbolLabel3.Text = "영업소";
            // 
            // sellTel
            // 
            this.sellTel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.sellTel.Hint = "";
            this.sellTel.Location = new System.Drawing.Point(326, 142);
            this.sellTel.MaxLength = 32767;
            this.sellTel.Multiline = false;
            this.sellTel.Name = "sellTel";
            this.sellTel.PasswordChar = '\0';
            this.sellTel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sellTel.SelectedText = "";
            this.sellTel.SelectionLength = 0;
            this.sellTel.SelectionStart = 0;
            this.sellTel.Size = new System.Drawing.Size(282, 38);
            this.sellTel.TabIndex = 2;
            this.sellTel.TabStop = false;
            this.sellTel.UseSystemPasswordChar = false;
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Enabled = false;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("HY동녘M", 14.25F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(193, 142);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(107, 35);
            this.uiSymbolLabel2.Symbol = 61589;
            this.uiSymbolLabel2.SymbolSize = 26;
            this.uiSymbolLabel2.TabIndex = 26;
            this.uiSymbolLabel2.Text = "전 화";
            // 
            // sellName
            // 
            this.sellName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.sellName.Hint = "";
            this.sellName.Location = new System.Drawing.Point(326, 88);
            this.sellName.MaxLength = 32767;
            this.sellName.Multiline = false;
            this.sellName.Name = "sellName";
            this.sellName.PasswordChar = '\0';
            this.sellName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sellName.SelectedText = "";
            this.sellName.SelectionLength = 0;
            this.sellName.SelectionStart = 0;
            this.sellName.Size = new System.Drawing.Size(282, 38);
            this.sellName.TabIndex = 1;
            this.sellName.TabStop = false;
            this.sellName.UseSystemPasswordChar = false;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Enabled = false;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("HY동녘M", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiSymbolLabel1.Location = new System.Drawing.Point(193, 88);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(107, 35);
            this.uiSymbolLabel1.Symbol = 62142;
            this.uiSymbolLabel1.SymbolSize = 26;
            this.uiSymbolLabel1.TabIndex = 27;
            this.uiSymbolLabel1.Text = "이 름";
            // 
            // uiSymbolLabel5
            // 
            this.uiSymbolLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel5.Enabled = false;
            this.uiSymbolLabel5.Font = new System.Drawing.Font("HY동녘M", 14.25F);
            this.uiSymbolLabel5.Location = new System.Drawing.Point(193, 307);
            this.uiSymbolLabel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel5.Name = "uiSymbolLabel5";
            this.uiSymbolLabel5.Padding = new System.Windows.Forms.Padding(34, 0, 0, 0);
            this.uiSymbolLabel5.Size = new System.Drawing.Size(107, 35);
            this.uiSymbolLabel5.Symbol = 61461;
            this.uiSymbolLabel5.SymbolSize = 30;
            this.uiSymbolLabel5.TabIndex = 25;
            this.uiSymbolLabel5.Text = "직 위";
            // 
            // sellPosition
            // 
            this.sellPosition.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.sellPosition.Hint = "";
            this.sellPosition.Location = new System.Drawing.Point(326, 304);
            this.sellPosition.MaxLength = 32767;
            this.sellPosition.Multiline = false;
            this.sellPosition.Name = "sellPosition";
            this.sellPosition.PasswordChar = '\0';
            this.sellPosition.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sellPosition.SelectedText = "";
            this.sellPosition.SelectionLength = 0;
            this.sellPosition.SelectionStart = 0;
            this.sellPosition.Size = new System.Drawing.Size(282, 38);
            this.sellPosition.TabIndex = 5;
            this.sellPosition.TabStop = false;
            this.sellPosition.UseSystemPasswordChar = false;
            // 
            // SellerinsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addCancel);
            this.Controls.Add(this.sellerOk);
            this.Controls.Add(this.sellPosition);
            this.Controls.Add(this.sellAgent);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.uiSymbolLabel5);
            this.Controls.Add(this.sellEmail);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.sellTel);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.sellName);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Name = "SellerinsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "판매자 추가 정보";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton addCancel;
        private Sunny.UI.UISymbolButton sellerOk;
        private CxFlatUI.CxFlatTextBox sellAgent;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private CxFlatUI.CxFlatTextBox sellEmail;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private CxFlatUI.CxFlatTextBox sellTel;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private CxFlatUI.CxFlatTextBox sellName;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel5;
        private CxFlatUI.CxFlatTextBox sellPosition;
    }
}