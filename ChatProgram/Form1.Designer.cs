namespace ChatProgram
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
            this.txtChatHistory = new System.Windows.Forms.TextBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtServerIp = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtChatHistory
            // 
            this.txtChatHistory.Location = new System.Drawing.Point(12, 12);
            this.txtChatHistory.Multiline = true;
            this.txtChatHistory.Name = "txtChatHistory";
            this.txtChatHistory.Size = new System.Drawing.Size(489, 375);
            this.txtChatHistory.TabIndex = 0;
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(12, 410);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(489, 28);
            this.txtSend.TabIndex = 1;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(522, 63);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(266, 34);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "서버 켜기";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(522, 126);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(266, 34);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "서버 연결";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtServerIp
            // 
            this.txtServerIp.Location = new System.Drawing.Point(522, 189);
            this.txtServerIp.Name = "txtServerIp";
            this.txtServerIp.Size = new System.Drawing.Size(266, 28);
            this.txtServerIp.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(522, 354);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(266, 32);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "프로그램 종료";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(522, 397);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(266, 41);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "보내기";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            this.btnSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSend_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtServerIp);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.txtChatHistory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChatHistory;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtServerIp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSend;
    }
}

