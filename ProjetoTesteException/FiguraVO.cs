using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteException;

internal class FiguraVO
{
    protected int codigo;
    protected string descricao;
    protected PontoVO ancora;
    protected int idFigura = 0;
    // Atributo estático compartilhado entre todas as figuras
    private static int numeroObjetosFigura = 0;

    public FiguraVO()
    {
        this.ancora = new PontoVO();
        numeroObjetosFigura++; // incrementa a cada instância criada
        idFigura = numeroObjetosFigura;
    }
    public FiguraVO(int codigo, string descricao) : this()
    {
        this.codigo = codigo;
        this.descricao = descricao;
    }
    public FiguraVO(int codigo, string descricao, PontoVO ancora) : this(codigo, descricao)
    {
        this.ancora = ancora;
    }

    public int Codigo
    {
        get => codigo;
        set => codigo = value;
    }

    public PontoVO Ancora
    {
        get => ancora;
        set => ancora = value;
    }

    public String Descricao
    {
        get => descricao;
        set => descricao = value;
    }

    public override string ToString()
    {
        return "Figura{" + "Código=" + codigo + ", descricao=" + descricao + '}';
    }
    public virtual double CalcularArea()
    {
        return 0;
    }
    public virtual void ImprimirDados()
    {
        Console.Write("\n\nCódigo: " + codigo + ", \tdescrição: " + descricao);
    }

    public static int RetornarNumeroObjetosFigura() => numeroObjetosFigura;
}
