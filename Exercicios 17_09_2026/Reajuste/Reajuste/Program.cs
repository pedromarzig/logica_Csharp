using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reajuste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 3-	 Faça um algoritmo que leia um valor qualquer e imprima na tela com um reajuste de 5%.
             */

            double valorAle, reajuste;

            Console.WriteLine("Digite um valor para verificar seu reajuste: ");
            valorAle = double.Parse(Console.ReadLine());

            reajuste = valorAle * 1.05;
            Console.WriteLine($"O reajuste é: {reajuste}");
        }
    }
}
