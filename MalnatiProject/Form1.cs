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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AvviaServerBtn_Click(object sender, EventArgs e)
        {
            Foto f = new Foto();
            

            if (privatoRdBtn.Checked.Equals(true))
            {
               
                
                Mod_priv.IniziaModalitaPrivata(f);
            }

            if (publicoRdBtn.Checked)
            {
                Mod_Publ.IniziaModalitaPubblica(f);

            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CaricaFoto_Click(object sender, EventArgs e)
        {

        }
    }
}
