package Aulas_Java_02;

import javax.swing.JOptionPane;

public class Exercicio18 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		double base= Double.parseDouble(JOptionPane.showInputDialog("Digite o valor da base de seu triangulo"));
        double altura= Double.parseDouble(JOptionPane.showInputDialog("Digite o valor da altura de seu triangulo"));
		
	    double Area = (base * altura)/2;
		
		JOptionPane.showMessageDialog(null, "a area de seu triangulo é " + Area);
	}

}
