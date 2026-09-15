using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 /*  crie um algoritomo que peça: nome do aluno, nota 1, nota 2, nota 3, nota 4, (notas de 0 - 10),
  calcule a media e exiba na tela: o nome do aluno com a media*/
namespace Media_Notas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, media;

            string nomeAluno;

            Console.WriteLine("Digite o nome do aluno");
            nomeAluno = Console.ReadLine(); 

            Console.WriteLine("Digite a primeira nota: ");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            n3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quarta nota: ");
            n4 = double.Parse(Console.ReadLine());

            media = (n1+ n2 + n3 + n4) / 4;

            Console.WriteLine("O aluno: " +  nomeAluno + "a media é:" + media);


        }
    }
}
