namespace ProjetoHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circulo obj1 = new Circulo(1, "c1", 2);
            obj1.imprimirDados();

            Circulo obj2 = new Circulo(2, "c2", 4);
            obj2.imprimirDados();
        }
    }
}
