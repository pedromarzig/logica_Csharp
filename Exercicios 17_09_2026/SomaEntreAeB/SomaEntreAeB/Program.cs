using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaEntreAeB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1-	Faça um algoritmo que leia dois valores inteiros A e B, se os valores de A e B forem iguais, deverá somar os dois valores, 
                caso contrário devera multiplicar A por B. Ao final de qualquer um dos cálculos deve-se atribuir o resultado a uma variável C e
                imprimir seu valor na tela.
             * */

            int A, B, soma, multi;

            Console.WriteLine("Digite o primeiro número: ");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            B = int.Parse(Console.ReadLine());

            if(A == B) 
            {
                soma = A + B;
                Console.WriteLine($"A soma é: {soma}");
            }else
            {
                multi = A * B;
                Console.WriteLine($"A multiplicação é: {multi}");
            }

        }
    }
}
