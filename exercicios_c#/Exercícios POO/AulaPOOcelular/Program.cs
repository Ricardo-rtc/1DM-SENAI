using System;

namespace AulaPOOcelular
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular iPhone = new Celular();
            Console.WriteLine("Deseja ligar o celular? (s/n)");
            iPhone.Ligar = Console.ReadLine(); 
            if (iPhone.Ligar == "s" )
            {
                iPhone.Ligado();
            } 
            else
            {
                Console.WriteLine("Entendi, você não que mexer no seu celular vá dormir então!");

            }
            if (iPhone.ligado == true )
            {
                Console.WriteLine("Celular ligando!");
            }
            
            while (iPhone.ligado == true)
            {
                Console.WriteLine(@"
==================================
|                                |
|   1- Ligar para alguém         |
|                                |
|   2- Enviar mensagem           |
|                                |
|   3- Listar propriedades       |
|                                |
|   4- Desligar celular          |
|                                |
==================================
");
                iPhone.menu= int.Parse(Console.ReadLine());
                switch (iPhone.menu)
                {
                    case 1:
                        Console.WriteLine(@"
Como você não pagou sua conta você não pode fazer chamadas até quitar seu débito!");
                        break;
                    case 2:
                        Console.WriteLine(@"
Você está sem sinal! Tente novamente.");
                        break;
                    case 3:
                        Console.WriteLine($@"
A cor do celular é {iPhone.cor}
O modelo do celular é {iPhone.modelo}
O tamanho do celular é {iPhone.tamanho}");
                        break;
                    case 4:
                        Console.WriteLine("Desligando! Bye bye!");
                        iPhone.Desligado();
                        break;
                    default:
                        break;
                }
            }
           
        }

    }
}
