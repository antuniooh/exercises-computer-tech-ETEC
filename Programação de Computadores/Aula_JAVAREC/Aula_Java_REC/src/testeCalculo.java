import javax.swing.JOptionPane;


public class testeCalculo {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		double total = 0;
		
		String endereco = JOptionPane.showInputDialog("Digite o endere�o do imovel:");
		double valor = Double.parseDouble(JOptionPane.showInputDialog("Digite o valor do im�vel:"));

		Imovel imovel = new Imovel (valor, endereco);
		System.out.println("\n Im�vel: \n Endere�o: " + imovel.getEndereco() + "\n Valor: R$" + imovel.getValor());
		

		double valorDesconto = Double.parseDouble(JOptionPane.showInputDialog("Digite o valor de desconto do imovel velho:"));
		
		Velho velho = new Velho(valorDesconto, imovel);
		System.out.println("\n Im�vel Velho: \n Endere�o: " + imovel.getEndereco() + "\n ValorTotal: R$" + velho.Calcular(total));
		
		
        double valorAdicional = Double.parseDouble(JOptionPane.showInputDialog("Digite o valor adicional do imovel novo:"));
		
		Novo novo = new Novo(valorAdicional, imovel);
		System.out.println("\n Im�vel Novo: \n Endere�o: " + imovel.getEndereco() + "\n ValorTotal: R$" + novo.Calcular(total));
		
		
	}
	}