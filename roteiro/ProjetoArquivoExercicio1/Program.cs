using System.IO;

namespace ProjetoArquivoExercicio1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            StreamReader rd = new StreamReader(@"c:\Users\User\Documents\Faculdade\poo\dotnetPOO\roteiro\ProjetoArquivoExercicio1\customers-100.csv");

            while (!rd.EndOfStream) { 
                string linha = rd.ReadLine();
                Console.WriteLine(linha); 
                contador++;

                if (contador%20==0)
                {
                    Console.WriteLine("\nDigite qualquer tecla para continuar...");
                    Console.ReadKey();
                }
            }
            rd.Close();

            string text = "Um exemplo de string para tokenização.";
            string[] tokens = text.Split(' ');
            foreach (string token in tokens)
            {
                Console.WriteLine(token);
            }

            Console.WriteLine("\nDigite qualquer tecla para continuar...");
            Console.ReadKey();

        }
    }
}
