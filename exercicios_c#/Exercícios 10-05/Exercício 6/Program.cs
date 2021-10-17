using System;

namespace Exercício_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome de 10 pessoas!");

            string[] nomes = new string[10];

            for (var i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"Digite o {(i + 1)}º nome");
                nomes[i] = Console.ReadLine().ToLower();
            }

            Console.WriteLine("Digite o nome que deseja buscar: ");
            string nomeBuscar = Console.ReadLine().ToLower();

            bool encontrado = false;

            foreach (var item in nomes)
            {
                if (nomeBuscar == item)
                {
                    encontrado = true;
                }
            }


            // if (encontrado == true)
            if (encontrado )
            {
                Console.WriteLine("ACHEI!!!!");
            }
            else
            {
                Console.WriteLine("NÃO ACHEI!!!!");

            }
        }
    }
}
