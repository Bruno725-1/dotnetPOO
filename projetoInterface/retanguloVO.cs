namespace ProjetoInterface;
internal class RetanguloVO : FiguraVO
{
    private double comprimento;
    private double altura;

    public RetanguloVO(int codigo, string descricao, double comprimento, double altura) : base(codigo, descricao)
    {
        this.comprimento = comprimento;
        this.altura = altura;
    }

    public override double CalcularArea() => comprimento * altura;

    public override void ImprimirDados()
    {
        base.ImprimirDados();
        Console.Write($"\nComprimento: {comprimento}\nAltura: {altura}");
        Console.WriteLine("\nID da figura: " + idFigura);
    }
}
