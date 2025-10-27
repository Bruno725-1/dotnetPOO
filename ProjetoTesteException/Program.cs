namespace ProjetoTesteException;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Início do Main...");
        ConjuntoHelper conjunto = ConjuntoHelper.GetInstance();
        int opcao;
        do
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1: Instanciar nova figura");
            Console.WriteLine("2: Excluir figura existente");
            Console.WriteLine("3: Sair");
            Console.Write("Opção: ");
            opcao = int.TryParse(Console.ReadLine(), out int valor) ? valor : 0;
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Informe o raio do círculo");
                    double raio = double.TryParse(Console.ReadLine(), out double valorRaio) ? valorRaio : 0;
                    CirculoVO circulo = new CirculoVO(111, "Círculo", raio);
                    conjunto.Adicionar(circulo.Ancora);
                    break;
                case 2:
                    conjunto.ExcluirPonto();
                    break;
                case 3:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Digite uma das opções especificadas");
                    break;
            }
        }
        while (opcao != 3);
    }
}
