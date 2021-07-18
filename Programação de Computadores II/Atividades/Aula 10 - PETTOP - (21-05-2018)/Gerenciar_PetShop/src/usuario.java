
public class usuario {
private int cpf;
private String nome;
private String email;
private int telefone;
private String tipo;
private String servico;
private String login;
private String senha;

public usuario(){
	this(0,"","",0,"","","","");
}
public usuario (int cpf, String nome, String email,int telefone,String tipo,String servico, String login,String senha){
	this.cpf = cpf;
	this.nome = nome;
	this.email =email;
	this.telefone =telefone;
	this.tipo = tipo;
	this.servico = servico;
	this.login = login;
	this.senha = senha;
}

//CPF
public int getCPF(){
	return cpf;
}
public void setCPF(int cpf){
	this.cpf = cpf;
}
//nome
public String getNome(){
	return nome;
}
public void setNome(String nome){
	this.nome = nome;
}
//email
public String getEmail(){
	return email;
}
public void setEmail(String email){
	this.email = email;
}
//telefone
public int getTelefone(){
	return telefone;
}
public void setTelefone(int telefone){
	this.telefone = telefone;
}
//tipo
public String getTipo(){
	return tipo;
}
public void setTipo(String tipo){
	this.tipo = tipo;
}
//servico
public String getServico(){
	return servico;
}
public void setServico(String servico){
	this.servico = servico;
}
//login
public String getLogin(){
	return login;
}
public void setLogin(String login){
	this.login = login;
}
//senha
public String getSenha(){
	return senha;
}
public void setSenha(String senha){
	this.senha = senha;
}

}
