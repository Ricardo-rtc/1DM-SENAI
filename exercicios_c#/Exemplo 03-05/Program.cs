using System;

namespace Exemplo_03_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o seu nome:");
            string nome = Console.ReadLine().ToLower();

            string letra = nome.Substring(0,1);

            switch (letra)
            {
                case "a" :
                    Console.WriteLine("A primeura letra é : " + letra + ", igual a Abelha");

                    break;

                case "e":
                    Console.WriteLine("A primeura letra é : " + letra + ", igual a Elefante");

                    break;

                case "i":
                    Console.WriteLine("A primeura letra é : " + letra + ", igual a Igreja");

                    break;
                    
                case "o":
                    Console.WriteLine("A primeura letra é : " + letra + ", igual a Ovo");

                    break;

                case "u":
                    Console.WriteLine("A primeura letra é : " + letra + ", igual a Urubu");

                    break;
                    
                default:
                    Console.WriteLine("A primeira letra do seu nome não é uma vogal! Nunca será! ");
                    break;
            }
            
           
            

        }
    }
}
