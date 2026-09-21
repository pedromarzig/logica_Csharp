using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabricaLatinha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Uma fábrica tem uma linha de produção capaz de produzir 400 peças/dia. Um funcionário
             * o controla a qualidade, cadastrando o número da peça e o seu estado
             * (aprovado ou reprovado). Criar um programa para cadastrar o controle de qualidade e imprimir o total de peças aprovadas e reprovadas
             * no final do dia.
             * */
            int totalDePeca = 20;
            int Aprovado = 0, reprovado = 0;
           

          

            for(int i = 1; i <= totalDePeca; i++)
            {
                string estado;
                Console.WriteLine($"Peça número {i}");
                Console.WriteLine("Digite se a peça foi aprovada ou reprovada [A,R] ou F para sair");
                estado = Console.ReadLine()?.Trim().ToUpper();


                if (estado == "F")
                {
                    break;
                }
                if (estado == "A")
                {
                    Aprovado++;
                }
                else if(estado == "R") 
                {
                    reprovado++;
                }
                else
                {
                    i--;
                    Console.WriteLine("Erro, não é o é a palavra correta");
                }

               


            }


            Console.WriteLine($"Peças aprovadas {Aprovado}");
            Console.WriteLine($"Peças reprovadas {reprovado}");  
        }
    }
}
