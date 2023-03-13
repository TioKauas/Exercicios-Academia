using System;

namespace ListaExecícios.Exercício11
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            inicio:
			try
			{
                Console.Write("Digite um número inteiro: ");
                int Numero = int.Parse(Console.ReadLine());

                Console.WriteLine();

                if (Numero <= 1)
                {
                    Console.WriteLine("O número deve ser maior que 1.");
                }
                else if (Numero == 2)
                {
                    Console.WriteLine("O número 2 é primo.");
                }
                else if (Numero % 2 == 0)
                {
                    Console.WriteLine("O número " + Numero + " não é primo, pois é par.");
                }
                else
                {
                    int Limite = (int)Math.Floor(Math.Sqrt(Numero));
                    bool Primo = true;

                    for (int i = 3; i <= Limite; i += 2)
                    {
                        if (Numero % i == 0)
                        {
                            Primo = false;
                            break;
                        }
                    }
                    if (Primo)
                    {
                        Console.WriteLine("O número " + Numero + " é primo.");
                    }
                    else
                    {
                        Console.WriteLine("O número " + Numero + " não é primo.");
                    }

                sair:
                    Console.WriteLine("Gostaria de realizar outra verificação? (S/N)");
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
            }
			catch (Exception)
			{
                Console.WriteLine("Erro ao realizar a verificação, pressione qualquer botão para continuar...");
                Console.ReadKey();

                Console.Clear();
                goto inicio;
			}
        }
    }
}
