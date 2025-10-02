namespace ProjetoHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado q1 = new Quadrado();
            double areaq1 = q1.calcularArea();
            Console.WriteLine($"Área do quadrado 1: {areaq1}");
            Quadrado q2 = new Quadrado(4);
            double areaq2 = q2.calcularArea();
            Console.WriteLine($"Área do quadrado 2: {areaq2}");
            Console.WriteLine("Imprimindo os dados:");
            q1.imprimirDados();
            q2.imprimirDados();
        }
    }
}
