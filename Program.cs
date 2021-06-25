using System;

namespace ProjetoFinal202101
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;

            do
            {
                exibeMenu();
                opcao = Console.ReadLine();
            }
            while (opcao != "X");

        }

        static void exibeMenu()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("|           Menu          |");
            Console.WriteLine("---------------------------");
            Console.WriteLine("| S - Soma (+)            |");
            Console.WriteLine("| B - Subtração (-)       |");
            Console.WriteLine("| M - Multiplicação (x)   |");
            Console.WriteLine("| D - Divisão (/)         |");
            Console.WriteLine("| E - Exponenciação (¹²³) |");
            Console.WriteLine("| R - Radiciação (V)      |");
            Console.WriteLine("---------------------------");
            Console.WriteLine("| A - Sobre o programa    |");
            Console.WriteLine("---------------------------");
        }
    }
}
