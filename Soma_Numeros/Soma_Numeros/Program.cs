using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_Numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, subitrair;

            Console.WriteLine("Digite o primeiro numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: "); 
            numero2 = int.Parse(Console.ReadLine());

            subitrair = numero1 - numero2;

            Console.WriteLine("o resultado da subtração é: " + subitrair);
        }
    }
}
