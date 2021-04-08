
namespace Lotto
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
            this.labelNum6 = new System.Windows.Forms.Label();
            this.labelNum5 = new System.Windows.Forms.Label();
            this.labelNum4 = new System.Windows.Forms.Label();
            this.labelNum3 = new System.Windows.Forms.Label();
            this.labelNum2 = new System.Windows.Forms.Label();
            this.labelNum1 = new System.Windows.Forms.Label();
            this.button_test = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNum6
            // 
            this.labelNum6.AutoSize = true;
            this.labelNum6.Location = new System.Drawing.Point(577, 67);
            this.labelNum6.Name = "labelNum6";
            this.labelNum6.Size = new System.Drawing.Size(11, 12);
            this.labelNum6.TabIndex = 3;
            this.labelNum6.Text = "-";
            // 
            // labelNum5
            // 
            this.labelNum5.AutoSize = true;
            this.labelNum5.Location = new System.Drawing.Point(510, 67);
            this.labelNum5.Name = "labelNum5";
            this.labelNum5.Size = new System.Drawing.Size(11, 12);
            this.labelNum5.TabIndex = 4;
            this.labelNum5.Text = "-";
            // 
            // labelNum4
            // 
            this.labelNum4.AutoSize = true;
            this.labelNum4.Location = new System.Drawing.Point(443, 67);
            this.labelNum4.Name = "labelNum4";
            this.labelNum4.Size = new System.Drawing.Size(11, 12);
            this.labelNum4.TabIndex = 5;
            this.labelNum4.Text = "-";
            // 
            // labelNum3
            // 
            this.labelNum3.AutoSize = true;
            this.labelNum3.Location = new System.Drawing.Point(376, 67);
            this.labelNum3.Name = "labelNum3";
            this.labelNum3.Size = new System.Drawing.Size(11, 12);
            this.labelNum3.TabIndex = 6;
            this.labelNum3.Text = "-";
            // 
            // labelNum2
            // 
            this.labelNum2.AutoSize = true;
            this.labelNum2.Location = new System.Drawing.Point(309, 67);
            this.labelNum2.Name = "labelNum2";
            this.labelNum2.Size = new System.Drawing.Size(11, 12);
            this.labelNum2.TabIndex = 7;
            this.labelNum2.Text = "-";
            // 
            // labelNum1
            // 
            this.labelNum1.AutoSize = true;
            this.labelNum1.Location = new System.Drawing.Point(242, 67);
            this.labelNum1.Name = "labelNum1";
            this.labelNum1.Size = new System.Drawing.Size(11, 12);
            this.labelNum1.TabIndex = 8;
            this.labelNum1.Text = "-";
            // 
            // button_test
            // 
            this.button_test.Location = new System.Drawing.Point(47, 56);
            this.button_test.Name = "button_test";
            this.button_test.Size = new System.Drawing.Size(176, 23);
            this.button_test.TabIndex = 2;
            this.button_test.Text = "테스트";
            this.button_test.UseVisualStyleBackColor = true;
            this.button_test.Click += new System.EventHandler(this.button_test_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelNum6);
            this.Controls.Add(this.labelNum5);
            this.Controls.Add(this.labelNum4);
            this.Controls.Add(this.labelNum3);
            this.Controls.Add(this.labelNum2);
            this.Controls.Add(this.labelNum1);
            this.Controls.Add(this.button_test);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

