package Aulas_Java_07_02;

public class Mensalista extends Empregado{
   private double salario;
   
   public Mensalista(String nome, double salario){
      super(nome);
      this.salario = salario;
   }
   
   public double salario(){
      return this.salario;
   }
   public String toString() {
		return "\n Nome " + getNome() + "\nSalario " + salario ;
	}
}