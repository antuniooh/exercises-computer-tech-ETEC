package Aulas_Java_06_01;

import javax.swing.JOptionPane;

public class testeAtribuição {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		String nome = JOptionPane.showInputDialog("Nome do professor");
		
		int idade = Integer.parseInt(JOptionPane.showInputDialog("Idade"));
		
		String nomed = JOptionPane.showInputDialog("Nome da disciplina");
		
		boolean pratica = Boolean.parseBoolean(JOptionPane.showInputDialog("Pratica? F/T"));
		
		//cria o professor
		Professor professor = new Professor(nome, idade);
		// cria a disciplina
		Disciplina disciplina = new Disciplina(nomed , pratica);
		
		// mostra novamente o cadastro do aluno
		// mostra o aluno
		
		JOptionPane.showMessageDialog(null, professor.getDados());
		JOptionPane.showMessageDialog(null, disciplina.getDados());
		}
	}

