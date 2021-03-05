using System;

namespace FACTORIAL_DE_UN_NUMERO
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, contador, factorial;
            Console.WriteLine("FACTORIAL DE UN NUMERO\n");
            Console.Write("ESCRIBA UN NUMERO: ");
            numero = int.Parse(Console.ReadLine());
            if (numero == 0)
            {
                Console.WriteLine("EL FACTORIAL DE {0} ES 1: ",numero);
            }
            else
            {
                factorial = numero;
                for(contador = numero; contador > 1; contador--)
                {
                    factorial = factorial * (contador - 1);
                }
                Console.WriteLine("EL FACTORIAL DE {0} ES: {1} ",numero, factorial);
            }
            Console.ReadKey();       


        }
    }
}
