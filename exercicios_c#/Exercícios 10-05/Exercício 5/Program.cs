using System;

namespace Exercício_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int formula, contador;
            int tabs;
            
            for (tabs = 1; tabs <= 10; tabs++)
            {
                Console.WriteLine($"\nTabuada do {tabs}\n");
                for (contador = 1; contador <= 10; ++contador)
                {
                    formula = tabs * contador;
                    Console.WriteLine(tabs + " X " + contador + " = " + formula);

                }





            }
        }
    }
}
