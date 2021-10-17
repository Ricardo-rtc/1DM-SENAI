using System;
using MetodosConstrutores.Classes;

namespace MetodosConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo de Métodos Construtores");

            Produto p = new Produto();

            Console.WriteLine("Produto 1 (Construtor sem argumentos)");
            Console.WriteLine($"Codigo: {p.Codigo}\nNome: {p.Nome}\nDescricao: {p.Descricao}\nItens em estoque:  {p.Estoque}\n");
            p.Codigo = 3;
            
            Produto p2 = new Produto(456);
            Console.WriteLine("Produto 2 (Construtor com 1 argumentos)");
            Console.WriteLine($"Codigo: {p2.Codigo}\nNome: {p2.Nome}\nDescricao: {p2.Descricao}\nItens em estoque:  {p2.Estoque}\n");
           
            Produto p3 = new Produto(789, "Maçã", "Maçãs bela e orgânicas", 3);
            Console.WriteLine("Produto 3 (Construtor com 4 argumentos)");
            Console.WriteLine($"Codigo: {p3.Codigo}\nNome: {p3.Nome}\nDescricao: {p3.Descricao}\nItens em estoque:  {p3.Estoque}\n");


            
        }
    }
}
