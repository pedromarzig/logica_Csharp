using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisorDeArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa que armazene 20 números e separe-os em dois arrays: um com numeros pares e outro com números impares;

            int[] numeros = new int[20];
            int[] pares = new int[20];
            int[] impares = new int[20];

            int qtdPares = 0;
            int qtdImpares = 0;


            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Digite o primeiro{i}: ");
                numeros[i] = int.Parse(Console.ReadLine());
                if(numeros[i] % 2 == 0)
                {
                    pares[qtdPares] = numeros[i];
                    qtdPares++;
                }
                else
                {
                    impares[qtdImpares] = numeros[i];
                    qtdImpares++;
                }

                

                
            }
            Console.WriteLine("\n--- RESULTADOS ---");
            Console.WriteLine($"Quantidade de números pares: {qtdPares}");
            Console.Write("Números pares: ");

            for (int i = 0; i < qtdPares; i++)
            {
                Console.Write(pares[i] + " ");
            }

            for (int i = 0; i < qtdImpares; i++)
            {
                Console.Write(impares[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
