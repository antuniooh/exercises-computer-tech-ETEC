package Aulas_Java_07_01;

public class Pagamento {
	
	// atributos
	
	private String nomePagador, CPF;
	private double valorASerPago;
	
	//construtor
	public Pagamento(String nomePagador, String CPF, double valorASerPago) {
	this.nomePagador = nomePagador;
	this.CPF = CPF;
	this.valorASerPago = valorASerPago;
	}
	//métodos de acesso
	public String getNomePagador() {
	return nomePagador;
	}
	public String getCPF() {
	return CPF;
	}
	public double getValorASerPago() {
	return valorASerPago;
	}
	//métodos modificadores
	public void setNomePagador(String nomePagador) {
	this.nomePagador = nomePagador;
	}
	public void setCPF(String CPF) {
	this.CPF = CPF;
	}
	public void setValorASerPago(double valorASerPago) {
	this.valorASerPago = valorASerPago;
	}
	

}
