using System;

namespace Exemploconsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Exercício de média\n");
            Console.WriteLine("Qual é o seu nome?");
            string nomePessoa = Console.ReadLine();

            Console.WriteLine("Olá! " + nomePessoa + "\n");

            Console.WriteLine(nomePessoa + ", digite o primeiro número:");
            float primeiroNumero = float.Parse(Console.ReadLine());

            Console.WriteLine(nomePessoa + ", digite o segundo número:");
            float segundoNumero = float.Parse(Console.ReadLine());

            Console.WriteLine(nomePessoa + ", digite o terceiro número:");
            float terceiroNumero = float.Parse(Console.ReadLine());

            float soma = primeiroNumero + segundoNumero + terceiroNumero;
            float divisao = soma/3;

            Console.WriteLine("A soma dos números é: " + soma + ". Logo dividindo esse valor por 3 é igual a : " + divisao.ToString("N2"));

            if (divisao >= 5)
            {
                Console.WriteLine(nomePessoa + " como a sua média foi " + divisao.ToString("N2") + ", você foi aprovado!");
            }

            else 
            {
                Console.WriteLine(nomePessoa +  " como a sua média foi " + divisao.ToString("N2") + ", você foi reprovado!");
            }
        }
    }
}
