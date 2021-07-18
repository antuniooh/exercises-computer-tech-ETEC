
public class Imovel {

	// criou os atributos
	private double valor;
	private String endereco;

	//metodo construtor
	public Imovel(double v,String e)
	{
		valor = v;
		endereco = e;
	}
	// metodos modificadores
	public void setValor(double v)
	{
		this.valor = v;
	}
	public void setEndereco(String e)
	{
		this.endereco = e;
	}
	
	//metodos acessores
	public double getValor()
	{
		return valor;
	}
	public String getEndereco()
	{
		return endereco;
	}
	
	//metodo getDados
	public String getDados() 
	{
		return "Imovel [Endereço=" + endereco + "\n Valor=" + valor + "]";
	}
	
}
