using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Robô_Tupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Robô Tupiniquim";

            inicio:
            try
            {
                Console.WriteLine("Informe a área de atuação do robo: (Ex: 2 0)");
                string[] input = Console.ReadLine().Split();
                int maxX = int.Parse(input[0]);
                int maxY = int.Parse(input[1]);


                while (true)
                {
                    Console.WriteLine();

                    Console.WriteLine("Informe os eixos X, Y e Direção: (Ex: 0 0 L) ");
                    input = Console.ReadLine().Split(); //0 0 L

                    //Conversão dos dados acima
                    int x = int.Parse(input[0]);
                    int y = int.Parse(input[1]);
                    char Direcao = char.Parse(input[2]);

                    Console.WriteLine();

                    Console.WriteLine("Insira as instruções: ");
                    string Instrucoes = Console.ReadLine();

                    foreach (char c in Instrucoes)
                    {
                        if (c == 'M')
                        {
                            switch (Direcao)
                            {
                                case 'N':
                                    y++;
                                    break;

                                case 'S':
                                    y--;
                                    break;

                                case 'L':
                                    x++;
                                    break;

                                case 'O':
                                    x--;
                                    break;

                            }
                        }
                        else
                        {
                            if (c == 'E') 
                            {
                                switch (Direcao)
                                {
                                    case 'N':
                                        Direcao = 'O';
                                        break;
                                    case 'S':
                                        Direcao = 'L';
                                        break;
                                    case 'L':
                                        Direcao = 'N';
                                        break;
                                    case 'O':
                                        Direcao = 'S';
                                        break;
                                }
                            }
                            else if (c == 'D')
                            {
                                switch (Direcao)
                                {
                                    case 'N':
                                        Direcao = 'L';
                                        break;
                                    case 'S':
                                        Direcao = 'O';
                                        break;
                                    case 'L':
                                        Direcao = 'S';
                                        break;
                                    case 'O':
                                        Direcao = 'N';
                                        break;
                                }
                            }
                        }
                    }

                    Console.WriteLine();

                    Console.WriteLine("Posiçã atual: ");
                    Console.WriteLine("X: " + x + " Y: " + y + " " + Direcao);

                    Console.WriteLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Erro, pressione qualquer botão para reiniciar...");
                Console.ReadKey();

                Console.Clear();
                goto inicio;
            }
        }
    }
}