using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercícios.Exercício2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Conversor Fahrenheit para Celsius";

            inicio:
            try
            {
                Console.Write("Informe a temperatura em Fahrenheit: ");
                decimal F = Convert.ToDecimal(Console.ReadLine());

                decimal C = (F - 32) * 5 / 9;
                C = Math.Round(C, 2);

                Console.WriteLine();

                Console.WriteLine(F + "°F em celsius é " + C + "°C");

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
                    Console.WriteLine("Opção inválida,tente novamento...");
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
