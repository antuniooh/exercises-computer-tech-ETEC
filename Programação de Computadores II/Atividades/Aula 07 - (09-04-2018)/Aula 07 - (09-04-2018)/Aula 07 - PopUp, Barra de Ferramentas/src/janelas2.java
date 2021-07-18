import javax.swing.*;

import java.awt.*;
import java.awt.event.*;

public class janelas2 extends JFrame{
	TelaInicial inicio;
	JButton botaosair;
	
	public janelas2(){
		super("Exemplo de Splash Screen");
		Container tela = getContentPane();
		tela.setLayout(null);
		
		inicio = new TelaInicial();
		inicio.setVisible(true);
		botaosair = new JButton ("Sair");
		botaosair.setBounds(100, 50, 100, 20);
		botaosair.addActionListener(new ActionListener(){
			
			public void actionPerformed(ActionEvent e){
				System.exit(0);
			}});
	tela.add(botaosair);
	setSize(300,150);
	setLocationRelativeTo(null);
	}

	public static void main(String[] args) {
		janelas2 app = new janelas2();
		app.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	}
	private void principal(){
		setVisible(true);
	}
	
	private class TelaInicial extends JWindow{
	private TelaInicial(){
		Container tela = getContentPane();
		tela.setLayout(new FlowLayout(FlowLayout.LEFT,1,1));
		ImageIcon imagem = new ImageIcon("imagens/fundo.png");
		JLabel rotulo = new JLabel(imagem);
		tela.add(rotulo);
		
		ActionListener fechar = new ActionListener(){
			public void actionPerformed(ActionEvent e){
				setVisible(false);
				dispose();
				principal();}};
				
				javax.swing.Timer timer = new javax.swing.Timer(3000,fechar);
				timer.start();
				pack();
				setLocationRelativeTo(null);}}}
