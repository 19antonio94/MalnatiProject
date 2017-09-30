using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Net.NetworkInformation;
using System.Runtime.Serialization.Formatters.Binary;

namespace MalnatiProject
{
    class Advertisment
    {
        public static void annuncia() {
            //mi annuncio alla rete 

            UdpClient client = new UdpClient();           
            IPAddress mioIP;
            IPAddress mask=null;
            IPAddress broad=null;
            byte[] broadcastIPBytes = new byte[4];            
            byte[] maskBytes;
            var host = Dns.GetHostEntry(Dns.GetHostName());
            mioIP = host.AddressList.LastOrDefault();
            byte[] hostBytes = mioIP.GetAddressBytes();

            foreach (NetworkInterface f in NetworkInterface.GetAllNetworkInterfaces())
            {               
                IPInterfaceProperties ipInterface = f.GetIPProperties();
                foreach (UnicastIPAddressInformation unicastAddress in ipInterface.UnicastAddresses)
                {
                    if (unicastAddress.Address.Equals(mioIP))
                    {
                        Console.WriteLine(unicastAddress.IPv4Mask == null ? "No subnet defined" : unicastAddress.IPv4Mask.ToString());
                        mask = unicastAddress.IPv4Mask;                       
                        maskBytes = mask.GetAddressBytes();
                        for (int i = 0; i < 4; i++)
                        {
                            broadcastIPBytes[i] = (byte)(hostBytes[i] | (byte)~maskBytes[i]);
                        }
                        broad = new IPAddress(broadcastIPBytes);
                    }
                }
            }
            
            Utente u = new Utente(host.HostName,mioIP,broad,mask);
            



            byte[] bytes = null;
            using (var ms = new System.IO.MemoryStream())
            {
                var bf = new BinaryFormatter();
                bf.Serialize(ms, u);
                bytes = ms.ToArray();
            }

            Thread.Sleep(3000);

            client.Send(bytes, bytes.Length, new IPEndPoint(broad,15000));
            

            client.Close();     
        }
    }
}
