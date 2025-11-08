using System.IO;
namespace ProjetoManipularArquivo
{
    public class Program
    {
        static void Main(string[] args)
        {
            StreamWriter wr = new StreamWriter(@"doc.txt", true);
            wr.WriteLine("Primeira linha");
            wr.WriteLine("Segunda linha");
            wr.Close();
            StreamReader rd = new StreamReader(@"doc.txt");
            while (!rd.EndOfStream)
            {
                string linha = rd.ReadLine();
                Console.WriteLine(linha);
            }
            rd.Close(); Console.Write("\n\n\nPressione qualquer tecla para sair..."); Console.ReadKey(true);
        }
    }
}