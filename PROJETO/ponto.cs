using System;
class Ponto
{
    private double x;
    private double y;
    private string descricao;

    public Ponto() { } //construtor vazio

    public Ponto(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public Ponto(double x, double y, string descricao)
    {
        this.x = x;
        this.y = y;
        this.descricao = descricao;
    }

    public double GetX() => x;
    public double GetY() => y;
    public string GetDescricao() => descricao;

    public void SetX(double valor)
    {
        x = valor;
    }

    public void SetY(double valor)
    {
        y = valor;
    }

    public void SetDescricao(string valor)
    {
        descricao = valor;
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

    public override bool Equals(object? obj) => Equals(obj as Ponto);

    public bool Equals(Ponto p)
    {
        if (p is null) return false;
        return (this.x == p.x) && (this.y == p.y) && (this.descricao == p.descricao);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(x, y, descricao);
    }
}