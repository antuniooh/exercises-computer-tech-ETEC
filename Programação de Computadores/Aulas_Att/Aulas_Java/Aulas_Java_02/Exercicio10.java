package Aulas_Java_02;

import javax.swing.JOptionPane;

public class Exercicio10 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub


        double numero = Double.parseDouble(JOptionPane.showInputDialog("Digite um numero"));	
      /* double base = Double.parseDouble(JOptionPane.showInputDialog("));*/
        
		double log = Math.log(numero);
		System.out.println(" O logaritmo de seu numero é: "+ log);
	}

}
