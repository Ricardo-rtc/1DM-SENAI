using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool resposta = false;
            do
            {
                Console.WriteLine("Insira um número de 0 a 10: ");
                int number = int.Parse(Console.ReadLine());
                if (number > 10)
                {
                    Console.WriteLine("Número inválido!");
                }
                else 
                {    
                Console.WriteLine("Número válido!");
                Console.WriteLine("FIM DA EXECUÇÃO");
                resposta = true;
                }
                
            } while (resposta == false);

        }
    }
}

