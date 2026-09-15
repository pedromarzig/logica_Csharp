using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisaoEntreN1eN2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Digite seu número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu número: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("A divisão do número é igual à: " + n1 / n2);
        }
    }
}
