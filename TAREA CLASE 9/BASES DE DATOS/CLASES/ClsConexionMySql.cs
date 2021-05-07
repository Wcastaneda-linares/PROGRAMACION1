using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace BASES_DE_DATOS.CLASES
{
    class ClsConexionMySql
    {
        public MySqlConnection conexion;
        private String _conexion { get; }

        public ClsConexionMySql()
        {

            _conexion = "datasource=localhost;port=3306;username=root;password=Umg$2019;database=db_estudiantes";
            MessageBox.Show("Conectado Con Exito");
        }



        /// <summary>
        /// Cierra la conexion.
        /// </summary>
        public void cerrarConexionBD()
        {
            conexion.Close();
        }



        /// <summary>
        /// abre la conexion
        /// </summary>
        public void abrirConexion()
        {
            conexion = new MySqlConnection(_conexion);
            conexion.Open();
        }




        /// <summary>
        /// metodo que ejecuta una consulta, esta clase maneja la apertura y clausura a la base de datos
        /// </summary>
        /// <param name="sqll"></param>
        /// <returns></returns>
        public DataTable consultaTablaDirecta(String sql)
        {
            abrirConexion();
            MySqlDataReader dr;
            MySqlCommand comm = new MySqlCommand(sql, conexion);
            dr = comm.ExecuteReader();

            var dataTable = new DataTable();
            dataTable.Load(dr);
            cerrarConexionBD();
            return dataTable;
        }



        /// <summary>
        /// ejecuta una instrucción de insersion, eliminación y actualización,
        /// esta clase se encarga de manejar las aperturas y clausuras de la conexion.
        /// </summary>
        /// <param name="sqll"></param>
        public void EjecutaSQLDirecto(String sql)
        {
            abrirConexion();
            try
            {

                MySqlCommand comm = new MySqlCommand(sql, conexion);
                comm.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            finally
            {
                cerrarConexionBD();
            }



        }




        /// <summary>
        /// ejecuta instrucciones SQL, pero el progromador debe manejar la apertura y clausura
        /// de las conexiones.
        /// </summary>
        /// <param name="sql"></param>
        public void EjecutaSQLManual(String sql)
        {
            // se abre y cierra la conexino manualmente
            MySqlCommand comm = new MySqlCommand(sql, conexion);
            comm.ExecuteReader();
        }
    }
}
