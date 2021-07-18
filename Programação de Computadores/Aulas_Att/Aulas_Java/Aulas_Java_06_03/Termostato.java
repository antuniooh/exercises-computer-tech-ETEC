package Aulas_Java_06_03;

public class Termostato {

	//atributos
	private int temperatura;
	
	//construtor
	public Termostato() {
     temperatura = 20;
	   }
	
	// metodo de acesso
	public int getTemperatura() {
		return temperatura;
	}
	//métodos modificadores
	public void setTemperatura(int temperatura) {
	this.temperatura = temperatura;
	}
}
