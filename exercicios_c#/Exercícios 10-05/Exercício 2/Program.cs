using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool caracterfail = false;

            do
            {

                Console.WriteLine("Com que combustível você quer abastecer seu veículo? a(álcool)  g(gasolina)");
                string comb = Console.ReadLine().ToLower();
                if (comb == "g")
                {
                    Console.WriteLine("Quantos litros de gasolina você pretende colocar no seu tanque? O preço da gasolina está R$5,30.");
                    double ltg = int.Parse(Console.ReadLine());
                    caracterfail = true; 
                    if (ltg <= 20)
                    {
                        double resultadog = (5.3 * 0.96) * ltg;
                        Console.WriteLine("O preço a pagar com desconto é : R$ " + resultadog );

                    }
                    else 
                    {
                        double resultadog = (5.3 * 0.94)*ltg;
                        Console.WriteLine("O preço a pagar com desconto é : R$ " + resultadog );

                    }

                }
                else if (comb == "a")
                {
                    Console.WriteLine("Quantos litros de ácool você pretende colocar no seu tanque? O preço do álcool está R$4,90.");
                    int lta = int.Parse(Console.ReadLine());
                    caracterfail = true; 
                    if (lta <= 20)
                    {
                        double resultadoa = (4.9 * 0.97) * lta ;
                        Console.WriteLine("O preço a pagar com desconto é : R$ " + resultadoa );
                    }
                    else 
                    {
                        double resultadoa = (4.9 * 0.95) * lta;
                        Console.WriteLine("O preço a pagar com desconto é : R$ " + resultadoa );

                    }
                }
                else
                {
                    Console.WriteLine("Você colocou um caracter inválido! ");
                    
                }
            } while (caracterfail == false);

        }
    }
}
