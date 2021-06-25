using System;

namespace ProjetoFinal202101
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            double numeroUm, numeroDois, resultado;

            do
            {
                exibeMenu();
                opcao = Console.ReadLine().ToUpper();

                switch (opcao)
                {
                    case "A":
                        Console.WriteLine("Sou o programa");
                        break;
                    case "S":
                        calculaSoma();
                        break;
                    case "B":
                        calculaSubtracao();
                        break;
                    case "X":
                        Console.WriteLine("Obrigado por utilizar nosso programa!");
                        break;
                    default:
                        Console.WriteLine("Funcionalidade indisponível");
                        break;
                }
                Console.WriteLine("Pressione uma tecla para continuar...\n");
                Console.ReadKey();
                Console.Clear();
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
            Console.WriteLine("| X - Sair                |");
            Console.WriteLine("---------------------------");
        }

        static void calculaSoma()
        {
            double numeroUm, numeroDois, resultado;
            Console.WriteLine("---------------------------");
            Console.WriteLine("|          Soma           |");
            Console.WriteLine("---------------------------");

            numeroUm = digitaNumero("primeiro");
            numeroDois = digitaNumero("segundo");

            resultado = numeroUm + numeroDois;

            Console.WriteLine($"A soma de {numeroUm} + {numeroDois} é igual a {resultado}");
        }

        static void calculaSubtracao()
        {
            double numeroUm, numeroDois, resultado;
            Console.WriteLine("---------------------------");
            Console.WriteLine("|       Subtração         |");
            Console.WriteLine("---------------------------");

            numeroUm = digitaNumero("primeiro");
            numeroDois = digitaNumero("segundo");

            resultado = numeroUm - numeroDois;

            Console.WriteLine($"A subtração de {numeroUm} - {numeroDois} é igual a {resultado}");
        }

        static double digitaNumero(string ordem)
        {
            double numero = 0;
            Console.Write($"Digite o {ordem} número: ");
            Double.TryParse(Console.ReadLine(), out numero);
            return numero;
        }

    }
}
