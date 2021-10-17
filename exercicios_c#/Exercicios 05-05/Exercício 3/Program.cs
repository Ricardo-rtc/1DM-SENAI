using System;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá! Para se cadastrar em nosso sistema precisamos de algumas informações! ");
            string Nome;
            int Idade;
            int Salário;
            string Civil;
            bool varNome = false;
            bool varIdade = false;
            bool varSalario = false;
            bool varCivil = false;
            do
            {
                Console.WriteLine("Digite seu nome:");
                Nome = Console.ReadLine();
                if (Nome == "")
                {
                    Console.WriteLine("Nenhum nome inserido! ");
                }
                else
                {
                    varNome = true;
                }


            } while (varNome == false);

            do
            {
                Console.WriteLine("Digite sua idade:");
                Idade = int.Parse(Console.ReadLine());

                if ((Idade == 0)|| (Idade > 150))
                {
                    Console.WriteLine("Idade incorreta! ");
                    
                }
                else 
                {
                    varIdade = true;
                }
            } while (varIdade == false);

            do
            {
                Console.WriteLine("Digite sua salário:");
                Salário = int.Parse(Console.ReadLine());
                if (Salário == 0)
                {
                    Console.WriteLine("Você não recebe um valor menor que zero! ");
                    
                }
                else
                {
                    varSalario = true;
                }
            } while (varSalario == false);
            do
            {
                Console.WriteLine(@"
Digite seu estado civil: 
- 's'(solteiro(a)) 
- 'c'(casado(a))
- 'v'(viuvo(a)) 
- 'd'(divorciado(a)):");
                Civil = Console.ReadLine().ToLower();
                switch (Civil)
                {
                    case "":
                        Console.WriteLine("Espaço em branco!");
                        break;
                    case "s":
                        Console.WriteLine("Você é Solteiro(a).");
                        varCivil = true;
                        break;
                    case "c":
                        Console.WriteLine("Você é Casado(a).");
                        varCivil = true;
                        break;
                    case "v":
                        Console.WriteLine("Você é Viuvo(a).");
                        varCivil = true;
                        break;
                    case "d":
                        Console.WriteLine("Você é Divorciado(a).");
                        varCivil = true;
                        break;
                    default:
                        Console.WriteLine("Dado incorreto!");
                        break;
                }
                
            } while (varCivil == false);
        }
    }
}