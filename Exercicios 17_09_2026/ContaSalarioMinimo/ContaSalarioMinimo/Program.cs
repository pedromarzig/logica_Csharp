using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaSalarioMinimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 2-	Faça um algoritmo que leia o valor do salário mínimo e o valor do salário de um usuário, calcule quantos salários mínimos esse 
              usuário ganha e imprima na tela o resultado. (Base para o Salário mínimo R$ 1.518,00).

             * */

            double salarioMin = 1.518, calcSalario, salarioUser;

            Console.WriteLine("Calculo salario do usaurio em salario minimo [Digite]:");
            salarioUser = double.Parse(Console.ReadLine());

            calcSalario = salarioUser / salarioMin;


            Console.WriteLine($"O seu salario é equivalente a tantos salarios minimos: {calcSalario}");




        }
    }
}
