using System;
using SistemaCafeteira.Classes;

namespace SistemaCafeteira
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cafe = false;
            bool segundoCafe = false;
            MaquinaCafe mc = new MaquinaCafe();

            Console.WriteLine(@"
Super CafeteiraTabajaras Plus++ ");
            do
            {
                mc.fazerCafe();
                do
                {

                    Console.WriteLine($@"
Deseja fazer outro café?
(S) Sim
(N) Não");
                    string sn = Console.ReadLine().ToUpper();
                    if (sn == "S")
                    {
                        segundoCafe = true;
                        cafe = false;
                    }
                    else if (sn == "N")
                    {
                        segundoCafe = false;
                        cafe = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Opção inválido");
                        Console.ForegroundColor = ConsoleColor.White;
                        cafe = true;
                    }
                } while (cafe == true);
            } while (segundoCafe == true);
        }
    }
}
