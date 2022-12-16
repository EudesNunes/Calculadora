using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();

        }
        static void menu()
        {
            Console.Clear();
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Raiz");
            Console.WriteLine("6 - Modulo");
            Console.WriteLine("7 - Pôtencia");
            Console.WriteLine("8 - Sair");
            Console.WriteLine("---------");

            Console.WriteLine("Selecione uma opcão: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1:
                    Soma();
                    break;
                case 2:
                    Subtracao();
                    break;
                case 3:
                    Divisao();
                    break;
                case 4:
                    Multiplicacao();
                    break;
                case 5:
                    Raiz();
                    break;
                case 6:
                    Modulo();
                    break;
                case 7:
                    Potencia();
                    break;
                case 8: System.Environment.Exit(0); break;
                default:
                    menu();
                    break;
            }
        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            Console.WriteLine("O resultado da soma é: " + resultado);
            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.WriteLine($"O resultado da soma é: {v1 + v2}");
            Console.ReadKey();
            menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resutado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é: {resutado}");
            Console.ReadKey();
            menu();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é {resultado}");
            Console.ReadKey();
            menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;
            Console.WriteLine($"O resultado a multiplicação é: {resultado}");
            Console.ReadKey();
            menu();
        }

        static void Raiz()
        {
            Console.Clear();
            Console.WriteLine("Qual o  valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            var resultado = Math.Sqrt(v1);


            Console.WriteLine($"A Raiz é: {resultado}");
            Console.ReadKey();
            menu();
        }
        static void Modulo()
        {
            Console.Clear();
            Console.WriteLine("Qual o  valor: ");
            float v1 = float.Parse(Console.ReadLine());
           
            Console.WriteLine("");

            var resultado = v1;
            if (v1 < 0)
            {
                resultado = v1 * -1;
            }

            Console.WriteLine($"O Modulo é: {resultado}");
            Console.ReadKey();
            menu();
        }
        static void Potencia()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            var resultado = Math.Pow(v1,v2);
            Console.WriteLine($"O resultado da Potência é: {resultado}");
            Console.ReadKey();
            menu();
        }
    }

        
}