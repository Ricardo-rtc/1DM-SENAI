using System;

namespace SistemaElevador.Classes
{
    public abstract class Elevador
    {
        private int andarAtual;
        private int andarTotal;
        private int capacidadeElev = 8;
        private int pessoas;


        public void Inicializar()
        {
            andarAtual = 0;
            pessoas = 0;
            Console.WriteLine("Quantos andares tem nesse prédio?");
            andarTotal = int.Parse(Console.ReadLine());
        }

        public string Entrar()
        {
            if (pessoas < capacidadeElev)
            {
                pessoas++;
                return $@"
Entrou uma pessoa no elevador. 
Pessoas no elevador {pessoas} ";
            }
            else
            {
                return @"Elevador lotado!";
            }
        }
        public string Sair()
        {
            if (pessoas != 0)
            {
                pessoas--;
                return $@"
Saiu uma pessoa no elevador. 
Pessoas no elevador {pessoas} ";
            }
            else
            {
                return @"Elevador Vazio!";
            }

        }
        public string Subir()
        {
            Console.WriteLine("Para qual andar deseja subir?");
            int respostaAndar = int.Parse(Console.ReadLine());

            if (respostaAndar <= andarTotal)
            {
                int conta = respostaAndar - andarAtual;
                for (var i = 0; i < conta; i++)
                {
                    andarAtual++;

                }
                return $"O elevador subiu até o andar: {andarAtual}";
            }
            else
            {
                return "Andar inválido!";
            }

        }
        public string Descer()
        {
            Console.WriteLine("Para qual andar deseja descer?");
            int respostaAndar = int.Parse(Console.ReadLine());

            if (respostaAndar >= 0 && respostaAndar < andarAtual)
            {
                int conta = andarAtual - respostaAndar;
                for (var i = 0; i < conta; i++)
                {
                    andarAtual = andarAtual - 1;

                }
                return $"O elevador desceu até o andar: {andarAtual}";
            }
            else
            {
                return "O elevador já está no térreo!";
            }
        }
    }
}