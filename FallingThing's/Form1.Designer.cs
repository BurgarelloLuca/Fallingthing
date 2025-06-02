namespace FallingThing_s
{
    partial class formGioco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formGioco));
            this.timerPersonaggio = new System.Windows.Forms.Timer(this.components);
            this.timerCadutaOggetti = new System.Windows.Forms.Timer(this.components);
            this.lblPunteggio = new System.Windows.Forms.Label();
            this.Oggetto1 = new System.Windows.Forms.PictureBox();
            this.Oggetto3 = new System.Windows.Forms.PictureBox();
            this.cuore3 = new System.Windows.Forms.PictureBox();
            this.cuore2 = new System.Windows.Forms.PictureBox();
            this.cuore1 = new System.Windows.Forms.PictureBox();
            this.tronco = new System.Windows.Forms.PictureBox();
            this.lblTesto = new System.Windows.Forms.Label();
            this.Oggetto2 = new System.Windows.Forms.PictureBox();
            this.personaggio = new System.Windows.Forms.PictureBox();
            this.Pausa = new System.Windows.Forms.PictureBox();
            this.ptcAudio = new System.Windows.Forms.PictureBox();
            this.pctMuta = new System.Windows.Forms.PictureBox();
            this.btnPLAY = new System.Windows.Forms.Button();
            this.btnIstruzioni = new System.Windows.Forms.Button();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Oggetto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Oggetto3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuore3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuore2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuore1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tronco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Oggetto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaggio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pausa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcAudio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMuta)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.lblPunteggio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPunteggio.AutoSize = true;
            this.lblPunteggio.BackColor = System.Drawing.Color.Transparent;
            this.lblPunteggio.Font = new System.Drawing.Font("SimSun-ExtB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunteggio.ForeColor = System.Drawing.Color.White;
            this.lblPunteggio.Image = ((System.Drawing.Image)(resources.GetObject("lblPunteggio.Image")));
            this.lblPunteggio.Location = new System.Drawing.Point(988, 531);
            this.lblPunteggio.Name = "lblPunteggio";
            this.lblPunteggio.Size = new System.Drawing.Size(88, 24);
            this.lblPunteggio.TabIndex = 3;
            this.lblPunteggio.Text = "0 Kcal";
            this.lblPunteggio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Oggetto1
            // 
            this.Oggetto1.BackColor = System.Drawing.Color.Transparent;
            this.Oggetto1.Image = global::FallingThing_s.Properties.Resources.Flopper;
            this.Oggetto1.Location = new System.Drawing.Point(667, -100);
            this.Oggetto1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Oggetto1.Name = "Oggetto1";
            this.Oggetto1.Size = new System.Drawing.Size(73, 73);
            this.Oggetto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Oggetto1.TabIndex = 9;
            this.Oggetto1.TabStop = false;
            // 
            // Oggetto3
            // 
            this.Oggetto3.BackColor = System.Drawing.Color.Transparent;
            this.Oggetto3.Image = global::FallingThing_s.Properties.Resources.Rottame;
            this.Oggetto3.Location = new System.Drawing.Point(1117, -2700);
            this.Oggetto3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Oggetto3.Name = "Oggetto3";
            this.Oggetto3.Size = new System.Drawing.Size(77, 73);
            this.Oggetto3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Oggetto3.TabIndex = 8;
            this.Oggetto3.TabStop = false;
            // 
            // cuore3
            // 
            this.cuore3.BackColor = System.Drawing.Color.Transparent;
            this.cuore3.Image = global::FallingThing_s.Properties.Resources.Cuore;
            this.cuore3.Location = new System.Drawing.Point(120, 12);
            this.cuore3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cuore3.Name = "cuore3";
            this.cuore3.Size = new System.Drawing.Size(53, 49);
            this.cuore3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cuore3.TabIndex = 7;
            this.cuore3.TabStop = false;
            // 
            // cuore2
            // 
            this.cuore2.BackColor = System.Drawing.Color.Transparent;
            this.cuore2.Image = global::FallingThing_s.Properties.Resources.Cuore;
            this.cuore2.Location = new System.Drawing.Point(64, 12);
            this.cuore2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cuore2.Name = "cuore2";
            this.cuore2.Size = new System.Drawing.Size(61, 49);
            this.cuore2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cuore2.TabIndex = 6;
            this.cuore2.TabStop = false;
            // 
            // cuore1
            // 
            this.cuore1.BackColor = System.Drawing.Color.Transparent;
            this.cuore1.Image = global::FallingThing_s.Properties.Resources.Cuore;
            this.cuore1.Location = new System.Drawing.Point(12, 12);
            this.cuore1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cuore1.Name = "cuore1";
            this.cuore1.Size = new System.Drawing.Size(59, 49);
            this.cuore1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cuore1.TabIndex = 5;
            this.cuore1.TabStop = false;
            // 
            // tronco
            // 
            this.tronco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tronco.BackColor = System.Drawing.Color.Transparent;
            this.tronco.BackgroundImage = global::FallingThing_s.Properties.Resources.Tronco;
            this.tronco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tronco.ImageLocation = "";
            this.tronco.InitialImage = null;
            this.tronco.Location = new System.Drawing.Point(910, 452);
            this.tronco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tronco.Name = "tronco";
            this.tronco.Size = new System.Drawing.Size(224, 138);
            this.tronco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tronco.TabIndex = 4;
            this.tronco.TabStop = false;
            // 
            // lblTesto
            // 
            this.lblTesto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTesto.BackColor = System.Drawing.Color.Transparent;
            this.lblTesto.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTesto.ForeColor = System.Drawing.Color.White;
            this.lblTesto.Image = ((System.Drawing.Image)(resources.GetObject("lblTesto.Image")));
            this.lblTesto.Location = new System.Drawing.Point(978, 480);
            this.lblTesto.Name = "lblTesto";
            this.lblTesto.Size = new System.Drawing.Size(122, 63);
            this.lblTesto.TabIndex = 1;
            this.lblTesto.Text = "Ti stai saziando?";
            this.lblTesto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Oggetto2
            // 
            this.Oggetto2.BackColor = System.Drawing.Color.Transparent;
            this.Oggetto2.Image = ((System.Drawing.Image)(resources.GetObject("Oggetto2.Image")));
            this.Oggetto2.Location = new System.Drawing.Point(871, -1500);
            this.Oggetto2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Oggetto2.Name = "Oggetto2";
            this.Oggetto2.Size = new System.Drawing.Size(61, 60);
            this.Oggetto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Oggetto2.TabIndex = 1;
            this.Oggetto2.TabStop = false;
            // 
            // personaggio
            // 
            this.personaggio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.personaggio.BackColor = System.Drawing.Color.Transparent;
            this.personaggio.BackgroundImage = global::FallingThing_s.Properties.Resources.personaggio;
            this.personaggio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.personaggio.Location = new System.Drawing.Point(483, 423);
            this.personaggio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.personaggio.Name = "personaggio";
            this.personaggio.Size = new System.Drawing.Size(150, 191);
            this.personaggio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.personaggio.TabIndex = 0;
            this.personaggio.TabStop = false;
            // 
            // Pausa
            // 
            this.Pausa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pausa.BackColor = System.Drawing.Color.Transparent;
            this.Pausa.Image = ((System.Drawing.Image)(resources.GetObject("Pausa.Image")));
            this.Pausa.Location = new System.Drawing.Point(992, -1);
            this.Pausa.Margin = new System.Windows.Forms.Padding(4);
            this.Pausa.Name = "Pausa";
            this.Pausa.Size = new System.Drawing.Size(108, 62);
            this.Pausa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pausa.TabIndex = 12;
            this.Pausa.TabStop = false;
            this.Pausa.Visible = false;
            this.Pausa.Click += new System.EventHandler(this.Pausa_Click);
            // 
            // ptcAudio
            // 
            this.ptcAudio.BackColor = System.Drawing.Color.Transparent;
            this.ptcAudio.Image = global::FallingThing_s.Properties.Resources.AUDIOO;
            this.ptcAudio.Location = new System.Drawing.Point(910, 12);
            this.ptcAudio.Margin = new System.Windows.Forms.Padding(4);
            this.ptcAudio.Name = "ptcAudio";
            this.ptcAudio.Size = new System.Drawing.Size(60, 42);
            this.ptcAudio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptcAudio.TabIndex = 15;
            this.ptcAudio.TabStop = false;
            this.ptcAudio.Click += new System.EventHandler(this.ptcAudio_Click);
            // 
            // pctMuta
            // 
            this.pctMuta.BackColor = System.Drawing.Color.Transparent;
            this.pctMuta.Image = ((System.Drawing.Image)(resources.GetObject("pctMuta.Image")));
            this.pctMuta.Location = new System.Drawing.Point(831, 12);
            this.pctMuta.Margin = new System.Windows.Forms.Padding(4);
            this.pctMuta.Name = "pctMuta";
            this.pctMuta.Size = new System.Drawing.Size(71, 42);
            this.pctMuta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctMuta.TabIndex = 16;
            this.pctMuta.TabStop = false;
            this.pctMuta.Click += new System.EventHandler(this.pctMuta_Click);
            // 
            // btnPLAY
            // 
            this.btnPLAY.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPLAY.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnPLAY.Image = global::FallingThing_s.Properties.Resources.Play;
            this.btnPLAY.Location = new System.Drawing.Point(201, 74);
            this.btnPLAY.Margin = new System.Windows.Forms.Padding(4);
            this.btnPLAY.Name = "btnPLAY";
            this.btnPLAY.Size = new System.Drawing.Size(260, 60);
            this.btnPLAY.TabIndex = 0;
            this.btnPLAY.UseVisualStyleBackColor = true;
            this.btnPLAY.Click += new System.EventHandler(this.btnPLAY_Click);
            // 
            // btnIstruzioni
            // 
            this.btnIstruzioni.Image = global::FallingThing_s.Properties.Resources.Options;
            this.btnIstruzioni.Location = new System.Drawing.Point(201, 169);
            this.btnIstruzioni.Margin = new System.Windows.Forms.Padding(4);
            this.btnIstruzioni.Name = "btnIstruzioni";
            this.btnIstruzioni.Size = new System.Drawing.Size(260, 64);
            this.btnIstruzioni.TabIndex = 1;
            this.btnIstruzioni.UseVisualStyleBackColor = true;
            this.btnIstruzioni.Click += new System.EventHandler(this.btnIstruzioni_Click);
            // 
            // btnEXIT
            // 
            this.btnEXIT.Image = global::FallingThing_s.Properties.Resources.Exit;
            this.btnEXIT.Location = new System.Drawing.Point(201, 268);
            this.btnEXIT.Margin = new System.Windows.Forms.Padding(4);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(260, 65);
            this.btnEXIT.TabIndex = 2;
            this.btnEXIT.UseVisualStyleBackColor = true;
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnEXIT);
            this.panel1.Controls.Add(this.btnIstruzioni);
            this.panel1.Controls.Add(this.btnPLAY);
            this.panel1.Location = new System.Drawing.Point(215, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 404);
            this.panel1.TabIndex = 11;
            // 
            // formGioco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FallingThing_s.Properties.Resources.sfondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1098, 724);
            this.Controls.Add(this.personaggio);
            this.Controls.Add(this.pctMuta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ptcAudio);
            this.Controls.Add(this.lblPunteggio);
            this.Controls.Add(this.Pausa);
            this.Controls.Add(this.lblTesto);
            this.Controls.Add(this.Oggetto1);
            this.Controls.Add(this.Oggetto3);
            this.Controls.Add(this.cuore3);
            this.Controls.Add(this.cuore2);
            this.Controls.Add(this.cuore1);
            this.Controls.Add(this.tronco);
            this.Controls.Add(this.Oggetto2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "formGioco";
            this.Text = "FallingThings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formGioco_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Oggetto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Oggetto3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuore3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuore2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuore1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tronco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Oggetto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaggio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pausa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcAudio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMuta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerPersonaggio;
        private System.Windows.Forms.PictureBox Oggetto2;
        private System.Windows.Forms.Timer timerCadutaOggetti;
        private System.Windows.Forms.Label lblTesto;
        private System.Windows.Forms.Label lblPunteggio;
        private System.Windows.Forms.PictureBox tronco;
        private System.Windows.Forms.PictureBox cuore1;
        private System.Windows.Forms.PictureBox cuore2;
        private System.Windows.Forms.PictureBox cuore3;
        private System.Windows.Forms.PictureBox Oggetto3;
        private System.Windows.Forms.PictureBox Oggetto1;
        private System.Windows.Forms.PictureBox personaggio;
        private System.Windows.Forms.PictureBox Pausa;
        private System.Windows.Forms.PictureBox ptcAudio;
        private System.Windows.Forms.PictureBox pctMuta;
        private System.Windows.Forms.Button btnPLAY;
        private System.Windows.Forms.Button btnIstruzioni;
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.Panel panel1;
    }
}

