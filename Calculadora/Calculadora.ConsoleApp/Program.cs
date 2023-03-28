using System.Runtime.CompilerServices;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo Opc = new ConsoleKeyInfo();

            do {
                Console.Clear();
                try
                {
                    Menu(Opc);

                    Console.WriteLine();

                    #region Sair
                    Console.WriteLine("Gostaria de realizar outra operação? (S/N)");
                    Opc = Console.ReadKey();

                    if (Opc.Key == ConsoleKey.S)
                    {
                        Console.Clear();
                    }
                    else if (Opc.Key == ConsoleKey.N)
                    {
                        Environment.Exit(0);
                    }
                    #endregion
                }
                catch (FormatException)
                {
                    Console.WriteLine();

                    Console.Write("Valores de entrada inválidos, pressione qualquer botão e tente novamente...");
                    Console.ReadKey();

                    Console.Clear();    
                }
            }while(Opc.Key != ConsoleKey.N);
        }

        static int Menu(ConsoleKeyInfo Opc)
        {
            Console.WriteLine("Seleciona uma opção abaixo:");
            Console.WriteLine("1 - Calculadora");
            Console.WriteLine("2 - Tabuada");
            Console.WriteLine("3 - Calculos anteriores");

            Opc = Console.ReadKey(true);

            switch (Opc.Key) 
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Console.Clear();

                    Calculadora(Opc);
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Console.Clear();

                    Tabuada();
                    break;
            }
            return 0;
        }

        static int Calculadora(ConsoleKeyInfo Opc, out int[] num1, out int[] num2)
        {
            do
            {
                int[] num2 = new int[999];
                int[] num1 = new int[999];

                Console.WriteLine("*****************");
                Console.WriteLine("*  Calculadora  *");
                Console.WriteLine("*****************");

                Console.WriteLine();

                Console.Write("Informe o primeiro número: ");
                num1[0] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Informe o segunda número: ");
                num2[0] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");

                Console.Write("Escolha uma acima operação: ");
                Opc = Console.ReadKey(true);

                Console.WriteLine();

                decimal result = 0;

                switch (Opc.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        result = num1 + num2;
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        result = num1 - num2;
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        result = num1 * num2;
                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        if (num2 == 0)
                        {
                            while (num2 == 0)
                            {
                                Console.WriteLine("Divisor inválido, tente novamente... ");

                                Console.Write("Informe o segunda número: ");
                                num2 = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine();
                            }
                            result = num1 / num2;
                        }
                        else
                        {
                            result = num1 / num2;
                        }
                        break;

                    default:
                        Console.Write("Opção inválida...");
                        return 0;
                }

                result = Math.Round(result, 2);
                Console.WriteLine("Resultado: " + result);

                return (int)result;
            } while (true); 
        }

        static int Tabuada()
        {
            int num1 = 0, result = 0;

            Console.WriteLine("*****************");
            Console.WriteLine("*  Tabuada  *");
            Console.WriteLine("*****************");

            Console.WriteLine();

            Console.Write("Digite um número: ");
            num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine();

            for (int i = 1; i < 10; i++)
            {
                result = i * num1;
                Console.WriteLine(num1 + " * " + i + " = " + result);
            }

            return result;
        }
    }
}
