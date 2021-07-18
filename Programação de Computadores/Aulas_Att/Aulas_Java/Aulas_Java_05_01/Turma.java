package Aulas_Java_05_01;

public class Turma {
	private String curso;
	private String nome;
	private int quantidadedealunos;
	private int serie;

	// metodo construtor	
	public Turma(String c, String n,int qtd, int s )
	{
		curso = c;
	    nome = n;
	    quantidadedealunos = qtd;
	    serie = s;	 
	}
	
	// metodos de acesso
	public void setCurso(String c)
	{
		this.curso = c;
	}
	public String getCurso()
	{
		return curso;
	}
	
	public void setNome(String n)
	{
		this.nome = n;
	}
	public String getNome()
	{
		return nome;
	}
	
	public void setQuantidadeAlunos(int qtd)
	{
		this.quantidadedealunos = qtd;
	}
	public int getQuantidadeAlunos()
	{
		return quantidadedealunos;
	}
	
	public void setSerie(int s)
	{
		this.serie = s;
	}
	public int getSerie()
	{
		return serie;
	}


}
