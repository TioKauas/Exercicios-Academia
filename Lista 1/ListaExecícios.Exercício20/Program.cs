using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExecícios.Exercício20
{
    internal class Program
    {
        static void Main(string[] args)
        {
                       inicio:
			try
			{
                Console.Write("Informe o número: ");
                int Numero = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                int Resto = Numero % 2;

                if (Resto == 0)
                {
                    Console.WriteLine("Este número é Par");
                }
                else
                {
                    Console.WriteLine("Este número é Impar");
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
