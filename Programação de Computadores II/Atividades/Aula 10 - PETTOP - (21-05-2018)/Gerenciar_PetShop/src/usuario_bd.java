import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import javax.swing.JOptionPane;
import com.mysql.jdbc.ResultSetMetaData;

public class usuario_bd {
//driver de conexão ao mysql
	private String servidor="com.mysql.jdbc.Driver";
	//url que identifica o banco
	private String urlBanco ="jdbc:mysql://localhost:3306/aula";//localhost pode substituir para o ip e 3306 porta de rede
	//login de usuario no banco
	private String usuarioBanco ="root";
	//senha do usuario no banco
	private String senhaBanco="";
	
	public boolean testaConexao(){
		//declaração e inicialição de uma variável de retorno("true" se conectar ou "false" se ocorreur erro)
		boolean ret=false;
		//declaração e inicialização de uma variavel do tipo Connection que armazenara a conexao e:
		Connection con = null;
		try{
			Class.forName(servidor);
			con=DriverManager.getConnection(urlBanco,usuarioBanco,senhaBanco);
			ret =true;
		}catch(ClassNotFoundException e){
			e.printStackTrace();
		}catch(SQLException e){e.printStackTrace();}
		return ret;}
	
	
		public void Consultar(){
			Connection con =null;
			try{
			Class.forName(servidor);
			con=DriverManager.getConnection(urlBanco,usuarioBanco,senhaBanco);
			Statement stmt = con.createStatement();//bufferde registros
			String sql = "select * from usuarios";
			ResultSet rs = stmt.executeQuery(sql);//executa o sql e guarad no buffer
			
			String relacao = "Relação de usuarios cadastrados \n";
			while(rs.next()){
				relacao = relacao + "\n CPF: " + rs.getString(1).toString() + 
						" - Nome: " + rs.getString(2) + " - Email: " + rs.getString(3) + " - Telefone: "
						+ rs.getString(4) + " - Tipo: " + rs.getString(5) + " - Servico: " + rs.getString(6) 
						+ " - Login: " + rs.getString(7) + " - Senha: " + rs.getString(8);
			}
		rs.close();
		JOptionPane.showMessageDialog(null, relacao + "\n");
		
	}catch (ClassNotFoundException e){
		e.printStackTrace();
	}catch(SQLException e){
		e.printStackTrace();
	}finally{
		try{
			con.close();
	}catch(Exception e){
		e.printStackTrace();
	}
	}}

	public usuario Pesquisar(usuario usu){
		Connection con = null;
		try{
			Class.forName(servidor);
			con=DriverManager.getConnection(urlBanco,usuarioBanco,senhaBanco);
			Statement stmt = con.createStatement();//bufferde registros
			String sql = "select * from usuarios where usuCPF = " + usu.getCPF();
			ResultSet rs = stmt.executeQuery(sql);//executa o sql e guarad no buffer
			rs.next();
			usu.setCPF(rs.getInt(1));
			usu.setNome(rs.getString(2));
			usu.setEmail(rs.getString(3));
			usu.setTelefone(rs.getInt(4));
			usu.setTipo(rs.getString(5));
			usu.setServico(rs.getString(6));
			usu.setLogin(rs.getString(7));
			usu.setSenha(rs.getString(8));
			rs.close();
		} catch(ClassNotFoundException e){
			e.printStackTrace();
		} catch (SQLException e){
		e.printStackTrace();
		}finally{
			try{
				con.close();
		}catch(Exception e ){
			e.printStackTrace();
		}
		}return usu;}
public void Incluir(usuario usu){
	Connection con = null;
	PreparedStatement ps =null;
	try{
		Class.forName(servidor);
		con=DriverManager.getConnection(urlBanco,usuarioBanco,senhaBanco);
		Statement stmt = con.createStatement();//bufferde registros
		String sqlInsert = "insert into usuarios values(?, ?, ?, ?, ?, ?);";
		ps =con.prepareStatement(sqlInsert);
		ps.setInt(1,usu.getCPF());
		ps.setString(2, usu.getNome());
		ps.setString(3, usu.getEmail());
		ps.setInt(4, usu.getTelefone());
		ps.setString(5, usu.getTipo());
		ps.setString(6, usu.getServico());
		ps.setString(7, usu.getLogin());
		ps.setString(8, usu.getSenha());
		ps.executeUpdate();
	} catch(ClassNotFoundException e){
		e.printStackTrace();
	} catch (SQLException e){
	e.printStackTrace();
	}finally{
		try{
			ps.close();
			con.close();
	}catch(Exception e ){
		e.printStackTrace();
	}
	}}
public void Alterar (usuario usu){
	Connection con = null;
	PreparedStatement ps =null;
	try{
		Class.forName(servidor);
		con=DriverManager.getConnection(urlBanco,usuarioBanco,senhaBanco);
		String sqlUpdate = "update usuarios set usuNome = ?, usuEmail = ?,"
				+ "usuTelefone = ?, usuTipo = ?, usuServico = ?,usuLogin = ?, usuSenha = ? where usuCPF = ?;";
		
		ps =con.prepareStatement(sqlUpdate);
		ps.setInt(1,usu.getCPF());
		ps.setString(2, usu.getNome());
		ps.setString(3, usu.getEmail());
		ps.setInt(4, usu.getTelefone());
		ps.setString(5, usu.getTipo());
		ps.setString(6, usu.getServico());
		ps.setString(7, usu.getLogin());
		ps.setString(8, usu.getSenha());
		ps.executeUpdate();
	} catch(ClassNotFoundException e){
		e.printStackTrace();
	} catch (SQLException e){
	e.printStackTrace();
	}finally{
		try{
			ps.close();
			con.close();
	}catch(Exception e ){
		e.printStackTrace();
	}
	}}
public void Excluir (usuario usu){
	Connection con = null;
	PreparedStatement ps =null;
	try{
		Class.forName(servidor);
		con=DriverManager.getConnection(urlBanco,usuarioBanco,senhaBanco);
		String sqlDelete = "delete from usuarios where usuCod = ?;";
		
		ps =con.prepareStatement(sqlDelete);
		ps.setString(1, Integer.toString(usu.getCPF()));
		ps.executeUpdate();
	} catch(ClassNotFoundException e){
		e.printStackTrace();
	} catch (SQLException e){
	e.printStackTrace();
	}finally{
		try{
			ps.close();
			con.close();
	}catch(Exception e ){
		e.printStackTrace();
	}
	}}
}
