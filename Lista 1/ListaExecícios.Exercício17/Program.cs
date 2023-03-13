using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExecícios.Exercício17
{
    internal class Program
    {
        static void Main(string[] args)
        {
        inicio:
			try
			{
                Console.Write("O valor de A: ");
                int A = Convert.ToInt16(Console.ReadLine());

                Console.Write("O valor de B: ");
                int B = Convert.ToInt16(Console.ReadLine());

                Console.Write("O valor de C: ");
                int C = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine();

                int AB = A + B;

                if (AB < C)
                {
                    Console.WriteLine("A soma de A+B é menor que o valor de C");
                }
                else
                {
                    Console.WriteLine("A soma de A+B é maior ou igual ao valor de C");
                }

            sair:
                Console.WriteLine();

                Console.WriteLine("Gostaria de realizar outra checagem? (S/N)");
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
                Console.Write("Erro ao realizar a checagem, pressione qualquer botão para continuar...");
                Console.ReadKey();

                Console.Clear();
                goto inicio;
			}
        }
    }
}
