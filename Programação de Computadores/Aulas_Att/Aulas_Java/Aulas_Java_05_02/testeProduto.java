package Aulas_Java_05_02;

import javax.swing.JOptionPane;

public class testeProduto {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		String nome = JOptionPane.showInputDialog("Digite o nome do produto");
		int qtd = Integer.parseInt(JOptionPane.showInputDialog("Digite a quantidade"));
		double preço = Double.parseDouble(JOptionPane.showInputDialog("Digite o preço"));

		Produto produto/*nome que denominamos*/ = new /*significa instancia*/ Produto(nome, qtd, preço);
		
		System.out.println("Produto Criado: "+ "\n\n Nome: " + produto.getNome() + "\n Quantidade: " + produto.getQuantidade() + "\n Preço: R$ " + produto.getPreço());
	}


	}
