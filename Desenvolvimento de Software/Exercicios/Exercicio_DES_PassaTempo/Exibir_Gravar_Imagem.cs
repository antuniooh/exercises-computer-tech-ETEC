using System;
using System.Collections.Generic; // SÃO CLASSES
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Data.SqlClient; // manipular base de dados

namespace Passa_Tempo_DES
{
    public partial class Exibir_Gravar_Imagem : Form
    {
        SqlConnection ocon = new SqlConnection
         (@"Data Source = LAB2653-03\SQLEXPRESS;Initial Catalog=BDDImagem;Integrated Security=True;Pooling=false");
        SqlCommand comando = new SqlCommand();

        public Exibir_Gravar_Imagem()
        {
            InitializeComponent();
        }

        private void btnExibirSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (caixaDialogo.ShowDialog() == DialogResult.OK)
                {
                   
                   
                    //exibir a imagem

                    string NomeArquivo = caixaDialogo.FileName;
                    Bitmap bmp = new Bitmap(NomeArquivo);
                    pcbImagem.Image = bmp;

                    MemoryStream ms = new MemoryStream();
                    bmp.Save(ms, ImageFormat.Bmp);
                    byte[] foto = ms.ToArray();

                    //salvar a imagem

                    comando = new SqlCommand("Insert into Imagem(Imagem) values(@foto)", ocon);
                    SqlParameter paramFoto = new SqlParameter("@foto", SqlDbType.Binary);
                    paramFoto.Value = foto;

                    comando.Parameters.Add(paramFoto);

                    ocon.Open();
                    comando.ExecuteNonQuery();
                    ocon.Close();

                    MessageBox.Show("Cadastro Realizado com Sucesso!!!", "*** CADASTRO ***",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro => " + erro.Message,
                    "*** ADO.NET ***",
                    MessageBoxButtons.OK);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            try
            {
                //recuperar
                comando = new SqlCommand("Select Imagem from Imagem where ID=" + txtID.Text, ocon);
                ocon.Open();

                SqlDataReader reader = comando.ExecuteReader();
                Image imagem = null;

                if (reader.Read())
                {
                    byte[] foto = (byte[])reader["Imagem"];
                    MemoryStream ms = new MemoryStream(foto);
                    imagem = Image.FromStream(ms);
                }
                pcbImagem.Image = imagem;

                ocon.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
            }
        }


    }
}
