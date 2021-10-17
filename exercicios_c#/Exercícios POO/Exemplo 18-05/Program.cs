using System;

namespace Exemplo_18_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem personagem1 = new Personagem();

            // Console.WriteLine("Qual o nome do personagem 1?");
            personagem1.nome = "Cap";

            // Console.WriteLine("Qual a idade do personagem 1?");
            personagem1.idade = 120;

            // Console.WriteLine("Qual a armadura?");
            personagem1.armadura = "Escudo";

            // Console.WriteLine("Quantos pontos de vida tem o personagem 1?");
            personagem1.pontoVida = 80;


            Personagem personagem2 = new Personagem();

            // Console.WriteLine("Qual o nome do personagem 1?");
            personagem2.nome = "Miranha";

            // Console.WriteLine("Qual a idade do personagem 1?");
            personagem2.idade = 24;

            // Console.WriteLine("Qual a armadura?");
            personagem2.armadura = "Aranha de ferro";

            // Console.WriteLine("Quantos pontos de vida tem o personagem 1?");
            personagem2.pontoVida = 45;

            do
            {
                
            Console.WriteLine($@"
Selecione uma opção para o Cap:
    1- Atacar
    2- Defender
            ");

            int opcaoCap = int.Parse(Console.ReadLine());



            Console.WriteLine($@"
Selecione uma opção para o Miranha:
    1- Atacar
    2- Defender
            ");

            int opcaoMiranha = int.Parse(Console.ReadLine());

            if (opcaoCap == 1 && opcaoMiranha == 1)
            {
                personagem1.pontoVida = personagem1.pontoVida - personagem2.Atacar();
                personagem2.pontoVida = personagem2.pontoVida - personagem1.Atacar();
            }

            else if (opcaoCap == 1 && opcaoMiranha == 2)
            {
                personagem2.pontoVida = personagem2.pontoVida - (personagem1.Atacar() - personagem2.Defender());
            }

            else if (opcaoCap == 2 && opcaoMiranha == 1)
            {
                personagem1.pontoVida = personagem1.pontoVida - (personagem2.Atacar() - personagem1.Defender());
            }

            else if (opcaoCap == 2 && opcaoMiranha == 2)
            {}

            Console.WriteLine($"Vida do Cap {personagem1.pontoVida}");
            Console.WriteLine($"Vida do Miranha {personagem2.pontoVida}");
            } while (personagem1.pontoVida > 0 && personagem2.pontoVida > 0);
            
            if (personagem1.pontoVida <= 0)
            {
                Console.Write ("Você matou o Cap! Pressione \"F\": ");
            }
            else if (personagem2.pontoVida <= 0)
            {
                Console.Write("Você matou o Miranha! Pressione \"F\": ");
            }
            string respect = Console.ReadLine().ToUpper() ;
            if (respect == "F")
            {
                Console.WriteLine("Obrigado pelo seu respeito que ele vá em paz!");
            }
            else
            {
                Console.WriteLine("Como você não obteve respeito pelo nosso herói, você foi amaldiçoado por mil anos!");
            }
        }
    }
}
