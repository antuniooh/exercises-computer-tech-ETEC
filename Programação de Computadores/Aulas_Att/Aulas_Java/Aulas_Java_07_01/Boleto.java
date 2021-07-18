package Aulas_Java_07_01;

public class Boleto extends Pagamento{

	// atribute
	private String numeroDoBoleto;
	private int dia,mes,ano;
	
	public Boleto(String nomePagador, String CPF, double valorASerPago,int dia,int mes,int ano, String numeroDoBoleto ) {
		super(nomePagador, CPF, valorASerPago);
		this.setNumeroDoBoleto(numeroDoBoleto);
		this.setAno(ano);
		this.setMes(mes);
		this.setDia(dia);
	}

	public String getNumeroDoBoleto() {
		return numeroDoBoleto;
	}

	public void setNumeroDoBoleto(String numeroDoBoleto) {
		this.numeroDoBoleto = numeroDoBoleto;
	}

	public int getDia() {
		return dia;
	}

	public void setDia(int dia) {
		this.dia = dia;
	}

	public int getAno() {
		return ano;
	}

	public void setAno(int ano) {
		this.ano = ano;
	}

	public int getMes() {
		return mes;
	}

	public void setMes(int mes) {
		this.mes = mes;
	}

}
