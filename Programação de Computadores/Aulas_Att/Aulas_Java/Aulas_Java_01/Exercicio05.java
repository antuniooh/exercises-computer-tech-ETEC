package Aulas_Java_01;

import javax.swing.JOptionPane;

public class Exercicio05 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		String um = JOptionPane.showInputDialog("Digite um caractere");
		String dois = JOptionPane.showInputDialog("Digite um caractere");
		String tres = JOptionPane.showInputDialog("Digite um caractere");
		String quatro = JOptionPane.showInputDialog("Digite um caractere");
		String cinco = JOptionPane.showInputDialog("Digite um caractere");
		String seis = JOptionPane.showInputDialog("Digite um caractere");
		String sete = JOptionPane.showInputDialog("Digite um caractere");
		String oito = JOptionPane.showInputDialog("Digite um caractere");
		String nove = JOptionPane.showInputDialog("Digite um caractere");
		String dez = JOptionPane.showInputDialog("Digite um caractere");

		JOptionPane.showMessageDialog(null, "A palavra formada é: " + um + dois + tres + quatro + cinco + seis + sete + oito + nove + dez);
	}

}
