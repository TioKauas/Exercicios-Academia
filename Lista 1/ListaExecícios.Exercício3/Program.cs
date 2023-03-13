using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExecícios.Exercício3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            inicio:
			try
			{
                Console.Title = "Calcular volume do cilindro";

                Console.WriteLine("Preencha os campos abaixo: ");

                Console.WriteLine();

                Console.Write("Informe o raio: ");
                double Raio = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Informe a altura: ");
                decimal Altura = Convert.ToDecimal(Console.ReadLine());

                decimal V = (decimal)Math.PI * (decimal)Math.Pow(Raio,2) * Altura;
                V = Math.Round(V,2);

                Console.WriteLine();

                Console.WriteLine("O volume do cilindro é de: " + V);

                Console.WriteLine();

            sair:
                Console.WriteLine();

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
                    Console.WriteLine("Opção inválida,tente novamento...");
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
