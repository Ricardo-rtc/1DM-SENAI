using System;

namespace Exemplo_24_05.Classes
{
    public class Credito : Cartao
    {
        private float Limite = 3000f;
        public void Pagar()
        {
            float valor = this.Valor;
            int vezes;

            if (valor > Limite)
            {
                Console.WriteLine("Você não tem limite suficiente para fazer esta compra!");
            }
            else
            {
                do
                {
                    Console.WriteLine($"Em quantas parcelas deseja pagar esse valor {valor:C2}? (De 1 à 12)");
                    vezes = int.Parse(Console.ReadLine());

                    if (vezes >= 1 && vezes <= 6)
                    {
                        Console.WriteLine($"Você optou por parcelar em {vezes} vezes, dessa forma o juros será de 5% do valor total");
                        Console.WriteLine($"Você pagará {valor * 1.05:C2} em {vezes} vezes de {(valor * 1.05) / vezes:C2}");
                    }
                    else if (vezes >= 7 && vezes <= 12)
                    {
                        Console.WriteLine($"Você optou por parcelar em {vezes} vezes, dessa forma o juros será de 5% do valor total");
                        Console.WriteLine($"Você pagará {valor * 1.08:C2} em {vezes} vezes de {(valor * 1.08) / vezes:C2}");
                    }
                    else
                    {
                        Console.WriteLine("Impossível parcelar nessa quantidade, escola um número de vezes entre 1 e 12");
                    }

                } while (vezes > 12 || vezes < 1);
            }
        }
    }
}