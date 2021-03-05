using System;

namespace LETRA_MAYUSCULA_O_MINUSCULA
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;
            Console.Write("DIGITE UNA LETRA: ");
            letra = char.Parse(Console.ReadLine());
            Console.WriteLine();
            if (letra == 'A'||letra=='B' || letra == 'C' || letra == 'D' || letra == 'E' || letra == 'F' || letra == 'G' || letra == 'H' || letra == 'I' || letra == 'J' || letra == 'K' || letra == 'L' || letra == 'M' || letra == 'N' || letra == 'O' || letra == 'P' || letra == 'Q' || letra == 'R' || letra == 'S' || letra == 'T' || letra == 'U' || letra == 'V' || letra == 'W' || letra == 'X' || letra == 'Y' || letra == 'Z')
            {
                Console.WriteLine("LA LETRA " + letra+" ES UNA LETRA MAYUSCULA");
            }
            else
            {
                Console.WriteLine("LA LETRA " + letra+" ES UNA LETRA MINUSCULA");
            }
            Console.ReadKey();

        }
    }
}
