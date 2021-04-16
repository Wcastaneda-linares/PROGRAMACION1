using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEGUNDO_PARCIAL.Clases
{
    class ClsPromedios : InterfacePromedios
    {
        public string[,] clasificar_alumnos(string[,] matriz, string seccion)
        {
            string[,] NombreAlumnos = new string[1, 2];

            int acumulador;
            int Nota = 0;
            int TotalFilas = matriz.GetLength(0);
            int filasSecc = TotalFilas;
            int TotalColumnas = matriz.GetLength(1);
            for (int fila = 1; fila < TotalFilas; fila++)
            {

                if (matriz[fila, enumColumnas.Seccion] == seccion)
                {
                    acumulador = Convert.ToInt32(matriz[fila, enumColumnas.Parcial1])
                    + Convert.ToInt32(matriz[fila, enumColumnas.Parcial2])
                    + Convert.ToInt32(matriz[fila, enumColumnas.Parcial3]);
                    if (Nota > acumulador)
                    {
                        NombreAlumnos[0, 1] = Nota.ToString();
                    }
                    else
                    {
                        NombreAlumnos[0, 0] = matriz[fila, enumColumnas.Nombre];
                        NombreAlumnos[0, 1] = acumulador.ToString();
                        Nota = acumulador;
                    }
                }


            }

            return NombreAlumnos;

        }

        public string nombre_nota_mayor(string[,] matriz)
        {
            string nombre = "";
            int acumulador;
            int mayor = 0;
            int TotalFilas = matriz.GetLength(0);
            int filasSecc = TotalFilas;
            int TotalColumnas = matriz.GetLength(1);
            for (int fila = 1; fila < TotalFilas; fila++)
            {

                int parcial1 = Convert.ToInt32(matriz[fila, enumColumnas.Parcial1]);
                int parcial2 = Convert.ToInt32(matriz[fila, enumColumnas.Parcial2]);
                int parcial3 = Convert.ToInt32(matriz[fila, enumColumnas.Parcial3]);

                acumulador = (parcial1 + parcial2 + parcial3) / 3;

                if (acumulador > mayor)
                {
                    nombre = matriz[fila, enumColumnas.Nombre];
                    mayor = acumulador;
                }
            }

            return nombre;
        }

        public string nombre_nota_mayor(string[,] matriz, string seccion)
        {
            string nombre = "";
            int acumulador;
            int NotaMayor = 0;
            int TotalFilas = matriz.GetLength(0);
            int filasSecc = TotalFilas;
            int TotalColumnas = matriz.GetLength(1);


            for (int fila = 0; fila < TotalFilas; fila++)
            {
                if (matriz[fila, enumColumnas.Seccion] == seccion)
                {
                    int parcial1 = Convert.ToInt32(matriz[fila, enumColumnas.Parcial1]);
                    int parcial2 = Convert.ToInt32(matriz[fila, enumColumnas.Parcial2]);
                    int parcial3 = Convert.ToInt32(matriz[fila, enumColumnas.Parcial3]);

                    acumulador = (parcial1 + parcial2 + parcial3) / 3;

                    if (acumulador > NotaMayor)
                    {
                        nombre = matriz[fila, enumColumnas.Nombre];
                        NotaMayor = acumulador;
                    }
                }

            }

            return nombre;
        }

        public int promedios_general_seccion(string[,] matriz, int columna_parcial, string seccion)
        {
            int acumulador = 0;
            int PromedioGeneralSeccion;
            int totalFilas = matriz.GetLength(0);
            int totalColumnas = matriz.GetLength(1);

            for (int fila = 0; fila < totalFilas; fila++)
            {
                acumulador = acumulador + Convert.ToInt32(matriz[fila, columna_parcial]);
            }


            PromedioGeneralSeccion = acumulador;
            return PromedioGeneralSeccion;


        }

        public int promedios_por_parcial(string[,] matriz, int columna_parcial)
        {
            int acumulador = 0;
            int promedioParcial1;
            int totalFilas = matriz.GetLength(0);
            int totalColumnas = matriz.GetLength(1);
            for (int fila = 1; fila < totalFilas; fila++)
            {
                acumulador = acumulador + Convert.ToInt32(matriz[fila, columna_parcial]);
            }
            promedioParcial1 = acumulador / (totalFilas - 1);

            return promedioParcial1;
        }


        public int promedios_por_seccion(string[,] matriz, int columna_parcial, string seccion)
        {
            int acumulador = 0;
            int Parcial2;
            int totalFilas = matriz.GetLength(0);
            int totalColumnas = matriz.GetLength(1);

                for (int fila = 0; fila < totalFilas; fila++)
                {
                    acumulador = acumulador + Convert.ToInt32(matriz[fila, columna_parcial]);
                }


            Parcial2 = acumulador;
            return Parcial2;

        }
    }
}
