import javax.swing.*;

import java.awt.*;
import java.awt.event.*;

public class Rev_18 extends JFrame{
	JButton erro,informação,exclamação,pergunta,nenhum;
	
	public Rev_18(){
		super("exemplo de mensagens");
		Container tela = getContentPane();
		tela.setLayout(null);
		
		erro= new JButton("Erro");
		informação= new JButton("Informação");
		exclamação= new JButton("Exclamação");
		pergunta= new JButton("Pergunta");
		nenhum= new JButton("Nenhum");
		
		erro.setBounds(30, 20, 100, 20);
		informação.setBounds(30, 50, 100, 20);
		exclamação.setBounds(30, 80, 100, 20);
		pergunta.setBounds(30, 110, 100, 20);
		nenhum.setBounds(30, 140, 100, 20);
		
		tela.add(erro);tela.add(informação);tela.add(exclamação);
		tela.add(pergunta);tela.add(nenhum);
		
		erro.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent e){
				JOptionPane.showMessageDialog(null, "Voce escolheu erro", "Mensagem de erro", JOptionPane.ERROR_MESSAGE,null);}});
		nenhum.addActionListener(new ActionListener(){
			public void actionPerformed (ActionEvent e){
				JOptionPane.showMessageDialog(null, "Voce escolheu erro "
								+ "nenhum", "Mensagem", JOptionPane.PLAIN_MESSAGE,null);}});
		informação.addActionListener(new ActionListener(){
			public void actionPerformed (ActionEvent e){
				JOptionPane.showMessageDialog(null, "Voce escolheu "
								+ "informação", "Mensagem", JOptionPane.INFORMATION_MESSAGE,null);}});
		exclamação.addActionListener(new ActionListener(){
			public void actionPerformed (ActionEvent e){
				JOptionPane.showMessageDialog(null, "Voce escolheu "
								+ "exclamação", "Mensagem", JOptionPane.WARNING_MESSAGE,null);}});
		pergunta.addActionListener(new ActionListener(){
			public void actionPerformed (ActionEvent e){
				JOptionPane.showMessageDialog(null, "Voce escolheu "
								+ "pergunta", "Mensagem", JOptionPane.QUESTION_MESSAGE,null);}});
		setSize(300,200);
		setLocationRelativeTo(null);
		setVisible(true);}
				
	public static void main(String[] args) {
		// TODO Auto-generated method stub

		Rev_18 app = new Rev_18();
		app.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);}
	}
