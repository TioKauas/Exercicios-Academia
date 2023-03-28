using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArraysEFunções.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo Opc = new ConsoleKeyInfo();
            int[] Numero = new int[10];
            int Holder = 0;
            string Input;

            Inicio:
            do
            {
                try
                {
                    Console.WriteLine("Informe 10 valores dentres as opçãoes abaixo:");
                    Console.WriteLine("-5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6");
                    Console.Write(">");
                    Input = Console.ReadLine();

                    Console.WriteLine();

                    Console.WriteLine("Selecione a ação desejada: ");
                    Console.WriteLine("1 - Cresencete");
                    Console.WriteLine("2 - Decresencete");
                    Console.Write(">");
                    Opc = Console.ReadKey();

                    Console.WriteLine();

                    string[] stringNum = Input.Split(',');

                    for (int i = 0; i < stringNum.Length; i++)
                    {
                        if (i < Numero.Length)
                        {
                            Numero[i] = Convert.ToInt32(stringNum[i]);
                        }
                    }

                    switch (Opc.Key)
                    {
                        case ConsoleKey.D1:
                        case ConsoleKey.NumPad1:
                            Funcoes.Cresencete(Numero, Holder, stringNum);
                            break;

                        case ConsoleKey.D2:
                        case ConsoleKey.NumPad2:
                            Funcoes.Decresencete(Numero, Holder, stringNum);
                            break;

                        default:
                            Console.WriteLine();
                            Console.WriteLine("Opção Inválida...");
                            Console.ReadKey();

                            Console.Clear();
                            goto Inicio;
                    }

                    Funcoes.Sair(Opc);
                }
                catch (Exception Erro)
                {

                    Console.Write(Erro);
                    Console.ReadKey();
                    break;
                }
            } while (Opc.Key != ConsoleKey.N);
        }

    }
}
