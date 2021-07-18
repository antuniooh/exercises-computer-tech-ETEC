package Aulas_Java_06_01;

public class Disciplina {

	//atributos
	private String nome;
	private boolean pratica;
	
	//construtor
	public Disciplina(String nome, boolean pratica) {
	this.nome = nome;
	this.pratica = false;;
	}
	//métodos de acesso
	public String getNome() {
	return nome;
	}
	public boolean getpratica() {
	return pratica;
	}
	//métodos modificadores
	public void setNome(String nome) {
	this.nome = nome;
	}
	public void setIdade(boolean pratica) {
	this.pratica = pratica;
	}
	//método getDados
	public String getDados() {
	return "Disciplina [nome =" + nome + ", pratica =" + pratica + "]";
	}
}
