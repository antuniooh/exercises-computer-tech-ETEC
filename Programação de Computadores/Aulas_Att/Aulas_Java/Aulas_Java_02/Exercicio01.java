package Aulas_Java_02;

import javax.swing.JOptionPane;

public class Exercicio01 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

        double peso= Double.parseDouble(JOptionPane.showInputDialog("Digite seu peso"));
        double altura= Double.parseDouble(JOptionPane.showInputDialog("Digite sua altura"));
		
	    double IMC = peso/(altura * altura);
		
		JOptionPane.showMessageDialog(null, "Seu IMC é " + IMC);
	}

}
