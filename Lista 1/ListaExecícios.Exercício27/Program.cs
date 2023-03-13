using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExecícios.Exercício27
{
    internal class Program
    {
        static void Main(string[] args)
        {
                       inicio:
			try
			{
                Console.Title = "Fibonacci";

                Console.Write("Digite um número: ");
                int numero = int.Parse(Console.ReadLine());

                int a = 0;
                int b = 1;
                int c;

                Console.WriteLine();

                Console.Write("Sequência de Fibonacci até o número " + numero + ": " + a + " " + b + " ");

                while (a + b < numero)
                {
                    c = a + b;
                    Console.Write(c + " ");
                    a = b;
                    b = c;
                }

                Console.WriteLine();

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
