using System;

namespace NUMERO_ELEVADO_A_LA_POTENCIA_N
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero, potencia, resultado = 1;
            Console.Write("ESCRIBA UN NUMERO: ");
            numero = Convert.ToDouble(Console.ReadLine());
            Console.Write("ESCRIBA POTENCIA QUE LO DESEA ELEVAR: ");
            potencia = Convert.ToDouble(Console.ReadLine());
            for(int i =1; i<=potencia; i++)
            {
                resultado = resultado * numero;
            }
            Console.WriteLine("\n{0} ELEVADO A LA POTENCIA {1} ES IGUAL A: {2}", numero, potencia, resultado);
            Console.ReadKey();
        }
    }
}
