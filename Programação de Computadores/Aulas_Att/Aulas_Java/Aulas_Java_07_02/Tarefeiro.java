package Aulas_Java_07_02;

public class Tarefeiro extends Empregado{

	//atributo
	private int qtdTarefas;
	private double valorTarefas;
	
	public Tarefeiro(String nome, double valorTarefas, int qtdTarefas) {
		super(nome);
		this.valorTarefas = valorTarefas;
		this.qtdTarefas = qtdTarefas;
	}
	public double salario() {
		return qtdTarefas * valorTarefas;
	}
	public String toString() {
		return "\nValor Hora " + valorTarefas + "\n Quantidade Tarefas " + qtdTarefas
	+ "\n Nome " + getNome() + "\n Salario " + salario();
	}
	
}
