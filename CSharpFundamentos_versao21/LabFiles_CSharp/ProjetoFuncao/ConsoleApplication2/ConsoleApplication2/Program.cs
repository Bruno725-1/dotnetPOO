using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int colunas = 0, linhas = 0;

            Console.WriteLine("Digite a quantidade de colunas do tabuleiro: ");
            colunas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de linhas do tabuleiro");
            linhas = int.Parse(Console.ReadLine());


            double[,] quadro;
            quadro = new double[3, 3];
            int i = 0, j = 0, z = 0, total = 1;

            for (i = 0; i < linhas; i++)
            {

                for (j = 0; j < colunas; j++)
                {
                    z = z + 2;

                    total = total + (z * 2);

                }



            }


            Console.WriteLine(total + "  graos terao que ser colocados no tabuleiro");
            Console.ReadKey();
        }
    }
}
