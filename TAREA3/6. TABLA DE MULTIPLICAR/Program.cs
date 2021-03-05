using System;

namespace TABLA_DE_MULTIPLICAR
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                byte numero;
                int resultado;
                Console.Write("TABLAS DE MULTIPLICAR \n\n");
                Console.Write("DIGITE NÚMERO: ");
                numero = byte.Parse(Console.ReadLine());
                for (int i = 1; i <= 10; i++)
                {
                    resultado = numero * i;
                    Console.WriteLine("{0} * {1} = {2}", numero, i, resultado);
                }
                Console.ReadKey();
            }
        }
    }
}
