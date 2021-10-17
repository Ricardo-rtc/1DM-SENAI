using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoAtual = DateTime.Now.Year;
            Console.WriteLine("Qual o seu ano de nascimento? ");
            int anoNasc = int.Parse(Console.ReadLine());

            int idade = anoAtual - anoNasc;

            if (idade < 16)
            {
                Console.WriteLine(@"
Você não possui maturidade necesária para escolher 
um representante logo você não pode votar!");
            }
            else if (idade >= 16 && idade < 18)
            {
                Console.WriteLine(@"
Você pode votar, mas ainda não é obrigatório pode continuar 
jogando LOL, ou qualquer jogo melhor!");
            }
            else if (idade >= 18)
            {
                Console.WriteLine(@"
Você já possui mais de 18 e deve votar, 
caso não o faça tomará uma multa!");

            }
        }
    }
}
