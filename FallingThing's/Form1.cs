using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FallingThing_s
{
    public partial class Form1: Form
    {
        Random random = new Random();
        bool movimentoSinistra = false;
        bool movimentoDestra = false;
        int velocitaPersonaggio = 5;
        PictureBox[] immagini = new PictureBox[3];
      


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
        
            if(e.KeyCode == Keys.A)
            {
                movimentoSinistra = true;
            }
            else if (e.KeyCode == Keys.D)
            {
                movimentoDestra = true;
            }
            timerPersonaggio.Start();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                movimentoSinistra = false;
            }
            else if (e.KeyCode == Keys.D)
            {
                movimentoDestra = false;
            }
            if (!movimentoSinistra && !movimentoDestra)
            {
                timerPersonaggio.Stop();
            }
        }

        private void timerPersonaggio_Tick(object sender, EventArgs e)
        {
            int nuovaSinistra = personaggio.Left;
            if (movimentoSinistra)
            {
                nuovaSinistra -= velocitaPersonaggio;
            }
            else if (movimentoDestra)
            {
                nuovaSinistra += velocitaPersonaggio;
            }
            if (nuovaSinistra>= 0 && nuovaSinistra + personaggio.Width <= this.ClientSize.Width-lblTesto.Width)
            {
                personaggio.Left = nuovaSinistra;
            }
          
        }
        private void cadutaOggetto(int velocitaCaduta, int punteggio)
        {
            oggetto.Top += velocitaCaduta;

            if (oggetto.Bounds.IntersectsWith(personaggio.Bounds))
            {
                oggetto.Top = 0;
                oggetto.Left = random.Next(0 , this.ClientSize.Width - oggetto.Width - lblTesto.Width);
                string[] parole = lblPunteggio.Text.Split(' ');
                if (int.TryParse(parole[0], out punteggio))
                {
                    punteggio += 125;
                    lblPunteggio.Text = punteggio.ToString() + " Kcal ";
                }
                    
            }
            if (oggetto.Top > this.ClientSize.Height)
            {
                oggetto.Top = 0;
                oggetto.Left = random.Next(0, this.ClientSize.Width - oggetto.Width - lblTesto.Width);
            }
        }
        private void timerCadutaOggetti_Tick(object sender, EventArgs e)
        {
            cadutaOggetto(5,100);
        }

    }
}
