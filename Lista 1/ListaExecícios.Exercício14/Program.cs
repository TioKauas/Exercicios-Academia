using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ListaExecícios.Exercício14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            inicio:
			try
			{
                Console.Title = "Dias de vida";

                Console.Write("Informe seu nome: ");
                string Nome = Console.ReadLine();

                if (!int.TryParse(Nome, out int a))
                {
                    Console.Write("Informe seu nome: ");
                    int Idade = Convert.ToInt32(Console.ReadLine());

                    int diasVida = Idade * 365;

                    Console.WriteLine(Nome + " viveu " + diasVida + " dias");

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
                else
                {
                    Console.WriteLine();

                    Console.Write("Valores inválidos,tente novamente...");
                    Console.ReadKey();

                    Console.Clear();
                    goto inicio;
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
