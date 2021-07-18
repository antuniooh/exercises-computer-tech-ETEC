package Aulas_Java_03;

import javax.swing.JOptionPane;

public class Exercicio13 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		String a= JOptionPane.showInputDialog("Digite um valor");
		
	    String dezenas = a.substring(1,2);
	    int dez = Integer.parseInt(dezenas);
	    
	    if(dez%2 ==0)
	    {		
	    	System.out.println("O algarismo das dezenas é par");
	    }
	    else
	    {
	    	System.out.println("O algarismo das dezenas é impar");
	    }
	}

}
