using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SistemaDeBiblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();

            int option = -1;
            
            while (option != 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(@"
                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
                ██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗
                ╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝
                ██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗
                ╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝
                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░


                ░██████╗██╗░██████╗████████╗███████╗███╗░░░███╗░█████╗░  ██████╗░███████╗
                ██╔════╝██║██╔════╝╚══██╔══╝██╔════╝████╗░████║██╔══██╗  ██╔══██╗██╔════╝
                ╚█████╗░██║╚█████╗░░░░██║░░░█████╗░░██╔████╔██║███████║  ██║░░██║█████╗░░
                ░╚═══██╗██║░╚═══██╗░░░██║░░░██╔══╝░░██║╚██╔╝██║██╔══██║  ██║░░██║██╔══╝░░
                ██████╔╝██║██████╔╝░░░██║░░░███████╗██║░╚═╝░██║██║░░██║  ██████╔╝███████╗
                ╚═════╝░╚═╝╚═════╝░░░░╚═╝░░░╚══════╝╚═╝░░░░░╚═╝╚═╝░░╚═╝  ╚═════╝░╚══════╝

                ░██████╗░███████╗░██████╗████████╗░█████╗░░█████╗░  ██████╗░███████╗
                ██╔════╝░██╔════╝██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
                ██║░░██╗░█████╗░░╚█████╗░░░░██║░░░███████║██║░░██║  ██║░░██║█████╗░░
                ██║░░╚██╗██╔══╝░░░╚═══██╗░░░██║░░░██╔══██║██║░░██║  ██║░░██║██╔══╝░░
                ╚██████╔╝███████╗██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
                ░╚═════╝░╚══════╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

                ██████╗░██╗██████╗░██╗░░░░░██╗░█████╗░████████╗███████╗░█████╗░░█████╗░
                ██╔══██╗██║██╔══██╗██║░░░░░██║██╔══██╗╚══██╔══╝██╔════╝██╔══██╗██╔══██╗
                ██████╦╝██║██████╦╝██║░░░░░██║██║░░██║░░░██║░░░█████╗░░██║░░╚═╝███████║
                ██╔══██╗██║██╔══██╗██║░░░░░██║██║░░██║░░░██║░░░██╔══╝░░██║░░██╗██╔══██║
                ██████╦╝██║██████╦╝███████╗██║╚█████╔╝░░░██║░░░███████╗╚█████╔╝██║░░██║
                ╚═════╝░╚═╝╚═════╝░╚══════╝╚═╝░╚════╝░░░░╚═╝░░░╚══════╝░╚════╝░╚═╝░░╚═╝


                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
                ██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗
                ╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝
                ██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗██████╗
                ╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝╚═════╝
                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");

                Console.ResetColor();

                Console.WriteLine("1 - Cadastrar Livro");
                Console.WriteLine("2 - Cadastrar Jogo");
                Console.WriteLine("3 - Cadastrar Cliente");
                Console.WriteLine("4 - Cadastrar Fornecedor");
                Console.WriteLine("5 - Registrar Empréstimo");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("=================================================");
                option = int.Parse(Console.ReadLine());


                switch (option)
                {
                    case 1:
                        Livros();
                        break;
                    case 2:
                        Games();
                        break;
                    case 3:
                        Cliente();
                        break;
                    case 4:
                        Fornecedor();
                        break;
                    case 5:
                        Emprestimo();
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Saindo do Programa!! By");
                        break;
                }
            }

           
        }

        static void Livros()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"
                    ░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
                    ██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
                    ██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
                    ██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
                    ╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
                    ░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

                    ██╗░░░░░██╗██╗░░░██╗██████╗░░█████╗░░██████╗██╗
                    ██║░░░░░██║██║░░░██║██╔══██╗██╔══██╗██╔════╝██║
                    ██║░░░░░██║╚██╗░██╔╝██████╔╝██║░░██║╚█████╗░██║
                    ██║░░░░░██║░╚████╔╝░██╔══██╗██║░░██║░╚═══██╗╚═╝
                    ███████╗██║░░╚██╔╝░░██║░░██║╚█████╔╝██████╔╝██╗
                    ╚══════╝╚═╝░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░╚═════╝░╚═╝");
            Console.ResetColor();
            int qtdSaveLivros = 0;
            int id, anoPublicacao, qtdExemplares;
            string autor, tituloObra, genero, ISBN;

            Console.WriteLine("Digite o número de livros que irá cadastrar: ");
            qtdSaveLivros = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdSaveLivros; i++)
            {
                Console.WriteLine($"Digite o número do id do livro[{i}]:");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o titulo da: ");
                tituloObra = Console.ReadLine();

                Console.WriteLine("Digite autor da obra: ");
                autor = Console.ReadLine();

                Console.WriteLine("Digite o genero do livro: ");
                genero = Console.ReadLine();

                Console.WriteLine("Digite o ISBN do livro: ");
                ISBN = Console.ReadLine();

                Console.WriteLine("Digite o ano de publicação da obra: ");
                anoPublicacao = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a quantidade de Exemplares: ");
                qtdExemplares = int.Parse(Console.ReadLine());

                Console.WriteLine(id);
                Console.WriteLine(tituloObra);
                Console.WriteLine(autor);
                Console.WriteLine(genero);
                Console.WriteLine(ISBN);
                Console.WriteLine(anoPublicacao);
                Console.WriteLine(qtdExemplares);
                Thread.Sleep(3500);
            }

        }


        static void Games()
        {
            Console.Clear();
            int qtdSaveGames = 0;
            int id, FaixaEtaria, NumMinJogadores, NumMaxJogadores, QuantidadeExemplares;
            string nome, categoria;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"
                    ░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ░██████╗░░█████╗░███╗░░░███╗███████╗░██████╗
                    ██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔════╝░██╔══██╗████╗░████║██╔════╝██╔════╝
                    ██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██╗░███████║██╔████╔██║█████╗░░╚█████╗░
                    ██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░╚██╗██╔══██║██║╚██╔╝██║██╔══╝░░░╚═══██╗
                    ╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ╚██████╔╝██║░░██║██║░╚═╝░██║███████╗██████╔╝
                    ░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ░╚═════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚══════╝╚═════╝░");

            Console.ResetColor();
            Console.WriteLine("Digite a quantidade de jogos que serão cadastrados!");
            qtdSaveGames = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdSaveGames; i++)
            {

                Console.WriteLine($"Digite o número do id do jogo[{i}]:");
                Console.WriteLine("Digite o id do produto: ");
                id = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o nome do jogo: ");
                nome = Console.ReadLine();

                Console.WriteLine("Digite a categoria: ");
                categoria = Console.ReadLine();

                Console.WriteLine("Digite a Faixa etaria do jogo: ");
                FaixaEtaria = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o número minimo de jogadores");
                NumMinJogadores = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o número maximo de jogadores");
                NumMaxJogadores = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a quantidade de exemplares: ");
                QuantidadeExemplares = int.Parse(Console.ReadLine());


                Console.WriteLine(id);
                Console.WriteLine(nome);
                Console.WriteLine(categoria);
                Console.WriteLine(FaixaEtaria);
                Console.WriteLine(NumMinJogadores);
                Console.WriteLine(NumMaxJogadores);
                Console.WriteLine(QuantidadeExemplares);
                Thread.Sleep(3500);

            }
        }
        
        static void Cliente()
        {
            Console.Clear();
            int id;
            string nome, cpf, telefone, email;
            bool ativo = false;
            DateTime data;

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"
                ░█████╗░██╗░░░░░██╗███████╗███╗░░██╗████████╗███████╗
                ██╔══██╗██║░░░░░██║██╔════╝████╗░██║╚══██╔══╝██╔════╝
                ██║░░╚═╝██║░░░░░██║█████╗░░██╔██╗██║░░░██║░░░█████╗░░
                ██║░░██╗██║░░░░░██║██╔══╝░░██║╚████║░░░██║░░░██╔══╝░░
                ╚█████╔╝███████╗██║███████╗██║░╚███║░░░██║░░░███████╗
                ░╚════╝░╚══════╝╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝");
            Console.ResetColor();

            Console.WriteLine("Digite o id do cliente: ");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do cliente: ");
            nome = Console.ReadLine();

            Console.WriteLine("digite seu cpf do cliente: ");
            cpf = Console.ReadLine();

            Console.WriteLine("Digite o seu telefone: ");
            telefone = Console.ReadLine();

            Console.WriteLine("Digite o seu email: ");
            email = Console.ReadLine();

            Console.WriteLine("Digite a data de nascimento: ");
            data = DateTime.Parse(Console.ReadLine());

            ativo = true;

            Console.WriteLine(id);
            Console.WriteLine(nome);
            Console.WriteLine(cpf);
            Console.WriteLine(telefone);
            Console.WriteLine(email);
            Console.WriteLine(data);
            Console.WriteLine("Cadastro realizado com success!");
            Thread.Sleep(3500);

        }

        static void Fornecedor()
        {
            Console.Clear();
            int id;
            string razaoSocial, cnpj, telefone, email, endereco;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"
            ███████╗░█████╗░██████╗░███╗░░██╗███████╗░█████╗░███████╗██████╗░░█████╗░██████╗░
            ██╔════╝██╔══██╗██╔══██╗████╗░██║██╔════╝██╔══██╗██╔════╝██╔══██╗██╔══██╗██╔══██╗
            █████╗░░██║░░██║██████╔╝██╔██╗██║█████╗░░██║░░╚═╝█████╗░░██║░░██║██║░░██║██████╔╝
            ██╔══╝░░██║░░██║██╔══██╗██║╚████║██╔══╝░░██║░░██╗██╔══╝░░██║░░██║██║░░██║██╔══██╗
            ██║░░░░░╚█████╔╝██║░░██║██║░╚███║███████╗╚█████╔╝███████╗██████╔╝╚█████╔╝██║░░██║
            ╚═╝░░░░░░╚════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚══════╝░╚════╝░╚══════╝╚═════╝░░╚════╝░╚═╝░░╚═╝");
            Console.ResetColor();


            Console.WriteLine("Digite o id:");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("digite a razão social: ");
            razaoSocial = Console.ReadLine();

            Console.WriteLine("Digite o cnpj: ");
            cnpj = Console.ReadLine();

            Console.WriteLine("Digite o telefone da empresa: ");
            telefone  = Console.ReadLine();

            Console.WriteLine("Digite o email: ");
            email = Console.ReadLine();

            Console.WriteLine("Digite o endereço da empresa:");
            endereco = Console.ReadLine();

            Console.WriteLine(id);
            Console.WriteLine(razaoSocial);
            Console.WriteLine(cnpj);
            Console.WriteLine(telefone);
            Console.WriteLine(email);
            Console.WriteLine(endereco);
            Console.WriteLine("Cadastro realizado com success!");
            Thread.Sleep(3500);
        }


        static void Emprestimo()
        {
            Console.Clear();
            int id, clienteId, itemId;
            string tipoItem;
            bool devolvido = false;
            DateTime DataEmprestimo, dataDevoluçãoPrevista;


            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"
                ███████╗███╗░░░███╗██████╗░██████╗░███████╗░██████╗████████╗██╗███╗░░░███╗░█████╗░
                ██╔════╝████╗░████║██╔══██╗██╔══██╗██╔════╝██╔════╝╚══██╔══╝██║████╗░████║██╔══██╗
                █████╗░░██╔████╔██║██████╔╝██████╔╝█████╗░░╚█████╗░░░░██║░░░██║██╔████╔██║██║░░██║
                ██╔══╝░░██║╚██╔╝██║██╔═══╝░██╔══██╗██╔══╝░░░╚═══██╗░░░██║░░░██║██║╚██╔╝██║██║░░██║
                ███████╗██║░╚═╝░██║██║░░░░░██║░░██║███████╗██████╔╝░░░██║░░░██║██║░╚═╝░██║╚█████╔╝
                ╚══════╝╚═╝░░░░░╚═╝╚═╝░░░░░╚═╝░░╚═╝╚══════╝╚═════╝░░░░╚═╝░░░╚═╝╚═╝░░░░░╚═╝░╚════╝░");
            Console.ResetColor();

            Console.WriteLine("Digite o id: ");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o id do cliente: ");
            clienteId = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o id do produto: ");
            itemId = int.Parse(Console.ReadLine());

            Console.WriteLine("tipo do item [livro, jogo]");
            tipoItem = Console.ReadLine();


            Console.WriteLine("Digite a data emprestimo: ");
            DataEmprestimo = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite a data de devolução: ");
            dataDevoluçãoPrevista = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite se foi devolvido [true, false]");
            devolvido = bool.Parse(Console.ReadLine());

            Console.WriteLine(id);
            Console.WriteLine(clienteId);
            Console.WriteLine(itemId);
            Console.WriteLine(tipoItem);
            Console.WriteLine(DataEmprestimo);
            Console.WriteLine(dataDevoluçãoPrevista);
            Console.WriteLine(devolvido);
            Console.WriteLine("...........................");
            Thread.Sleep(3500);


        }
    }
}
