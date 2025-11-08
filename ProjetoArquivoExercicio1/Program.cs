using System.IO;

namespace ProjetoArquivoExercicio1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            CListaVet<CustomerVO> clientes = new CListaVet<CustomerVO>();
            StreamReader rd = new StreamReader(@"customers-100.csv");
            rd.ReadLine(); // ignorar a primeira linha

            while (!rd.EndOfStream)
            {
                // não ouse comer minha identação com angu!
                string[] dados = rd.ReadLine().Split(',');
                clientes.Adiciona(new CustomerVO(dados));
            }
            rd.Close();
            StreamWriter sw = new StreamWriter("saida.txt", false);
            for (int i = 0; i < clientes.Quantidade; i++)
                sw.WriteLine(clientes[i]);
            sw.Close();

            /*string text = "Um exemplo de string para tokenização.";
            string[] tokens = text.Split(' ');
            foreach (string token in tokens)
            {
                Console.WriteLine(token);
            }

            Console.WriteLine("\nDigite qualquer tecla para continuar...");
            Console.ReadKey();*/

        }
    }
}
