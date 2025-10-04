using System;

namespace OrdemCrescente
{
    internal class Program
    {
        private const int TotalNumeros = 6;

        private static void Main()
        {
            int[] numeros = new int[TotalNumeros];
            Console.WriteLine("Digite 6 números inteiros:");

            for (int i = 0; i < TotalNumeros; i++)
            {
                while (true)
                {
                    Console.Write($"Número {i + 1}: ");
                    string? entrada = Console.ReadLine();
                    if (int.TryParse(entrada, out int valor))
                    {
                        numeros[i] = valor;
                        break;
                    }
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
                }
            }

            bool estaCrescente = true;
            for (int i = 1; i < TotalNumeros; i++)
            {
                if (numeros[i] < numeros[i - 1])
                {
                    estaCrescente = false;
                    break;
                }
            }

            if (estaCrescente)
            {
                Console.WriteLine("Os números estão em ordem crescente.");
            }
            else
            {
                Console.WriteLine("Os números não estão em ordem crescente.");
            }
        }
    }
}
