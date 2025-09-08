using System;

class Program
{
    public static void Main(string[] args)
    {
        Conjunto c1 = new Conjunto(1, "Primeiro");
        int opcao;
        do
        {
            Console.WriteLine("Escolha uma das opções:");
            Console.WriteLine("1: Adicionar ponto.");
            Console.WriteLine("2: Excluir ponto.");
            Console.WriteLine("3: Listar pontos");
            Console.WriteLine("4: Mostrar quantidade de pontos no conjunto.");
            Console.WriteLine("5: Sair.");
            Console.Write("Opção: ");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Informe as coordenadas, descrição é opcional. Digite todas as informações em uma linha separadas por espaços");
                    string[] informacoes = Console.ReadLine().Split(' ');
                    double x = double.Parse(informacoes[0] ?? "0");
                    double y = double.Parse(informacoes[1] ?? "0");
                    string descricao = informacoes[2];
                    Ponto p1 = new Ponto(x, y, descricao);
                    c1.AdicionarPonto(p1);
                    Console.WriteLine("Ponto adicionado com sucesso!");
                    break;

                case 2:
                    Console.WriteLine("Informe as coordenadas, descrição é opcional. Digite todas as informações em uma linha separadas por espaços");
                    string[] informacoes2 = Console.ReadLine().Split(' ');
                    double x2 = double.Parse(informacoes2[0] ?? "0");
                    double y2 = double.Parse(informacoes2[1] ?? "0");
                    string descricao2 = informacoes2[2];
                    Ponto p2 = new Ponto(x2, y2, descricao2);
                    c1.ExcluirPonto(p2);
                    break;

                case 3:
                    c1.ListarPontos();
                    break;

                case 4:
                    Console.WriteLine($"Quantidade de pontos no conjunto: {c1.ContarPontos}");
                    break;

                case 5:
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Digite uma das opções acima.");
                    break;
            }
        }
        while (opcao != 5);
    }
}
