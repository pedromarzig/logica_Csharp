using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Construa um programa que permita fazer o levantamento do estoque de vinhos de uma adega, tendo como dados de entrada
             * tipos de vinho sendo: "t" para tinto e "b" para branco. Como a quantidade de vinhos é desconhecida, utilize a letra "f" para finalizar. 
             * Após finalizer o programar dever mostrar a quantidade de cada vinho na adega.
             * */
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"
                ░█████╗░██████╗░███████╗░██████╗░░█████╗░  ██████╗░███████╗  ██╗░░░██╗██╗███╗░░██╗██╗░░██╗░█████╗░
                ██╔══██╗██╔══██╗██╔════╝██╔════╝░██╔══██╗  ██╔══██╗██╔════╝  ██║░░░██║██║████╗░██║██║░░██║██╔══██╗
                ███████║██║░░██║█████╗░░██║░░██╗░███████║  ██║░░██║█████╗░░  ╚██╗░██╔╝██║██╔██╗██║███████║██║░░██║
                ██╔══██║██║░░██║██╔══╝░░██║░░╚██╗██╔══██║  ██║░░██║██╔══╝░░  ░╚████╔╝░██║██║╚████║██╔══██║██║░░██║
                ██║░░██║██████╔╝███████╗╚██████╔╝██║░░██║  ██████╔╝███████╗  ░░╚██╔╝░░██║██║░╚███║██║░░██║╚█████╔╝
                ╚═╝░░╚═╝╚═════╝░╚══════╝░╚═════╝░╚═╝░░╚═╝  ╚═════╝░╚══════╝  ░░░╚═╝░░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝░╚════╝░");
            Console.ResetColor();
            char letra = ' ';
            int countT = 0, countB = 0;
            Console.WriteLine("Digite T para vinho tinto, B para vinho branco ou F para finalizar:");
            letra = char.ToLower(char.Parse(Console.ReadLine()));

            while (letra != 'f')
            {
                if(letra == 't' )
                {
                    countT++;
                    

                }
                else if(letra == 'b' )
                {
                    countB++;
                   
                }

                Console.WriteLine("Digite T para vinho tinto, B para vinho branco ou F para finalizar:");
                letra = char.ToLower(char.Parse(Console.ReadLine()));
            }
            Console.WriteLine("A quantidade de vinho tinto é: " + countT);
            Console.WriteLine("A quantidade branco é: " + countB);

        }
    }
}
