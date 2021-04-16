
namespace SEGUNDO_PARCIAL
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
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.buttonPromedio = new System.Windows.Forms.Button();
            this.buttonPromediosPorSeccion = new System.Windows.Forms.Button();
            this.buttonPromediosGeneralSeccion = new System.Windows.Forms.Button();
            this.ClasificarAlumnos = new System.Windows.Forms.Button();
            this.buttonNombreNotaMayor = new System.Windows.Forms.Button();
            this.buttonNombreNotaMayorSeccion = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(349, 11);
            this.textBoxResultado.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxResultado.Multiline = true;
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResultado.Size = new System.Drawing.Size(592, 240);
            this.textBoxResultado.TabIndex = 0;
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.ItemHeight = 15;
            this.listBoxResultado.Location = new System.Drawing.Point(349, 264);
            this.listBoxResultado.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.ScrollAlwaysVisible = true;
            this.listBoxResultado.Size = new System.Drawing.Size(592, 289);
            this.listBoxResultado.TabIndex = 1;
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(57, 16);
            this.buttonCargar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(125, 36);
            this.buttonCargar.TabIndex = 3;
            this.buttonCargar.Text = "Cargar Archivo";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // buttonPromedio
            // 
            this.buttonPromedio.Enabled = false;
            this.buttonPromedio.Location = new System.Drawing.Point(57, 62);
            this.buttonPromedio.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPromedio.Name = "buttonPromedio";
            this.buttonPromedio.Size = new System.Drawing.Size(125, 43);
            this.buttonPromedio.TabIndex = 4;
            this.buttonPromedio.Text = "Promedio General del Segundo Parcial";
            this.buttonPromedio.UseVisualStyleBackColor = true;
            this.buttonPromedio.Click += new System.EventHandler(this.buttonPromedio_Click);
            // 
            // buttonPromediosPorSeccion
            // 
            this.buttonPromediosPorSeccion.Enabled = false;
            this.buttonPromediosPorSeccion.Location = new System.Drawing.Point(57, 109);
            this.buttonPromediosPorSeccion.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPromediosPorSeccion.Name = "buttonPromediosPorSeccion";
            this.buttonPromediosPorSeccion.Size = new System.Drawing.Size(125, 41);
            this.buttonPromediosPorSeccion.TabIndex = 6;
            this.buttonPromediosPorSeccion.Text = "Promedio Primer Parcial Seccion A";
            this.buttonPromediosPorSeccion.UseVisualStyleBackColor = true;
            this.buttonPromediosPorSeccion.Click += new System.EventHandler(this.buttonPromediosPorSeccion_Click);
            // 
            // buttonPromediosGeneralSeccion
            // 
            this.buttonPromediosGeneralSeccion.Enabled = false;
            this.buttonPromediosGeneralSeccion.Location = new System.Drawing.Point(57, 154);
            this.buttonPromediosGeneralSeccion.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPromediosGeneralSeccion.Name = "buttonPromediosGeneralSeccion";
            this.buttonPromediosGeneralSeccion.Size = new System.Drawing.Size(125, 42);
            this.buttonPromediosGeneralSeccion.TabIndex = 7;
            this.buttonPromediosGeneralSeccion.Text = "Promedio Primer Parcial Por Seccion";
            this.buttonPromediosGeneralSeccion.UseVisualStyleBackColor = true;
            this.buttonPromediosGeneralSeccion.Click += new System.EventHandler(this.buttonPromediosGeneralSeccion_Click);
            // 
            // ClasificarAlumnos
            // 
            this.ClasificarAlumnos.Enabled = false;
            this.ClasificarAlumnos.Location = new System.Drawing.Point(57, 200);
            this.ClasificarAlumnos.Margin = new System.Windows.Forms.Padding(2);
            this.ClasificarAlumnos.Name = "ClasificarAlumnos";
            this.ClasificarAlumnos.Size = new System.Drawing.Size(125, 45);
            this.ClasificarAlumnos.TabIndex = 8;
            this.ClasificarAlumnos.Text = "Nombre y Suma de Parciales";
            this.ClasificarAlumnos.UseVisualStyleBackColor = true;
            this.ClasificarAlumnos.Click += new System.EventHandler(this.ClasificarAlumnos_Click);
            // 
            // buttonNombreNotaMayor
            // 
            this.buttonNombreNotaMayor.Enabled = false;
            this.buttonNombreNotaMayor.Location = new System.Drawing.Point(57, 249);
            this.buttonNombreNotaMayor.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNombreNotaMayor.Name = "buttonNombreNotaMayor";
            this.buttonNombreNotaMayor.Size = new System.Drawing.Size(125, 39);
            this.buttonNombreNotaMayor.TabIndex = 9;
            this.buttonNombreNotaMayor.Text = "Nombre Nota Mayor General";
            this.buttonNombreNotaMayor.UseVisualStyleBackColor = true;
            this.buttonNombreNotaMayor.Click += new System.EventHandler(this.buttonNombreNotaMayor_Click);
            // 
            // buttonNombreNotaMayorSeccion
            // 
            this.buttonNombreNotaMayorSeccion.Enabled = false;
            this.buttonNombreNotaMayorSeccion.Location = new System.Drawing.Point(57, 292);
            this.buttonNombreNotaMayorSeccion.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNombreNotaMayorSeccion.Name = "buttonNombreNotaMayorSeccion";
            this.buttonNombreNotaMayorSeccion.Size = new System.Drawing.Size(125, 43);
            this.buttonNombreNotaMayorSeccion.TabIndex = 10;
            this.buttonNombreNotaMayorSeccion.Text = "Nombres Nota Mayor Por Seccion";
            this.buttonNombreNotaMayorSeccion.UseVisualStyleBackColor = true;
            this.buttonNombreNotaMayorSeccion.Click += new System.EventHandler(this.buttonNombreNotaMayorSeccion_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Enabled = false;
            this.buttonLimpiar.Location = new System.Drawing.Point(91, 482);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 11;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1082, 600);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonNombreNotaMayorSeccion);
            this.Controls.Add(this.buttonNombreNotaMayor);
            this.Controls.Add(this.ClasificarAlumnos);
            this.Controls.Add(this.buttonPromediosGeneralSeccion);
            this.Controls.Add(this.buttonPromediosPorSeccion);
            this.Controls.Add(this.buttonPromedio);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.textBoxResultado);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Button buttonPromedio;
        private System.Windows.Forms.Button buttonPromediosPorSeccion;
        private System.Windows.Forms.Button buttonPromediosGeneralSeccion;
        private System.Windows.Forms.Button ClasificarAlumnos;
        private System.Windows.Forms.Button buttonNombreNotaMayor;
        private System.Windows.Forms.Button buttonNombreNotaMayorSeccion;
        private System.Windows.Forms.Button buttonLimpiar;
    }
}

