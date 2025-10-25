using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInterface;

public class ConjuntoHelper
{
    private static ConjuntoHelper instance;

    private CListaVet<PontoVO> listaPontos;

    private ConjuntoHelper()
    {
        listaPontos = new CListaVet<PontoVO>();
    }
    public static ConjuntoHelper getInstance()
    {
        if (instance == null)
        {
            instance = new ConjuntoHelper();
        }
        return instance;
    }

    public int adicionar(PontoVO ponto)
    {
        listaPontos.Adiciona(ponto);
        return 1;
    }

    public void listarPontos()
    {
        PontoVO p = null;
        Console.WriteLine("Início listarPontos...");
        for (int i = 0; i < listaPontos.Quantidade; i++)
        {
            p = (PontoVO)listaPontos[i];
            Console.WriteLine(p);
        }
        Console.WriteLine("Fim listarPontos...");
    }
    public void excluirPonto(PontoVO p)
    {
        listaPontos.Remove(p);
        if ((double)listaPontos.Capacidade >= (double)listaPontos.Quantidade * 2.5)
            listaPontos.CortarExcessos();
    }
}
