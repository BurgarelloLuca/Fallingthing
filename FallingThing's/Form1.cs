using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FallingThing_s
{

    public partial class Form1 : Form
    {

        Random random = new Random();
        bool movimentoSinistra = false;
        bool movimentoDestra = false;
        int velocitaPersonaggio = 6;
        bool giocoFinito = false;
        bool pausa = false;
        int cuori = 3;


        Image[] immagini = new Image[10]
        {
            Properties.Resources.Fungo,
            Properties.Resources.Anguria,
            Properties.Resources.LeccaLecca,    //100 punti
            Properties.Resources.Mela,

            Properties.Resources.Rottame,
            Properties.Resources.Ruota,         // -200 punti
            Properties.Resources.Peperoncino,

            Properties.Resources.Flopper,
            Properties.Resources.Hamburger,     //500 punti
            Properties.Resources.Cioccolato
        };
        int punteggio = 0;
        PictureBox[] oggettiCadenti;


        public Form1()
        {
            InitializeComponent();

            oggettiCadenti = new PictureBox[]
                {
                Oggetto1,
                Oggetto2,
                Oggetto3
            };
            for (int i = 0; i < oggettiCadenti.Length; i++)
            {
                oggettiCadenti[i].Tag = -1;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!pausa)
            {

                if (e.KeyCode == Keys.A)
                {
                    movimentoSinistra = true;
                }
                else if (e.KeyCode == Keys.D)
                {
                    movimentoDestra = true;
                }
                timerPersonaggio.Start();
            }
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
            if (nuovaSinistra >= 0 && nuovaSinistra + personaggio.Width <= this.ClientSize.Width - tronco.Width)
            {
                personaggio.Left = nuovaSinistra;
            }

        }

        private void timerCadutaOggetti_Tick(object sender, EventArgs e)
        {
            int nuovoIndice;
            for (int i = 0; i < oggettiCadenti.Length; i++)
            {
                int indice = (int)oggettiCadenti[i].Tag;    //indice immagine   
                int velocita;

                if (indice <= 3)
                {
                    velocita = 4;
                }
                else
                {
                    velocita = 7;
                }
                oggettiCadenti[i].Top += velocita;
                if (oggettiCadenti[i].Bounds.IntersectsWith(lblTerreno.Bounds))
                {
                    nuovoIndice = random.Next(0, immagini.Length);
                    oggettiCadenti[i].Image = immagini[nuovoIndice];
                    oggettiCadenti[i].Tag = nuovoIndice;
                    oggettiCadenti[i].Top = 0;
                    oggettiCadenti[i].Left = random.Next(0, this.ClientSize.Width - tronco.Width);
                }
                if (!giocoFinito && oggettiCadenti[i].Bounds.IntersectsWith(personaggio.Bounds))
                {
                    if (indice <= 3)
                    {
                        punteggio += 100;
                    }
                    else if (indice <= 6)
                    {
                        punteggio -= 200;
                    }
                    else
                    {
                        punteggio += 500;
                    }
                    if (indice < 7 && indice > 3)
                    {

                        switch (cuori)
                        {
                            case 3:

                                cuore3.Visible = false;
                                cuori--;
                                break;
                            case 2:
                                cuore2.Visible = false;
                                cuori--;
                                break;
                            case 1:
                                cuore1.Visible = false;
                                cuori--;
                                personaggio.Visible = false;
                                giocoFinito = true;
                                timerPersonaggio.Stop();
                                timerCadutaOggetti.Stop();
                                MessageBox.Show($" Hai perso! \n Hai accomulato {(punteggio + 200).ToString()} kcal");
                                this.Close();
                                return;
                        }
                    }

                    nuovoIndice = random.Next(0, immagini.Length);
                    oggettiCadenti[i].Image = immagini[nuovoIndice];
                    oggettiCadenti[i].Tag = nuovoIndice;
                    oggettiCadenti[i].Top = 0;
                }
            }
            lblPunteggio.Text = punteggio + "kcal";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pausa = true;
            this.DoubleBuffered = true;
            timerCadutaOggetti.Stop();
            timerPersonaggio.Stop();
        }

        private void btnPLAY_Click(object sender, EventArgs e)
        {
            pausa = false;
            panel1.Visible = false;
            timerPersonaggio.Start();
            timerCadutaOggetti.Start();
            Pausa.Visible = true;
        }

        private void btnIstruzioni_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" A -- Sinistra      D -- Destra \n Evita i rottami, il peperoncino e la ruota \n Mangia tutto il resto per accomulare più kcal possibili \n La barretta cioccolato, il pesce e l hamburger ti daranno più kcal");
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pausa_Click(object sender, EventArgs e)
        {
            pausa = true;
            timerCadutaOggetti.Stop();
            timerPersonaggio.Stop();
            panel1.Visible = true;
            Pausa.Visible = false;
        }
    }
}

