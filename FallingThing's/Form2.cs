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
    public partial class formIniziale: Form
    {
        public formIniziale()
        {
            InitializeComponent();

        }

        private void formIniziale_Click(object sender, EventArgs e)
        {
            formGioco nuovoForm = new formGioco();
            nuovoForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            formGioco nuovoForm = new formGioco();
            nuovoForm.Show();
            this.Hide();
        }
    }
}
