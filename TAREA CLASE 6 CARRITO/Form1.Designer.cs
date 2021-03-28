
using System;

namespace Toyota_Yaris
{
    partial class botonQuinta
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BotonInicio = new System.Windows.Forms.Button();
            this.labelEstado = new System.Windows.Forms.Label();
            this.buttonEncender = new System.Windows.Forms.Button();
            this.buttonAcelerar = new System.Windows.Forms.Button();
            this.labelEstadoVelocidad = new System.Windows.Forms.Label();
            this.buttonFrenar = new System.Windows.Forms.Button();
            this.buttonPrimera = new System.Windows.Forms.Button();
            this.buttonSegunda = new System.Windows.Forms.Button();
            this.buttonTercera = new System.Windows.Forms.Button();
            this.buttonCuarta = new System.Windows.Forms.Button();
            this.buttonQuinta = new System.Windows.Forms.Button();
            this.buttonRetroceso = new System.Windows.Forms.Button();
            this.labelVel = new System.Windows.Forms.Label();
            this.buttonMusica = new System.Windows.Forms.Button();
            this.pictureBoxDetener = new System.Windows.Forms.PictureBox();
            this.pictureDetener = new System.Windows.Forms.PictureBox();
            this.picturePlay = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetener)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDetener)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // BotonInicio
            // 
            this.BotonInicio.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BotonInicio.Location = new System.Drawing.Point(346, 53);
            this.BotonInicio.Name = "BotonInicio";
            this.BotonInicio.Size = new System.Drawing.Size(128, 41);
            this.BotonInicio.TabIndex = 0;
            this.BotonInicio.Text = "Crear Carro";
            this.BotonInicio.UseVisualStyleBackColor = false;
            this.BotonInicio.Click += new System.EventHandler(this.BotonInicio_Click);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.BackColor = System.Drawing.Color.Red;
            this.labelEstado.ForeColor = System.Drawing.Color.Black;
            this.labelEstado.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelEstado.Location = new System.Drawing.Point(292, 9);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(143, 25);
            this.labelEstado.TabIndex = 1;
            this.labelEstado.Text = "Estado del Carro";
            this.labelEstado.Visible = false;
            // 
            // buttonEncender
            // 
            this.buttonEncender.BackColor = System.Drawing.Color.Red;
            this.buttonEncender.Location = new System.Drawing.Point(538, 177);
            this.buttonEncender.Name = "buttonEncender";
            this.buttonEncender.Size = new System.Drawing.Size(77, 45);
            this.buttonEncender.TabIndex = 2;
            this.buttonEncender.Text = "On/Off";
            this.buttonEncender.UseVisualStyleBackColor = false;
            this.buttonEncender.Visible = false;
            this.buttonEncender.Click += new System.EventHandler(this.buttonEncender_Click);
            // 
            // buttonAcelerar
            // 
            this.buttonAcelerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAcelerar.Location = new System.Drawing.Point(414, 297);
            this.buttonAcelerar.Name = "buttonAcelerar";
            this.buttonAcelerar.Size = new System.Drawing.Size(89, 41);
            this.buttonAcelerar.TabIndex = 3;
            this.buttonAcelerar.Text = "Acelerar";
            this.buttonAcelerar.UseVisualStyleBackColor = false;
            this.buttonAcelerar.Visible = false;
            this.buttonAcelerar.Click += new System.EventHandler(this.buttonAcelerar_Click);
            // 
            // labelEstadoVelocidad
            // 
            this.labelEstadoVelocidad.AutoSize = true;
            this.labelEstadoVelocidad.Location = new System.Drawing.Point(346, 119);
            this.labelEstadoVelocidad.Name = "labelEstadoVelocidad";
            this.labelEstadoVelocidad.Size = new System.Drawing.Size(89, 25);
            this.labelEstadoVelocidad.TabIndex = 4;
            this.labelEstadoVelocidad.Text = "Velocidad";
            this.labelEstadoVelocidad.Visible = false;
            // 
            // buttonFrenar
            // 
            this.buttonFrenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonFrenar.Location = new System.Drawing.Point(283, 295);
            this.buttonFrenar.Name = "buttonFrenar";
            this.buttonFrenar.Size = new System.Drawing.Size(72, 43);
            this.buttonFrenar.TabIndex = 5;
            this.buttonFrenar.Text = "Frenar";
            this.buttonFrenar.UseVisualStyleBackColor = false;
            this.buttonFrenar.Visible = false;
            this.buttonFrenar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPrimera
            // 
            this.buttonPrimera.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonPrimera.Location = new System.Drawing.Point(638, 278);
            this.buttonPrimera.Name = "buttonPrimera";
            this.buttonPrimera.Size = new System.Drawing.Size(29, 34);
            this.buttonPrimera.TabIndex = 6;
            this.buttonPrimera.Text = "1";
            this.buttonPrimera.UseVisualStyleBackColor = true;
            this.buttonPrimera.Visible = false;
            this.buttonPrimera.Click += new System.EventHandler(this.buttonPrimera_Click);
            // 
            // buttonSegunda
            // 
            this.buttonSegunda.Location = new System.Drawing.Point(662, 318);
            this.buttonSegunda.Name = "buttonSegunda";
            this.buttonSegunda.Size = new System.Drawing.Size(27, 34);
            this.buttonSegunda.TabIndex = 7;
            this.buttonSegunda.Text = "2";
            this.buttonSegunda.UseVisualStyleBackColor = true;
            this.buttonSegunda.Visible = false;
            this.buttonSegunda.Click += new System.EventHandler(this.buttonSegunda_Click);
            // 
            // buttonTercera
            // 
            this.buttonTercera.Location = new System.Drawing.Point(682, 278);
            this.buttonTercera.Name = "buttonTercera";
            this.buttonTercera.Size = new System.Drawing.Size(25, 34);
            this.buttonTercera.TabIndex = 8;
            this.buttonTercera.Text = "3";
            this.buttonTercera.UseVisualStyleBackColor = true;
            this.buttonTercera.Visible = false;
            this.buttonTercera.Click += new System.EventHandler(this.buttonTercera_Click);
            // 
            // buttonCuarta
            // 
            this.buttonCuarta.Location = new System.Drawing.Point(695, 318);
            this.buttonCuarta.Name = "buttonCuarta";
            this.buttonCuarta.Size = new System.Drawing.Size(27, 34);
            this.buttonCuarta.TabIndex = 9;
            this.buttonCuarta.Text = "4";
            this.buttonCuarta.UseVisualStyleBackColor = true;
            this.buttonCuarta.Visible = false;
            this.buttonCuarta.Click += new System.EventHandler(this.buttonCuarta_Click);
            // 
            // buttonQuinta
            // 
            this.buttonQuinta.Location = new System.Drawing.Point(713, 278);
            this.buttonQuinta.Name = "buttonQuinta";
            this.buttonQuinta.Size = new System.Drawing.Size(29, 34);
            this.buttonQuinta.TabIndex = 10;
            this.buttonQuinta.Text = "5";
            this.buttonQuinta.UseVisualStyleBackColor = true;
            this.buttonQuinta.Visible = false;
            this.buttonQuinta.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonRetroceso
            // 
            this.buttonRetroceso.Location = new System.Drawing.Point(744, 318);
            this.buttonRetroceso.Name = "buttonRetroceso";
            this.buttonRetroceso.Size = new System.Drawing.Size(34, 34);
            this.buttonRetroceso.TabIndex = 11;
            this.buttonRetroceso.Text = "R";
            this.buttonRetroceso.UseVisualStyleBackColor = true;
            this.buttonRetroceso.Visible = false;
            this.buttonRetroceso.Click += new System.EventHandler(this.buttonRetroceso_Click);
            // 
            // labelVel
            // 
            this.labelVel.AutoSize = true;
            this.labelVel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelVel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelVel.Location = new System.Drawing.Point(400, 177);
            this.labelVel.Name = "labelVel";
            this.labelVel.Size = new System.Drawing.Size(35, 25);
            this.labelVel.TabIndex = 12;
            this.labelVel.Text = "Vel";
            this.labelVel.Visible = false;
            // 
            // buttonMusica
            // 
            this.buttonMusica.BackColor = System.Drawing.Color.Blue;
            this.buttonMusica.Location = new System.Drawing.Point(695, 168);
            this.buttonMusica.Name = "buttonMusica";
            this.buttonMusica.Size = new System.Drawing.Size(100, 34);
            this.buttonMusica.TabIndex = 15;
            this.buttonMusica.Text = "Musica";
            this.buttonMusica.UseVisualStyleBackColor = false;
            this.buttonMusica.Visible = false;
            this.buttonMusica.Click += new System.EventHandler(this.buttonMusica_Click);
            // 
            // pictureBoxDetener
            // 
            this.pictureBoxDetener.Image = global::Toyota_Yaris.Properties.Resources.toyota_auris_2015_hd_58716;
            this.pictureBoxDetener.Location = new System.Drawing.Point(0, 1);
            this.pictureBoxDetener.Name = "pictureBoxDetener";
            this.pictureBoxDetener.Size = new System.Drawing.Size(967, 403);
            this.pictureBoxDetener.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDetener.TabIndex = 14;
            this.pictureBoxDetener.TabStop = false;
            this.pictureBoxDetener.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureDetener
            // 
            this.pictureDetener.Image = global::Toyota_Yaris.Properties.Resources.pausa;
            this.pictureDetener.Location = new System.Drawing.Point(627, 223);
            this.pictureDetener.Name = "pictureDetener";
            this.pictureDetener.Size = new System.Drawing.Size(40, 35);
            this.pictureDetener.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDetener.TabIndex = 16;
            this.pictureDetener.TabStop = false;
            this.pictureDetener.Visible = false;
            this.pictureDetener.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // picturePlay
            // 
            this.picturePlay.Image = global::Toyota_Yaris.Properties.Resources.play;
            this.picturePlay.Location = new System.Drawing.Point(686, 220);
            this.picturePlay.Name = "picturePlay";
            this.picturePlay.Size = new System.Drawing.Size(36, 37);
            this.picturePlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePlay.TabIndex = 17;
            this.picturePlay.TabStop = false;
            this.picturePlay.Visible = false;
            this.picturePlay.Click += new System.EventHandler(this.picturePlay_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Toyota_Yaris.Properties.Resources.detener;
            this.pictureBox4.Location = new System.Drawing.Point(739, 223);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(39, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // botonQuinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(965, 403);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.picturePlay);
            this.Controls.Add(this.pictureDetener);
            this.Controls.Add(this.buttonMusica);
            this.Controls.Add(this.labelVel);
            this.Controls.Add(this.buttonRetroceso);
            this.Controls.Add(this.buttonQuinta);
            this.Controls.Add(this.buttonCuarta);
            this.Controls.Add(this.buttonTercera);
            this.Controls.Add(this.buttonSegunda);
            this.Controls.Add(this.buttonPrimera);
            this.Controls.Add(this.buttonFrenar);
            this.Controls.Add(this.labelEstadoVelocidad);
            this.Controls.Add(this.buttonAcelerar);
            this.Controls.Add(this.buttonEncender);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.BotonInicio);
            this.Controls.Add(this.pictureBoxDetener);
            this.Name = "botonQuinta";
            this.Text = "Toyota Yaris";
            this.Load += new System.EventHandler(this.buttonInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetener)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDetener)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button BotonInicio;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Button buttonEncender;
        private System.Windows.Forms.Button buttonAcelerar;
        private System.Windows.Forms.Label labelEstadoVelocidad;
        private System.Windows.Forms.Button buttonFrenar;
        private System.Windows.Forms.Button buttonPrimera;
        private System.Windows.Forms.Button buttonSegunda;
        private System.Windows.Forms.Button buttonTercera;
        private System.Windows.Forms.Button buttonCuarta;
        private System.Windows.Forms.Button buttonQuinta;
        private System.Windows.Forms.Button buttonRetroceso;
        private System.Windows.Forms.Label labelVel;
        private System.Windows.Forms.Button buttonMusica;
        private System.Windows.Forms.PictureBox pictureBoxDetener;
        private System.Windows.Forms.PictureBox pictureDetener;
        private System.Windows.Forms.PictureBox picturePlay;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

