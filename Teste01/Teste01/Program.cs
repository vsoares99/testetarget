using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int N = int.Parse(Console.ReadLine());
            bool verificar = false;

            if (N == 0)
            {
                verificar = true;
            }

            int numeroAnterior = 0;
            int numeroAtual = 1;
            while (numeroAtual <= N)
            {
                int proximo = numeroAnterior + numeroAtual;
                numeroAnterior = numeroAtual;
                numeroAtual = proximo;

                if (numeroAtual == N)
                {
                    verificar = true;
                }
            }

            Console.WriteLine();
            if (verificar)
            {
                Console.WriteLine($"{N} Pertence à sequência de Fibonacci");
            }
            else
            {
                Console.WriteLine($"{N} Não pertence à sequência de Fibonacci");
            }
            
        }
    }
}