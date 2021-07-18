using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pratica_BancodeDados_2609
{
    public partial class FrmConsulta : Form
    {
        private SqlConnection objCnx = new SqlConnection();
        private SqlCommand objCmd = new SqlCommand();
        private SqlDataReader objDados;

        public FrmConsulta()
        {
            InitializeComponent();
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            try
            {
                /* objCnx.ConnectionString = @"Data Source = LAB2653-03\SQLEXPRESS;Initial Catalog=Cadastro;Integrated
                 Security=True";*/
                objCnx.ConnectionString = Properties.Settings.Default.ConexãoSQLServer;
                objCnx.Open();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erroooooo ==> " + erro.Message, " ADO.NET ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string strSql = "Select * from Cadastro";
            objCmd.CommandText = strSql;
            objCmd.Connection = objCnx;
            objDados = objCmd.ExecuteReader();

            if (objDados.HasRows)
            {
                while (objDados.Read())
                {
                    dataGridView1.Rows.Add(
                    objDados["Codigo"].ToString(),
                    objDados["Nome"].ToString(),
                    objDados["RG"].ToString(),
                    objDados["CPF"].ToString(),
                    objDados["Telefone"].ToString(),
                    objDados["Sexo"].ToString(),
                    objDados["CEP"].ToString(),
                    objDados["Número"].ToString(),
                    objDados["Logradouro"].ToString(),
                    objDados["Bairro"].ToString(),
                    objDados["Cidade"].ToString(),
                    objDados["Email"].ToString(),
                    objDados["Facebook"].ToString(),
                    objDados["Twitter"].ToString());
                }
                objDados.Close();
            }
            else
            {
                MessageBox.Show("Código Não Encontrado!", "Consulta Geral", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
