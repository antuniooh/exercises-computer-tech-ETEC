package Aulas_Java_05_03;

import javax.swing.JOptionPane;

public class testeDisciplina {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		String nome = JOptionPane.showInputDialog("Digite o nome da disciplina");
		String professor = JOptionPane.showInputDialog("Digite o nome do professor");
		int semestre = Integer.parseInt(JOptionPane.showInputDialog("Digite o número do semestre"));
		boolean ofertada = Boolean.parseBoolean(JOptionPane.showInputDialog("Ofertada?true/false"));

		Disciplina disciplina/*nome que denominamos*/ = new /*significa instancia*/ Disciplina (nome, professor, semestre, ofertada);
		
		System.out.println("Disciplina Criada: "+ "\n\n Nome: " + disciplina.getNome() +
		"\n Professor: " + disciplina.getProfessor() + "\n Semestre: " + disciplina.getSemestre() +"\n Ofertada: " + disciplina.getOfertada());

	}

}
