package Aulas_Java_06_01;

public class Atribuição {

	//atributos
	private Professor professor;
	private Disciplina disciplina;
	
	//construtor
	public Atribuição(Professor professor, Disciplina disciplina) {
	this.professor = professor;
	this.disciplina = disciplina;
	}
	//métodos de acesso
	public Professor getProfessor() {
	return professor;
	}
	public Disciplina getDisciplina() {
	return disciplina;
	}
	//métodos modificadores
	public void setDisciplina(Disciplina disciplina) {
	this.disciplina = disciplina;;
	}
	public void setProfessor(Professor professor) {
	this.professor = professor;
	}
	//método getDados
	public String getDados() {
	return "Atribuição [Professor=" + professor + ", Disciplina=" + disciplina + "]";
	}
}
