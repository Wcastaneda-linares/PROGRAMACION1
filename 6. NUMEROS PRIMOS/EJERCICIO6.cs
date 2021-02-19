using System;

namespace NUMEROS_PRIMOS
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int contador;
            contador = 0;
            Console.Write("INGRESE UN NUMERO A EVALUAR: ");
            numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    contador = contador + 1;
                }
            }
            if (contador > 2)
            {
                Console.WriteLine(+numero + " NO ES UN NUMERO PRIMO");
            }
            else
            {
                Console.WriteLine(+numero + " ES UN NUMERO PRIMO");
            }

            Console.ReadKey();
        }
    }
}
