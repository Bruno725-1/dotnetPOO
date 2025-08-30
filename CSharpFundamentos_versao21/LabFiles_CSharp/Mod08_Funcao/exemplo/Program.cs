using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, opcao = 0;
            string valorB = "";



            do
            {
                Console.WriteLine("\n-=-   Menu de opções -=-  ");

                Console.WriteLine("\n-=-   Perímetro do círculo..............[1]");
                Console.WriteLine("\n-=-   ÁPerímetro do retângulo...........[2]");
                Console.WriteLine("\n-=-   Perímetro do triângulo............[3]");
                Console.WriteLine("\n-=-   Sair..............................[4]");

                Console.WriteLine("\n\n\n-=-   Digite sua opção: ");

                valorB = Console.ReadLine();
                opcao = int.Parse(valorB);


                switch (opcao)
                {

                    case 1:
                        {
                            Console.WriteLine("\nCalcular perímetro do círculo! ");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("\nCalcular perímetro do círetângulo! ");
                            // Solicitar entrada de dados do usuário
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("\nCalcular perímetro do triângulo! ");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("\nSair! ");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\nNúmero digitado: OUTROS VALORES! ");
                            break;
                        }
                }
            } while (opcao != 4);

            Console.WriteLine("\nFim do programa ");


            Console.ReadKey();

        }
    }
}
