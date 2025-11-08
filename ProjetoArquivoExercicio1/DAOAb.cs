using System.IO;
namespace ProjetoArquivoExercicio1;
public class DAOAb
{
    private static DAOAb instance = null;
    protected string nomeArquivo;

    // construtora
    protected DAOAb(string nomeArquivo)
    {
        this.nomeArquivo = nomeArquivo;
    }
    public static DAOAb GetInstance(string nomeArquivo)
    {
        if (instance == null)
            instance = new DAOAb(nomeArquivo);
        return instance;
    }

    public CListaVet<string> ObterTodosRegistros()
    {
        var linhas = new CListaVet<string>();
        StreamReader sr = new StreamReader(nomeArquivo);
        while (!sr.EndOfStream)
        {
            linhas.Adiciona(sr.ReadLine());
        }
        sr.Close();
        return linhas;
    }
}