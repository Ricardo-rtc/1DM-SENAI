using System;

namespace Exercício_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
		
			Console.Write("Digite 10 números!\n");
		for (int p=0; p<numeros.Length; p++)
		{
			Console.Write("Digite um número: ");
			numeros[p] = Convert.ToInt32(Console.ReadLine());
		}
		
		Array.Sort(numeros);
		Console.WriteLine(@$"
O menor número escrito é: {numeros[0]}
O maior número escrito é: {numeros[9]}");
		
        }
    }
}
