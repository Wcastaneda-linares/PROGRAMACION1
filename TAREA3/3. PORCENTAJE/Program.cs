using System;

namespace PORCENTAJE
{
    class Program
    {
        static void Main(string[] args)
        {
            byte opc;
            decimal iva = 12, producto, total;
            Console.WriteLine("1). MEDICINA");
            Console.WriteLine("2). OTRO PRODUCTO");
            Console.Write("INGRESE UNA OPCION: ");
            opc = byte.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Console.Write("INGRESE TOTAL A PAGAR: ");
                    producto = decimal.Parse(Console.ReadLine());
                    total = producto;
                    Console.Write("SU TOTAL A PAGAR ES DE {0}",total);
                    break;
                case 2:
                    Console.Write("INGRESE TOTAL A PAGAR: ");
                    producto = decimal.Parse(Console.ReadLine());
                    iva = (producto * 12 / 100);
                    total = iva + producto;
                    Console.Write("SU TOTAL A PAGAR ES DE {0}", total);
                    break;
                default:
                    Console.Write("INGRESE UN NUMERO DENTRO DEL RANGO INDICADO");
                    break;
            }
            Console.ReadKey();
        }
    }
}
