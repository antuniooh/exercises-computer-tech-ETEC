package Aulas_Java_08_03;

import java.awt.BorderLayout;
import java.awt.Container;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JFrame;
import javax.swing.JLabel;

public class Tela extends JFrame implements ActionListener{

	private JLabel empregado, mensalista, comissionado, horista, tarefeiro;
	    
	  public Tela(){
	   super("Interface");
	       
	   empregado = new JLabel("Empregado");
	   mensalista = new JLabel("Mensalista");
	   comissionado = new JLabel("Comissionado");
	   horista = new JLabel("Horista");
	   tarefeiro = new JLabel("Tarefeiro");
	   
	   Container caixa = getContentPane();
       caixa.setLayout(new GridLayout(1,1));
	   Container caixa2 = getContentPane();
       caixa2.setLayout(new BorderLayout());

       
       caixa.add(empregado);
       caixa2.add(mensalista, BorderLayout.SOUTH);
       caixa2.add(comissionado, BorderLayout.NORTH);
       caixa2.add(mensalista, BorderLayout.WEST);
       caixa2.add(horista, BorderLayout.SOUTH);
       caixa2.add(tarefeiro, BorderLayout.SOUTH);
       
       setSize(200,150);
       setLocationRelativeTo(null);
       setVisible(true);
       setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
       
	  }
	public void actionPerformed(ActionEvent e) {
		
	}
	
}
