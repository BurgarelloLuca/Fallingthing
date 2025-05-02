namespace FallingThing_s
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerPersonaggio = new System.Windows.Forms.Timer(this.components);
            this.timerCadutaOggetti = new System.Windows.Forms.Timer(this.components);
            this.lblPunteggio = new System.Windows.Forms.Label();
            this.lblTesto = new System.Windows.Forms.Label();
            this.oggetto = new System.Windows.Forms.PictureBox();
            this.personaggio = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.oggetto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaggio)).BeginInit();
            this.SuspendLayout();
            // 
            // timerPersonaggio
            // 
            this.timerPersonaggio.Interval = 10;
            this.timerPersonaggio.Tick += new System.EventHandler(this.timerPersonaggio_Tick);
            // 
            // timerCadutaOggetti
            // 
            this.timerCadutaOggetti.Enabled = true;
            this.timerCadutaOggetti.Interval = 10;
            this.timerCadutaOggetti.Tick += new System.EventHandler(this.timerCadutaOggetti_Tick);
            // 
            // lblPunteggio
            // 
            this.lblPunteggio.AutoSize = true;
            this.lblPunteggio.BackColor = System.Drawing.Color.Transparent;
            this.lblPunteggio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunteggio.ForeColor = System.Drawing.Color.White;
            this.lblPunteggio.Location = new System.Drawing.Point(1027, 768);
            this.lblPunteggio.Name = "lblPunteggio";
            this.lblPunteggio.Size = new System.Drawing.Size(79, 29);
            this.lblPunteggio.TabIndex = 3;
            this.lblPunteggio.Text = "0 Kcal";
            this.lblPunteggio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTesto
            // 
            this.lblTesto.BackColor = System.Drawing.Color.Transparent;
            this.lblTesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTesto.ForeColor = System.Drawing.Color.White;
            this.lblTesto.Image = ((System.Drawing.Image)(resources.GetObject("lblTesto.Image")));
            this.lblTesto.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblTesto.Location = new System.Drawing.Point(997, 701);
            this.lblTesto.Name = "lblTesto";
            this.lblTesto.Size = new System.Drawing.Size(141, 121);
            this.lblTesto.TabIndex = 2;
            this.lblTesto.Text = "Ti stai saziando?";
            this.lblTesto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // oggetto
            // 
            this.oggetto.BackColor = System.Drawing.Color.Transparent;
            this.oggetto.Image = ((System.Drawing.Image)(resources.GetObject("oggetto.Image")));
            this.oggetto.Location = new System.Drawing.Point(504, 12);
            this.oggetto.Name = "oggetto";
            this.oggetto.Size = new System.Drawing.Size(115, 59);
            this.oggetto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.oggetto.TabIndex = 1;
            this.oggetto.TabStop = false;
            // 
            // personaggio
            // 
            this.personaggio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.personaggio.BackColor = System.Drawing.Color.Transparent;
            this.personaggio.Image = ((System.Drawing.Image)(resources.GetObject("personaggio.Image")));
            this.personaggio.Location = new System.Drawing.Point(491, 503);
            this.personaggio.Name = "personaggio";
            this.personaggio.Size = new System.Drawing.Size(192, 137);
            this.personaggio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.personaggio.TabIndex = 0;
            this.personaggio.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1139, 822);
            this.Controls.Add(this.lblPunteggio);
            this.Controls.Add(this.lblTesto);
            this.Controls.Add(this.oggetto);
            this.Controls.Add(this.personaggio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.oggetto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaggio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerPersonaggio;
        private System.Windows.Forms.PictureBox personaggio;
        private System.Windows.Forms.PictureBox oggetto;
        private System.Windows.Forms.Timer timerCadutaOggetti;
        private System.Windows.Forms.Label lblTesto;
        private System.Windows.Forms.Label lblPunteggio;
    }
}

