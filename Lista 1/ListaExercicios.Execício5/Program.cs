using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.Execício5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calcular o volume de uma esfera";

        inicio:
            try
            {
                Console.Write("Informe o raio da esfera: ");
                double Raio = Convert.ToDouble(Console.ReadLine());

                decimal Volume = (4m / 3m) * (decimal)Math.PI * (decimal)Math.Pow(Raio, 3);
                Volume = Math.Round(Volume, 2);

                Console.WriteLine("O Volume da esfera é de " + Volume + "cm");

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

            }
        }
    }
}