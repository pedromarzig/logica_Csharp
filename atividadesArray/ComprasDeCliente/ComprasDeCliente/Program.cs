using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprasDeCliente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desenvolva um programa que armazene o histórico total de compras de 10 clientes e mostre o total gasto por cada cliente.
            /*
            int[] totalGasto = new int[10];
            int[] compras = new int[10];
            int totalGeralTodosClientes = 0;


            for(int i = 0; i <10; i++) 
            {
                Console.WriteLine($"Digite o valor da compra do cliente: {i + 1} ");
                compras[i] = int.Parse(Console.ReadLine());
                totalGasto[i] = compras[i];
                
            }

            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine($"O total gasto pelo clinte {i+1} foi : {totalGasto[i]}");

                totalGeralTodosClientes += totalGasto[i];
                
            }
            Console.WriteLine($"O valor total é: {totalGeralTodosClientes}");
           */

            double[,] compras = new double[10, 5];
            for(int i = 0; i < 10; i++)
            {
                double total = 0.0;
                Console.WriteLine($"\nCompras do cliente {i + 1}");
                for(int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"Valor de compra {j+ 1}? R$");
                    compras[i, j] = double.Parse(Console.ReadLine());
                    total += compras[i, j];

                }

                Console.WriteLine($"Total gasto pelo cliente {i + 1}: R$ {total:0.00}");
            }
        }
    }
}
