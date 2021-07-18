package Aulas_Java_02;

import javax.swing.JOptionPane;

public class Exercicio03 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		    double base= Double.parseDouble(JOptionPane.showInputDialog("Digite o valor da base de seu retangulo"));
	        double altura= Double.parseDouble(JOptionPane.showInputDialog("Digite o valor da altura de seu retangulo"));
			
		    double Area = (base * altura);
			
			JOptionPane.showMessageDialog(null, "a area de seu retangulo é " + Area);
	}

}
