using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Echiquier
{
    public partial class Echiquier : Form
    {
        public Echiquier()
        {
            InitializeComponent();
        }

        private void Saisie(object sender, EventArgs e)
        {
            int x = 8;
            int y = 8;
            Button bouton1 = new Button();
            bouton1.Location = new Point(0, 0);
            bouton1.Size = new Size(65, 65);
            bouton1.BackColor = Color.White;

            /*for (int nblignes = 0; nblignes.Length; nblignes++)
            {
                Button bouton = new Button();
                for (int nbcolonnes = 0; nbcolonnes.Length; nbcolonnes++)
                {

                }
            }*/
        }

       
    }
}
