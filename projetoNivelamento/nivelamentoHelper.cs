class NivelamentoHelper
{
    public static int Somar(int soma, int num) => soma + num;
    public static bool Maior(int num, int maior) => num > maior;
    public static bool Menor(int num, int menor) => num < menor && num >= 0;
    public static int Contador(int num, int contador) => num >= 0 ? ++contador : contador;
    public static double Media(int soma, int contador) => (double)soma / contador;
}