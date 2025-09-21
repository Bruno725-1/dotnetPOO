using System;
class PontoVO
{
    private double x;
    private double y;
    private string descricao;

    public PontoVO() { } //construtor vazio

    public PontoVO(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public PontoVO(double x, double y, string descricao)
    {
        this.x = x;
        this.y = y;
        this.descricao = descricao;
    }

    public double X
    {
        get => x;
        set => x = value;
    }

    public double Y
    {
        get => y;
        set => y = value;
    }

    public string Descricao
    {
        get => descricao;
        set => descricao = value;
    }

    public void IncrementarCoordenadas(double deltaX, double deltaY)
    {
        x += deltaX;
        y += deltaY;
    }

    public void ImprimirCoordenadas()
    {
        Console.WriteLine($"x={x}, y={y}");
        Console.WriteLine(descricao);
    }

    public void ZerarCoordenadas()
    {
        x = 0;
        y = 0;
    }

    public override string ToString()
    {
        return $"{x} {y} {descricao}";
    }

    public override bool Equals(object? obj) => Equals(obj as PontoVO);

    public bool Equals(PontoVO p)
    {
        if (p is null) return false;
        return (this.x == p.x) && (this.y == p.y) && (this.descricao == p.descricao);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(x, y, descricao);
    }
}