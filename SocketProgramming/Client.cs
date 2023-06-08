using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketProgramming
{
    internal class Client
    {
        public static void start()
        {
            TcpClient? client = null;

            try
            {
                client = new TcpClient("127.0.0.1", 3000);

                NetworkStream stream = client.GetStream();
                byte[] readBuffer = new byte[sizeof(int)];

                stream.Read(readBuffer, 0, readBuffer.Length);
                int bufferSize = BitConverter.ToInt32(readBuffer, 0);
                Console.WriteLine("received int: {0}", bufferSize);

                readBuffer = new byte[bufferSize];
                string message = Encoding.UTF8.GetString(readBuffer, 0, bufferSize);
                Console.WriteLine("received string: {0}", message);

                client.Close();
                stream.Close();
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            } finally
            {
                if (client != null) client.Close();
            }

            Console.WriteLine("Client Exit");
        }
    }
}
