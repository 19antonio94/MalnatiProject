using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MalnatiProject
{
    class Mod_priv
    {
        public Mod_priv() { }
        public static void IniziaModalitaPrivata(Foto f) {
            //****implementazione della modalita privata***//

            Console.WriteLine("starting modalita privata");
            //Thread init_ser = new Thread(Server.avvia);
            Thread init_client = new Thread(PrivateClient.avvia);
            //init_ser.Start();
            init_client.Start();


        }
    }
}
