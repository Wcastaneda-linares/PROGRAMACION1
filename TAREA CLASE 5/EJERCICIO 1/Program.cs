using System;
using System.Threading;

namespace EJERCICIO_1
{
    class Program
    {
        public static string Mid(string parametro, int startindex, int Length)
        {
            string result = parametro.Substring(startindex, Length);
            return result;
        }
        static void Main(string[] args)
        {
            string nombre;
            string caracter;
            int totaldecaracteres = 0;
            int quitar_letra = 0;
            int largo_nombre = 0;
            int recorrido = 0;
            Console.Write("Ingrese un nombre: ");
            nombre = Console.ReadLine();
            Console.SetCursorPosition(1, 12);
            Console.Write(nombre);
            largo_nombre = nombre.Length;
            recorrido = 50;
            nombre = nombre.ToUpper();
            for (quitar_letra = nombre.Length; quitar_letra >= 1; quitar_letra--)
            {
                caracter = Mid(nombre, quitar_letra - 1, 1);
                for (totaldecaracteres = largo_nombre; totaldecaracteres <= recorrido; totaldecaracteres++)
                {
                    Console.SetCursorPosition(totaldecaracteres, 12);
                    Console.Write(" " + caracter);
                    Thread.Sleep(50);
                }
                recorrido = recorrido - 1;
                largo_nombre = largo_nombre - 1;
            }
        }

    }
}
