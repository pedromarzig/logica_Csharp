using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerdadeiroOuFalso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4-	Faça um algoritmo que leia dois valores booleanos (lógicos) e determine se ambos são VERDADEIRO ou FALSO.*/

            bool value1, value2;

            Random random = new Random();

            Console.WriteLine("Digite verdadeiro ou falso: ");
            value1 = bool.Parse(Console.ReadLine());

            value2 = random.Next(2) == 0;
            Console.WriteLine($"A máquina escolheu: {value2.ToString().ToLower()}");

            
            if (value1 && value2)
            {
                Console.WriteLine("Ambos os valores são VERDADEIROS!");
            }
            else if (!value1 && !value2)
            {
                Console.WriteLine("Ambos os valores são FALSOS!");
            }
            else
            {
                Console.WriteLine("Os valores são diferentes!");
            }

        }
    }
}
