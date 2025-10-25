namespace ProjetoInterface;

class Program
{
    static void Main(string[] args)
    {
        CirculoVO c1 = new CirculoVO(123, "Círculo 1", 4.55);
        double areaC1 = c1.CalcularArea();
        Console.WriteLine($"Área do círculo 1: {areaC1:F2}");
        c1.ImprimirDados();
        RetanguloVO r1 = new RetanguloVO(234, "Retângulo 2", 5.42, 3);
        Console.WriteLine($"Área do retângulo 1: {r1.CalcularArea():F2}");
        r1.ImprimirDados();
        CListaVet<FiguraVO> listaDeObjetos = new CListaVet<FiguraVO>(10);
        for (int i = 0; i < listaDeObjetos.Capacidade; i++)
        {
            Random aleatorio = new Random();
            if (i % 2 == 0)
                listaDeObjetos.Adiciona(new RetanguloVO(aleatorio.Next(5, 99), "Descrição genérica que é pra servir pra todos", aleatorio.Next(5, 99), aleatorio.Next(5, 99)));
            else
                listaDeObjetos.Adiciona(new CirculoVO(aleatorio.Next(5, 99), "Descrição genérica que é pra servir pra todos", aleatorio.Next(5, 99)));
        }
        Console.WriteLine($"Iterando na lista de figuras:");
        for (int i = 0; i < listaDeObjetos.Quantidade;  i++)
        {
            FiguraVO fv = listaDeObjetos[i];
            Console.WriteLine($"Área da figura: {fv.CalcularArea()}");
            Console.WriteLine("Dados da figura:");
            fv.ImprimirDados();
        }
        Console.WriteLine($"Total de figuras instanciadas: {FiguraVO.RetornarNumeroObjetosFigura()}");
    }
}
/*
Exercício 14)
O teste da etapa 13 tem tudo a ver com polimorfismo, pois podemos visualizar claramente a ação dele. Polimorfismo significa "muitas formas" - ou seja, a capacidade de um mesmo método se comportar de várias formas diferentes.
No caso do exercício 13, se a figura for um retângulo, o método CalcularArea retornará o resultado da multiplicação do comprimento pela altura.
Se for um círculo, o método retornará Pi * Raio * Raio.
Isso também vale para o método ImprmirDados, pois este por sua vez, não imprimirá o raio de um retângulo, nem o comprimento e a altura de um círculo.
*/