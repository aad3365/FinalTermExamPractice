using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacketTest
{
    public partial class Form1 : Form
    {
        NetworkStream networkStream;
        TcpListener listener;

        byte[] sendBuffer = new byte[1024 * 4];
        byte[] readBuffer = new byte[1024 * 4];

        bool clientOn = false;

        Thread thread;

        public Form1()
        {
            InitializeComponent();
        }
    }
}
