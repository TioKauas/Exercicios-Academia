using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamante.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
                       inicio:
			try
			{
                Console.Title = "Diamante";

                Console.WriteLine("Escolha como desenhar o diamante: ");
                Console.WriteLine("1 - Alfabeto");
                Console.WriteLine("2 - X");
                int Escolha = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                if (Escolha == 1)
                {
                    #region Diamante Alfabeto
                    Console.Clear();

                    Console.WriteLine("Informe uma letra: ");
                    char Letra = char.Parse(Console.ReadLine());

                    int Tamanho = (Letra - 'A') * 2 + 1;

                    for (char c = 'A'; c <= Letra; c++)
                    {
                        int preenchimento = (Tamanho - (c - 'A') * 2 - 1) / 2;
                        Console.Write(new string(' ', preenchimento));
                        for (char d = 'A'; d <= c; d++)
                        {
                            Console.Write(d);
                            if (d != c)
                            {
                                Console.Write(' ');
                            }
                        }
                        Console.Write(new string(' ', preenchimento));
                        Console.WriteLine();
                    }

                    for (char c = (char)(Letra - 1); c >= 'A'; c--)
                    {
                        int preenchimento = (Tamanho - (c - 'A') * 2 - 1) / 2;
                        Console.Write(new string(' ', preenchimento));
                        for (char d = 'A'; d <= c; d++)
                        {
                            Console.Write(d);
                            if (d != c)
                            {
                                Console.Write(' ');
                            }
                        }
                        Console.Write(new string(' ', preenchimento));
                        Console.WriteLine();
                    }  
        #endregion
                }
                else if (Escolha == 2)
                {
                    #region Diamante X
                    Console.Clear();

                    Console.Write("Digite um número ímpar: ");
                    int tamanho = Convert.ToInt32(Console.ReadLine());

                    int espacos = (tamanho - 1) / 2;

                    int letras = 1;

                    for (int i = 0; i < tamanho / 2; i++)
                    {
                        for (int j = 0; j < espacos; j++)
                        {
                            Console.Write(" ");
                        }

                        for (int j = 0; j < letras; j++)
                        {
                            Console.Write("x");
                        }

                        Console.WriteLine();

                        espacos--;
                        letras += 2;
                    }

                    for (int i = tamanho / 2; i >= 0; i--)
                    {
                        for (int j = 0; j < espacos; j++)
                        {
                            Console.Write(" ");
                        }

                        for (int j = 0; j < letras; j++)
                        {
                            Console.Write("x");
                        }

                        Console.WriteLine();

                        espacos++;
                        letras -= 2;
                    }
                    #endregion
                }
                else
                {
                    Console.WriteLine("Escolha uma opção válida");
                    Console.WriteLine();

                    goto inicio;
                }


            sair:
                Console.WriteLine();

                Console.WriteLine("Gostaria de fazer outro desenho? (S/N)");
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
                Console.Write("Erro ao desenhar, pressione qualquer botão para continuar...");
                Console.ReadKey();

                Console.Clear();
                goto inicio;
			}
        }
    }
}
