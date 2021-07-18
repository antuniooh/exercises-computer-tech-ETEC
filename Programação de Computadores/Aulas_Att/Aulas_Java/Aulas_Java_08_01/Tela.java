package Aulas_Java_08_01;

import java.awt.Container;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JTextField;

public class Tela extends JFrame implements ActionListener{
	
    /**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private JTextField txtTexto;
    private JButton btnMostrar, btnLimpar, btnSair;
    
    public Tela(){
       super("Interface");
       
       txtTexto = new JTextField("");
       btnMostrar = new JButton("Mostrar");
       btnLimpar = new JButton("Limpar");
       btnSair = new JButton("Sair");
       
       Container caixa = getContentPane();
       caixa.setLayout(new GridLayout(4,1));
       
       caixa.add(txtTexto);
       caixa.add(btnMostrar);
       caixa.add(btnLimpar);
       caixa.add(btnSair);
       
       btnMostrar.addActionListener(this);
       btnLimpar.addActionListener(this);
       btnSair.addActionListener(this);
       
       setSize(200,150);
       setLocationRelativeTo(null);
       setVisible(true);
       setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
       
    }
    public void actionPerformed(ActionEvent e){
       if (e.getSource()==btnMostrar){
          String sText = txtTexto.getText();
          JOptionPane.showMessageDialog(null,sText);
       }
       if(e.getSource()==btnLimpar)
       {
          txtTexto.setText("");      
       }
       if(e.getSource()==btnSair)
       {
    	   System.exit(0);
       }
    }
}