package Aulas_Java_08_02;

import java.awt.Container;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;

public class Tela extends JFrame implements ActionListener{
	
    /** *  */
	private static final long serialVersionUID = 1L;
	
	private JLabel mostrador;
    private JButton ticTac, minuto, hora;
        
    public Tela(){
       super("Interface");
       
       mostrador = new JLabel();
       ticTac = new JButton("TicTac");
       minuto = new JButton("Minuto");
       hora = new JButton("Hora");
       
       Container caixa = getContentPane();
       caixa.setLayout(new GridLayout(4,1));
       
       caixa.add(mostrador);
       caixa.add(ticTac);
       caixa.add(minuto);
       caixa.add(hora);
       
       ticTac.addActionListener(this);
       minuto.addActionListener(this);
       hora.addActionListener(this);
       
       setSize(200,150);
       setLocationRelativeTo(null);
       setVisible(true);
       setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
       
    }

    public void actionPerformed(ActionEvent e){
    	
    	Relógio r = new Relógio();
    	
        if (e.getSource()==ticTac)
        {   
        	for(int i = 0; i < 1440; i++)
       	    {
       			r.ticTac();
       			JOptionPane.showMessageDialog(null,r.mostra());
       	    }
       }
       if(e.getSource()==minuto)
       {
    	   for(int i = 0; i < 60; i++)
    	    {
    		   r.minuto();
    	       JOptionPane.showMessageDialog(null,r.mostra());
    	    }
       }
       if(e.getSource()==hora)
       {
    	   for(int i = 0; i < 24; i++)
     	    {
     			r.hora();
     			JOptionPane.showMessageDialog(null,r.mostra());
     		}  
       }
    }
}
