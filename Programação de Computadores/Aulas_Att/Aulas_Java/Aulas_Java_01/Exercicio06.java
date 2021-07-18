package Aulas_Java_01;

import javax.swing.JOptionPane;

public class Exercicio06 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		int milhar =Integer.parseInt(JOptionPane.showInputDialog("Digite um numero"));
		int centena =Integer.parseInt(JOptionPane.showInputDialog("Digite um numero"));
		int dezena =Integer.parseInt(JOptionPane.showInputDialog("Digite um numero"));
		int unidade =Integer.parseInt(JOptionPane.showInputDialog("Digite um numero"));
		
		String numero = (milhar + "" + centena + "" + dezena +"" + unidade);
		
		JOptionPane.showMessageDialog(null, "O numero é: "+ numero);
	}

}
