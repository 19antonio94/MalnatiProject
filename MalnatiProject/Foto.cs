using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MalnatiProject
{
    public partial class Foto : Form
    {
        public Foto()
        {
            InitializeComponent();
        }

        private void Invia_Click(object sender, EventArgs e)
        {

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Server.avvia(this);
            
            //
            // CERCHIAMO CHI E ONLINE
            //
            //

            //Ripuliamo il form
            /*++++++++++AGGIUNGIAMO LE CHECkBOX*/
            MessageBox.Show("papapa", "pappap");
           // this.Refresh();
        }
    }
}
