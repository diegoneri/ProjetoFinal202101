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
                opcao = Console.ReadLine().Trim().ToUpper();

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
                    case "M":
                        calculaProduto();
                        break;
                    case "D":
                        calculaDivisao();
                        break;
                    case "E":
                        calculaExponenciacao();
                        break;
                    case "R":
                        calculaRadiciacao();
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

            numeroUm = digitaNumeroOrdenado("primeiro");
            numeroDois = digitaNumeroOrdenado("segundo");

            resultado = numeroUm + numeroDois;

            Console.WriteLine($"A soma de {numeroUm} + {numeroDois} é igual a {resultado:N2}");
        }

        static void calculaSubtracao()
        {
            double numeroUm, numeroDois, resultado;
            Console.WriteLine("---------------------------");
            Console.WriteLine("|       Subtração         |");
            Console.WriteLine("---------------------------");

            numeroUm = digitaNumeroOrdenado("primeiro");
            numeroDois = digitaNumeroOrdenado("segundo");

            resultado = numeroUm - numeroDois;

            Console.WriteLine($"A subtração de {numeroUm} - {numeroDois} é igual a {resultado}");
        }

        static void calculaProduto()
        {
            double numeroUm, numeroDois, resultado;
            Console.WriteLine("---------------------------");
            Console.WriteLine("|      Multiplicação      |");
            Console.WriteLine("---------------------------");

            numeroUm = digitaNumeroOrdenado("primeiro");
            numeroDois = digitaNumeroOrdenado("segundo");

            resultado = numeroUm * numeroDois;

            Console.WriteLine($"O produto de {numeroUm} x {numeroDois} é igual a {resultado:N2}");
        }

        static void calculaDivisao()
        {
            double numeroUm, numeroDois, resultado;
            Console.WriteLine("---------------------------");
            Console.WriteLine("|         Divisão         |");
            Console.WriteLine("---------------------------");

            numeroUm = digitaNumeroOrdenado("primeiro");
            numeroDois = digitaNumeroOrdenado("segundo");

            if (numeroDois == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Não é possível a divisão por zero!");
                Console.ResetColor();
            }
            else
            {
                resultado = numeroUm / numeroDois;
                Console.WriteLine($"A divisão de {numeroUm} / {numeroDois} é igual a {resultado:N2}");
            }
        }

        static void calculaExponenciacao()
        {
            double @base, potencia, resultado;
            Console.WriteLine("---------------------------");
            Console.WriteLine("|     Exponenciação       |");
            Console.WriteLine("---------------------------");

            @base = digitaNumero("Digite a base: ");
            potencia = digitaNumero("Digite a potência: ");

            resultado = Math.Pow(@base, potencia);

            Console.WriteLine($"A potência de {@base} elevado a {potencia} é igual a {resultado:N2}");
        }

        static void calculaRadiciacao()
        {
            double numero, resultado;
            Console.WriteLine("---------------------------");
            Console.WriteLine("|        Radiciação       |");
            Console.WriteLine("---------------------------");

            numero = digitaNumero("Digite um número: ");

            if (numero < 0)
            {
                Console.WriteLine("Não existem raízes de números negativos!");
            }
            else
            {
                resultado = Math.Sqrt(numero);
                Console.WriteLine($"A raiz de {numero} é igual a {resultado:N2}");
            }
        }

        static double digitaNumero(string mensagem)
        {
            double numero = 0;
            Console.Write(mensagem);
            Double.TryParse(Console.ReadLine(), out numero);
            return numero;
        }

        static double digitaNumeroOrdenado(string ordem)
        {
            return digitaNumero($"Digite o {ordem} número");
        }



    }
}
