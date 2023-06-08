using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatProgram
{
    public partial class Form1 : Form
    {
        public NetworkStream stream;
        public StreamReader streamReader;
        public StreamWriter streamWriter;
        const int PORT = 4444;
        private Thread threadReader;

        public bool isStopped = false;

        TcpListener listener;
        Thread threadServer;

        public bool isConnected = false;
        TcpClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ServerStart()
        {
            try
            {
                listener = new TcpListener(PORT);
                listener.Start();

                isStopped = false;
                Message("클라이언트 접속 대기중");

                while (!isStopped)
                {
                    TcpClient client = listener.AcceptTcpClient();

                    if (client.Connected)
                    {
                        isConnected = true;
                        Message("클라이언트 접속");

                        stream = client.GetStream();
                        streamReader = new StreamReader(stream);
                        streamWriter = new StreamWriter(stream);

                        threadReader = new Thread(new ThreadStart(Receive));
                        threadReader.Start();
                    }
                }
            }
            catch
            {
                Message("시작 도중 에러 발생");
                return;
            }
        }


        public void Message(string msg)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                txtChatHistory.AppendText(msg + "\r\n");
                txtChatHistory.Focus();
                txtChatHistory.ScrollToCaret();
                txtSend.Focus();
            }));
        }

        public void ServerStop()
        {
            if (!isStopped)
                return;

            listener.Stop();

            streamReader.Close();
            streamWriter.Close();

            stream.Close();

            threadReader.Abort();
            threadServer.Abort();

            Message("서비스 종료");
        }

        public void Disconnect()
        {
            if (!isStopped)
                return;

            isStopped = false;

            streamReader.Close();
            streamWriter.Close();

            stream.Close();

            threadReader.Abort();

            Message("서비스 종료");
        }

        public void Connect(string ipAddress)
        {
            client = null;

            try
            {
                client = new TcpClient(ipAddress, PORT);
            } catch
            {
                isConnected = false;
                return;
            }

            isConnected = true;
            Message("서버에 연결됨.");
            stream = client.GetStream();

            streamReader = new StreamReader(stream);
            streamWriter = new StreamWriter(stream);

            threadReader = new Thread(new ThreadStart(Receive));
            threadReader.Start();
        }

        public void Receive()
        {
            try
            {
                while (isConnected)
                {
                    string message = streamReader.ReadLine();

                    if (message != null)
                        Message("상대방 >>> : " + message);
                }
            }
            catch
            {
                Message("데이터를 읽는 부분에서 오류 발생.");
            }

            Disconnect();
        }

        public void Send()
        {
            try
            {
                streamWriter.WriteLine(txtSend.Text);
                streamWriter.Flush();
                Message(">>> : " + txtSend.Text);
                txtSend.Text = "";
            }
            catch
            {
                Message("전송 실패");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ServerStop();
            Disconnect();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (btnConnect.Text == "서버 연결")
            {
                Connect(txtServerIp.Text);
                if (isConnected)
                {
                    btnConnect.Text = "연결 끊기";
                    btnConnect.ForeColor = Color.Red;
                }
            } else
            {
                Disconnect();
                btnConnect.Text = "서버 연결";
                btnConnect.ForeColor = Color.Black;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (btnStop.Text == "서버 켜기")
            {
                threadServer = new Thread(new ThreadStart(ServerStart));
                threadServer.Start();

                btnStop.Text = "서버 멈춤";
                btnStop.ForeColor = Color.Red;
            } else
            {
                ServerStop();
                btnStop.Text = "서버 켜기";
                btnStop.ForeColor = Color.Black;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Send();
        }

        private void btnSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Send();
        }
    }
}
