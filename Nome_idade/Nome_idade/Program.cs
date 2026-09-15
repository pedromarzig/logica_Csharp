using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nome_idade
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int idade;
            string nome;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite sua idade:");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Parabéns " + nome + " você acabou de ganhar uma coca-cola");
            Console.WriteLine("Você possui " + idade + " anos, beba mais agua");
        }
    }
}
