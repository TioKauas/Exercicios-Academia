namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            decimal result;
            int Operacao;
            ConsoleKeyInfo Opc;

        inicio:
            try
            {
                Console.Write("Informe o primeiro número: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Informe o segunda número: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");

                Console.Write("Escolha uma acima operação: ");
                Operacao = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                #region Operações
                if (Operacao == 1)
                {
                    result = num1 + num2;
                    Console.WriteLine("Resultado: " + result);
                }
                else if (Operacao == 2)
                {
                    result = num1 - num2;
                    Console.WriteLine("Resultado: " + result);
                }
                else if (Operacao == 3)
                {
                    result = num1 * num2;
                    Console.WriteLine("Resultado: " + result);
                }
                else if (Operacao == 4)
                {
                    while (num2 == 0)
                    {
                        Console.WriteLine("Divisor inválido, tente novamente... ");

                        Console.Write("Informe o segunda número: ");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();
                    }
                    result = num1 / num2;

                    result = Math.Round(result, 2);
                    Console.WriteLine("Resultado: " + result);
                }
                else
                {
                    Console.Write("Opção inválida, pressione qualquer botão e tente novamente...");
                    Console.ReadKey();

                    Console.Clear();
                    goto inicio;
                }
                #endregion

                Console.WriteLine();

                #region Sair
                Console.WriteLine("Gostaria de realizar outra operação? (S/N)");
                Opc = Console.ReadKey();

                if (Opc.KeyChar == 'S' || Opc.KeyChar == 's')
                {
                    Console.Clear();
                    goto inicio;
                }
                else if (Opc.KeyChar == 'N' || Opc.KeyChar == 'n')
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
                goto inicio;
            }
        }
    }
}
