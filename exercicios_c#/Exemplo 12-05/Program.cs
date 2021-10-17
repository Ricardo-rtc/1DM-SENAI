using System;

namespace Exemplo_dia_12_05
{
    class Program
    {
        static bool confirmacaoPassagens;
        static bool confirmacaoMenu;
        
        static void Main(string[] args)
        {
        
            FunçãoSenha();
            ExibiçãoMenu();
        }
        static void FunçãoSenha()
        {
            string senha;
            // Confirmação senha padrão
            do
            {
                Console.WriteLine("Insira a senha para acessar o sistema");
                senha = Console.ReadLine();

                if (senha == "123456")
                {
                    Console.WriteLine("Senha correta!");
                }
                else
                {
                    Console.WriteLine("Senha incorreta! Tente novamente! ");
                }
            } while (senha != "123456");
        }
        static void ExibiçãoMenu()
        {
            int tamanhoArrays = 1000;
            string[] nomes = new string[tamanhoArrays];
            string[] origem = new string[tamanhoArrays];
            string[] destino = new string[tamanhoArrays];
            string[] dataVoo = new string[tamanhoArrays];
            var item = 0;
            
            //Exibição do Menu
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(@"
|===========================|
| Menu:                     |
|---------------------------|
| 1- Cadastrar passagem     |
| 2- Listar Passagens       |
| 0- Sair                   |
|===========================|");
                Console.ForegroundColor = ConsoleColor.White;

                int menu = int.Parse(Console.ReadLine());

                // Funções do Menu
                switch (menu)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("Insira os dados da passagem: ");
                            Console.WriteLine("Insira seu nome: ");
                            nomes[item] = Console.ReadLine();
                            Console.WriteLine("Insira a data do seu voo: ");
                            dataVoo[item] = Console.ReadLine();
                            Console.WriteLine("Insira a sua origem: ");
                            origem[item] = Console.ReadLine();
                            Console.WriteLine("Insira o seu destino: ");
                            destino[item] = Console.ReadLine();
                            Console.WriteLine("Você quer cadastrar outra passagem? (S/N) ");
                            string resposta = Console.ReadLine().ToLower();

                            if (resposta == "s")
                            {
                                confirmacaoPassagens = false;
                                item++;
                            }

                            else if (resposta == "n")
                            {
                                confirmacaoPassagens = true;
                            }

                            else
                            {
                                confirmacaoPassagens = false;

                            }
                        } while (confirmacaoPassagens == false);
                        break;

                    case 2:
                        for (var i = 0; i < nomes.Length; i++)
                        {
                            if (nomes[i] != null)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\n");
                                Console.WriteLine($@"Passagem {i + 1}:
{nomes[i]}
{dataVoo[i]}
{origem[i]}
{destino[i]} ");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                        if (nomes[0] == null)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Você ainda não cadastrou nenhuma passagem!");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;

                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Obrigado por utilizar o nosso sistema até a próxima viagem! :) ");
                        confirmacaoMenu = true;
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    default:
                        break;
                }
            } while (confirmacaoMenu == false);
        }
    }
}
