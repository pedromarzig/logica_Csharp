using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocaDeValor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              7- Faça um algoritmo que receba um valor A e B, e troque o valor de A por B e o valor de B por A e imprima na tela os valores.
              */

            int a, b, valorReverse;

            Console.WriteLine("Digite o primeiro número:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine($"valor de A: {a}");
            Console.WriteLine($"valor de B: {b}");
            valorReverse = a;
            a = b;
            b = valorReverse;

            Console.WriteLine($"O valor alterado A: {a}");
            Console.WriteLine($"O valor alterado B: {b}");
        }
    }
}
