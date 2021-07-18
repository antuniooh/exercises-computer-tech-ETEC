package Aulas_Java_07_02;
public abstract class Empregado extends PessoaFisica{
   private String nome;
   
   public Empregado(String nome){
      this.nome = nome;
   }
   
   public String getNome(){
      return nome;
   }
   
   public void setNome(String nome){
      this.nome = nome;
   }
   
   public abstract double salario();
      
   public void setComissao(double x){
   }
}