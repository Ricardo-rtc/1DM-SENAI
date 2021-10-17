using System;
using SistemaElevador.Classes;


namespace SistemaElevador
{
    class Program : Elevador
    {
        static void Main(string[] args)
        {
            int opcao;
            bool repetir = false;

            ElevadorSocial social = new ElevadorSocial();
            ElevadorServico servico = new ElevadorServico();
            social.Inicializar();


            Console.WriteLine(@"
Qual elevador deseja usar?
1 - Social
2 - Serviço");
            opcao = int.Parse(Console.ReadLine());
        

            if (opcao == 1)
            {
                do
                {
                    Console.WriteLine(@"
===================================
|       Elevador Social           |
|¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨|
| 1 - Entrar uma pessoa           |
| 2 - Sair uma pessoa             |
| 3 - Subir um andar              |
| 4 - Descer um andar             |
| 0 - Sair                        |
===================================");
                    opcao = int.Parse(Console.ReadLine());


                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine(social.Entrar());
                            break;
                        case 2:
                            Console.WriteLine(social.Sair());
                            break;
                        case 3:
                            Console.WriteLine(social.Subir());
                            break;
                        case 4:
                            Console.WriteLine(social.Descer());
                            break;
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Obrigado por utilizar nosso elevador!");
                            Console.ForegroundColor = ConsoleColor.White;
                            repetir = true;
                            break;
                    }
                } while (repetir == false);
            }
            else if (opcao == 2)
            {
                do
                {
                    Console.WriteLine(@"
===================================
|       Elevador Serviço          |
|¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨|
| 1 - Entrar uma pessoa           |
| 2 - Sair uma pessoa             |
| 3 - Subir um andar              |
| 4 - Descer um andar             |
| 5 - Adicionar uma caixa         |
| 6 - Retirar uma caixa           |  
| 0 - Sair                        |
===================================");
                    opcao = int.Parse(Console.ReadLine());
                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine(servico.Entrar());
                            break;
                        case 2:
                            Console.WriteLine(servico.Sair());
                            break;
                        case 3:
                            Console.WriteLine(servico.Subir());
                            break;
                        case 4:
                            Console.WriteLine(servico.Descer());
                            break;
                        case 5:
                            Console.WriteLine(servico.SomarCaixa());
                            break;
                        case 6:
                            Console.WriteLine(servico.RetirarCaixa());
                            break;
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Obrigado por utilizar nosso elevador!");
                            Console.ForegroundColor = ConsoleColor.White;
                            repetir = true;
                            break;
                    }
                } while (repetir == false);
            }

        }
    }
}
