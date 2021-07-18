package Aulas_Java_06_02;

public class CaixaEletronico {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		Agencia agencia = new Agencia("Ademar Apior",5,7890);
		ContaCorrente conta = new ContaCorrente(1234, 4, 150.00, agencia);
		Cliente cliente = new Cliente("Ademar Apior", "123231518-12", conta);
		
		conta.sacar(140.00);
		conta.consultarSaldo();
		conta.sacar(200);
		conta.consultarSaldo();
		conta.depositar(25.45);
		conta.ImprimirSaldo();
		cliente.setConta(conta);
	}

}
