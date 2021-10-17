using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool resposta = false;
            do
            {
                Console.WriteLine("Para se cadastrar em nosso sitema digite seu nome: ");
                string respostaNome = Console.ReadLine();

                Console.WriteLine("Agora digite sua senha: ");
                string respostaSenha = Console.ReadLine();
                int tamanhoString = respostaSenha.Length;


                if (respostaNome == respostaSenha)
                {
                    do
                    {
                        Console.WriteLine(@"
Sua senha e nome de usuário são iguais.  
Digite uma senha diferente do nome de usuário. Digite outra senha: ");
                        respostaSenha = Console.ReadLine();
                        tamanhoString = respostaSenha.Length;

                    } while (respostaNome == respostaSenha);
                    resposta = true;
                }

                if (respostaSenha == "")
                {
                    do
                    {
                        Console.WriteLine(@"
Sua senha está em branco.  
Digite uma senha válida: ");
                        respostaSenha = Console.ReadLine();
                        tamanhoString = respostaSenha.Length;

                    } while (respostaNome == respostaSenha);
                    resposta = true;

                }
                else
                {
                    resposta = true;
                }
                if (tamanhoString >= 8)
                {
                    resposta = true;
                }

                else
                {
                    do
                    {
                        if (tamanhoString < 8)
                        {
                            Console.WriteLine(@"
Sua senha é menor que 8 caracteres.  
Digite uma senha válida: ");
                            respostaSenha = Console.ReadLine();
                            tamanhoString = respostaSenha.Length;
                        }
                        if (respostaNome == respostaSenha)
                        {
                            Console.WriteLine(@"
Seu nome de usuário e a senha são iguais! 
Digite uma senha válida: ");
                            respostaSenha = Console.ReadLine();
                            tamanhoString = respostaSenha.Length;
                        }

                    } while ((tamanhoString < 8) || (respostaNome == respostaSenha));
                    resposta = true;
                }
                
            } while (resposta == false);
        }
    }
}
