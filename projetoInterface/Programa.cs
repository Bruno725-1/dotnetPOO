namespace ProjetoInterface
{
    internal class Programa
    {
        public static void Rodar()
        {
            Console.WriteLine("Início do Rodar...");
            ConjuntoHelper conjuntoHelper = ConjuntoHelper.getInstance();

            PontoVO obj1 = new PontoVO(1, "p1", 1, 5);
            conjuntoHelper.adicionar(obj1);

            PontoVO obj2 = new PontoVO(2, "p2", 3, 7);
            conjuntoHelper.adicionar(obj2);

            ConjuntoHelper.getInstance().adicionar(new PontoVO(3, "p3", 2, 18));
            ConjuntoHelper.getInstance().listarPontos();  
            
            Console.WriteLine("Fim do Rodar...");	    
        }
    }
}
