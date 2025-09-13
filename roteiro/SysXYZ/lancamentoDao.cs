/**
* PUC Minas, Campus Barreiro.
* POO Aula Prática 
* Data: 12/09/2025 (Sexta´feira)
* @author Bruno César Lima Araújo
* Objetivo: Continuação do RP4, o qual tem o objetivo de ver conceitos como manipulação de arquivos e persistência de objetos
*/
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
                lista[i] = Lancamentos[i];

            return lista;
        }
    }
}