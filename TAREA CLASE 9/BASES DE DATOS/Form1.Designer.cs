
namespace BASES_DE_DATOS
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonCargarArchivo = new System.Windows.Forms.Button();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.buttonSQLSERVER = new System.Windows.Forms.Button();
            this.buttonMYSQL = new System.Windows.Forms.Button();
            this.buttonConectarOracle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CnDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEnviarCorreo = new System.Windows.Forms.Button();
            this.buttonEnviar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCargarArchivo
            // 
            this.buttonCargarArchivo.Location = new System.Drawing.Point(12, 17);
            this.buttonCargarArchivo.Name = "buttonCargarArchivo";
            this.buttonCargarArchivo.Size = new System.Drawing.Size(85, 41);
            this.buttonCargarArchivo.TabIndex = 0;
            this.buttonCargarArchivo.Text = "Cargar Archivo";
            this.buttonCargarArchivo.UseVisualStyleBackColor = true;
            this.buttonCargarArchivo.Click += new System.EventHandler(this.buttonCargarArchivo_Click);
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(141, 23);
            this.textBoxResultado.Multiline = true;
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResultado.Size = new System.Drawing.Size(295, 387);
            this.textBoxResultado.TabIndex = 1;
            // 
            // buttonSQLSERVER
            // 
            this.buttonSQLSERVER.Location = new System.Drawing.Point(12, 90);
            this.buttonSQLSERVER.Name = "buttonSQLSERVER";
            this.buttonSQLSERVER.Size = new System.Drawing.Size(85, 53);
            this.buttonSQLSERVER.TabIndex = 2;
            this.buttonSQLSERVER.Text = "Conectar con SQLSERVER";
            this.buttonSQLSERVER.UseVisualStyleBackColor = true;
            this.buttonSQLSERVER.Click += new System.EventHandler(this.buttonSQLSERVER_Click);
            // 
            // buttonMYSQL
            // 
            this.buttonMYSQL.Location = new System.Drawing.Point(12, 149);
            this.buttonMYSQL.Name = "buttonMYSQL";
            this.buttonMYSQL.Size = new System.Drawing.Size(85, 47);
            this.buttonMYSQL.TabIndex = 3;
            this.buttonMYSQL.Text = "Conectar con MYSQL";
            this.buttonMYSQL.UseVisualStyleBackColor = true;
            this.buttonMYSQL.Click += new System.EventHandler(this.buttonMYSQL_Click);
            // 
            // buttonConectarOracle
            // 
            this.buttonConectarOracle.Location = new System.Drawing.Point(12, 202);
            this.buttonConectarOracle.Name = "buttonConectarOracle";
            this.buttonConectarOracle.Size = new System.Drawing.Size(85, 43);
            this.buttonConectarOracle.TabIndex = 4;
            this.buttonConectarOracle.Text = "Conectar con Oracle";
            this.buttonConectarOracle.UseVisualStyleBackColor = true;
            this.buttonConectarOracle.Click += new System.EventHandler(this.buttonConectarOracle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CnDestino});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(460, 12);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(343, 150);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Visible = false;
            // 
            // CnDestino
            // 
            this.CnDestino.HeaderText = "Destinatario";
            this.CnDestino.MinimumWidth = 8;
            this.CnDestino.Name = "CnDestino";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(517, 248);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(228, 20);
            this.textBoxPassword.TabIndex = 8;
            this.textBoxPassword.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(588, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Password e-mail";
            this.label2.Visible = false;
            // 
            // buttonEnviarCorreo
            // 
            this.buttonEnviarCorreo.Enabled = false;
            this.buttonEnviarCorreo.Location = new System.Drawing.Point(12, 340);
            this.buttonEnviarCorreo.Name = "buttonEnviarCorreo";
            this.buttonEnviarCorreo.Size = new System.Drawing.Size(85, 50);
            this.buttonEnviarCorreo.TabIndex = 20;
            this.buttonEnviarCorreo.Text = "Enviar Mensaje";
            this.buttonEnviarCorreo.UseVisualStyleBackColor = true;
            this.buttonEnviarCorreo.Click += new System.EventHandler(this.buttonEnviarCorreo_Click);
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Location = new System.Drawing.Point(12, 292);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(85, 42);
            this.buttonEnviar.TabIndex = 21;
            this.buttonEnviar.Text = "Enviar Correo";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 450);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.buttonEnviarCorreo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonConectarOracle);
            this.Controls.Add(this.buttonMYSQL);
            this.Controls.Add(this.buttonSQLSERVER);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.buttonCargarArchivo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCargarArchivo;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Button buttonSQLSERVER;
        private System.Windows.Forms.Button buttonMYSQL;
        private System.Windows.Forms.Button buttonConectarOracle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CnDestino;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonEnviarCorreo;
        private System.Windows.Forms.Button buttonEnviar;
    }
}

