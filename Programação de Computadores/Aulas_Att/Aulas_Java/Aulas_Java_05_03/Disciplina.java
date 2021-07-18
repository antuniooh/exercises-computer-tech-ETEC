package Aulas_Java_05_03;

public class Disciplina {

	private String nome;
	private String professor;
	private int semestre;
	private boolean ofertada;
	
	public Disciplina (String n , String p, int s , boolean f)
	{
	    nome = n;
	    professor = p;
	    semestre = s;
	    ofertada = f;	 
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
	
	public void setProfessor(String p)
	{
		this.professor = p;
	}
	public String getProfessor()
	{
		return professor;
	}
	
	public void setSemestre(int s)
	{
		this.semestre = s;
	}
	public int getSemestre()
	{
		return semestre;
	}
	
	public void setOfertada(boolean f)
	{
		this.ofertada = f;
	}
	public boolean getOfertada()
	{
		return ofertada;
	}

}
