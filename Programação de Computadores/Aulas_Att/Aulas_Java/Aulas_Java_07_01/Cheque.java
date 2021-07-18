package Aulas_Java_07_01;

public class Cheque extends Pagamento{

	// atribute
	private String numeroDoCheque;
	
	public Cheque(String nomePagador, String CPF, double valorASerPago,String numeroDoCheque ) {
		super(nomePagador, CPF, valorASerPago);
		this.numeroDoCheque =numeroDoCheque;
	}

	public String getNumeroDoCheque() {
		return numeroDoCheque;
	}

	public void setNumeroDoCheque(String numeroDoCheque) {
		this.numeroDoCheque = numeroDoCheque;
	}
	
}
