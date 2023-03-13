    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.Execício4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal Distancia;
            inicio:
			try
			{
                Console.Title = "Calcular o consumo de combustível por Km.";

                Console.Write("Informe a kilometragem inicial: ");
                decimal KmInicial = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Informe a kilometragem Final: ");
                decimal KmFinal = Convert.ToDecimal(Console.ReadLine());

                if (KmInicial < KmFinal)
                {
                    Distancia = KmFinal - KmInicial;
                }
                else
                {
                    Console.WriteLine();

                    Console.WriteLine("O valor inicial deve ser menor que o valor final.");
                    Console.Write("Pressione qualquer botão para recomeçar...");
                    Console.ReadKey();

                    Console.Clear();
                    goto inicio;
                }

                Console.Write("Informe o combustível gasto percorrida em Litros: ");
                decimal Combustivel = Convert.ToDecimal(Console.ReadLine());

                decimal Consumo = Distancia / Combustivel;
                Consumo = Math.Round(Consumo,2);

                Console.WriteLine();

                Console.WriteLine("Você percorreu " + Distancia + "Km");
                Console.WriteLine("Foram consumidos " + Consumo + "Km/l");

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
