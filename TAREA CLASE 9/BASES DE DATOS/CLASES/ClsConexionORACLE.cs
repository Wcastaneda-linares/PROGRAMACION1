﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace BASES_DE_DATOS.CLASES
{
    class ClsConexionORACLE
    {
        public OracleConnection conexion;
        private String _conexion { get; }

        public ClsConexionORACLE()
        {

            _conexion = "Data Source=UMG;Password=Umg$19;User ID=system;";
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
            conexion = new OracleConnection(_conexion);
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
            OracleDataReader dr;
            OracleCommand comm = new OracleCommand(sql, conexion);
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

                OracleCommand comm = new OracleCommand(sql, conexion);
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
            OracleCommand comm = new OracleCommand(sql, conexion);
            comm.ExecuteReader();
        }

    }
}
