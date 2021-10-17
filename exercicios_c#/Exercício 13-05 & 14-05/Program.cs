using System;

namespace Exercício_13_05___14_05
{
    class Program
    {

        static string respostaPromoção;
        static string s;
        static string[] nome = new string[1000];
        static string[] confirmacao = new string[1000];
        static float[] preço = new float[1000];
        static bool[] promoção = new bool[1000];

        static bool confirmacaoProdutos = false;
        static int item = 0;

        static void Main(string[] args)
        {
            bool confirmacaoMenu = false;
            do
            {
                int OpçãoMenu = ExibiçãoMenu();
                switch (OpçãoMenu)
                {
                    case 1:
                        do
                        {
                            FunçãoCadastrar();
                        } while (confirmacaoProdutos == false);
                        break;
                    case 2:
                        FunçãoListar();
                        break;
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Obrigado por utilizar o nosso sistema até a próxima compra! :) ");
                        confirmacaoMenu = true;
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    default:
                        break;
                }


            } while (confirmacaoMenu == false);
        }
        static int ExibiçãoMenu()
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
=============================
| Menu:                     |
-----------------------------
| 1- Cadastrar produto      |
| 2- Listar produtos        |
| 0- Sair                   |
|===========================|");
            Console.ForegroundColor = ConsoleColor.White;

            int menu = int.Parse(Console.ReadLine());
            return menu;
        }

        static bool FunçãoCadastrar()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Insira o nome do produto: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            nome[item] = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Insira o preço do produto: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            preço[item] = float.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("O produto está em promoção? (S/N) ");
            Console.ForegroundColor = ConsoleColor.Gray;
            respostaPromoção = Console.ReadLine().ToLower();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Você quer cadastrar outro produto? (S/N) ");
            Console.ForegroundColor = ConsoleColor.Gray;
            string resposta = Console.ReadLine().ToLower();
            item++;

            if (respostaPromoção == "sim" || respostaPromoção == "s")
            {
                promoção[item] = true;
            }
            else
            {
                promoção[item] = false;
            }

            if (resposta == "s")
            {
                confirmacaoProdutos = false;

            }

            else if (resposta == "n")
            {
                confirmacaoProdutos = true;
            }

            else
            {
                confirmacaoProdutos = false;

            }
            return confirmacaoProdutos;
        }
        static void FunçãoListar()
        {
            for (var i = 0; i < 1000; i++)
            {
                if (promoção[i] == true)
                {
                    s = promoção.ToString();
                    s = "Não";
                }
                else
                {
                    s = promoção.ToString();
                    s = "Sim";
                }
                if (nome[i] != null)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($@"
==================================================                  
Produto {i + 1}:                                             
--------------------------------------------------
{nome[i]}                                         
{preço[i]}                                        
{s}                                               
==================================================");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            if (nome[0] == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Você ainda não cadastrou nenhum produto!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }



    }
}
