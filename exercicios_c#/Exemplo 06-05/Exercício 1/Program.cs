using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pacotes = null;
            int quantidade;
            double preco;

            Console.Write("Digite quantos pacotes de pão de queijo você deseja: ");
            quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            pacotes = new int[quantidade];

            for(var i = 0; i <= (quantidade - 1); i++){
                Console.Write("Digite quantos pães de queijo haverá no pacote " + (i + 1) + ": ");
                pacotes[i] = int.Parse(Console.ReadLine());
            }

            int c = 1;
            Console.WriteLine("");
            foreach (var item in pacotes)
            {
                preco = item * 0.7;
                Console.WriteLine(@$"
 --------------------------------------------------------
|| Pacote   {c}   ||  {item } pães de queijo || Preço ${preco.ToString("N2")}   ||
 --------------------------------------------------------");
                c++;
            }
        }
    }
}
