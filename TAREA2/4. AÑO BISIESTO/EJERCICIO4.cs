using System;

namespace AÑO_BISIESTO
{
    class Program
    {
        static void Main(string[] args)
        {
            int anio;
            Console.Write("INGRESE UN ANIO BISIESTO: ");
            anio = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (anio % 4 != 0 || (anio % 100 ==0 && anio % 400 !=0))
            {
                Console.WriteLine("EL ANIO "+ anio +" NO ES UN ANIO BISIESTO");
                Console.WriteLine("FEBRERO DEL ANIO " + anio + " TIENE 28 DIAS");
            }
            else
            {
                Console.WriteLine("EL ANIO "+ anio +" ES UN ANIO BISIESTO");
                Console.WriteLine("FEBRERO DEL ANIO " + anio + " TIENE 29 DIAS");
            }
            Console.ReadKey();
        }
    }
}
