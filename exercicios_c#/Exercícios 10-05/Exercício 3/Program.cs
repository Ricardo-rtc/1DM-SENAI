using System;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do produto que você comprou? ");
            string nomeProduto = Console.ReadLine();

            Console.WriteLine($"Qual a quantidade de {nomeProduto} que você comprou? ");
            int qntProduto = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o valor untário de {nomeProduto}: (Se for um número decimal digite com . ) ");
            double valorProduto = double.Parse(Console.ReadLine());
            double valorTotal = qntProduto * valorProduto;
            Console.WriteLine($"O valor a se pagar sem desconto é R$ {(valorTotal).ToString("N2")}");


            if (qntProduto <= 5)
            {
                Console.WriteLine($"O valor a pagar com desconto é: R$ {(valorTotal * 0.98).ToString("N2")}");
            }
            else if (qntProduto > 5 && qntProduto <=10)
            {
                Console.WriteLine($"O valor a pagar com desconto é: R$ {(valorTotal * 0.97).ToString("N2")}");

            }
            else if (qntProduto > 10)
            {
                Console.WriteLine($"O valor a pagar com desconto é: R$ {(valorTotal * 0.95).ToString("N2")}");

            }
            



        }
    }
}
