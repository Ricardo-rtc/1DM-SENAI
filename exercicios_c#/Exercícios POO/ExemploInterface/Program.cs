using System;
using ExemploInterface.Classes;

namespace ExemploInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = 0;
            do
            {
                Produto produto = new Produto();

                Console.WriteLine("Digite o nome do produto:");
                produto.Nome = Console.ReadLine();

                Console.WriteLine("Digite o nome do produto:");
                produto.Preco = float.Parse(Console.ReadLine());

                produto.Codigo = id;

                Carrinho carrinho = new Carrinho();

                carrinho.Cadastrar(produto);
                id++;

            } while (true);



        }
    }
}
