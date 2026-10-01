using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturaMax
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Crie um algoritmo que armazene as temperaturas diárias de um cidade durante uma semena e informe o dia mais quente e o mais frio.
            int[] temperaturas = new int[7];
            int[] dias = new int[7];
            int maxTp = temperaturas[0];
            int minTp = temperaturas[0];

            for(int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Digite a temperatura do dia {i + 1}: ");
                temperaturas[i] = int.Parse(Console.ReadLine());
                dias[i] = i + 1;
            }
            
            for(int i = 0; i < 7; i++)
            {
                if (temperaturas[i] > maxTp)
                {
                    maxTp = temperaturas[i];
                    minTp = dias[i];
                }
                if (temperaturas[i] < minTp)
                {
                    minTp = temperaturas[i];
                    maxTp = dias[i];
                }
            }

            Console.WriteLine($"O dia mais quente foi o dia {minTp}°C com maxima de {maxTp}°C");
            Console.WriteLine($"O dia mais frio foi o dia {minTp}°C com temperatura de {minTp}°C");

        }
    }
}
