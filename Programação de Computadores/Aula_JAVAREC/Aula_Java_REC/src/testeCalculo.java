import javax.swing.JOptionPane;


public class testeCalculo {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		double total = 0;
		
		String endereco = JOptionPane.showInputDialog("Digite o endereço do imovel:");
		double valor = Double.parseDouble(JOptionPane.showInputDialog("Digite o valor do imóvel:"));

		Imovel imovel = new Imovel (valor, endereco);
		System.out.println("\n Imóvel: \n Endereço: " + imovel.getEndereco() + "\n Valor: R$" + imovel.getValor());
		

		double valorDesconto = Double.parseDouble(JOptionPane.showInputDialog("Digite o valor de desconto do imovel velho:"));
		
		Velho velho = new Velho(valorDesconto, imovel);
		System.out.println("\n Imóvel Velho: \n Endereço: " + imovel.getEndereco() + "\n ValorTotal: R$" + velho.Calcular(total));
		
		
        double valorAdicional = Double.parseDouble(JOptionPane.showInputDialog("Digite o valor adicional do imovel novo:"));
		
		Novo novo = new Novo(valorAdicional, imovel);
		System.out.println("\n Imóvel Novo: \n Endereço: " + imovel.getEndereco() + "\n ValorTotal: R$" + novo.Calcular(total));
		
		
	}
	}