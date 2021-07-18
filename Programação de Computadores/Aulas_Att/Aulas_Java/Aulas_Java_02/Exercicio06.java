package Aulas_Java_02;

import javax.swing.JOptionPane;

public class Exercicio06 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		
		double VI = Double.parseDouble(JOptionPane.showInputDialog("Digite o Valor Inicial"));
		double J = Double.parseDouble(JOptionPane.showInputDialog("Digite os Juros"));
		double N = Double.parseDouble(JOptionPane.showInputDialog("Digite o Numero de meses"));
		
		double VF1 = Math.pow(1 + J /100, N);
		double VF = VI * VF1;
		
		JOptionPane.showMessageDialog(null, "A sua divida é de: "+ "R$ "+ VF );
	}

}
