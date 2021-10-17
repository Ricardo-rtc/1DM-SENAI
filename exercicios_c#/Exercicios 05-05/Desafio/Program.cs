using System;

namespace Desafio
{
    class Program
    {

        static void Main(string[] args)
        {
            
            int numeroAnterior = -1;
            int ultimoN = 1;
            int resultado;
        
            Console.WriteLine("\nFibonacci\n");

            for (int i = 0; i <=14; i++)
            {
                resultado = numeroAnterior + ultimoN;
                numeroAnterior = ultimoN;
                ultimoN = resultado;
                Console.Write(resultado + " | ");
                
            }
        }
    }
}


