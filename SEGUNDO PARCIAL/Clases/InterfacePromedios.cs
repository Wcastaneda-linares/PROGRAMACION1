using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEGUNDO_PARCIAL.Clases
{
    interface InterfacePromedios
    {
        /// <summary>
        /// retorna el promedio en base a una columna especifica
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="columna_parcial"></param>
        /// <returns></returns>
        int promedios_por_parcial(string[,] matriz, int columna_parcial);


        /// <summary>
        /// retorna el promedio de un parcial en especial y una seccion en especial
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="columna_parcial"></param>
        /// <param name="seccion"></param>
        /// <returns></returns>
        int promedios_por_seccion(string[,] matriz, int columna_parcial, string seccion);

        /// <summary>
        /// saca el promedio general de todos los alumnos por seccion
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="columna_parcial"></param>
        /// <param name="seccion"></param>
        /// <returns></returns>
        int promedios_general_seccion(string[,] matriz , int columna_parcial, string seccion);

        /// <summary>
        /// retorna una matriz de dos columnas con el nombre y la columna
        /// es la sumatoria del parcial 1 al 3
        /// </summary>
        /// <param name="matiz"></param>
        /// <param name="seccion"></param>
        /// <returns></returns>
        string [,] clasificar_alumnos(string[,] matriz, string seccion);

        /// <summary>
        /// busca el mejor promedio general o por seccion
        /// </summary>
        /// <param name="matiz"></param>
        /// <returns></returns>
        string nombre_nota_mayor(string[,] matriz);

        string nombre_nota_mayor(string[,] matriz, string seccion);
    }
}
