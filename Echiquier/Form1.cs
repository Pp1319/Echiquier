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


        private void EventSaisie(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            int nbBouton;
            int x = 0;
            int y = 0;
            int hauteur = 65;
            int largeur = 65;

            if (!int.TryParse(textBox.Text, out nbBouton))
            {
                textBox.Text = string.Empty;
            }

            for (int i = 0; i < nbBouton; i++)
            {
                
                for (int j = 0; j < nbBouton; j++)
                {
                    Button bouton1 = new Button();
                    bouton1.Location = new Point(x,y);
                    bouton1.Size = new Size(65, 65);
                    if (x % 2 == 0)
                    {
                        bouton1.BackColor = Color.White;
                    }
                    else
                    {
                        bouton1.BackColor = Color.Black;
                    }
                    this.panel1.Controls.Add(bouton1);
                    x+=largeur;
                    
                }
                y += hauteur;
                x = 0;
            }
            
        }
    }
}
