import javax.swing.*;

import java.awt.*;
import java.awt.event.*;

public class Rev_20 extends JFrame{
	
	JLabel rotulo;
	JTextArea texto;
	JScrollPane painelrolagem;
	JPanel painel;
	
	public Rev_20(){
		super("exemplo com JTextField");
		Container tela = getContentPane();
		tela.setLayout(null);
		
		rotulo = new JLabel("Endereço");
		rotulo.setBounds(50,20,100,20);
		
		texto = new JTextArea(10,20);
		
		painelrolagem.setVerticalScrollBarPolicy(JScrollPane.VERTICAL_SCROLLBAR_ALWAYS);
		painelrolagem.setHorizontalScrollBarPolicy(JScrollPane.HORIZONTAL_SCROLLBAR_ALWAYS);
		
		painel = new JPanel();
		painel.add(painelrolagem);
		painel.setBounds(40, 40, 250, 250);
		
		texto.setLineWrap(true);
		texto.setWrapStyleWord(true);
		texto.setForeground(Color.blue);
		texto.setBackground(Color.yellow);
		texto.setFont(new Font("Comic Sans MS",Font.ITALIC,12));
		
		tela.add(rotulo);
		tela.add(painel);
		
		setSize(400,400);
		setLocationRelativeTo(null);
		setVisible(true);}
	public static void main(String[] args) {
		// TODO Auto-generated method stub

		Rev_20 app = new Rev_20();
		app.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);}
	}