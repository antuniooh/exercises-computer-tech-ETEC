package Aulas_Java_02;

import javax.swing.JOptionPane;

public class Exercicio11 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		 String F1 = JOptionPane.showInputDialog("Digite uma frase");	
		 String F2 = JOptionPane.showInputDialog("Digite uma frase");	
		 String F3 = JOptionPane.showInputDialog("Digite uma frase");	
		 
		 int CF1 = F1.length();    int MF1 = CF1/2;
		 int CF2 = F2.length();    int MF2 = CF2/2;
		 int CF3 = F3.length();    int MF3 = CF3/2;
		 
		 System.out.println("As frases originais são: " + F1 + F2 + F3);
		 System.out.println("A frase embaralhada é: "+  F2.substring(0, MF2) 
				                                         +  F3.substring(MF3,CF3) 
				                                         +  F2.substring(MF2, CF2)
				                                         +  F1.substring(0,MF1)
				                                         +  F3.substring(0,MF3) 
				                                         +  F1.substring(MF1, CF1));		 		 
	}

}
