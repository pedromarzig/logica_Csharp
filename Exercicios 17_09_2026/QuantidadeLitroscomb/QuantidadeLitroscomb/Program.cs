using System;

namespace CombustivelViagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 12 - Faça um algoritmo que calcule a quantidade de litros de combustível
             * gastos em uma viagem, sabendo que o carro faz 12km com um litro.
             *
             * Fórmula:
             * distância = tempo x velocidade
             * litros usados = distância / 12
             */

            double tempo;
            double velocidade;
            double distancia;
            double litros;

            Console.WriteLine("Digite o tempo da viagem em horas:");
            tempo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a velocidade média em km/h:");
            velocidade = double.Parse(Console.ReadLine());

            distancia = tempo * velocidade;
            litros = distancia / 12;

            Console.WriteLine($"Distância percorrida: {distancia:F2} km");
            Console.WriteLine($"Quantidade de litros utilizados: {litros:F2} litros");
        }
    }
}