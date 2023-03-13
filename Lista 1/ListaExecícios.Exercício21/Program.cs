using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExecícios.Exercício21
{
    internal class Program
    {
        static void Main(string[] args)
        {
        inicio:
			try
			{
                Console.Write("Informe o primeiro valor: ");
                int A = Convert.ToInt32(Console.ReadLine());

                Console.Write("Informe o segundo valor: ");
                int B = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                int Resultado;

                if (A == B)
                {
                    Resultado = A + B;
                    Console.Write("Os números foram somado: " + Resultado);
                }
                else if (A != B) 
                {
                    Resultado = A * B;
                    Console.Write("Os números foram multiplicados: " + Resultado);
                }

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
