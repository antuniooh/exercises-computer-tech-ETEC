package Aulas_Java_01;

import javax.swing.JOptionPane;

public class Exercicio04 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

        double peso= Double.parseDouble(JOptionPane.showInputDialog("Digite seu peso"));
		
		JOptionPane.showMessageDialog(null, "O peso informado foi " + peso + " kg.");
	}

}
