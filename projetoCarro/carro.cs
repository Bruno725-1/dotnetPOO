/**
* PUC Minas, Campus Barreiro.
* POO Aula Prática 
* Data: 10/10/2025 (Sexta-feira)
* @author Bruno César Lima Araújo
* Objetivo: RP7: Revisar os conceitos vistos até aqui
*/
class Carro
{
    private string chassi;
    private double consumo;
    private int qtdCombustivel;
    private double quilometragem;
    public Carro(double consumo)
    {
        this.consumo = consumo;
    }

    public string Chassi => chassi;
    public int Combustivel => qtdCombustivel;
    public double Consumo => consumo;
    public double Quilometragem => quilometragem;
}
