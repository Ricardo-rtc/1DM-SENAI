using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double um, dois;
            string operacao;

            Console.WriteLine("Calculadora iniciada\n");
            Console.WriteLine("Digite os dois números que deseja utilizar");

            Console.Write("Digite o primeiro número: ");
            um = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            dois = double.Parse(Console.ReadLine());

            Console.Write($@"
Soma(+), Subtração(-), Multiplicação(*) ou Divisão(/)
Digite qual operação deseja realizar: ");
            operacao = Console.ReadLine();

            switch (operacao)
            {
                case "+":
                    Soma(um, dois);
                    break;
                case "-":
                    Subtracao(um, dois);
                    break;
                case "*":
                    Multiplicacao(um, dois);
                    break;
                case "/":
                    Divisao(um, dois);
                    break;
            }
        }
        static void Soma(double numeroUm, double numeroDois)
        {
            double soma;
            soma = numeroUm + numeroDois;
            Console.WriteLine($"\nO resultado da soma é igual a {soma}.");
        }
        static void Subtracao(double numeroUm, double numeroDois)
        {
            double subtracao;
            subtracao = numeroUm - numeroDois;
            Console.WriteLine($"\nO resultado da subtração é igual a {subtracao}.");
        }
        static void Multiplicacao(double numeroUm, double numeroDois)
        {
            double multiplicacao;
            multiplicacao = numeroUm * numeroDois;
            Console.WriteLine($"\nO resultado da multiplicação é igual a {multiplicacao}.");
        }
        static void Divisao(double numeroUm, double numeroDois)
        {
            double divisao;
            divisao = numeroUm / numeroDois;
            Console.WriteLine($"\nO resultado da divisão é igual a {divisao}.");
        }
    }
}

