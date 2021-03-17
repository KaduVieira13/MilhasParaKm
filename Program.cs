using System;

namespace MilhasParaKm
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuario;
            double km = 1.609; 
            double resultado;
            double milhas;

            Console.WriteLine("Digite o Valor em Milhas: ");
            usuario = Console.ReadLine();
            milhas = Convert.ToDouble(usuario);
            resultado = milhas * km;
            Console.WriteLine("O resultado da conversão de milhas para Km é: ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine();
            Console.WriteLine($"{resultado } Quilômetros. ");
            Console.ResetColor();
            Console.Write("\n");
            Console.WriteLine("Pressione uma tecla para sair!");
            Console.ReadKey();
        }
    }
}
