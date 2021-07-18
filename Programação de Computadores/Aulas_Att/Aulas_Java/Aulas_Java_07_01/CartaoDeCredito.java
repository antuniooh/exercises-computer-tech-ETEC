package Aulas_Java_07_01;

public class CartaoDeCredito extends Pagamento{

	// atribute
	private String numeroDoCartao;
	
	public CartaoDeCredito(String nomePagador, String CPF, double valorASerPago,String numeroDoCartao ) {
		super(nomePagador, CPF, valorASerPago);
		this.numeroDoCartao = numeroDoCartao;
	}

	public String getNumeroDoCartao() {
		return numeroDoCartao;
	}

	public void setNumeroDoCartao(String numeroDoCartao) {
		this.numeroDoCartao = numeroDoCartao;
	}
	
	
}
