package Aulas_Java_06_01;

public class Atribui��o {

	//atributos
	private Professor professor;
	private Disciplina disciplina;
	
	//construtor
	public Atribui��o(Professor professor, Disciplina disciplina) {
	this.professor = professor;
	this.disciplina = disciplina;
	}
	//m�todos de acesso
	public Professor getProfessor() {
	return professor;
	}
	public Disciplina getDisciplina() {
	return disciplina;
	}
	//m�todos modificadores
	public void setDisciplina(Disciplina disciplina) {
	this.disciplina = disciplina;;
	}
	public void setProfessor(Professor professor) {
	this.professor = professor;
	}
	//m�todo getDados
	public String getDados() {
	return "Atribui��o [Professor=" + professor + ", Disciplina=" + disciplina + "]";
	}
}
