package Aulas_Java_02;

import javax.swing.JOptionPane;

public class Exercicio12 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

	        int numero = Integer.parseInt(JOptionPane.showInputDialog("Digite uma data"));	
			
			int ano = numero / 10000;
			int mes = (numero % 10000)/100;
			int dia = ((numero % 10000)/100)/1;
			System.out.println("Sua data é: "+ dia +"/" + mes+"/" + ano);
	}

}
