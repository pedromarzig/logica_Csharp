using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorQue100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1;
            Console.WriteLine("Digite um número: ");
            n1 = double.Parse(Console.ReadLine());

            if(n1 > 100)
            {
                Console.WriteLine("Seu número é: " + n1 + " e ele é maior que 100");
            }
            else
            {
                Console.WriteLine("Seu número é: " + n1 + " ele não é maior que 100");
            }
        }
    }
}
