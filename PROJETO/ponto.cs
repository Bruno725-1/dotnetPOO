/**
* PUC Minas, Campus Barreiro.
* POO Aula Prática 
* Data: 22/08/2025 (Sexta-feira)
* @author [Bruno César Lima Araújo]
* Objetivo: Introdução a criação de classes em dotnet
*/

class Ponto
{
    private double x;
    private double y;
    private string descricao;

    public Ponto() {}

    public Ponto(double x)
    {
        this.x = x;
    }

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
}