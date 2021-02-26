using System;

namespace NUMERO_PAR_O_IMPAR
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("\t\tNUMERO PAR O IMPAR\n");
            Console.Write("INGRESE UN NUMERO: ");
            numero = int.Parse(Console.ReadLine());
            if(numero %2 == 0)
            {
                Console.WriteLine("\nEL NUMERO ES PAR");
            }
            else
            {
                Console.WriteLine("\nEL NUMERO ES IMPAR");
            }
            Console.ReadKey();

        }
    }
}
