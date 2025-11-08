using System.IO;
namespace ProjetoSeparaTokens;
public class Program
{
    static void Main(string[] args)
    {
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