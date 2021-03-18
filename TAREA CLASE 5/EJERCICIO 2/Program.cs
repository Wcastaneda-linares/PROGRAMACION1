using System;
using System.Threading;

namespace EJERCICIO_2
{
    class Program
    {
        public static void dibuja(int Cantidad)
        {
            int espacios_entre_lineas = 22;
            int longitud = 77;
            int espacios_hacia_abajo = 2;
            int espacios_hacia_arriba = 2;
            int fila, columna, limite;

            for (limite = 1; limite <= Cantidad; limite++)
            {
                for (fila = espacios_hacia_arriba; fila <= longitud; fila++)
                {
                    Console.SetCursorPosition(fila, espacios_entre_lineas); Console.Write("?");
                    Console.SetCursorPosition(fila, espacios_hacia_abajo); Console.Write("?");
                }
                for (columna = espacios_hacia_arriba; columna <= espacios_entre_lineas; columna++)
                {
                    Console.SetCursorPosition(espacios_hacia_arriba, columna); Console.Write("X");
                    Console.SetCursorPosition(longitud, columna); Console.Write("X");
                }
                espacios_hacia_abajo = espacios_hacia_abajo + 1;
                espacios_entre_lineas = espacios_entre_lineas - 1;
                espacios_hacia_arriba = espacios_hacia_arriba + 1;
                longitud = longitud - 1;
            }
        }

        static void Main(string[] args)
        {
            for (int tamanio = 1; tamanio < 9; tamanio++)
            {
                dibuja(tamanio);
                Thread.Sleep(500);
            }

        }
        

    }
}
