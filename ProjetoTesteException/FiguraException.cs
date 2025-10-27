namespace ProjetoTesteException;
internal class FiguraException : Exception
{
    private int codigo;
    private string mensagem;
    public FiguraException(int codigo, string mensagem)
    {
        this.codigo = codigo;
        this.mensagem = mensagem;
    }

    public override string ToString()
    {
        return $"{codigo} {mensagem}";
    }
}