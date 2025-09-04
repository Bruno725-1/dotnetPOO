using System;
using AED;

class Program
{
    public static void Main(string[] args)
    {
        /*Ponto p1 = new Ponto();
        p1.ImprimirCoordenadas();
        p1.IncrementarCoordenadas(5, 2);
        p1.ImprimirCoordenadas();
        p1.IncrementarCoordenadas(4, 5);
        p1.ImprimirCoordenadas();
        p1.ZerarCoordenadas();
        p1.ImprimirCoordenadas();
        Ponto p3 = new Ponto(2, 6);
        p3.ImprimirCoordenadas();
        p3.IncrementarCoordenadas(6, 9);
        p3.ImprimirCoordenadas();
        p3.IncrementarCoordenadas(5, 2);
        p3.ImprimirCoordenadas();
        p3.ZerarCoordenadas();
        p3.ImprimirCoordenadas();
        p3.SetDescricao("Centro");
        string estringue = p3.ToString();
        Console.WriteLine(estringue);*/
        //Implementação de código que permitirá o usuário criar quantos objetos quizer
        double x, y;
        string descricao = "";
        Ponto p = null;
        CLista<Ponto> pontos = new CLista<Ponto>();
        do
        {
            descricao = ""; //devido a um bug de descrições sendo adicionadas indevidamente, esta variável precisa ser limpa ao entrar no loop
            Console.WriteLine("Informe as coordenadas x e y. Descrição é opcional. Digite todos os dados em uma única linha separados por espaço");
            string[] entrada = Console.ReadLine().Split(' ');
            x = double.Parse(entrada[0]);
            y = double.Parse(entrada[1]);
            if (entrada.Length >= 3)
                descricao = entrada[2];
            if (x >= 0 && y >= 0)
            {
                p = new Ponto(x, y, descricao);
                Console.WriteLine("Coordenadas:");
                p.ImprimirCoordenadas();
                pontos.InsereFim(p);
            }
        }
        while (x >= 0 && y >= 0);
        Console.WriteLine($"Total de itens instanciados: {pontos.Quantidade()}");
        for (int i = 1; i <= pontos.Quantidade(); i++)
        {
            Ponto p1 = pontos.RetornaIndice(i);
            Console.WriteLine(p1.ToString());
        }
    }
}
