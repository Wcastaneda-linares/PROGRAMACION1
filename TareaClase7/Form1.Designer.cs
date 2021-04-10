
namespace LIstado_de_Alumnos
{
    partial class Form1
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
            this.Arreglo = new System.Windows.Forms.ListBox();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonPromedios = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonOrdenar = new System.Windows.Forms.Button();
            this.buttonPromediosGenerales = new System.Windows.Forms.Button();
            this.buttonMenoryMayor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Arreglo
            // 
            this.Arreglo.FormattingEnabled = true;
            this.Arreglo.ItemHeight = 18;
            this.Arreglo.Location = new System.Drawing.Point(162, 320);
            this.Arreglo.Name = "Arreglo";
            this.Arreglo.Size = new System.Drawing.Size(579, 256);
            this.Arreglo.TabIndex = 1;
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(162, 11);
            this.textBoxResultado.Multiline = true;
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResultado.Size = new System.Drawing.Size(579, 283);
            this.textBoxResultado.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cargar Archivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPromedios
            // 
            this.buttonPromedios.Enabled = false;
            this.buttonPromedios.Location = new System.Drawing.Point(31, 147);
            this.buttonPromedios.Name = "buttonPromedios";
            this.buttonPromedios.Size = new System.Drawing.Size(112, 34);
            this.buttonPromedios.TabIndex = 5;
            this.buttonPromedios.Text = "Promedios Por Alumno";
            this.buttonPromedios.UseVisualStyleBackColor = true;
            this.buttonPromedios.Click += new System.EventHandler(this.buttonPromedios_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Enabled = false;
            this.buttonLimpiar.Location = new System.Drawing.Point(31, 406);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(108, 31);
            this.buttonLimpiar.TabIndex = 6;
            this.buttonLimpiar.Text = "Limpiar Datos";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonOrdenar
            // 
            this.buttonOrdenar.Enabled = false;
            this.buttonOrdenar.Location = new System.Drawing.Point(31, 196);
            this.buttonOrdenar.Name = "buttonOrdenar";
            this.buttonOrdenar.Size = new System.Drawing.Size(108, 34);
            this.buttonOrdenar.TabIndex = 7;
            this.buttonOrdenar.Text = "Ordenar A-Z";
            this.buttonOrdenar.UseVisualStyleBackColor = true;
            this.buttonOrdenar.Click += new System.EventHandler(this.buttonOrdenar_Click);
            // 
            // buttonPromediosGenerales
            // 
            this.buttonPromediosGenerales.Enabled = false;
            this.buttonPromediosGenerales.Location = new System.Drawing.Point(31, 251);
            this.buttonPromediosGenerales.Name = "buttonPromediosGenerales";
            this.buttonPromediosGenerales.Size = new System.Drawing.Size(108, 54);
            this.buttonPromediosGenerales.TabIndex = 8;
            this.buttonPromediosGenerales.Text = "Promedios Generales";
            this.buttonPromediosGenerales.UseVisualStyleBackColor = true;
            this.buttonPromediosGenerales.Click += new System.EventHandler(this.buttonPromediosGenerales_Click);
            // 
            // buttonMenoryMayor
            // 
            this.buttonMenoryMayor.Enabled = false;
            this.buttonMenoryMayor.Location = new System.Drawing.Point(31, 331);
            this.buttonMenoryMayor.Name = "buttonMenoryMayor";
            this.buttonMenoryMayor.Size = new System.Drawing.Size(108, 56);
            this.buttonMenoryMayor.TabIndex = 9;
            this.buttonMenoryMayor.Text = "Nota Mayor y Menor";
            this.buttonMenoryMayor.UseVisualStyleBackColor = true;
            this.buttonMenoryMayor.Click += new System.EventHandler(this.buttonMenoryMayor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 593);
            this.Controls.Add(this.buttonMenoryMayor);
            this.Controls.Add(this.buttonPromediosGenerales);
            this.Controls.Add(this.buttonOrdenar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonPromedios);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.Arreglo);
            this.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Listado de Alumnos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox Arreglo;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonPromedios;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonOrdenar;
        private System.Windows.Forms.Button buttonPromediosGenerales;
        private System.Windows.Forms.Button buttonMenoryMayor;
    }
}

