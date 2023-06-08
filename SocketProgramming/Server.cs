using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketProgramming
{
    internal class Server
    {
        public static void start()
        {
            TcpListener? listener = null;
            IPAddress address = IPAddress.Parse("127.0.0.1");
            int port = 3000;

            try
            {
                listener = new TcpListener(address, port);
                listener.Start();

                while (true)
                {
                    Console.WriteLine("waiting for connection...");
                    TcpClient client = listener.AcceptTcpClient();
                    Console.WriteLine("connected!");

                    byte[] writeBuffer = Encoding.UTF8.GetBytes("Hello c# socket!");
                    int bytes = writeBuffer.Length;
                    byte[] writeBufferSize = BitConverter.GetBytes(bytes);

                    NetworkStream stream = client.GetStream();
                    stream.Write(writeBufferSize, 0, writeBufferSize.Length);
                    stream.Write(writeBuffer, 0, writeBuffer.Length);

                    stream.Close();
                    client.Close();
                }
            } catch (SocketException e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                if (listener != null) listener.Stop();
            }

            Console.WriteLine("server end");
        }
    }
}
