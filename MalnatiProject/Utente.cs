using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Windows.Forms;


namespace MalnatiProject
{
    [Serializable]
   public class Utente
    {
        //implementare campo TIPO(risposta/annuncio/trasferimento)
        string nome;
        IPAddress ip=null;
        IPAddress broad=null;
        IPAddress mask=null;
        
        public Utente(string nome1 ,IPAddress ip1,IPAddress broad1, IPAddress mask1){
            nome = nome1;
            broad = broad1;
            ip = ip1;
            mask = mask1;
            
            
            
        }
        public IPAddress getIP() {
            return ip;
        }
        public String getNome()
        {
            return nome;
        }

        public static void mostra_utenti(List<Utente> u_list,Foto foto) {

            foto.Enabled = true;
            foto.Refresh();
           
            foto.ShowDialog();

        }



    }
}
