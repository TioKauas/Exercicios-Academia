using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Diamante.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo Opc = new ConsoleKeyInfo();

            do
            {
                try
                {
                    Console.Title = "Diamante";

                    Console.WriteLine("Escolha como desenhar o diamante: ");
                    Console.WriteLine("1 - Alfabeto");
                    Console.WriteLine("2 - X");
                    int Escolha = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();

                    switch (Escolha)
                    {
                        case 1:
                            DiamanteAlfafbeto();
                            break;

                        case 2:
                            DiamanteX();
                            break;

                        default:
                            Console.WriteLine("Escolha uma opção válida");
                            Console.WriteLine();

                            break;
                    }

                    Sair(Opc);
                }
                catch (Exception)
                {
                    Console.Write("Erro ao desenhar, pressione qualquer botão para continuar...");
                    Console.ReadKey();

                    Console.Clear();
                    break;
                }
            } while (Opc.Key != ConsoleKey.N);
        }

        static void DiamanteX()
        {
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
        }

        static void DiamanteAlfafbeto()
        {
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
        }

        static void Sair(ConsoleKeyInfo Opc)
        {
            Console.WriteLine();

            do
            {
                Console.WriteLine("Gostaria de fazer outro desenho? (S/N)");
                Opc = Console.ReadKey();

                switch (Opc.Key)
                {

                    case ConsoleKey.S:
                        Console.Clear();
                        break;

                    case ConsoleKey.N:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Opção inválida,tente novamente...");
                        Console.WriteLine();
                        break;

                }

            } while (Opc.Key != ConsoleKey.S && Opc.Key != ConsoleKey.N);
        }
    }
}
