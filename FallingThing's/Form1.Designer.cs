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
            this.Oggetto1 = new System.Windows.Forms.PictureBox();
            this.Oggetto3 = new System.Windows.Forms.PictureBox();
            this.cuore3 = new System.Windows.Forms.PictureBox();
            this.cuore2 = new System.Windows.Forms.PictureBox();
            this.cuore1 = new System.Windows.Forms.PictureBox();
            this.tronco = new System.Windows.Forms.PictureBox();
            this.lblTesto = new System.Windows.Forms.Label();
            this.Oggetto2 = new System.Windows.Forms.PictureBox();
            this.lblTerreno = new System.Windows.Forms.Label();
            this.personaggio = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.btnIstruzioni = new System.Windows.Forms.Button();
            this.btnPLAY = new System.Windows.Forms.Button();
            this.Pausa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Oggetto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Oggetto3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuore3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuore2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuore1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tronco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Oggetto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaggio)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pausa)).BeginInit();
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
            this.lblPunteggio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPunteggio.AutoSize = true;
            this.lblPunteggio.BackColor = System.Drawing.Color.Transparent;
            this.lblPunteggio.Font = new System.Drawing.Font("SimSun-ExtB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunteggio.ForeColor = System.Drawing.Color.White;
            this.lblPunteggio.Image = ((System.Drawing.Image)(resources.GetObject("lblPunteggio.Image")));
            this.lblPunteggio.Location = new System.Drawing.Point(1278, 513);
            this.lblPunteggio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPunteggio.Name = "lblPunteggio";
            this.lblPunteggio.Size = new System.Drawing.Size(75, 19);
            this.lblPunteggio.TabIndex = 3;
            this.lblPunteggio.Text = "0 Kcal";
            this.lblPunteggio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Oggetto1
            // 
            this.Oggetto1.BackColor = System.Drawing.Color.Transparent;
            this.Oggetto1.Image = global::FallingThing_s.Properties.Resources.Flopper;
            this.Oggetto1.Location = new System.Drawing.Point(500, -81);
            this.Oggetto1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Oggetto1.Name = "Oggetto1";
            this.Oggetto1.Size = new System.Drawing.Size(55, 59);
            this.Oggetto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Oggetto1.TabIndex = 9;
            this.Oggetto1.TabStop = false;
            // 
            // Oggetto3
            // 
            this.Oggetto3.BackColor = System.Drawing.Color.Transparent;
            this.Oggetto3.Image = global::FallingThing_s.Properties.Resources.Rottame;
            this.Oggetto3.Location = new System.Drawing.Point(838, -2194);
            this.Oggetto3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Oggetto3.Name = "Oggetto3";
            this.Oggetto3.Size = new System.Drawing.Size(58, 59);
            this.Oggetto3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Oggetto3.TabIndex = 8;
            this.Oggetto3.TabStop = false;
            // 
            // cuore3
            // 
            this.cuore3.BackColor = System.Drawing.Color.Transparent;
            this.cuore3.Image = global::FallingThing_s.Properties.Resources.Cuore;
            this.cuore3.Location = new System.Drawing.Point(90, 10);
            this.cuore3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cuore3.Name = "cuore3";
            this.cuore3.Size = new System.Drawing.Size(40, 40);
            this.cuore3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cuore3.TabIndex = 7;
            this.cuore3.TabStop = false;
            // 
            // cuore2
            // 
            this.cuore2.BackColor = System.Drawing.Color.Transparent;
            this.cuore2.Image = global::FallingThing_s.Properties.Resources.Cuore;
            this.cuore2.Location = new System.Drawing.Point(48, 10);
            this.cuore2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cuore2.Name = "cuore2";
            this.cuore2.Size = new System.Drawing.Size(46, 40);
            this.cuore2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cuore2.TabIndex = 6;
            this.cuore2.TabStop = false;
            // 
            // cuore1
            // 
            this.cuore1.BackColor = System.Drawing.Color.Transparent;
            this.cuore1.Image = global::FallingThing_s.Properties.Resources.Cuore;
            this.cuore1.Location = new System.Drawing.Point(9, 10);
            this.cuore1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cuore1.Name = "cuore1";
            this.cuore1.Size = new System.Drawing.Size(44, 40);
            this.cuore1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cuore1.TabIndex = 5;
            this.cuore1.TabStop = false;
            // 
            // tronco
            // 
            this.tronco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tronco.BackColor = System.Drawing.Color.Transparent;
            this.tronco.Image = global::FallingThing_s.Properties.Resources.Tronco;
            this.tronco.InitialImage = null;
            this.tronco.Location = new System.Drawing.Point(1183, 428);
            this.tronco.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tronco.Name = "tronco";
            this.tronco.Size = new System.Drawing.Size(225, 135);
            this.tronco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tronco.TabIndex = 4;
            this.tronco.TabStop = false;
            // 
            // lblTesto
            // 
            this.lblTesto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTesto.BackColor = System.Drawing.Color.Transparent;
            this.lblTesto.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTesto.ForeColor = System.Drawing.Color.White;
            this.lblTesto.Image = ((System.Drawing.Image)(resources.GetObject("lblTesto.Image")));
            this.lblTesto.Location = new System.Drawing.Point(1261, 462);
            this.lblTesto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTesto.Name = "lblTesto";
            this.lblTesto.Size = new System.Drawing.Size(102, 51);
            this.lblTesto.TabIndex = 1;
            this.lblTesto.Text = "Ti stai saziando?";
            this.lblTesto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Oggetto2
            // 
            this.Oggetto2.BackColor = System.Drawing.Color.Transparent;
            this.Oggetto2.Image = ((System.Drawing.Image)(resources.GetObject("Oggetto2.Image")));
            this.Oggetto2.Location = new System.Drawing.Point(653, -1219);
            this.Oggetto2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Oggetto2.Name = "Oggetto2";
            this.Oggetto2.Size = new System.Drawing.Size(46, 49);
            this.Oggetto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Oggetto2.TabIndex = 1;
            this.Oggetto2.TabStop = false;
            // 
            // lblTerreno
            // 
            this.lblTerreno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTerreno.BackColor = System.Drawing.Color.Transparent;
            this.lblTerreno.Location = new System.Drawing.Point(9, 565);
            this.lblTerreno.Name = "lblTerreno";
            this.lblTerreno.Size = new System.Drawing.Size(1636, 29);
            this.lblTerreno.TabIndex = 10;
            this.lblTerreno.Visible = false;
            // 
            // personaggio
            // 
            this.personaggio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.personaggio.BackColor = System.Drawing.Color.Transparent;
            this.personaggio.Image = ((System.Drawing.Image)(resources.GetObject("personaggio.Image")));
            this.personaggio.Location = new System.Drawing.Point(612, 428);
            this.personaggio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.personaggio.Name = "personaggio";
            this.personaggio.Size = new System.Drawing.Size(134, 155);
            this.personaggio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.personaggio.TabIndex = 0;
            this.personaggio.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnEXIT);
            this.panel1.Controls.Add(this.btnIstruzioni);
            this.panel1.Controls.Add(this.btnPLAY);
            this.panel1.Location = new System.Drawing.Point(428, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 328);
            this.panel1.TabIndex = 11;
            // 
            // btnEXIT
            // 
            this.btnEXIT.Image = global::FallingThing_s.Properties.Resources.Exit;
            this.btnEXIT.Location = new System.Drawing.Point(151, 218);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(195, 53);
            this.btnEXIT.TabIndex = 2;
            this.btnEXIT.UseVisualStyleBackColor = true;
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // btnIstruzioni
            // 
            this.btnIstruzioni.Image = global::FallingThing_s.Properties.Resources.Options;
            this.btnIstruzioni.Location = new System.Drawing.Point(151, 137);
            this.btnIstruzioni.Name = "btnIstruzioni";
            this.btnIstruzioni.Size = new System.Drawing.Size(195, 52);
            this.btnIstruzioni.TabIndex = 1;
            this.btnIstruzioni.UseVisualStyleBackColor = true;
            this.btnIstruzioni.Click += new System.EventHandler(this.btnIstruzioni_Click);
            // 
            // btnPLAY
            // 
            this.btnPLAY.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPLAY.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnPLAY.Image = global::FallingThing_s.Properties.Resources.Play;
            this.btnPLAY.Location = new System.Drawing.Point(151, 60);
            this.btnPLAY.Name = "btnPLAY";
            this.btnPLAY.Size = new System.Drawing.Size(195, 49);
            this.btnPLAY.TabIndex = 0;
            this.btnPLAY.UseVisualStyleBackColor = true;
            this.btnPLAY.Click += new System.EventHandler(this.btnPLAY_Click);
            // 
            // Pausa
            // 
            this.Pausa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pausa.BackColor = System.Drawing.Color.Transparent;
            this.Pausa.Image = ((System.Drawing.Image)(resources.GetObject("Pausa.Image")));
            this.Pausa.Location = new System.Drawing.Point(1263, 10);
            this.Pausa.Name = "Pausa";
            this.Pausa.Size = new System.Drawing.Size(100, 50);
            this.Pausa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pausa.TabIndex = 12;
            this.Pausa.TabStop = false;
            this.Pausa.Visible = false;
            this.Pausa.Click += new System.EventHandler(this.Pausa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1364, 705);
            this.Controls.Add(this.Pausa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.personaggio);
            this.Controls.Add(this.lblPunteggio);
            this.Controls.Add(this.lblTerreno);
            this.Controls.Add(this.lblTesto);
            this.Controls.Add(this.Oggetto1);
            this.Controls.Add(this.Oggetto3);
            this.Controls.Add(this.cuore3);
            this.Controls.Add(this.cuore2);
            this.Controls.Add(this.cuore1);
            this.Controls.Add(this.tronco);
            this.Controls.Add(this.Oggetto2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FallingThings";
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
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pausa)).EndInit();
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
        private System.Windows.Forms.Label lblTerreno;
        private System.Windows.Forms.PictureBox personaggio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.Button btnIstruzioni;
        private System.Windows.Forms.Button btnPLAY;
        private System.Windows.Forms.PictureBox Pausa;
    }
}

