using System;

namespace NUMEROS_PRIMOS_ENTRE_1_AL_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero=2, cantidad=0;
            Console.WriteLine("NUMEROS PRIMOS DEL 1 AL 1000\n");
            while (numero <= 1000)
            {
                for (int i = 1; i <= numero; i++)
                {
                    if (numero % i == 0)
                    {
                        cantidad++;
                    }
                    if (cantidad > 2)
                    {
                        break;
                    }
                }
                if (cantidad == 2)
                 {
                  Console.Write("{0} - ",numero);
                 }

                
                cantidad = 0;
                numero++;
            }
         Console.ReadKey();
        }
    }
}
