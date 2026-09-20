using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaDePagamento
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * 6- Faça um algoritmo que leia o valor de um produto e determine o valor que deve ser pago, conforme a escolha da forma de pagamento

            pelo comprador e imprima na tela o valor final do produto a ser pago. Utilize os códigos da tabela de condições de pagamento 
            para efetuar o cálculo adequado.

            Tabela de Código de Condições de Pagamento

            1 - À Vista em Dinheiro ou Pix, recebe 15% de desconto

            2 - À Vista no cartão de crédito, recebe 10% de desconto

            3 - Parcelado no cartão em duas vezes, preço normal do produto sem juros

            4 - Parcelado no cartão em três vezes ou mais, preço normal do produto mais juros de 10%
             * */

            double valor_Produto = 0.0, valorASerPago = 0.0 ;
            string forma_de_pagamento = " ";
            int parcelas = 0;

            Console.WriteLine("Digite o valor do protudo: ");
            valor_Produto = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a forma de pagamento[PIX, DINHEIRO, CARTÃO]: ");
            forma_de_pagamento = Console.ReadLine().ToLower();

            if (forma_de_pagamento == "dinheiro" || forma_de_pagamento == "pix")
            {
                valorASerPago = valor_Produto * 0.85;
                Console.WriteLine($"O valor em dinheiro ou pix tem disconto [ :) ]: {valorASerPago} ");
            }else if(forma_de_pagamento == "cartao")
            {
                Console.WriteLine("Digite a quantidade de parcelas no cartão: ");
                parcelas = int.Parse(Console.ReadLine());

                if (parcelas == 1)
                {
                    valorASerPago = valor_Produto * 0.90;
                    Console.WriteLine($"O valor tem disconto! {valorASerPago}");
                }else if(parcelas == 2)
                {
                    valorASerPago = valor_Produto;
                    valorASerPago = valorASerPago / 2;
                    Console.WriteLine($"Você não tem disconto: {valor_Produto} em duas vezes {valorASerPago}");
                }else if(parcelas >= 3)
                {
                    valorASerPago = valor_Produto * 1.10;
                    Console.WriteLine($"O valor será com juros: {valorASerPago} ");
                }
            }

        }
    }
}
