using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Perguntas
    {
        public float resValorUm { get; private set; }
        public float resValorDois { get; private set; }

        public void DoisValores()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            resValorUm = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            resValorDois = float.Parse(Console.ReadLine());
            Console.WriteLine("");
        }
    }
}
