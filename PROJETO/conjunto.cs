using System;
class Conjunto
{
    private int codigo;
    private string descricao;
    private CListaVet<Ponto> Pontos;

    public Conjunto(int codigo, string descricao)
    {
        this.codigo = codigo;
        this.descricao = descricao;
        Pontos = new CListaVet<Ponto>();
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

    public void AdicionarPonto(Ponto p) => Pontos.Adiciona(p);

    public void ExcluirPonto(Ponto p)
    {
        if (!Pontos.Contem(p))
        {
            Console.WriteLine("Elemento não encontrado");
            return;
        }
        Pontos.Remove(p);
        if (Pontos.Capacidade >= Pontos.Quantidade * 3)
            Pontos.CortarExcessos();
    }

    public void ListarPontos()
    {
        for (int i = 0; i < Pontos.Quantidade; i++)
            Console.WriteLine(Pontos[i]);
    }
}