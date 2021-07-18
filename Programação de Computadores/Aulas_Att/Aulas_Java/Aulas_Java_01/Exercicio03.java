package Aulas_Java_01;

import javax.swing.JOptionPane;

public class Exercicio03 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		int dia=Integer.parseInt(JOptionPane.showInputDialog("Digite um dia"));
		int mes=Integer.parseInt(JOptionPane.showInputDialog("Digite um mês"));
		int ano=Integer.parseInt(JOptionPane.showInputDialog("Digite um ano"));
		
		JOptionPane.showMessageDialog(null, "A data é: "+ dia+ "/" + mes + "/" + ano);
	}

}
