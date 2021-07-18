package Aulas_Java_02;

import javax.swing.JOptionPane;

public class Exercicio02 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

        int idade =Integer.parseInt(JOptionPane.showInputDialog("Digite sua idade"));
		
		int dias = idade * 365;
		
		JOptionPane.showMessageDialog(null, "Você viveu aproximadamente: "+ dias + " dias");
	}

}
