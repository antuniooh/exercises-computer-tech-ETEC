package Aulas_Java_05_02;

public class Produto {

	private String nome;
	private double pre�o;
	private int quantidade;
	
	public Produto (String n,int qtd, double p )
	{
	    nome = n;
	    quantidade = qtd;
	    pre�o = p;	 
	}
	
	// metodos de acesso
	public void setNome(String n)
	{
		this.nome = n;
	}
	public String getNome()
	{
		return nome;
	}
	
	public void setQuantidade(int qtd)
	{
		this.quantidade = qtd;
	}
	public int getQuantidade()
	{
		return quantidade;
	}
	
	public void setPre�o(double p)
	{
		this.pre�o = p;
	}
	public double getPre�o()
	{
		return pre�o;
	}

}
