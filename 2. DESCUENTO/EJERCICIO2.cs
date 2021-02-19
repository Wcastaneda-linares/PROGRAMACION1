using System;

namespace DESCUENTO
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal compra;
            decimal descuento;
            decimal total;
            Console.Write("INGRESE SU TOTAL DE COMPRA: ");
            compra = decimal.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            if (compra > 300)
            {
                descuento = (compra * 20) / 100;
                Console.WriteLine("SU DESCUENTO ES DE:     " + descuento);
                total = compra - descuento;
                Console.WriteLine("SU TOTAL DE PAGO ES DE: " + total);
            }
            else
            {
                Console.WriteLine("USTED NO TIENE DESCUENTO :( ");
                Console.WriteLine("SU TOTAL A PAGAR ES DE: " + compra);
            }

            Console.ReadKey();

        }
    }
}
