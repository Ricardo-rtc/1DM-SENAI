using System;

namespace SistemaCafeteira.Classes
{
    public class MaquinaCafe
    {
        private int acucarDisponivel = 500;

        public void fazerCafe()
        {
            bool repetirUm = false;
            bool repetirDois = false;
            do
            {
                Console.WriteLine(@"
Deseja fazer um café com ou sem açucar?
(C) Com
(S) Sem");
                string cs = Console.ReadLine().ToUpper();
                if (cs == "C")
                {
                    do
                    {
                        Console.WriteLine(@"
Deseja escolher a quantidade de açúcar?
(S) Sim
(N) Não");
                        string sn = Console.ReadLine().ToUpper();
                        if (sn == "S")
                        {
                            Console.WriteLine("Digite a quantidade de açúcar:");
                            int acucar = int.Parse(Console.ReadLine());
                            fazerCafe(acucar);
                            repetirDois = false;
                        }
                        else if (sn == "N")
                        {
                            acucarDisponivel = acucarDisponivel - 10;
                            Console.WriteLine($@"
O padrão quando não é informado a quantidade 
de açúcar é adicionar 10 gramas!
Você ainda tem {acucarDisponivel} gramas na sua máquina de café");
                            repetirDois = false;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Opção inválida!");
                            Console.ForegroundColor = ConsoleColor.White;
                            repetirDois = true;
                        }
                    } while (repetirDois == true);
                }
                else if (cs == "S")
                {
                    repetirUm = false;
                    Console.WriteLine("Seu café sem açúcar está pronto!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Opção inválida!");
                    Console.ForegroundColor = ConsoleColor.White;
                    repetirUm = true;
                }

            } while (repetirUm == true);
        }

        public void fazerCafe(int acucar)
        {
            if (acucar > acucarDisponivel)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Quantidade de açúcar indisponível!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine($"Seu café com {acucar} gramas de acucar está pronto");
                acucarDisponivel = acucarDisponivel - acucar;
                Console.WriteLine($"Agora tem {acucarDisponivel} gramas de açucar na sua máquinda de café");
            }

        }

    }
}