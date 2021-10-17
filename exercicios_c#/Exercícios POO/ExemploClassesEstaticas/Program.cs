using System;
using ExemploClassesEstaticas.Classes;

namespace ExemploClassesEstaticas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para conversão de moedas.");

            Console.Write("Digite o valor em R$: ");
            float valorEmReais = float.Parse(Console.ReadLine());

            Console.Write("O valor convertido em Dólar é de:  ");
            Console.WriteLine(Conversor.RealParaDolar(valorEmReais));


            Console.Write("Digite o valor em : ");
            float valorEmDolar = float.Parse(Console.ReadLine());

            Console.Write("O valor convertido em Reais é de:  ");
            Console.WriteLine(Conversor.DolarParaReal(valorEmDolar));

        }
    }
}
