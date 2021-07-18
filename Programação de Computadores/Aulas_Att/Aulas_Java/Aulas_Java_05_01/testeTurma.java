package Aulas_Java_05_01;

import javax.swing.JOptionPane;

public class testeTurma {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		
		String curso = JOptionPane.showInputDialog("Digite seu curso");
		String nome = JOptionPane.showInputDialog("Digite seu nome");
		int qtd = Integer.parseInt(JOptionPane.showInputDialog("Digite a quantidade de alunos"));
		int serie = Integer.parseInt(JOptionPane.showInputDialog("Digite sua serie"));

		Turma turma/*nome que denominamos*/ = new /*significa instancia*/ Turma(nome, curso, qtd, serie);
		
		System.out.println("Curso: " + turma.getCurso() + "\n Nome: " + turma.getNome() + "\n Quantidade de alunos: " + turma.getQuantidadeAlunos() + "\n Serie: " + turma.getSerie());
		
		
		
		curso = JOptionPane.showInputDialog("Digite seu curso");
		nome = JOptionPane.showInputDialog("Digite seu nome");
		qtd = Integer.parseInt(JOptionPane.showInputDialog("Digite a quantidade de alunos"));
	    serie = Integer.parseInt(JOptionPane.showInputDialog("Digite sua serie"));
		
		turma.setCurso(curso);
		turma.setNome(nome);
		turma.setQuantidadeAlunos(qtd);
		turma.setSerie(serie);
		
		System.out.println("Curso: " + turma.getCurso() + "\n Nome: " + turma.getNome() + "\n Quantidade de alunos: " + turma.getQuantidadeAlunos() + "\n Serie: " + turma.getSerie());
	}


	}
