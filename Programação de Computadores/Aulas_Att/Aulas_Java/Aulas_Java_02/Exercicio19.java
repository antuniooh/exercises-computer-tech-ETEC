package Aulas_Java_02;

import javax.swing.JOptionPane;

public class Exercicio19 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		double DMa= Double.parseDouble(JOptionPane.showInputDialog("Digite o valor da diagonal maior"));
        double DMe= Double.parseDouble(JOptionPane.showInputDialog("Digite o valor da diagonal menor"));
		
	    double Area = (DMa * DMe)/2;
		
		JOptionPane.showMessageDialog(null, "a area de seu losango é " + Area);
	}

}
