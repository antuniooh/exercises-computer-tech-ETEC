package Aulas_Java_05_02;

import javax.swing.JOptionPane;

public class testeProduto {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		String nome = JOptionPane.showInputDialog("Digite o nome do produto");
		int qtd = Integer.parseInt(JOptionPane.showInputDialog("Digite a quantidade"));
		double pre�o = Double.parseDouble(JOptionPane.showInputDialog("Digite o pre�o"));

		Produto produto/*nome que denominamos*/ = new /*significa instancia*/ Produto(nome, qtd, pre�o);
		
		System.out.println("Produto Criado: "+ "\n\n Nome: " + produto.getNome() + "\n Quantidade: " + produto.getQuantidade() + "\n Pre�o: R$ " + produto.getPre�o());
	}


	}
