using System;

namespace DIAS_DE_LA_SEMANA
{
    class Program
    {
        static void Main(string[] args)
        {
            String dia;
            int num;

            Console.WriteLine("DIAS DE LA SEMANA ");
            Console.WriteLine();
            Console.WriteLine("1. LUNES");
            Console.WriteLine("2. MARTES");
            Console.WriteLine("3. MIERCOLES");
            Console.WriteLine("4. JUEVES");
            Console.WriteLine("5. VIERNES");
            Console.WriteLine("6. SABADO");
            Console.WriteLine("7. DOMINGO");
            Console.Write("INGRESE UN NUMERO DEL 1 AL 7: ");
            dia = Console.ReadLine();
            num = int.Parse(dia);
            Console.WriteLine();
            switch (num)
            {
                case 1:
                    Console.WriteLine("ES LUNES"); break;
                case 2:
                    Console.WriteLine("ES MARTES"); break;
                case 3:
                    Console.WriteLine("ES MIERCOLES");
                    break;
                case 4:
                    Console.WriteLine("ES JUEVESES"); break;
                case 5:
                    Console.WriteLine("ES VIERNES");
                    break;
                case 6:
                    Console.WriteLine("ES SABADO"); break;
                case 7:
                    Console.WriteLine("ES DOMINGO"); break;
                default:
                    Console.WriteLine("EL NUMERO QUE INGRESO NO ESTA DENTRO DEL RANGO INDICADO"); break;
            }
            Console.ReadKey();
        }
    }
}
