using System;

namespace CALCULAR_PERIMETRO_Y_AREA
{
    class Program
    {
        static void Main(string[] args)
        {
            int area, b, altura, num, numero, perimetro;
            Console.WriteLine("QUE ES LO QUE DESEA CALCULAR: ");
            Console.WriteLine();
            Console.WriteLine("1). PERIMETRO ");
            Console.WriteLine("2). AREA ");
            Console.Write("INGRESE UN NUMERO: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (num)
            {
                case 1:
                    Console.WriteLine("ELIJA UNA FIGURA");
                    Console.WriteLine("1). CUADRADO");
                    Console.WriteLine("2). RECTANGULO");
                    Console.WriteLine("3). TRIANGULO");
                    Console.WriteLine("4). ROMBO");
                    Console.Write("INGRESE EL NUMERO DE LA FIGURA: ");
                    numero = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    switch (numero)
                    {
                        case 1:
                            Console.Write("ESCRIBA LA BASE DEL CUADRADO: ");
                            b = int.Parse(Console.ReadLine());
                            perimetro = b*4;
                            Console.WriteLine("EL PERIMETRO DEL CUADRADO ES: {0}", perimetro);
                            break;
                        case 2:
                            Console.Write("ESCRIBA LA BASE: ");
                            b = int.Parse(Console.ReadLine());
                            Console.Write("ESCRIBA LA ALTURA: ");
                            altura = int.Parse(Console.ReadLine());
                            perimetro = (b * 2) + (altura * 2);
                            Console.WriteLine("EL PERIMETRO DEL RECTRANGULO ES DE ES: {0}", perimetro);
                            break;
                        case 3:
                            Console.Write("ESCRIBA LA BASE: ");
                            b = int.Parse(Console.ReadLine());
                            Console.Write("ESCRIBA LA ALTURA: ");
                            altura = int.Parse(Console.ReadLine());
                            perimetro = b + altura + altura;
                            Console.WriteLine("EL PERIMETRO DEL RECTANGULO ES: {0}", perimetro);
                            break;
                        case 4:
                            Console.Write("ESCRIBA LA BASE: ");
                            b = int.Parse(Console.ReadLine());
                            perimetro = b * 4;
                            Console.WriteLine("EL PERIMETRO DEL ROMBO ES: {0}", perimetro);
                            break;
                        default:
                            Console.WriteLine("ESCRIBA UN NUMERO DENTRO DEL RANGO INDICADO: ");
                            break;
                    }

                    break;
                case 2:
                    Console.WriteLine("ELIJA UNA FIGURA");
                    Console.WriteLine("1). CUADRADO");
                    Console.WriteLine("2). RECTANGULO");
                    Console.WriteLine("3). TRIANGULO");
                    Console.WriteLine("4). ROMBO");
                    Console.Write("INGRESE EL NUMERO DE LA FIGURA: ");
                    numero = int.Parse(Console.ReadLine());
                    switch (numero)
                    {
                        case 1:
                            Console.Write("ESCRIBA LA BASE: ");
                            b = int.Parse(Console.ReadLine());
                            area = b * b;
                            Console.WriteLine("EL AREA DEL CUADRADO ES: {0}", area);
                            break;
                        case 2:
                            Console.Write("ESCRIBA LA BASE: ");
                            b = int.Parse(Console.ReadLine());
                            Console.Write("ESCRIBA LA ALTURA: ");
                            altura = int.Parse(Console.ReadLine());
                            area = b * altura;
                            Console.WriteLine("EL AREA DEL RECTANGULO ES: {0}", area);
                            break;
                        case 3:
                            Console.Write("ESCRIBA LA BASE: ");
                            b = int.Parse(Console.ReadLine());
                            Console.Write("ESCRIBA LA ALTURA: ");
                            altura = int.Parse(Console.ReadLine());
                            area = b * altura/2;
                            Console.WriteLine("EL AREA DEL CUADRADO ES: {0}", area);
                            break;
                        case 4:
                            Console.Write("ESCRIBA LA BASE: ");
                            b = int.Parse(Console.ReadLine());
                            Console.Write("ESCRIBA LA ALTURA: ");
                            altura = int.Parse(Console.ReadLine());
                            area = b * altura/2;
                            Console.WriteLine("EL AREA DEL CUADRADO ES: {0}", area);
                            break;
                        default: Console.WriteLine("ESCRIBA UN NUMERO DENTRO DEL RANGO INDICADO: ");
                            break;
                    }


                    break;
                default: Console.WriteLine("ESCRIBA UN NUMERO DENTRO DEL RANGO INDICADO: ");
                    break;
            }

            Console.ReadKey();

        }
    }
}
