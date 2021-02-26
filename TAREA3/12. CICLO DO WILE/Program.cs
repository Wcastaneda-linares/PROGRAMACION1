using System;

namespace CICLO_DO_WILE
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables necesarias
            float a = 0.0f;
            float b = 0.0f;
            float resultado = 0.0f;
            string valor = "";
            int opcion = 0;
            do
            {
                // Mostramos el menú
                Console.WriteLine("1 - Suma");
                Console.WriteLine("2 - Resta");
                Console.WriteLine("3 - División");
                Console.WriteLine("4 - Multiplicación");
                Console.WriteLine("5 - Salir");
                Console.Write("Que operación deseas hacer: ");
                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);
                switch (opcion)
                {
                    // Verificamos para suma
                    case 1:
                        // Pedimos el primer número
                        Console.Write("Dame el primer numero:");
                        valor = Console.ReadLine();
                        a = Convert.ToSingle(valor);
                        // Pedimos el segundo número
                        Console.Write("Dame el segundo numero:");
                        valor = Console.ReadLine();
                        b = Convert.ToSingle(valor);
                        resultado = a + b;
                        break;
                    // Verificamos para resta
                    case 2:
                        // Pedimos el primer número
                        Console.Write("Dame el primer numero:");
                        valor = Console.ReadLine();
                        a = Convert.ToSingle(valor);
                        // Pedimos el segundo número
                        Console.Write("Dame el segundo numero:");
                        valor = Console.ReadLine();
                        b = Convert.ToSingle(valor);
                        resultado = a - b;
                        break;
                    // Verificamos para división
                    case 3:
                        // Pedimos el primer número
                        Console.Write("Dame el primer numero:");
                        valor = Console.ReadLine();
                        a = Convert.ToSingle(valor);
                        // Pedimos el segundo número
                        Console.Write("Dame el segundo numero:");
                        valor = Console.ReadLine();
                        b = Convert.ToSingle(valor);
                        if (b != 0) // este if esta anidado
                            resultado = a / b;
                        else // Este else pertenece al segundo if
                            Console.WriteLine("Divisor no valido");
                        break;
                    // Verificamos para la multiplicación
                    case 4:
                        // Pedimos el primer número
                        Console.Write("Dame el primer numero:");
                        valor = Console.ReadLine();
                        a = Convert.ToSingle(valor);
                        // Pedimos el segundo número
                        Console.Write("Dame el segundo numero:");
                        valor = Console.ReadLine();
                        b = Convert.ToSingle(valor);
                        resultado = a * b;
                        break;
                    case 5:
                        // Despedida
                        Console.WriteLine("Adios");
                        break;
                    default:
                        // Si no se cumple ninguno de los casos anteriores
                        Console.WriteLine("Opción no valida");
                        break;
                        Console.WriteLine("El resultado es: {0}", resultado);
                }
            } while (opcion !=5);
            
        }
    }
}
