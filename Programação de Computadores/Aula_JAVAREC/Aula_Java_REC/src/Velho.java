
public class Velho {

	 // criou os atributos
	private double valorDesconto;
	private Imovel imovel;

	//metodo construtor
	public Velho(double vd, Imovel i)
	{
		valorDesconto = vd;
		imovel = i;
	}
	// metodos modificadores
	public void setValorDesconto(double vd)
	{
		this.valorDesconto = vd;
	}
	public void setImovel(Imovel i)
	{
		this.imovel = i;
	}
	
	//metodos acessores
	public double getValorDesconto()
	{
		return valorDesconto;
	}
	public Imovel getImovel()
	{
		return imovel;
	}
	
	// metodo soma
	public double Calcular(double total)
	{
		total = (imovel.getValor() - valorDesconto);
		return total;
	}
	
	//metodo getDados
	public String getDados()
	{
		return "Novo [Imovel=" + imovel + "\n Valor Desconto=" + valorDesconto +"]";
	}
}

