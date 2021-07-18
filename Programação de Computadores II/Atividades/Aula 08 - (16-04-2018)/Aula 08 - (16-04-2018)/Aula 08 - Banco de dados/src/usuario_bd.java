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
	private String urlbanco ="jdbc:mysql://localhost:3306/aula";//localhost pode substituir para o ip e 3306 porta de rede
	//login de usuario no banco
	private String usuarioBanco ="root";
	//senha do usuario no banco
	private String senhaBanco="";
	
	public boolean testaConexao(){
		//declaração e inicialição de uma variável de retorno("true" se conectar ou "false" se ocorreur erro)
		boolean ret=false;
		//declaração e inicialização de uma variavel do tipo Connection que armazenara a conexao e:
		Connection con=null;
		try{
			Class.forName(servidor);
			con=DriverManager.getConnection(urlbanco,usuarioBanco,senhaBanco);
			ret =true;
		}catch(ClassNotFoundException e){
			e.printStackTrace();
		}catch(SQLException e){e.printStackTrace();}
		return ret;}
	
		public void Consultar(){
			Connection con =null;
			try{
			Class.forName(servidor);
			con=DriverManager.getConnection(urlbanco,usuarioBanco,senhaBanco);
			Statement stmt = con.createStatement();//bufferde registros
			String sql = "select * from usuarios";
			ResultSet rs = stmt.executeQuery(sql);//executa o sql e guarad no buffer
			
			String relacao = "Relação de usuarios cadastrados \n";
			while(rs.next()){
				relacao = relacao + "\n Cod: " + rs.getString(1).toString() + 
						" - Nome: " + rs.getString(2) + " - Email: " + rs.getString(3) + " - Tipo: "
						+ rs.getString(4) + " - Login: " + rs.getString(5) + " - Senha: " + rs.getString(6);
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
			con=DriverManager.getConnection(urlbanco,usuarioBanco,senhaBanco);
			Statement stmt = con.createStatement();//bufferde registros
			String sql = "select * from usuarios where usuCod = " + usu.getCodigo();
			ResultSet rs = stmt.executeQuery(sql);//executa o sql e guarad no buffer
			rs.next();
			usu.setCodigo(rs.getInt(1));
			usu.setNome(rs.getString(2));
			usu.setEmail(rs.getString(3));
			usu.setTipo(rs.getString(4));
			usu.setLogin(rs.getString(5));
			usu.setSenha(rs.getString(6));
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
		con=DriverManager.getConnection(urlbanco,usuarioBanco,senhaBanco);
		Statement stmt = con.createStatement();//bufferde registros
		String sqlInsert = "insert into usuarios values(?,?,?,?,?,?);";
		ps =con.prepareStatement(sqlInsert);
		ps.setInt(1,usu.getCodigo());
		ps.setString(2, usu.getNome());
		ps.setString(3, usu.getEmail());
		ps.setString(4, usu.getTipo());
		ps.setString(5, usu.getLogin());
		ps.setString(6, usu.getSenha());
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
		con=DriverManager.getConnection(urlbanco,usuarioBanco,senhaBanco);
		String sqlUpdate = "update usuarios set usuNome = ?, usuEmail = ?,"
				+ "usuTipo = ?, usuLogin = ?, usuSenha = ? where usuCod = ?;";
		
		ps =con.prepareStatement(sqlUpdate);
		ps.setString(1,usu.getNome());
		ps.setString(2, usu.getEmail());
		ps.setString(3, usu.getTipo());
		ps.setString(4, usu.getLogin());
		ps.setString(5, usu.getSenha());
		ps.setString(6, Integer.toString(usu.getCodigo()));
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
		con=DriverManager.getConnection(urlbanco,usuarioBanco,senhaBanco);
		String sqlDelete = "delete from usuarios where usuCod = ?;";
		
		ps =con.prepareStatement(sqlDelete);
		ps.setString(1, Integer.toString(usu.getCodigo()));
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
