package Aulas_Java_06_02;

public class Cliente {

	//atributos
	private String nome;
	private String CPF;
	private ContaCorrente conta;
	
	//construtor
	public Cliente(String nome, String CPF, ContaCorrente conta) {
	this.nome = nome;
	this.CPF = CPF;
	this.conta = conta;
	}
	//métodos de acesso
	public String getNome() {
	return nome;
	}
	public String getCPF() {
	return CPF;
	}
	public ContaCorrente getConta() {
		return conta;
	}
	//métodos modificadores
	public void setNome(String nome) {
	this.nome = nome;
	}
	public void setIdade(String CPF) {
	this.CPF = CPF;
	}
	public void setConta(ContaCorrente conta) {
		this.conta = conta;
	}
}
