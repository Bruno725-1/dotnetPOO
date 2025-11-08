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
            DAOAb daoab = DAOAb.GetInstance("customers-100.csv");
            CListaVet<string> linhas = daoab.ObterTodosRegistros();
            Console.WriteLine("Imprimindo as linhas obtidas apartir de daoab:");
            for (int i = 0; i < linhas.Quantidade; i++)
                Console.WriteLine(linhas[i]);
            CustomerDAO customerDAO = CustomerDAO.GetInstance("customers-100.csv");
            CListaVet<CustomerVO> registros = customerDAO.ObterTodos();
            Console.WriteLine("Imprimindo a nova lista de registros:");
            for (int i = 0; i < registros.Quantidade; i++)
                Console.WriteLine(registros[i]);
        }
    }
}
