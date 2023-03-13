using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExecícios.Exercício12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            inicio:
			try
			{
                Console.Title = "Calcular a Área do terreno";

                Console.Write("Informe a comprimento: ");
                double Comprimento = Convert.ToDouble(Console.ReadLine());

                Console.Write("Informe a largura: ");
                double Largura = Convert.ToDouble(Console.ReadLine());

                double Area = Comprimento * Largura;
                Area = Math.Round(Area,2);

                Console.WriteLine();

                Console.WriteLine("A área do terreno é de " + Area + "m²");

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
                Console.WriteLine("Erro ao realizar o calculo, pressione qualquer botão para continuar...");
                Console.ReadKey();

                Console.Clear();
                goto inicio;
			}
        }
    }
}
