namespace ProjetoArquivoExercicio1;
public class CustomerDAO : DAOAb
{
    private static CustomerDAO instance = null;
    private CustomerDAO(string nomeArquivo) : base(nomeArquivo) { }
    public static CustomerDAO GetInstance(string nomeArquivo)
    {
        if (instance == null)
            instance = new CustomerDAO(nomeArquivo);
        return instance;
    }

    public CListaVet<CustomerVO> ObterTodos()
    {
        var listaVO = new CListaVet<CustomerVO>();
        var linhas = ObterTodosRegistros();
        // supondo que a primeira linha é o cabeçalho
        for (int i = 1; i < linhas.Quantidade; i++)
        {
            string linha = linhas[i];
            string[] tokens = linha.Split(',');
            CustomerVO customer = new CustomerVO(tokens);
            listaVO.Adiciona(customer);
        }
        return listaVO;
    }
}