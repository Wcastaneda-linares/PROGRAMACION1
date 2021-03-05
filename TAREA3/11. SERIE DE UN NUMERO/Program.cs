using System;

namespace SERIE_DE_UN_NUMERO
{
    class Program
    {
        static void Main(string[] args)
        {
            byte cantidad;
            int a, b, c;
            Console.Write("INGRESE UNA CANTIDAD DE NUMEROS A MOSTRAR: ");
            cantidad = byte.Parse(Console.ReadLine());
            a = 1;
            b = 1;
            Console.WriteLine("{0}", a);
            Console.WriteLine("{0}", b);
            for (int i = 3; i <= cantidad; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
            Console.ReadKey();
        }
    }
}
