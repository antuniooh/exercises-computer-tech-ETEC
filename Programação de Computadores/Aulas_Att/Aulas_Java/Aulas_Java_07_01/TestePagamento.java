package Aulas_Java_07_01;

public class TestePagamento {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		
		Pagamento pagamento = new Pagamento("Julio Tulio","503.334.308-40",50.0);
		System.out.println(pagamento.getNomePagador() + " " + pagamento.getCPF() + " " + pagamento.getValorASerPago());
		
		CartaoDeCredito cartao = new CartaoDeCredito("Julio Tulio","503.334.308-40",50.0,"123456");
		System.out.println(cartao.getNomePagador() + " " + cartao.getCPF() + " "  + cartao.getValorASerPago() + " " + cartao.getNumeroDoCartao());

		Cheque cheque= new Cheque("Julio Tulio","503.334.308-40",50.0,"1234568");
		System.out.println(cheque.getNomePagador() + " " + cheque.getCPF() + " "  + cheque.getValorASerPago() + " " + cheque.getNumeroDoCheque());

	}

}
