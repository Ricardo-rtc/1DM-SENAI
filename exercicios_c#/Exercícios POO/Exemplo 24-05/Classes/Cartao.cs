using System;

namespace Exemplo_24_05.Classes
{
    public abstract class Cartao : Pagamento
    {
        public string Bandeira; 
        public string Numero; 
        public string Titular; 
        public string Cvv; 


        public string SalvarCartao()
        {
            Console.WriteLine("Digite a bandeira do seu cartão:");
            Bandeira = Console.ReadLine();

            Console.WriteLine("Digite o número do seu cartão:");
            Numero = Console.ReadLine();

            Console.WriteLine("Digite o nome do titular do cartão:");
            Titular = Console.ReadLine();

            Console.WriteLine("Digite o código de segurança do seu cartão:");
            Cvv = Console.ReadLine();

            return $"Cartão de número {Numero} salvo com sucesso!";
        }
        
    }
}