using System;
using ExemploSobrecarga.Classes;

namespace ExemploSobrecarga 
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            for (var i = 0; i < f.lista.Length; i++)
            {
                Console.WriteLine("Digite um item: ");
                f.lista[i] = Console.ReadLine();

            }

            Console.WriteLine("Mostrar sem agurmentos.");
            f.Mostrar();


            Console.WriteLine("Mostrar com agurmento tipo 'int'.");
            f.Mostrar(2);

            Console.WriteLine("Mostrar com agurmento tipo 'string'.");
            f.Mostrar("maçã");
        }
    }
}
