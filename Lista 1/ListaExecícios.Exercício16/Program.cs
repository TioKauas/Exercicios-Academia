using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExecícios.Exercício16
{
    internal class Program
    {
        static void Main(string[] args)
        {
                inicio:
			try
			{
                Console.Title = "Salário - aumento e decremento";

                Console.Write("Informe o salário base: ");
                double SalarioB = Convert.ToDouble(Console.ReadLine());

                double SalarioInc = SalarioB + (SalarioB * 0.15);
                double SalarioDec = SalarioInc - (SalarioInc * 0.08);
                SalarioDec = Math.Round(SalarioDec, 2);

                Console.WriteLine();

                Console.WriteLine("Salário Inicial: " + SalarioB);
                Console.WriteLine("Salário Final:" + SalarioDec);

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
