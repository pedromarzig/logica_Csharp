using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturaFahre
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * 
             * 9- Faça um algoritmo que leia uma temperatura em Fahrenheit 
             * e calcule a temperatura correspondente em grau Celsius. Imprima na tela as duas temperaturas.

                Fórmula: C = (5 * ( F-32) / 9)
             * 
             */
            int TempFahrenheit = 0, celsius, formula;

            Console.WriteLine("Digite a temperatura em Fahrenheit: ");
            TempFahrenheit = int.Parse(Console.ReadLine());


            celsius = (5 * (TempFahrenheit - 32) / 9);

            Console.WriteLine($"Temperatura correspondente em C°: {celsius}");

        }
    }
}
