// Definição da classe Citros
public class Citros extends Fruta 
{
    private int acidoCitrico;
	
	// Construttor vazio
    public Citros(String nome) 
	{
	   super(nome); // chama o construtor da classe pai
	   this.acidoCitrico=1000;
    }
	
    public Citros(String nome, int g, int c, int a) 
	{
	   super(nome, g, c);
	   this.setAcidoCitrico(a);
    }
	 
    public int getAcidoCitrico() 
	{
	   return acidoCitrico;
	}
    public void setAcidoCitrico(int acido) 
	{
       this.acidoCitrico=acido;
	}
}