using System;

namespace Exemplo_04_05
{
    class Program
    {
        private const string V = "s";

        static void Main(string[] args)
        {
            //    for (var i = 0; i <=5; i++)
            //    {
            //        Console.WriteLine("Contador: " + i );
            //    }

            // bool respostaCorreta = false;

            // while (respostaCorreta == false)
            // {
            //     Console.WriteLine("Qual a idade do adulto Ney?");
            //     int resposta = int.Parse(Console.ReadLine());
            //     if (resposta == 29)
            //     {
            //         respostaCorreta = true;
            //     }
            // }

            //     Console.WriteLine("FIM DA EXECUÇÃO");

                bool respostaCorreta = false; 
            do
            {
            
                Console.WriteLine("Qual é a idade do adulto Ney?");
                int resposta = int.Parse(Console.ReadLine());

                if(resposta == 29){
                    respostaCorreta = true;
                }


            } while (respostaCorreta == false);

        }
    }
}
