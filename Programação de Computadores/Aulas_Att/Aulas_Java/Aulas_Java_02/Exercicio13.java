package Aulas_Java_02;

import javax.swing.JOptionPane;

public class Exercicio13 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		String numero = JOptionPane.showInputDialog("Digite uma data");
		
		String dia = numero.substring(0,2);
		String mes = numero.substring(2,4);
		String ano = numero.substring(4,6);
		
		System.out.println("Sua data é: "+ dia +"/" + mes+"/" + ano);
	}

}
