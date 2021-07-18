package rev;

import javax.swing.*;

import java.awt.*;
import java.awt.event.*;

public class Rev_08 extends JFrame{
	JPasswordField caixa;
	JLabel rotulo, exibir;
	JButton mostrar;
	
	public Rev_08(){
		super("Exemplo com JPasswordField");
		Container tela = getContentPane();
		setLayout(null);
		
		rotulo = new JLabel("Senha: ");
		caixa = new JPasswordField(10);
		exibir = new JLabel("A senha digitada é: ");
		mostrar = new JButton("Mostrar");
		
		exibir.setVisible(false);
		rotulo.setBounds(50, 20, 100, 20);
		caixa.setBounds(50, 60, 200, 20);
		exibir.setBounds(50, 120, 200, 20);
		mostrar.setBounds(150, 100, 80, 20);
		
		mostrar.addActionListener(
				new ActionListener(){
					public void actionPerformed(ActionEvent e){
						String senha = new String(caixa.getPassword());
						exibir.setVisible(true);
						exibir.setText(senha);
					}
				}
);
		tela.add(rotulo);
		tela.add(caixa);
		tela.add(exibir);
		tela.add(mostrar);
		setSize(400,250);
		setVisible(true);
	}

	public static void main(String[] args) {
		Rev_08 app = new Rev_08();
		app.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);}
		// TODO Auto-generated method stub

	}
