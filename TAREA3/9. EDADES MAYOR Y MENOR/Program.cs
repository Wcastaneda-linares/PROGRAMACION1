using System;

namespace EDADES_MAYOR_Y_MENOR
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, cantidad, menor = 0, mayor = 0;
            Console.Write("CUANTAS EDADES DESEA COMPARAR?: ");
            cantidad = int.Parse(Console.ReadLine());
            for(int i = 0; i < cantidad; i++)
            {
                Console.Write("ESCRIBA UNA EDAD: ");
                edad = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    mayor = edad;
                    menor = edad;
                }
                else if(i != 0)
                {
                    if (edad < menor)
                    {
                        menor = edad;
                    }
                    if (edad > mayor)
                    {
                        mayor = edad;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("LA EDAD MENOR ES: {0} ",menor);
            Console.WriteLine("LA EDAD MAYOR ES: {0} ", mayor);
            Console.ReadKey();
        }
    }
}
