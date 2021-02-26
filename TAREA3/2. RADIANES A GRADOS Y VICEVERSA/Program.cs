using System;

namespace RADIANES_A_GRADOS_Y_VICEVERSA
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            double numero, pi = 3.1416, resultado;
            Console.WriteLine("CONVERTIDOR");
            Console.WriteLine("1). DE GRADOS A RADIANES");
            Console.WriteLine("2). DE RADIANES A GRADOS");
            Console.Write("SELECCIONE UNA OPCION: ");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1: 
                    Console.Write("INGRESE CANTIDAD DE GRADOS A CONVERTIR: ");
                    numero = double.Parse(Console.ReadLine());
                    resultado = numero * pi / 180;
                    Console.WriteLine("RESPUESTA: {0}", resultado);

                    break;
                case 2:
                    Console.WriteLine("INGRESE CANTIDAD DE RADIANES: ");
                    Console.Write("INGRESE CANTIDAD DE RADIANES A CONVERTIR: ");
                    numero = double.Parse(Console.ReadLine());
                    resultado = 180/pi*numero;
                    Console.WriteLine("RESPUESTA: {0}", resultado);
                    break;
                default: Console.Write("INGRESE UN NUMERO DENTRO DEL RANGO INDICADO ");
                    break;
            }
            Console.ReadKey();
        }
    }
}
