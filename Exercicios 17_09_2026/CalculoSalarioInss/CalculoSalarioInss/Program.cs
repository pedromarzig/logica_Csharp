using System;

namespace SalarioProfessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 11 - Faça um algoritmo que efetue o cálculo do salário líquido de um professor.
             * As informações fornecidas serão: valor da hora aula, número de aulas lecionadas
             * no mês e percentual de desconto do INSS.
             * Imprima na tela o salário líquido final.
             */

            double valorHoraAula;
            int numeroAulas;
            double percentualINSS;
            double salarioBruto;
            double descontoINSS;
            double salarioLiquido;

            Console.WriteLine("Digite o valor da hora aula:");
            valorHoraAula = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de aulas lecionadas no mês:");
            numeroAulas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o percentual de desconto do INSS:");
            percentualINSS = double.Parse(Console.ReadLine());

            salarioBruto = valorHoraAula * numeroAulas;
            descontoINSS = salarioBruto * percentualINSS / 100;
            salarioLiquido = salarioBruto - descontoINSS;

            Console.WriteLine($"Salário bruto: R$ {salarioBruto:F2}");
            Console.WriteLine($"Desconto do INSS: R$ {descontoINSS:F2}");
            Console.WriteLine($"Salário líquido: R$ {salarioLiquido:F2}");
        }
    }
}