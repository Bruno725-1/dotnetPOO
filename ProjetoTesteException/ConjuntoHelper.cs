using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteException;

public class ConjuntoHelper
{
    private static ConjuntoHelper instance;
    private CListaVet<PontoVO> listaPontos;
    private int capacidade = 10;

    private ConjuntoHelper()
    {
        listaPontos = new CListaVet<PontoVO>();
    }
    public static ConjuntoHelper GetInstance()
    {
        if (instance == null)
        {
            instance = new ConjuntoHelper();
        }
        return instance;
    }

    public void Adicionar(PontoVO ponto)
    {
        if (listaPontos.Quantidade == capacidade)
            throw new FiguraException(1, "Número máximo de objeto extrapolados");
        listaPontos.Adiciona(ponto);
    }

    public void ListarPontos()
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
    public void ExcluirPonto(PontoVO p)
    {
        listaPontos.Remove(p);
        if ((double)listaPontos.Capacidade >= (double)listaPontos.Quantidade * 2.5)
            listaPontos.CortarExcessos();
    }

    public void ExcluirPonto()
    {
        if (listaPontos.Quantidade == 0)
            throw new FiguraException(2, "Não existem objetos armazenados");
        ExcluirPonto(listaPontos[listaPontos.Quantidade - 1]);
    }
}
