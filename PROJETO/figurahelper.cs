class FiguraHelper
{
    // cálculo do perímetro do círculo
    public static double CalcularPerimetro(double raio) => 2 * Math.PI * raio;

    // cálculo do perímetro do retângulo
    public static double CalcularPerimetro(double comprimento, double altura) => 2 * (comprimento + altura);

    // cálculo do perímetro do triângulo
    public static double CalcularPerimetro(double lado1, double lado2, double lado3) => lado1 + lado2 + lado3;
}