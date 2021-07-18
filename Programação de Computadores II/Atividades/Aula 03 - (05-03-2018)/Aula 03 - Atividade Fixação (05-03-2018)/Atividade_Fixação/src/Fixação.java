import javax.swing.*;

import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyEvent;

public class Fixação extends JFrame{
	JLabel rotulo1, rotulo2,rotulo3,rotulo4,rotulo5,rotulo6;
	JTextField texto1,texto2,texto3,texto4,texto5,texto6;
	JButton botao1,botao2;
	public Fixação(){
		super("Folha de Pagamento");

		Container tela = getContentPane();
		setLayout(null);
		
		tela.setBackground(Color.white);
		
		rotulo1 = new JLabel("Vendas Do Mês");
		rotulo2 = new JLabel("Comissão");
		rotulo3 = new JLabel("Prêmio");
		rotulo4 = new JLabel("Salário Bruto");
		rotulo5 = new JLabel("Desconto INSS");
		rotulo6 = new JLabel("Salário Líquido");
		
		botao1 = new JButton("Calcular");
		botao2 = new JButton("Sair");
		
		texto1 = new JTextField(20);
		texto2 = new JTextField(20);
		texto3 = new JTextField(20);
		texto4 = new JTextField(20);
		texto5 = new JTextField(20);
		texto6 = new JTextField(20);
		
		rotulo1.setBounds(50,20,150,20);
		rotulo2.setBounds(50,60,150,20);
		rotulo3.setBounds(50,100,150,20);
		rotulo4.setBounds(50,140,150,20);
		rotulo5.setBounds(50,180,150,20);
		rotulo6.setBounds(50,220,150,20);
		
		botao1.setBounds(50,260,150,40);
		botao2.setBounds(220,260,150,40);
		
		texto1.setBounds(180,20,80,20);
		texto2.setBounds(180,60,80,20);
		texto3.setBounds(180,100,80,20);
		texto4.setBounds(180,140,80,20);
		texto5.setBounds(180,180,80,20);
		texto6.setBounds(180,220,80,20);
		
		botao1.setBackground(Color.white);
		botao1.setForeground(Color.blue);
		botao1.setMnemonic(KeyEvent.VK_C);
		
		botao2.setBackground(Color.white);
		botao2.setForeground(Color.blue);
		botao2.setMnemonic(KeyEvent.VK_S);
		
		rotulo1.setForeground(Color.blue);
		rotulo2.setForeground(Color.blue);
		rotulo3.setForeground(Color.blue);
		rotulo4.setForeground(Color.blue);
		rotulo5.setForeground(Color.blue);
		rotulo6.setForeground(Color.blue);
		
		/*rotulo3.setForeground( new  Color(190,152,142));
		rotulo4.setForeground(new Color(201,200,100));*/
		
		texto1.setBackground(Color.blue);
		texto1.setForeground(Color.white);
		texto2.setBackground(Color.blue);
		texto2.setForeground(Color.white);
		texto3.setBackground(Color.blue);
		texto3.setForeground(Color.white);
		texto4.setBackground(Color.blue);
		texto4.setForeground(Color.white);
		texto5.setBackground(Color.blue);
		texto5.setForeground(Color.white);
		texto6.setBackground(Color.blue);
		texto6.setForeground(Color.white);
		
		rotulo1.setFont(new Font("Century Gothic",Font.BOLD,14));
		rotulo2.setFont(new Font("Century Gothic",Font.BOLD,14));
		rotulo3.setFont(new Font("Century Gothic",Font.BOLD,14));
		rotulo4.setFont(new Font("Century Gothic",Font.BOLD,14));
		rotulo5.setFont(new Font("Century Gothic",Font.BOLD,14));
		rotulo6.setFont(new Font("Century Gothic",Font.BOLD,14));
		
		botao1.setFont(new Font("Century Gothic",Font.BOLD,18));
		botao2.setFont(new Font("Century Gothic",Font.BOLD,18));
		
		botao1.addActionListener(
				new ActionListener(){
					public void actionPerformed(ActionEvent e){
						double vendas, comissão, premio, salarioB, descontoINSS, salarioL;
						vendas = Double.parseDouble(texto1.getText());
						comissão = (0.10 * vendas);
						premio = (0.02 * vendas);
						salarioB = (comissão + premio);
						descontoINSS = (salarioB * 0.08);
						salarioL = (salarioB - descontoINSS);
						
						String comissão1 = Double.toString(comissão);
						String premio1 = Double.toString(premio);
						String salarioB1 = Double.toString(salarioB);
						String descontoINSS1 = Double.toString(descontoINSS);
						String salarioL1 = Double.toString(salarioL);
						
						texto2.setText(comissão1);
						texto3.setText(premio1);
						texto4.setText(salarioB1);
						texto5.setText(descontoINSS1);
						texto6.setText(salarioL1);
						
					}
				}
					);
		botao2.addActionListener(
				new ActionListener(){
					public void actionPerformed(ActionEvent e){
						System.exit(0);}}
					);
		
		tela.add(rotulo1);
		tela.add(rotulo2);
		tela.add(rotulo3);
		tela.add(rotulo4);
		tela.add(rotulo5);
		tela.add(rotulo6);
		tela.add(texto1);
		tela.add(texto2);
		tela.add(texto3);
		tela.add(texto4);
		tela.add(texto5);
		tela.add(texto6);
		tela.add(botao1);
		tela.add(botao2);

		
		setSize(400,400);
		setVisible(true);
		setLocationRelativeTo(null);

	}
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Fixação app = new Fixação();
		app.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);}
	}

