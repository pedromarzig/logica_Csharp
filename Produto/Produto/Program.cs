using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Crie um algorítmo para cadastro de produto: Código, fabricante, categoria,
            preço, estoque, valor total em estoque
             */

            string fabricante, categoria;
            int Codigo, estoque;
            double preco, valorTotalEmEstoque;

            Console.WriteLine("Escreva o código do produto: ");
            Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o fabricante: ");
            fabricante = Console.ReadLine();

            Console.WriteLine("Escreva a categoria do produto: ");
            categoria = Console.ReadLine();

            Console.WriteLine("Digite o preço do produto: ");
            preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o estoque: ");
            estoque = int.Parse(Console.ReadLine());

            valorTotalEmEstoque = preco * estoque;

            Console.WriteLine("O valor total em estoque é: " + valorTotalEmEstoque);

                

        }
    }
}
