
//modificato
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MalnatiProject
{
    class Mod_Publ
    {
        public static void IniziaModalitaPubblica(Foto f) {


            Thread adv = new Thread(Advertisment.annuncia);
            Thread ser = new Thread(()=>Server.avvia(f));
            //Thread t = new Thread(() => Utente.mostra_utenti(utent_conn, f));
            //t.Start();
            adv.Start();
            ser.Start();
            

        }

    }
}
