using System.IO;
using System.Text;
class LancamentoDao
{
    private CListaVet<LancamentoVo> Lancamentos;
    public LancamentoDao(int num)
    {
        Lancamentos = new CListaVet<LancamentoVo>(num);
    }

    public void Incluir(LancamentoVo vo) => Lancamentos.Adiciona(vo);

    public void Excluir(LancamentoVo vo)
    {
        Lancamentos.Remove(vo);
        if ((double)Lancamentos.Capacidade >= (double)Lancamentos.Quantidade * 2.5)
            Lancamentos.CortarExcessos();
    }

    public LancamentoVo Consultar(LancamentoVo vo)
    {
        if (!Lancamentos.Contem(vo))
        {
            Console.WriteLine("Lançamento não encontrado.");
            return default!;
        }
        return vo;
    }

    public int Contador => Lancamentos.Quantidade;

    public CListaVet<LancamentoVo> ObterTodos
    {
        get
        {
            CListaVet<LancamentoVo> lista = new CListaVet<LancamentoVo>(Lancamentos.Quantidade);
            for (int i = 0; i < Lancamentos.Quantidade; i++)
                lista.Adiciona (Lancamentos[i]);

            return lista;
        }
    }

    public void CarregarNovoArquivo()
    {
        StreamWriter escritor = new StreamWriter("registro.txt", true, Encoding.UTF8);
        for (int i = 0; i < Lancamentos.Quantidade; i++)
            escritor.WriteLine(Lancamentos[i]);
        escritor.Close();
    }
}