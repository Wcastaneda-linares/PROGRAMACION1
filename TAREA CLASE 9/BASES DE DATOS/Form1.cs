using BASES_DE_DATOS.CLASES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BASES_DE_DATOS
{
    public partial class Form1 : Form
    {
        private string[] ArregloNotas;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCargarArchivo_Click(object sender, EventArgs e)
        {
            ClsArchivo ar = new ClsArchivo();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Porfa Selecciona tu Archivo Plano";
            ofd.InitialDirectory = @"C: \Users\alumno\Desktop\Archivo Plano 2.csv";
            ofd.Filter = "Archivo Plano 2 (.csv)|.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                string resultado = ar.LeerTodoArchivo(archivo);
                ArregloNotas = ar.LeerArchivo(archivo);
                textBoxResultado.Text = resultado;
            }
        }

        private void buttonSQLSERVER_Click(object sender, EventArgs e)
        {
            ClsConexionSQLSERVER cn = new ClsConexionSQLSERVER();

            foreach (string linea in ArregloNotas)
            {

                string[] datosUnitarios = linea.Split(';');
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                string cuerito = $"insert into tb_alumnos values('{datosUnitarios[0]}','{datosUnitarios[1]}','{datosUnitarios[2]}','{datosUnitarios[3]}','{datosUnitarios[4]}')";
                cn.consultaTablaDirecta(cuerito);

            }

        }

        private void buttonMYSQL_Click(object sender, EventArgs e)
        {
            ClsConexionMySql cn = new ClsConexionMySql();

            foreach (string linea in ArregloNotas)
            {

                string[] datosUnitarios = linea.Split(';');
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                string cuerito = $"INSERT INTO tb_alumnos1 VALUES('{datosUnitarios[0]}','{datosUnitarios[1]}','{datosUnitarios[2]}','{datosUnitarios[3]}','{datosUnitarios[4]}')";
                cn.consultaTablaDirecta(cuerito);

            }

        }

        private void buttonConectarOracle_Click(object sender, EventArgs e)
        {
            ClsConexionORACLE cn = new ClsConexionORACLE();

            foreach (string linea in ArregloNotas)
            {

                string[] datosUnitarios = linea.Split(';');
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                string cuerito = $"INSERT INTO TB_ALUMNOS VALUES('{datosUnitarios[0]}','{datosUnitarios[1]}','{datosUnitarios[2]}','{datosUnitarios[3]}','{datosUnitarios[4]}')";
                cn.consultaTablaDirecta(cuerito);

            }

        }


        private void buttonEnviarCorreo_Click(object sender, EventArgs e)
        {
            ClsCorreo correo = new ClsCorreo
            {
                correo = "wcastanedal@miumg.edu.gt",
                nombre = "Wagner Castañeda Linares",
                asunto = "Felicidades",
                password = textBoxPassword.Text,
                puerto = Convert.ToInt32("25"),
                smtp = "smtp.gmail.com",
                cuerpo = "Te felicito sacaste una nota mayor a 15",
                destinatarios = new List<string>(),
            };

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                var des = fila.Cells["CnDestino"].Value;
                if (des == null) continue;
                string destinatario = fila.Cells["CnDestino"].Value.ToString();
                if (!string.IsNullOrWhiteSpace(destinatario))
                {
                    correo.destinatarios.Add(destinatario);
                }

            }
            if (ClsCorreo.Send(correo))
            {
                MessageBox.Show("Correo Enviado");
            }
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            buttonEnviar.Enabled = false;
            buttonEnviarCorreo.Enabled = true;
            textBoxPassword.Visible = true;
            textBoxResultado.Visible = true;
            dataGridView1.Visible = true;
            label2.Visible = true;

        }

    }
}
