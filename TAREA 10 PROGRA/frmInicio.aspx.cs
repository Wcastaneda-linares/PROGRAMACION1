using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TAREA_10_PROGRA.CLASES.ARCHIVO;
using TAREA_10_PROGRA.CLASES.DATABASE;

namespace TAREA_10_PROGRA
{
    public partial class frmInicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void CargarArchivoExterno()
        {
            string fuente = @"C:\Users\PC\Desktop\crudDB.csv";
            ClsArchivo ar = new ClsArchivo();

            //obtener todo el archivo de un arreglo
            string[] ArregloNotas = ar.LeerArchivo(fuente);
            string SentenciaSql = "";
            int NumeroLinea = 0;

            //iteramos sobre el arreglo, linea por linea
            //para luego convertirlos en datos individuales
            ClsConexionSqlServer cn = new ClsConexionSqlServer();
            foreach (string linea in ArregloNotas)
            {
                string[] datos = linea.Split(';');
                if (NumeroLinea > 0)
                {
                    SentenciaSql = $"insert into tb_alumnos values({datos[0]},'{datos[1]}',{datos[2]},{datos[3]},{datos[4]},{datos[5]},'{datos[6]}');\n";
                    cn.consultaTablaDirecta(SentenciaSql);
                }
                NumeroLinea++;
            }
            NumeroLinea = 0;
        }
        protected void ButtonSql_Click(object sender, EventArgs e)
        {

            CargarArchivoExterno();
            TextBoxID.Enabled = true;
            TextBoxNombre.Enabled = true;
            ButtonBuscarID.Enabled = true;
            ButtonBuscarPorNombre.Enabled = true;
        }

        public DataTable CargarDatosDB(string condicion = "1=1")
        {
            ClsConexionSqlServer cn = new ClsConexionSqlServer();
            DataTable dt = new DataTable();
            string sentencia = $"select * from tb_alumnos where {condicion}";
            dt = cn.consultaTablaDirecta(sentencia);
            return dt;
        }
        protected void ButtonBuscarID_Click(object sender, EventArgs e)
        {
            string Id = TextBoxID.Text.Trim();
            string condicion = $"Correlativo = {Id}";
            DataTable dt = CargarDatosDB(condicion);

            if (dt.Rows.Count > 0)
            {
                string nombre = dt.Rows[0].Field<string>("Nombre");
                TextBoxNombre.Text = nombre;
            }
            else
            {
                TextBoxNombre.Text = "NO HAY INFORMACION";
            }
        }

        protected void ButtonBuscarPorNombre_Click(object sender, EventArgs e)
        {
            string nombre = TextBoxNombre.Text.Trim();
            ClsConexionSqlServer cn = new ClsConexionSqlServer();
            DataTable dt = new DataTable();
            string condicion = $"Select Correlativo from tb_alumnos where Nombre like ('%{nombre}%')";
             dt = cn.consultaTablaDirecta(condicion);

            if (dt.Rows.Count > 0)
            {
                int id = dt.Rows[0].Field<Int32>("Correlativo");
                TextBoxID.Text = id+"";
            }
            else
            {
                TextBoxID.Text = "NO HAY INFORMACION";
            }

        }

        private void CargarArchivoExternoMySql()
        {
            string fuente = @"C:\Users\PC\Desktop\crudDB.csv";
            ClsArchivo ar = new ClsArchivo();

            //obtener todo el archivo de un arreglo
            string[] ArregloNotas = ar.LeerArchivo(fuente);
            string SentenciaSql = "";
            int NumeroLinea = 0;

            //iteramos sobre el arreglo, linea por linea
            //para luego convertirlos en datos individuales
            ClsConexionMySql cn = new ClsConexionMySql();
            foreach (string linea in ArregloNotas)
            {
                string[] datos = linea.Split(';');
                if (NumeroLinea > 0)
                {
                    SentenciaSql = $"insert into tb_alumnos values({datos[0]},'{datos[1]}',{datos[2]},{datos[3]},{datos[4]},{datos[5]},'{datos[6]}');\n";
                    cn.consultaTablaDirecta(SentenciaSql);
                }
                NumeroLinea++;
            }
            NumeroLinea = 0;
        }

        protected void ButtonCargarDatosMySql_Click(object sender, EventArgs e)
        {
            CargarArchivoExternoMySql();
            ButtonBuscarPorNombreMySql.Enabled = true;
            ButtonBuscarIdMySql.Enabled = true;
            TextBoxIDMySql.Enabled = true;
            TextBoxNombreMySql.Enabled = true;
        }
        public DataTable CargarDatosDBMySql(string condicion = "1=1")
        {
            ClsConexionMySql cn = new ClsConexionMySql();
            DataTable dt = new DataTable();
            string sentencia = $"select * from tb_alumnos where {condicion}";
            dt = cn.consultaTablaDirecta(sentencia);
            return dt;
        }

        protected void ButtonBuscarIdMySql_Click(object sender, EventArgs e)
        {
            string Id = TextBoxIDMySql.Text.Trim();
            string condicion = $"Correlativo = {Id}";
            DataTable dt = CargarDatosDBMySql(condicion);

            if (dt.Rows.Count > 0)
            {
                string nombre = dt.Rows[0].Field<string>("Nombre");
                TextBoxNombreMySql.Text = nombre;
            }
            else
            {
                TextBoxNombreMySql.Text = "NO HAY INFORMACION";
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string nombre = TextBoxNombreMySql.Text.Trim();
            ClsConexionMySql cn = new ClsConexionMySql();
            DataTable dt = new DataTable();
            string condicion = $"Select Correlativo from tb_alumnos where Nombre like ('%{nombre}%')";
            dt = cn.consultaTablaDirecta(condicion);

            if (dt.Rows.Count > 0)
            {
                int id = dt.Rows[0].Field<Int32>("Correlativo");
                TextBoxIDMySql.Text = id + "";
            }
            else
            {
                TextBoxIDMySql.Text = "NO HAY INFORMACION";
            }
        }

        protected void TextBoxID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}