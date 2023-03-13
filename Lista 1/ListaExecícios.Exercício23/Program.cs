using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExecícios.Exercício23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i <= 200; i++)
            {
                int impar = i % 2;

                if (impar != 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
