using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ArraysEFunções.ConsoleApp
{
    internal class Funcoes
    {
        static void Apresentar(int[] Numero)
        {
            foreach (int Num1 in Numero)
            {
                if (Num1 < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                Console.WriteLine(Num1);

                Console.ResetColor();
            }
        }

        public static void Cresencete(int[] Numero, int Holder, string[] stringNum)
        {
            int maiorNum = 0, menorNum = 0, indice = 0;
            int[] maioresNum = new int[3];
            int[] Negativos = Array.FindAll(Numero, x => x < 0);
            decimal mediaNum = 0;

            for (int j = 1; j < stringNum.Length; j++)
            {
                Holder = Numero[j];

                for (int k = 0; k < j; k++)
                {
                    if (Numero[k] > Holder)
                    {
                        Numero[j] = Numero[k];
                        Numero[k] = Holder;
                        Holder = Numero[j];
                    }
                }
            }

            Apresentar(Numero);

            Remover(Numero, indice);

            (maiorNum, menorNum, maioresNum, Negativos, mediaNum) = encontrarValores(Numero);

            Resolucoes(maiorNum, menorNum, maioresNum, Negativos, mediaNum);
        }

        public static void Decresencete(int[] Numero, int Holder, string[] stringNum)
        {
            int maiorNum = 0, menorNum = 0, indice = 0;
            int[] maioresNum = new int[3];
            int[] Negativos = Array.FindAll(Numero, x => x < 0);
            decimal mediaNum = 0;

            for (int j = 1; j < stringNum.Length; j++)
            {
                Holder = Numero[j];

                for (int k = 0; k < j; k++)
                {
                    if (Numero[k] > Holder)
                    {
                        Numero[j] = Numero[k];
                        Numero[k] = Holder;
                        Holder = Numero[j];
                    }
                }
            }

            Apresentar(Numero);

            Remover(Numero, indice);

            (maiorNum, menorNum, maioresNum, Negativos, mediaNum) = encontrarValores(Numero);

            Resolucoes(maiorNum, menorNum, maioresNum, Negativos, mediaNum);
        }

        static(int, int, int[], int[], decimal) encontrarValores(int[] Numero)
        {
            int maiorNum = Numero[0], menorNum = Numero[0];
            int[] maioresNum = new int[3];
            decimal mediaNum = Numero[0];

            Console.Clear();

            #region Maior e menor numero
            for (int i = 0; i < Numero.Length; i++)
            {
                if (Numero[i] > maiorNum)
                {
                    maiorNum = Numero[i];
                }

                if (Numero[i] < menorNum)
                {
                    menorNum = Numero[i];
                }
            }
            #endregion

            #region Tirar média
            for (int i = 0; i < Numero.Length; i++)
            {
                mediaNum += Numero[i];
            }

            mediaNum = mediaNum / Numero.Length;

            Math.Round(mediaNum, 2);
            #endregion

            #region 3 maiores valores
            Array.Sort(Numero);
            Array.Reverse(Numero);

            for (int i = 0; i < 3; i++)
            {
                if (Numero[i] > maioresNum[i])
                {
                    maioresNum[i] = Numero[i];
                }
            }
            #endregion

            #region Valores negativos
            int[] Negativos = Array.FindAll(Numero, x => x < 0);

            int j = 0;
            for (int i = 0; i < Numero.Length; i++)
            {
                if (Numero[i] < 0)
                {
                    Negativos[j] = Numero[i];
                    j++;
                }
            }
            #endregion

            Console.WriteLine("Nova tabela com as modificações: ");

            foreach(int Num1 in Numero)
            {
                if (Num1 < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                Console.WriteLine(Num1);

                Console.ResetColor();
            }

            return (menorNum, maiorNum, maioresNum, Negativos, mediaNum);
        }

        public static void Remover(int[] Numero, int indice)
        {
            Console.Write("Insira o índice do item a ser removido:");
            indice = int.Parse(Console.ReadLine());

            Array.Copy(Numero, indice + 1, Numero, indice, Numero.Length - indice - 1);

            Array.Resize(ref Numero, Numero.Length - 1);
        }

        public static void Resolucoes(int maiorNum, int menorNum, int[] maioresNum, int[] Negativos, decimal mediaNum)
        {
            Console.WriteLine();

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"O maior valor é o {maiorNum}");
            Console.WriteLine($"O menor valor da é o {menorNum}");
            Console.WriteLine($"O valor médio é {mediaNum}");
            Console.WriteLine($"Os três maiores números são: {maioresNum[0]}, {maioresNum[1]}, {maioresNum[2]}");

            if (Negativos.Length > 0)
            {
                Console.WriteLine("Os valores negativos são: " + string.Join(", ", Negativos));
            }
            else
            {
                Console.WriteLine("Não há valores negativos na sequência.");
            }
        }

        public static void Sair(ConsoleKeyInfo Opc)
        {
            Console.WriteLine();

            do
            {
                Console.WriteLine("Gostaria de reiniciar o programa? (S/N)");
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
