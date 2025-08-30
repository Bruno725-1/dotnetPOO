// Definição da classe Fruta
public class Fruta
{
  private int gramas;   
  private int caloriasPorGrama;
  private String nomeFruta;
  
  // Construtor com um parâmetro
  public Fruta(String nome)
  {
     this(nome, 70,3); 
  }
  
  // Construtor com 3 parâmetros
  public Fruta(String nome, int g, int c)
  {
    this.nomeFruta = nome;
    this.gramas=g;
    this.caloriasPorGrama=c;
  }
  
  // Retorna o peso em gramas
  public int getGramas() 
  {
      return this.gramas;
  }
  // Retorna o nome da fruta
  public String getNomeFruta()
  {
     return this.nomeFruta;
  }
  
  // Retorna o número de calorias por grama
  public int getCaloriasPorGrama()
  {
     return caloriasPorGrama;
  }
  // Imprime os dados da fruta
  public void imprimeFruta()
  {
     System.out.println("Fruta: " + nomeFruta);
     System.out.println("Peso: " + gramas);
     System.out.println("Calorias: " + caloriasPorGrama);
  }
}
