using System;

namespace CalculoAniversario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 8 - Faça um algoritmo que leia o ano em que uma pessoa nasceu,
             * imprima na tela quantos anos, meses e dias essa pessoa já viveu.
             * consideração o ano com 365 dias e o mês com 30 dias.
                (Ex: 5 anos, 2 meses e 15 dias de vida)
             */

            int anoUser = 0;
            int dataAtual = 0;

            DateTime date = DateTime.Now;

            Console.WriteLine("Digite o ano de seu nascimento: ");
            anoUser = int.Parse(Console.ReadLine());

            dataAtual = date.Year;

            int anos = dataAtual - anoUser;
            int dias = anos * 365;

            int meses = dias / 30;
            dias = dias % 30;

            anos = meses / 12;
            meses = meses % 12;

            Console.WriteLine($"Você viveu aproximadamente {anos} anos, {meses} meses e {dias} dias.");
        }
    }
}