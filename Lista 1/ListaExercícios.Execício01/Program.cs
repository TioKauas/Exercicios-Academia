using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercícios.Execício01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculadora de volume de uma caixa retangular";
        inicio:
            try
            {
                #region Coleto de dados
                Console.WriteLine("Preencha os campos abaixo como as informções da caixa:");

                Console.WriteLine();

                Console.Write("Comprimento: ");
                int Comprimento = Convert.ToInt32(Console.ReadLine());

                Console.Write("Largura: ");
                int Largura = Convert.ToInt32(Console.ReadLine());

                Console.Write("Altura: ");
                int Altura = Convert.ToInt32(Console.ReadLine());
                #endregion

                #region Processamento de dados e Devolução
                int Volume = Comprimento * Largura * Altura;

                Console.WriteLine("O volume da caixa é de: " + Volume + "cm³");
                #endregion

                //DAQUI PRA BAIXO NÃO PRECISA
                #region "Menu"
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
            #endregion
        }
    }
}
