using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExecícios.Exercício26
{
    internal class Program
    {
        static void Main(string[] args)
        {
                       inicio:
			try
			{
                Console.Title = "Fatorial";

                Console.Write("Informe um número: ");
                int A = Convert.ToInt32(Console.ReadLine());

                int f = 1;

                for (int i = 1; i < A; i++)
                {
                    f *= i;

                    Console.WriteLine(i + "! = " + f);
                }

                Console.WriteLine();

                Console.WriteLine("O resultado de " + A + "! é " + f + ".");

                sair:
                Console.WriteLine();

                Console.WriteLine("Gostaria de realizar outro cálculo? (S/N)");
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
                Console.Write("Erro ao realizar o calculo, pressione qualquer botão para continuar...");
                Console.ReadKey();

                Console.Clear();
                goto inicio;
			}
        }
    }
}
