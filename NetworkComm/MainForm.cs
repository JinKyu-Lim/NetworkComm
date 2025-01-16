using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDPCommunication
{
    public partial class MainForm : Form
    {
        private UdpClient udpClient;
        private UdpClient udpServer;
        private bool isServerRunning = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Initialize UDP Client
            udpClient = new UdpClient();
        }

        private async void btnStartServer_Click(object sender, EventArgs e)
        {
            if (isServerRunning)
            {
                MessageBox.Show("서버가 이미 실행 중입니다.");
                return;
            }

            if (!int.TryParse(txtServerPort.Text, out int serverPort))
            {
                MessageBox.Show("유효한 서버 포트를 입력하세요.");
                return;
            }

            udpServer = new UdpClient(serverPort);
            isServerRunning = true;

            // 비동기 수신 대기
            await Task.Run(() => ReceiveDataAsync());
            MessageBox.Show("서버 시작됨: " + serverPort);
        }

        private async Task ReceiveDataAsync()
        {
            while (isServerRunning)
            {
                try
                {
                    var receivedResult = await udpServer.ReceiveAsync();
                    string receivedMessage = Encoding.UTF8.GetString(receivedResult.Buffer);

                    // 수신된 메시지를 출력
                    Invoke(new Action(() =>
                    {
                        txtReceivedData.AppendText($"[{DateTime.Now}] {receivedMessage}\r\n");
                    }));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"수신 중 오류 발생: {ex.Message}");
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string ipAddress = txtIPAddress.Text;
                string portText = txtPort.Text;
                string data = txtSendData.Text;

                if (!IPAddress.TryParse(ipAddress, out IPAddress ip))
                {
                    MessageBox.Show("유효한 IP 주소를 입력하세요.");
                    return;
                }

                if (!int.TryParse(portText, out int port))
                {
                    MessageBox.Show("유효한 포트 번호를 입력하세요.");
                    return;
                }

                byte[] sendData = Encoding.UTF8.GetBytes(data);
                udpClient.Send(sendData, sendData.Length, new IPEndPoint(ip, port));

                txtReceivedData.AppendText($"[{DateTime.Now}] Sent: {data}\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"데이터 전송 중 오류 발생: {ex.Message}");
            }
        }
    }
}
