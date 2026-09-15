using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ano_Bissexto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 
             * 6. Ano bissexto
             * Determine se um ano é bissexto. Um ano é bissexto se for divisível por 4, mas não por 100, a não
              ser que seja divisivel por 400
             * Entrada:2024
             * Saída esperada: Ano bissexto
             * 
             * 
             * */
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"
            ░█████╗░███╗░░██╗░█████╗░  ██████╗░██╗░██████╗░██████╗███████╗██╗░░██╗████████╗░█████╗░
            ██╔══██╗████╗░██║██╔══██╗  ██╔══██╗██║██╔════╝██╔════╝██╔════╝╚██╗██╔╝╚══██╔══╝██╔══██╗
            ███████║██╔██╗██║██║░░██║  ██████╦╝██║╚█████╗░╚█████╗░█████╗░░░╚███╔╝░░░░██║░░░██║░░██║
            ██╔══██║██║╚████║██║░░██║  ██╔══██╗██║░╚═══██╗░╚═══██╗██╔══╝░░░██╔██╗░░░░██║░░░██║░░██║
            ██║░░██║██║░╚███║╚█████╔╝  ██████╦╝██║██████╔╝██████╔╝███████╗██╔╝╚██╗░░░██║░░░╚█████╔╝
            ╚═╝░░╚═╝╚═╝░░╚══╝░╚════╝░  ╚═════╝░╚═╝╚═════╝░╚═════╝░╚══════╝╚═╝░░╚═╝░░░╚═╝░░░░╚════╝░");
            Console.ResetColor();
            int ano;

            Console.WriteLine("Escreva o ano para verificar se é bissexto: ");
            ano = int.Parse(Console.ReadLine());

            if((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0)
            {
                Console.WriteLine("Ano bissexto");
            }
            else
            {
                Console.WriteLine("Ano não bissexto");
            }
            

        }
    }
}
