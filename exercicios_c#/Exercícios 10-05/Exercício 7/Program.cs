using System;

namespace Exercício_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira 15 números!");

            int[] numeros = new int[3];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Digite o {(i + 1)}º número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
                Console.WriteLine($"\n-------------------------------------------------------");

            for (var i = (numeros.Length - 1); i >=0 ; i--)
            {
                Console.WriteLine($"{numeros[i]}\n");
            }
        }
    }
}
