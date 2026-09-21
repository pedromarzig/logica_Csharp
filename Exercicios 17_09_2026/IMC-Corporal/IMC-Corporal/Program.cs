using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC_Corporal
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 
              
              5-	Faça um algoritmo que calcule o IMC (Índice de Massa Corporal) de uma pessoa, leia o seu peso e sua altura e imprima na tela sua condição 
                        de acordo com a tabela abaixo:
                        Fórmula do IMC = peso / (altura) ²
                        Tabela Condições IMC
  
                         Abaixo de 18,5   | Abaixo do peso          
                         Entre 18,6 e 24,9 | Peso ideal (parabéns)  
                         Entre 25,0 e 29,9 | Levemente acima do peso
                         Entre 30,0 e 34,9 | Obesidade grau I 
                         Entre 35,0 e 39,9 | Obesidade grau II (severa)
                         Maior ou igual a 40 | Obesidade grau III (mórbida)


              */


           
            double altura,peso, imc;

            Console.WriteLine("Digite seu peso: ");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura: ");
            altura = double.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            Console.WriteLine($"\nSeu IMC é: {imc:F2}");

            if (imc < 18.5)
            {
                Console.WriteLine("Situação: Abaixo do peso");
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine("Situação: Peso ideal (parabéns)");
            }
            else if (imc >= 25.0 && imc <= 29.9)
            {
                Console.WriteLine("Situação: Levemente acima do peso");
            }
            else if (imc >= 30.0 && imc <= 34.9)
            {
                Console.WriteLine("Situação: Obesidade grau I");
            }
            else if (imc >= 35.0 && imc <= 39.9)
            {
                Console.WriteLine("Situação: Obesidade grau II (severa)");
            }
            else 
            {
                Console.WriteLine("Situação: Obesidade grau III (mórbida)");
            }
        }

    }
}
