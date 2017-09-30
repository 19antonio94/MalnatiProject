using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace MalnatiProject
{
 
    public class Server
    {
        public void crea_form() {
            Foto f = new Foto();
        }

        public static void avvia(Foto f) {        
            Console.WriteLine("Starting server...");
            Socket s = new Socket(AddressFamily.InterNetwork,SocketType.Dgram, ProtocolType.Udp);
            s.ReceiveTimeout = 5000;
            byte[] data = new byte[1024];
            byte[] data1 = new byte[1024];
            List<Utente> utent_conn = new List<Utente>();
            IPAddress mioIP;
            mioIP = Dns.GetHostEntry(Dns.GetHostName()).AddressList.LastOrDefault();
            // UdpClient client = new UdpClient(15000);
            IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any,0);
            EndPoint ep = (EndPoint)RemoteIpEndPoint;
            s.Bind(RemoteIpEndPoint);
           // Foto f = new Foto();
           
            int i = 0;
            utent_conn.Add(new Utente("gain", IPAddress.Parse("127.1.1.1"), IPAddress.Parse("127.1.1.1"), IPAddress.Parse("127.1.1.1")));

            foreach (Utente ul in utent_conn)
                    {
                        CheckBox c = new CheckBox();
                        c.Location = new System.Drawing.Point(100, 100);
                        c.Tag = ul.getNome();
                        f.Controls.Add(c);
                        
                        Console.WriteLine(c.Tag);
                        i++;
                    }


            //Questo pezo qua metterlo dopo laggiornamento
            if (f.Visible == true)
            {
                foreach (Control control in f.Controls)
                {
                    if (control is CheckBox)
                    {

                        control.Visible = false;
                        
                    }
                }
             
            }
            else
            {
                f.Enabled = true;
                // f.Refresh();
                //f.Visible = false;
                f.ShowDialog();
            }
            // Thread t = new Thread(() => Utente.mostra_utenti(utent_conn, f));
            // t.Start();

            Utente u = null;
            while (true) {
                try
                {
                    s.ReceiveFrom(data, ref ep);
                }
                catch (SocketException e)
                {
                    Console.Write("nessuna risposta");
                    break;
                }
                using (var ms = new MemoryStream(data))
                {
                    var bf = new BinaryFormatter();
                    u = (Utente)bf.Deserialize(ms);
                    if (u.getIP().Equals(mioIP))
                    {
                        Console.WriteLine("mioIP");
                      
                    }
                    else {
                        if(u.getIP()!=null)
                        {
                            //inserisci nella lista
                            if (!utent_conn.Contains(u))
                            {
                                utent_conn.Add(u);
                                Console.WriteLine("ho ricevuto");
                                                      
                            }
                        

                        }

                    }
                }
            }
            s.Close();
        }
    }
}
