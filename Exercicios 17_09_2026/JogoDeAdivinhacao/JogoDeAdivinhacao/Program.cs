using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDeAdivinhacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Simular o jogo de adivinhação: O jogador 1 escolhe um número entre: 1 e 10;
             * jogador 2 insere números na tentativa de acertar o número escolhido pelo jogador 1.
             * quando ele acertar, o algoritmo deve informar que ele acertou o número x 
             * (escolhido pelo jogador 1) em x tentativas (quantidade de tentativas do jogador 2).
             * */
            int jogador1, jogador2;
            int tentativas = 0;
            Random random = new Random();

            Console.Write("Digite um número para o Jogador 2 tentar adivinhar (1 a 10): ");
            jogador1 = int.Parse(Console.ReadLine());

            do
            {
                jogador2 = random.Next(1, 11);
                tentativas++;

                Console.WriteLine($"Tentativa {tentativas}: Jogador 2 chutou {jogador2}");

            } while (jogador1 != jogador2);

            Console.WriteLine($"\nO Jogador 2 acertou o número {jogador1} em {tentativas} tentativa(s)!");
        }

    }
    }

