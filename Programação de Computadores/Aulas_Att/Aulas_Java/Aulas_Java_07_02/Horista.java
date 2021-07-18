package Aulas_Java_07_02;

public class Horista extends Empregado{

	// atributos
	private double valorHora;
	private int horasTrabalhadas;
	
	// construtor
	public Horista(String nome, double valorHora, int horasTrabalhadas)
	{
		super(nome);
		this.horasTrabalhadas = horasTrabalhadas;
		this.valorHora = valorHora;
	}
	//sobrepoer o metodo salario
	
	public double salario() {
		return horasTrabalhadas * valorHora;
	}
	public String toString() {
		return "\nValor Hora " + valorHora + "\n Horas trabalhadas " + horasTrabalhadas
	+ "\n Nome " + getNome() + "\n Salario " + salario();
	}

}
