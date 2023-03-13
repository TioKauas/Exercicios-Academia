using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExecícios.Exercício18
{
    internal class Program
    {
        static void Main(string[] args)
        {
        inicio:
			try
			{
                Console.Write("Primeiro valor: ");
                int A = Convert.ToInt16(Console.ReadLine());

                Console.Write("Segundo valor: ");
                int B = Convert.ToInt16(Console.ReadLine());

                Console.Write("Terceiro valor: ");
                int C = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine();

                if (A > B && A > C)
                {
                    if (B > C)
                    {
                        Console.WriteLine(A + "," + B + "," + C);
                    }
                    else 
                    {
                        Console.WriteLine(A + "," + C + "," + B);
                    }
                }
                else if(B > A && B > C)
                {
                    if(A > C) 
                    {
                        Console.WriteLine(B + "," + A + "," + C);
                    }
                    else
                    {
                        Console.WriteLine(B + "," + C + "," + A);
                    }
                }
                else
                {
                    if (A > B)
                    {
                        Console.WriteLine(C + "," + A + "," + B);
                    }
                    else
                    {
                        Console.WriteLine(C + "," + B + "," + A);
                    }
                }

            sair:
                Console.WriteLine();

                Console.WriteLine("Gostaria de digtar outros valores? (S/N)");
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
                Console.Write("Erro ao reorganizar, pressione qualquer botão para continuar...");
                Console.ReadKey();

                Console.Clear();
                goto inicio;
			}
        }
    }
}
