namespace ListaExecícios.Exercício6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Conversor Celsius para Fahrenheit";

        inicio:
            try
            {
                Console.Write("Informe a temperatura em Celsius: ");
                decimal C = Convert.ToDecimal(Console.ReadLine());

                decimal F = (C * 9/5) + 32;
                F = Math.Round(F, 2);

                Console.WriteLine();

                Console.WriteLine(C + "°C em Fahrenheit é " + F + "°F");

            sair:
                Console.WriteLine();

                Console.WriteLine("Gostaria de realizar outra conversão? (S/N)");
                ConsoleKeyInfo Opc = Console.ReadKey();

                if (Opc.Key == ConsoleKey.S)
                {
                    Console.Clear();
                    goto inicio;
                }
                else if (Opc.Key == ConsoleKey.N)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Opção inválida,tente novamente...");
                    goto sair;
                }

            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.WriteLine("Valor inválido, pressione qualquer botão para continuar...");
                Console.ReadKey();

                Console.Clear();
                goto inicio;
            }
        }
    }
}




