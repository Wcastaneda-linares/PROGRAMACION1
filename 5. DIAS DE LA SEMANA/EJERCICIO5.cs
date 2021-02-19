using System;

namespace DIAS_DE_LA_SEMANA
{
    class Program
    {
        static void Main(string[] args)
        {
            String dia;
            int num;

            Console.WriteLine("\t\t\tDIAS DE LA SEMANA ");
            Console.WriteLine();
            Console.WriteLine("\t\t1. LUNES");
            Console.WriteLine("\t\t2. MARTES");
            Console.WriteLine("\t\t3. MIERCOLES");
            Console.WriteLine("\t\t4. JUEVES");
            Console.WriteLine("\t\t5. VIERNES");
            Console.WriteLine("\t\t6. SABADO");
            Console.WriteLine("\t\t7. DOMINGO");
            Console.Write("INGRESE UN NUMERO DEL 1 AL 7 CORRESPONDIENTE A UN DIA DE LA SEMANA: ");
            dia = Console.ReadLine();
            num = int.Parse(dia);
            Console.WriteLine();
            switch (num)
            {
                case 1:
                    Console.WriteLine("LUNES ES UN DIA LABORAL");break;
                case 2:
                    Console.WriteLine("MARTES ES UN DIA LABORAL");break;
                case 3:
                    Console.WriteLine("MIERCOLES ES UN DIA LABORAL");
                    break;
                case 4:
                    Console.WriteLine("JUEVESES UN DIA LABORAL");break;
                case 5:
                    Console.WriteLine("VIERNESES UN DIA LABORAL");
                    break;
                case 6:
                    Console.WriteLine("SABADO NO ES UN DIA LABORAL");break;
                case 7:
                    Console.WriteLine("DOMINGO NO ES UN DIA LABORAL");break;
                default:
                    Console.WriteLine("EL NUMERO QUE INGRESO NO ESTA DENTRO DEL RANGO INDICADO");break;
            }

        }
    }
}
