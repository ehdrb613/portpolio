
namespace Lotto2
{
    partial class Loading
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
            this.loadLabel1 = new System.Windows.Forms.Label();
            this.loadLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadLabel1
            // 
            this.loadLabel1.AutoSize = true;
            this.loadLabel1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loadLabel1.Location = new System.Drawing.Point(61, 43);
            this.loadLabel1.Name = "loadLabel1";
            this.loadLabel1.Size = new System.Drawing.Size(112, 24);
            this.loadLabel1.TabIndex = 0;
            this.loadLabel1.Text = "로딩중...";
            // 
            // loadLabel2
            // 
            this.loadLabel2.AutoSize = true;
            this.loadLabel2.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loadLabel2.Location = new System.Drawing.Point(194, 43);
            this.loadLabel2.Name = "loadLabel2";
            this.loadLabel2.Size = new System.Drawing.Size(46, 24);
            this.loadLabel2.TabIndex = 0;
            this.loadLabel2.Text = "0%";
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 112);
            this.ControlBox = false;
            this.Controls.Add(this.loadLabel2);
            this.Controls.Add(this.loadLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.Shown += new System.EventHandler(this.Loading_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label loadLabel1;
        public System.Windows.Forms.Label loadLabel2;
    }
}