package Aulas_Java_02;

import javax.swing.JOptionPane;

public class Exercicio07 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

	    String numero = JOptionPane.showInputDialog("Digite um numero");	
		
		System.out.println(" O algarismo da centena é: "+ numero.substring(0, 1));
	}

}
