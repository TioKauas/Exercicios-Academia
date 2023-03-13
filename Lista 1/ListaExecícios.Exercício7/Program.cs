using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ListaExecícios.Exercício7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calcular o salário total de um vendedor";

            inicio:
            try
            {
                Console.Write("Informe o salário base: ");
                decimal SBase = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Informe o total das vendas: ");
                decimal VTotal = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Informe o percentual da comissão: ");
                decimal CPercentual = Convert.ToDecimal(Console.ReadLine());

                decimal STotal = (VTotal * (CPercentual / 100)) + SBase;

                Console.WriteLine();

                Console.Write("O salário total é de R$" + STotal);

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
                Console.WriteLine("Erro ao realizar o calculo, pressione qualquer botão para continuar...");
                Console.ReadKey();

                Console.Clear();
                goto inicio;
            }
        }
    }
}
