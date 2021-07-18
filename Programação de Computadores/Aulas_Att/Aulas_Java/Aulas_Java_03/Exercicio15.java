package Aulas_Java_03;

import javax.swing.JOptionPane;

public class Exercicio15 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		int AN = Integer.parseInt(JOptionPane.showInputDialog("Digite o seu ano de nascimento"));
		int AA = Integer.parseInt(JOptionPane.showInputDialog("Digite o ano atual"));
		int idade =0;
		
	    if(AN >= 1900)
	    {
	       idade = (AA - AN);	
	       System.out.println( "Sua idade é: " + idade +" anos");
	    }
	    else
	    {
	    	System.out.println("Digite uma data de nascimento válida");
	    }
	}

}
