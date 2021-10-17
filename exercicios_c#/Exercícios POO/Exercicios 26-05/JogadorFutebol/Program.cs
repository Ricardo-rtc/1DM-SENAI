using System;
using JogadorFutebol.Classes;

namespace JogadorFutebol 
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool repetir = false;

            do
            {

                Console.WriteLine(@"
Fala jogador!
Para seber se você deve se apostentar, 
responda a perguntar a baixo:
Qual posição do campo você joga?
(A) Ataque 
(M) Meio
(D) Defesa");

                string escolha = Console.ReadLine().ToUpper();

                JogadorAtaque a = new JogadorAtaque();
                JogadorMeio m = new JogadorMeio();
                JogadorDefesa d = new JogadorDefesa();
                switch (escolha)
                {
                    case "A":
                        a.GravarDados();
                        a.Aposentadoria();
                        Console.WriteLine(a.ListarDados(a.Idade()));
                        Console.WriteLine($"{a.Aposentadoria()}");
                        repetir = false; 
                        break;

                    case "M":
                        m.GravarDados();
                        m.Aposentadoria();
                        Console.WriteLine(m.ListarDados(m.Idade()));
                        Console.WriteLine($"{m.Aposentadoria()}");
                        repetir = false; 
                        break;

                    case "D":
                        d.GravarDados();
                        d.Aposentadoria();
                        Console.WriteLine(d.ListarDados(d.Idade()));
                        Console.WriteLine($"{d.Aposentadoria()}");
                        repetir = false; 
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Opção inválida!");
                        Console.ForegroundColor = ConsoleColor.White;
                        repetir = true; 
                        break;
                }
            } while (repetir == true);


        }
    }
}
