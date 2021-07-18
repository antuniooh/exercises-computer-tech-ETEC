package Aulas_Java_05_02;

public class Produto {

	private String nome;
	private double preço;
	private int quantidade;
	
	public Produto (String n,int qtd, double p )
	{
	    nome = n;
	    quantidade = qtd;
	    preço = p;	 
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
	
	public void setPreço(double p)
	{
		this.preço = p;
	}
	public double getPreço()
	{
		return preço;
	}

}
