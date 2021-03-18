using System;

namespace EJERCICIO_3
{
    class Program
    {
        public static string generaletra(int min=0, int max=256)

        {
            Random ran = new Random();
            int numeros = Convert.ToInt32(ran.Next(48,90));
            string letrarespuesta = "";
            if (((numeros > min) & (numeros < max)))
            {
                letrarespuesta = Convert.ToString((char)numeros);
            }
            return letrarespuesta;
        }
        static void Main(string[] args)
        {
            byte cantidad, digitos;
            string cantidad_numeros;
            Console.Write("De cuantos digitos desea su tocken: ");
            cantidad_numeros = Console.ReadLine();
            cantidad = byte.Parse(cantidad_numeros);

            string caracter = "";
                for (digitos = 1; digitos <= cantidad; digitos++)
                {
                    caracter = caracter + generaletra(48, 90);
                }

                Console.WriteLine($"Su tocken generado es: {caracter}");
        }

    }
}
