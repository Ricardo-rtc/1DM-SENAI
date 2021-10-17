using System;

namespace Exemplo_2_03_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número de 0 a 10 em algarismo romano: ");
            string number = Console.ReadLine().ToUpper();

            switch (number)
            {
                case "0" :
                    Console.WriteLine("O número que você escreveu em algarismo romano foi: " + number + ", logo esse número equivale a 0");
                    break;

                case "I" :
                    Console.WriteLine("O número que você escreveu em algarismo romano foi: " + number + ", logo esse número equivale a 1");
                    break;

                case "II" :
                    Console.WriteLine("O número que você escreveu em algarismo romano foi: " + number + ", logo esse número equivale a 2");
                    break;
                    
                case "III":
                    Console.WriteLine("O número que você escreveu em algarismo romano foi: " + number+ ", logo esse número equivale a 3");
                    break;

                case "IV":
                    Console.WriteLine("O número que você escreveu em algarismo romano foi: " + number + ", logo esse número equivale a 4");
                    break;

                case "V":
                    Console.WriteLine("O número que você escreveu em algarismo romano foi: " + number + ", logo esse número equivale a 5");
                    break;

                case "VI":
                    Console.WriteLine("O número que você escreveu em algarismo romano foi: " + number+ ", logo esse número equivale a 6");
                    break;
                    
                case "VII":
                    Console.WriteLine("O número que você escreveu em algarismo romano foi: " + number + ", logo esse número equivale a 7");
                    break;

                case "VIII":
                    Console.WriteLine("O número que você escreveu em algarismo romano foi: " + number + ", logo esse número equivale a 8");
                    break;

                case "IX":
                    Console.WriteLine("O número que você escreveu em algarismo romano foi: " + number + ", logo esse número equivale a 9");
                    break;

                case "X":
                    Console.WriteLine("O número que você escreveu em algarismo romano foi: " + number + ", logo esse número equivale a 10" );
                    break;

                default:
                    Console.WriteLine($@"
O número que você escreveu em algarismo romano foi: {number}  
Logo esse número está fora do que foi pedido e não consigo reconhece-lo!"); 

                    break;
            }
            
        }
    }
}
