using System.Runtime.Serialization.Formatters.Binary;

namespace PacketNetwork
{
    public enum PacketType
    {
        RESET = 0,
        CONNECT
    }

    public enum PacketSendERROR
    {
        NORMAL = 0,
        ERROR
    }

    [Serializable]
    public class Packet
    {
        public int Length;
        public int Type;

        public Packet()
        {
            Length = 0;
            Type = 0;
        }

        public static byte[] Serialize(Object o)
        {
            MemoryStream ms = new MemoryStream(1024 * 4);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, o);

            return ms.ToArray();
        }

        public static Object Deserialize(byte[] bt)
        {
            MemoryStream ms = new MemoryStream(1024 * 4);
            foreach (byte b in bt)
            {
                ms.WriteByte(b);
            }

            ms.Position = 0;
            BinaryFormatter bf = new BinaryFormatter();
            Object obj =  bf.Deserialize(ms);
            ms.Close();

            return obj;
        }
    }

    [Serializable]
    public class Initialize : Packet
    {
        public int Data = 0;
    }

    public class Login : Packet
    {
        public string m_strID;

        public Login()
        {
            m_strID = null;
        }
    }
}