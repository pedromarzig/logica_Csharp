using System;
using System.Threading;

namespace CadastrosDeBandas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             
              se / enquanto / para / caso

              if / while / for / switch


                Crie um sistema de cadastro de Álbuns de um artista / banda em que seá possível cadastrar

                um número x de músicas informada pelo usuário. Crie um menu de opções para isso

        */
            int option = 0;
            while (option != 4) {

                Console.Clear();


                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(@"
                    ░█████╗░░█████╗░███╗░░██╗████████╗██████╗░░█████╗░██╗░░░░░███████╗  ██████╗░███████╗
                    ██╔══██╗██╔══██╗████╗░██║╚══██╔══╝██╔══██╗██╔══██╗██║░░░░░██╔════╝  ██╔══██╗██╔════╝
                    ██║░░╚═╝██║░░██║██╔██╗██║░░░██║░░░██████╔╝██║░░██║██║░░░░░█████╗░░  ██║░░██║█████╗░░
                    ██║░░██╗██║░░██║██║╚████║░░░██║░░░██╔══██╗██║░░██║██║░░░░░██╔══╝░░  ██║░░██║██╔══╝░░
                    ╚█████╔╝╚█████╔╝██║░╚███║░░░██║░░░██║░░██║╚█████╔╝███████╗███████╗  ██████╔╝███████╗
                    ░╚════╝░░╚════╝░╚═╝░░╚══╝░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░╚══════╝╚══════╝  ╚═════╝░╚══════╝

                    ██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░░██████╗
                    ██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔════╝
                    ██████╦╝███████║██╔██╗██║██║░░██║███████║╚█████╗░
                    ██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║░╚═══██╗
                    ██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║██████╔╝
                    ╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═════╝░");

                Console.ResetColor();


                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("1- Cadastrar Album da Banda");
                Console.WriteLine("2- Cadastrar Album do Artista");
                Console.WriteLine("3- Cadastrar Músicas");
                Console.WriteLine("4- Sair do Programa");
                Console.WriteLine("----------->");


                Console.ResetColor();



                option = int.Parse(Console.ReadLine());

                switch (option)
                {

                    case 1:
                        Cadastro_Bandas();

                        break;

                    case 2:

                        Album();
                        break;
                    case 3:
                        Musica();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Saindo do Programa!! By");
                        break;
                }

            }


        }

       static void Cadastro_Bandas()
        {
            string nomeBanda = " ", nomeDoAlbum = " ";
            int qtdMusicas = 0;
   
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"
        ░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
        ██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
        ██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
        ██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
        ╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
        ░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

        ██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░░██████╗
        ██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔════╝
        ██████╦╝███████║██╔██╗██║██║░░██║███████║╚█████╗░
        ██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║░╚═══██╗
        ██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║██████╔╝
        ╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═════╝░");

            Console.ResetColor();

            Console.WriteLine("Digite o nome da banda: ");
            nomeBanda = Console.ReadLine();

            Console.WriteLine("Digite o nome do album: ");
            nomeDoAlbum = Console.ReadLine();

            Console.WriteLine("Digite o Número de Músicas: ");
            qtdMusicas = int.Parse(Console.ReadLine());


            Console.WriteLine("Cadastro realizado com Sucesso!!!");
            Console.WriteLine(nomeBanda);
            Console.WriteLine(nomeDoAlbum);
            Console.WriteLine(qtdMusicas);

            Thread.Sleep(3500);

        }


        static void Album()
        {
            int ano = 0, qtdAlbum = 0;
            double qtdVendas = 0.0;
            string nome = " ";
            
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"
            ░█████╗░██╗░░░░░██████╗░██╗░░░██╗███╗░░░███╗  ░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░
            ██╔══██╗██║░░░░░██╔══██╗██║░░░██║████╗░████║  ██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗
            ███████║██║░░░░░██████╦╝██║░░░██║██╔████╔██║  ██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║
            ██╔══██║██║░░░░░██╔══██╗██║░░░██║██║╚██╔╝██║  ██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║
            ██║░░██║███████╗██████╦╝╚██████╔╝██║░╚═╝░██║  ╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝
            ╚═╝░░╚═╝╚══════╝╚═════╝░░╚═════╝░╚═╝░░░░░╚═╝  ░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░");

            Console.ResetColor();

            Console.WriteLine("Digite o ano de lançamento do album: ");
            ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de albums: ");
            qtdAlbum = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de vendas: ");
            qtdVendas = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do album: ");
            nome = Console.ReadLine();


            Console.WriteLine("Cadastro realizado com Sucesso!!!");
            Console.WriteLine(ano);
            Console.WriteLine(qtdAlbum);
            Console.WriteLine(qtdVendas);
            Console.WriteLine(nome);

            Thread.Sleep(3500);
        }

        static void Musica()
        {
            int qtdMusicas = 0, qtd_cad_musica = 0;
            string  premiacao = " ";
            string nome = " ", duracao = " ";

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"
                ███╗░░░███╗██╗░░░██╗░██████╗██╗░█████╗░░█████╗░  ░██████╗░█████╗░██╗░░░██╗███████╗
                ████╗░████║██║░░░██║██╔════╝██║██╔══██╗██╔══██╗  ██╔════╝██╔══██╗██║░░░██║██╔════╝
                ██╔████╔██║██║░░░██║╚█████╗░██║██║░░╚═╝███████║  ╚█████╗░███████║╚██╗░██╔╝█████╗░░
                ██║╚██╔╝██║██║░░░██║░╚═══██╗██║██║░░██╗██╔══██║  ░╚═══██╗██╔══██║░╚████╔╝░██╔══╝░░
                ██║░╚═╝░██║╚██████╔╝██████╔╝██║╚█████╔╝██║░░██║  ██████╔╝██║░░██║░░╚██╔╝░░███████╗
                ╚═╝░░░░░╚═╝░╚═════╝░╚═════╝░╚═╝░╚════╝░╚═╝░░╚═╝  ╚═════╝░╚═╝░░╚═╝░░░╚═╝░░░╚══════╝");

            Console.ResetColor();


            Console.WriteLine("Digite quantas musica voce deseja cadastrar: ");

            qtd_cad_musica = int.Parse(Console.ReadLine());


            for (int i = 1; i <= qtd_cad_musica; i++)

            {


                Console.WriteLine("Digite o nome da música:");

                nome = Console.ReadLine();


                Console.WriteLine("Digite o nome da premiação que essa musica lançou:");

                premiacao = Console.ReadLine();


                Console.WriteLine("Digite o tempo da musica ");

                Console.WriteLine("Minutos:");

                duracao = Console.ReadLine();

                

                Console.WriteLine("\nCadastro realizado com sucesso");

                Console.WriteLine($"{nome}\n{premiacao}\n{duracao}:{premiacao}\n\n");


            }

            Thread.Sleep(3500);
        }
    }
}
