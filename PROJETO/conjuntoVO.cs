using System;
class ConjuntoVO
{
    private int codigo;
    private string descricao;
    private CListaVet<PontoVO> Pontos;

    public ConjuntoVO(int codigo, string descricao)
    {
        this.codigo = codigo;
        this.descricao = descricao;
        Pontos = new CListaVet<PontoVO>();
    }

    public override string ToString()
    {
        return $"{codigo}, {descricao}";
    }

    public int Codigo
    {
        get => codigo;
        set
        {
            if (value < 0)
            {
                Console.WriteLine("O código não pode ser negativo.");
                return;
            }
            codigo = value;
        }
    }

    public string Descricao
    {
        get => descricao;
        set => descricao = value;
    }

    public int ContarPontos => Pontos.Quantidade;

    public void AdicionarPonto(PontoVO p) => Pontos.Adiciona(p);

    public void ExcluirPonto(PontoVO p)
    {
        if (!Pontos.Contem(p))
        {
            Console.WriteLine("Elemento não encontrado");
            return;
        }
        Pontos.Remove(p);
        if ((double)Pontos.Capacidade >= (double)Pontos.Quantidade * 2.5)
            Pontos.CortarExcessos();
    }

    public void ListarPontos()
    {
        for (int i = 0; i < Pontos.Quantidade; i++)
            Console.WriteLine(Pontos[i]);
    }
}