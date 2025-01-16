namespace UDPCommunication
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtSendData = new System.Windows.Forms.TextBox();
            this.txtReceivedData = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(12, 12);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.PlaceholderText = "IP 주소 입력";
            this.txtIPAddress.Size = new System.Drawing.Size(200, 23);
            this.txtIPAddress.TabIndex = 0;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(220, 12);
            this.txtPort.Name = "txtPort";
            this.txtPort.PlaceholderText = "포트 번호 입력";
            this.txtPort.Size = new System.Drawing.Size(100, 23);
            this.txtPort.TabIndex = 1;
            // 
            // txtSendData
            // 
            this.txtSendData.Location = new System.Drawing.Point(12, 41);
            this.txtSendData.Name = "txtSendData";
            this.txtSendData.PlaceholderText = "전송할 데이터 입력";
            this.txtSendData.Size = new System.Drawing.Size(308, 23);
            this.txtSendData.TabIndex = 2;
            // 
            // txtReceivedData
            // 
            this.txtReceivedData.Location = new System.Drawing.Point(12, 99);
            this.txtReceivedData.Multiline = true;
            this.txtReceivedData.Name = "txtReceivedData";
            this.txtReceivedData.ReadOnly = true;
            this.txtReceivedData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceivedData.Size = new System.Drawing.Size(400, 150);
            this.txtReceivedData.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(326, 41);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtServerPort
            // 
            this.txtServerPort.Location = new System.Drawing.Point(12, 70);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.PlaceholderText = "서버 포트 입력";
            this.txtServerPort.Size = new System.Drawing.Size(200, 23);
            this.txtServerPort.TabIndex = 5;
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(220, 70);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(100, 23);
            this.btnStartServer.TabIndex = 6;
            this.btnStartServer.Text = "Start Server";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(424, 261);
            this.Controls.Add(this.btnStartServer);
            this.Controls.Add(this.txtServerPort);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtReceivedData);
            this.Controls.Add(this.txtSendData);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIPAddress);
            this.Name = "MainForm";
            this.Text = "UDP Communication";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtSendData;
        private System.Windows.Forms.TextBox txtReceivedData;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.Button btnStartServer;
    }
}
