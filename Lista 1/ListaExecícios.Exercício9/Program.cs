using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExecícios.Exercício9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calcular a média harmônica das notas de um Aluno";

            inicio:
            try
            {
                Console.Write("Informe o número de notas: ");
                int n = Convert.ToInt32(Console.ReadLine());

                double soma = 0;

                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("Informe a nota " + i + ": ");
                    double nota = Convert.ToDouble(Console.ReadLine());

                    soma += 1 / nota;
                }

                double mediaHarmonica = n / soma;
                mediaHarmonica = Math.Round(mediaHarmonica, 2);

                Console.WriteLine("A média harmônica das notas é: " + mediaHarmonica);

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
