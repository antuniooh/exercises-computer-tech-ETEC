import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class Rev_15 extends JFrame{
	JButton botao; 
	
	public Rev_15(){
		super("exemplo de botoes com dialogos de confirmação");
		Container tela = getContentPane();
		tela.setLayout(null);
		
		botao = new JButton ("Sair");
		botao.setBounds(100,50,100,20);
		botao.setToolTipText("Botao que finaliza a janela");
		tela.add(botao);
		
		botao.addActionListener(new ActionListener(){
					public void actionPerformed(ActionEvent e){
						int opcao;
						opcao = JOptionPane.showConfirmDialog(null, "Deseja fechar mesmo a janela?",
								"Fechar",JOptionPane.YES_NO_OPTION);
						if(opcao == JOptionPane.YES_OPTION)
							System.exit(0);
					}});
		setSize(300,200);
		setLocationRelativeTo(null);
		setVisible(true);
	}
		
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Rev_15 app = new Rev_15();
		app.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);}

	}
