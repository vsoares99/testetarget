using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva uma palavra ou frase:");
            string texto = Console.ReadLine();

            int cont = 0;
            foreach (char a in texto)
            {
                if (a == 'a' || a == 'A')
                {
                    cont++;
                }
            }

            if (cont == 0)
            {
                Console.WriteLine("Letra 'a' não foi encontrada na string.");
            }
            else
            {
                Console.WriteLine($"Letra 'a' foi encontrada {cont} vez(es) na string.");
            }
        }
    }
}