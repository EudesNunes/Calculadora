using System;
using Operacoes;

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
            Perguntas perguntas = new Perguntas();
            perguntas.DoisValores();

            Calcular calcular = new Calcular();
            calcular.Soma(perguntas.resValorUm, perguntas.resValorDois);

            Console.WriteLine($"O resultado da soma é: {calcular.Resposta}");
            Console.ReadKey();
            menu();
        }

        static void Subtracao()
        {
            Perguntas perguntas = new Perguntas();
            perguntas.DoisValores();

            Calcular calcular = new Calcular();
            calcular.Subtracao(perguntas.resValorUm, perguntas.resValorDois);

            Console.WriteLine($"O resultado da subtração é: {calcular.Resposta}");
            Console.ReadKey();
            menu();
        }

        static void Divisao()
        {
            Perguntas perguntas = new Perguntas();
            perguntas.DoisValores();

            Calcular calcular = new Calcular();
            calcular.Divisao(perguntas.resValorUm, perguntas.resValorDois);

            Console.WriteLine($"O resultado da divisão é {calcular.Resposta}");
            Console.ReadKey();
            menu();
        }

        static void Multiplicacao()
        {
            Perguntas perguntas = new Perguntas();
            perguntas.DoisValores();

            Calcular calcular = new ();
            calcular.Multiplicacao(perguntas.resValorUm, perguntas.resValorDois);

            Console.WriteLine($"O resultado a multiplicação é: {calcular.Resposta}");
            Console.ReadKey();
            menu();
        }

        static void Raiz()
        {
            Console.Clear();
            Console.WriteLine("Qual o  valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Calcular calcular = new Calcular();
            calcular.Raiz(v1);
            float resultado = Convert.ToSingle(calcular.Resposta);

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
            Calcular calcular = new Calcular();
            calcular.Modulo(v1);
            float resultado = Convert.ToSingle(calcular.Resposta);

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

            Calcular calcular = new Calcular();
            calcular.Potencia(v1, v2);
            float resultado = Convert.ToSingle(calcular.Resposta);

            Console.WriteLine($"O resultado da Potência é: {resultado}");
            Console.ReadKey();
            menu();
        }
    }
      

        
}