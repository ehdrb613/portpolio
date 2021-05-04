
namespace CarManager0323.UI
{
    partial class DealView
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
            this.dealList = new System.Windows.Forms.ListView();
            this.deal_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deal_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deal_model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deal_money = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deal_seller = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deal_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.custDetail = new Sunny.UI.UISymbolButton();
            this.dealViewClose = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // dealList
            // 
            this.dealList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.deal_count,
            this.deal_name,
            this.deal_model,
            this.deal_money,
            this.deal_seller,
            this.deal_date});
            this.dealList.FullRowSelect = true;
            this.dealList.HideSelection = false;
            this.dealList.Location = new System.Drawing.Point(18, 48);
            this.dealList.Name = "dealList";
            this.dealList.Size = new System.Drawing.Size(591, 324);
            this.dealList.TabIndex = 2;
            this.dealList.UseCompatibleStateImageBehavior = false;
            this.dealList.View = System.Windows.Forms.View.Details;
            // 
            // deal_count
            // 
            this.deal_count.Text = "번호";
            this.deal_count.Width = 50;
            // 
            // deal_name
            // 
            this.deal_name.Text = "고객이름";
            this.deal_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deal_name.Width = 80;
            // 
            // deal_model
            // 
            this.deal_model.Text = "구매차량";
            this.deal_model.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deal_model.Width = 120;
            // 
            // deal_money
            // 
            this.deal_money.Text = "구매가격";
            this.deal_money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deal_money.Width = 150;
            // 
            // deal_seller
            // 
            this.deal_seller.Text = "판매자";
            this.deal_seller.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deal_seller.Width = 80;
            // 
            // deal_date
            // 
            this.deal_date.Text = "거래날짜";
            this.deal_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deal_date.Width = 120;
            // 
            // custDetail
            // 
            this.custDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custDetail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custDetail.Location = new System.Drawing.Point(643, 64);
            this.custDetail.MinimumSize = new System.Drawing.Size(1, 1);
            this.custDetail.Name = "custDetail";
            this.custDetail.Size = new System.Drawing.Size(144, 44);
            this.custDetail.TabIndex = 3;
            this.custDetail.Text = "고객 상세 정보";
            this.custDetail.Click += new System.EventHandler(this.custDetail_Click);
            // 
            // dealViewClose
            // 
            this.dealViewClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dealViewClose.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dealViewClose.Location = new System.Drawing.Point(643, 139);
            this.dealViewClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.dealViewClose.Name = "dealViewClose";
            this.dealViewClose.Size = new System.Drawing.Size(144, 44);
            this.dealViewClose.TabIndex = 3;
            this.dealViewClose.Text = "닫기";
            this.dealViewClose.Click += new System.EventHandler(this.dealViewClose_Click);
            // 
            // DealView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dealViewClose);
            this.Controls.Add(this.custDetail);
            this.Controls.Add(this.dealList);
            this.Name = "DealView";
            this.Text = "거래내역 보기";
            this.Load += new System.EventHandler(this.DealView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView dealList;
        private System.Windows.Forms.ColumnHeader deal_count;
        private System.Windows.Forms.ColumnHeader deal_name;
        private System.Windows.Forms.ColumnHeader deal_model;
        private System.Windows.Forms.ColumnHeader deal_money;
        private System.Windows.Forms.ColumnHeader deal_seller;
        private Sunny.UI.UISymbolButton custDetail;
        private Sunny.UI.UISymbolButton dealViewClose;
        private System.Windows.Forms.ColumnHeader deal_date;
    }
}