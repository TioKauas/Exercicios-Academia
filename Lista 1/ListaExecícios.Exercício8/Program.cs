using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExecícios.Exercício8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calcular o volume de uma lata de óleo";

            inicio:
            try
            {
                Console.Write("Informe a altrura da lata: ");
                double Altura = Convert.ToDouble(Console.ReadLine());

                Console.Write("Informe o raio da lata: ");
                double Raio = Convert.ToDouble(Console.ReadLine());

                double Volume = Altura * Math.PI * Math.Pow(Raio,2);
                Volume = Math.Round(Volume, 2);    

                Console.WriteLine();

                Console.WriteLine("O volume da lata é de " + Volume + "cm³");

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
                    Console.WriteLine("Opção inválida,tente novamente...");
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
