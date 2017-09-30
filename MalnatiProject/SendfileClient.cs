using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MalnatiProject
{
    class SendfileClient
    {
        public static int invia_file(string path,IPAddress destIP)
        {

            IPEndPoint dest = new IPEndPoint(destIP, 15000);
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            s.Connect(dest);
            s.SendFile(path);
            s.Shutdown(SocketShutdown.Both);
            s.Close();


            return 0;
        }
    }
}
