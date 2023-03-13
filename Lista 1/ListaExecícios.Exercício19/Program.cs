using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ListaExecícios.Exercício19
{
    internal class Program
    {
        static void Main(string[] args)
        {
        inicio:
			try
			{
                Console.Title = "IMC";

                Console.Write("Informe seu peso: ");
                double Peso = Convert.ToDouble(Console.ReadLine());

                Console.Write("Informe sua altura em metros: ");
                double Altura = Convert.ToDouble(Console.ReadLine());

                double IMC = Peso / Math.Pow(Altura, 2);
                IMC = Math.Round(IMC, 2);

                if (IMC < 18.5)
                {
                    Console.WriteLine("SEU IMC " + IMC + " | MAGREZA");
                }
                else if (IMC < 25)
                {
                    Console.WriteLine("SEU IMC " + IMC + " | NORMAL");
                }
                else if (IMC < 30)
                {
                    Console.WriteLine("SEU IMC " + IMC + " | ACIMA DO PESO");
                }
                else
                {
                    Console.WriteLine("SEU IMC " + IMC + " | OBESO");
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
