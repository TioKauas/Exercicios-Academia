using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExecícios.Exercício10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calcular a média harmônica das notas de um Aluno";

            inicio:
            try
            {
                Console.Write("Informe e nota da primeira prova: ");
                double n1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Informe e nota da segunda prova: ");
                double n2 = Convert.ToDouble(Console.ReadLine());

                double mediaHarmonica = 2 / ((1 / n1) + (1 / n2));
                mediaHarmonica = Math.Round(mediaHarmonica, 2);

                Console.WriteLine("A média é de " + mediaHarmonica);

            sair:

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
