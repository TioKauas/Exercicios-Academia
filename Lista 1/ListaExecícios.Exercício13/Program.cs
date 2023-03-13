using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExecícios.Exercício13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            inicio:
            try
            {
                Console.Title = "Padaria Hotpão";

                Console.Write("Informe a quantidade de pães vendidos: ");
                int Paes = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Informe a quantidade de broas vendidos: ");
                int Broa = Convert.ToInt32(Console.ReadLine());

                double PaesT = Paes * 0.12;
                double BroaT = Broa * 1.50;
                double VendasT = PaesT + BroaT;

                double Poupanca = (VendasT * 10) / 100;

                Console.WriteLine();

                Console.WriteLine("Vendas total: R$" + VendasT);
                Console.WriteLine("Você deve guardar na poupança: R$" + Poupanca);

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
                Console.WriteLine("Erro ao realizar o calculo, pressione qualquer botão para continuar...");
                Console.ReadKey();

                Console.Clear();
                goto inicio;
            }
        }
    }
}
