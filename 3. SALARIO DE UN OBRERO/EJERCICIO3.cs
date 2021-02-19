using System;

namespace SALARIO_DE_UN_OBRERO
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas, pago_horas, horas_extras, total, total_pago, hora;
            
            Console.Write("DIGITE SU TOTAL DE HORAS TRABAJADAS: ");
            horas = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            if (horas > 40)
            {
                horas_extras=horas-40;
                Console.WriteLine("TOTAL DE HORAS EXTRAS: " + horas_extras);
                total = horas_extras*20;
                Console.WriteLine("TOTAL DE DINERO POR EXTRAS: " + total);
                hora = 40 * 16;
                Console.WriteLine("PAGO MENSUAL: " + hora);
                total_pago = total+hora;
                Console.WriteLine("SU TOTAL DE PAGO ES DE: "+total_pago);
                
            }
            else
            {
                pago_horas = horas * 16;
                Console.WriteLine("SU TOTAL DE PAGO ES DE:"+pago_horas);
            }
        }
    }
}
