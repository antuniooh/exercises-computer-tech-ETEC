import java.awt.*;
import java.awt.event.*;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JOptionPane;

public class janelas extends JFrame{
	JButton abrir;
	Inicial segundajanela;
	
	public janelas(){
		super("Abrir uma nova janela");
		Container tela = getContentPane();
		tela.setLayout(null);
		
		abrir = new JButton("Abrir");
		abrir.setBounds(100, 50, 80, 20);
		abrir.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent e){
				segundajanela= new Inicial();
				segundajanela.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
				segundajanela.setVisible(true);
				
				setVisible(false);
				dispose();}});
		tela.add(abrir);
		setSize(300,150);
		setLocationRelativeTo(null);
		setVisible(true);
	}

	public static void main(String[] args) {
		janelas app = new janelas();
		app.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	}
	
	private class Inicial extends JFrame{ JButton sair;
		private Inicial(){
			super("Menu Principal");
			Container tela = getContentPane();
			tela.setLayout(null);
			
			sair = new JButton("Sair");
			sair.setBounds(50, 50, 100, 20);
			TBsair tsair = new TBsair();
			sair.addActionListener(tsair);
			tela.add(sair);
			setSize(200,200);
			setLocationRelativeTo(null);}}
	
	private class TBsair implements ActionListener{
		public void actionPerformed(ActionEvent evento){
			int status = JOptionPane.showConfirmDialog
			(null, "Deseja realmente fechar o  " +
			"programa?","Mensagem de saida",
			JOptionPane.YES_NO_OPTION);
			if(status == JOptionPane.YES_NO_OPTION)
			{segundajanela.setVisible(false);
			segundajanela.dispose();}}}}
