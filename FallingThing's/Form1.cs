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
        bool movimentoSinistra = false;
        bool movimentoDestra = false;
        int velocitaPersonaggio= 5;
        PictureBox[] Immagini = new PictureBox[10];
        Random random = new Random();

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            int nuovaSinistra = pictureBox1.Left;
            if (movimentoSinistra)
            {
                nuovaSinistra -= velocitaPersonaggio;
            }
            else if (movimentoDestra)
            {
                nuovaSinistra += velocitaPersonaggio;
            }
            if (nuovaSinistra>= 0 && nuovaSinistra + pictureBox1.Width <= this.ClientSize.Width)
            {
                pictureBox1.Left = nuovaSinistra;
            }
          
        }

        private void timerCadutaOggetti_Tick(object sender, EventArgs e)
        {
            int velocitaCaduta = 5;
            pictureBox2.Top += velocitaCaduta;
            if (pictureBox2.Top >= this.ClientSize.Height - pictureBox1.Height)
            {
                pictureBox2.Top = 0;
            }
        }
    }
}
