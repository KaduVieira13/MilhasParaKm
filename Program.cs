using System;

namespace MilhasParaKm
{
    class Program
    {
        static void Main(string[] args)
        {
             double milhas;
            double km = 1.609;

            Console.WriteLine("Digite o Valor em Milhas: ");
            milhas = double.Parse(Console.ReadLine());

            Console.WriteLine("O resultado da conversão de milhas para Km é: ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine();
            Console.WriteLine($"{milhas * km} Quilômetros. ");
            Console.ResetColor();
            Console.Write("\n");
            Console.WriteLine("Pressione uma tecla para sair!");
            Console.ReadKey();
        }
    }
}
