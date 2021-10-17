using System;
using System.Collections.Generic;
using ExemploListasdeObjetos.Classes;

namespace ExemploListasdeObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            produtos.Add(new Produto(1, "Apple Watch", 3522.56f));
            produtos.Add(new Produto(2, "Xiaomi Watch", 1522.45f));
            produtos.Add(new Produto(3, "Zenfone ASUS", 2522.87f));
            produtos.Add(new Produto(4, "Samsung S21+", 2522.87f));
            produtos.Add(new Produto(5, "Motorola G8", 2522.87f));

            Produto iphone = new Produto();
            iphone.Codigo = 6;
            iphone.Nome = "Iphone XII";
            iphone.Preco = 8952.45f; 

            produtos.Add(iphone);

            foreach (Produto p in produtos)
            {
                Console.WriteLine($"{p.Nome} - R$ {p.Preco}");
            }
            Console.WriteLine("");

            produtos.RemoveAt(5);

            produtos.RemoveAll(x => x.Nome == "Apple Watch");

            Console.WriteLine("\nLista alterada: ");

            foreach (Produto p in produtos)
            {
                Console.WriteLine($"{p.Nome} - R$ {p.Preco}");
            }
            Console.WriteLine("");

            Produto atualizacao = produtos.Find(p => p.Codigo == 4);
            atualizacao.Preco = 1300.45f;

            produtos.Insert(3,atualizacao);
            produtos.RemoveAt(3);

            foreach (Produto p in produtos)
            {
                Console.WriteLine($"{p.Nome} - R$ {p.Preco}");
            }
            


        }
    }
}
