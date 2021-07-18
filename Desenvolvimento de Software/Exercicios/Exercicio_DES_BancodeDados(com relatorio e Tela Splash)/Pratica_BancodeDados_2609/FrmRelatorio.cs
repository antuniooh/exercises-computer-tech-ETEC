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
    public partial class FrmRelatorio : Form
    {
        #region Declaração de Componentes
        DataSet ds = new DataSet();
        SqlDataAdapter dt = new SqlDataAdapter();
        SqlConnection ocon = new SqlConnection();
        string sql, con;
        #endregion
        #region Método Construtor da Classe
        public FrmRelatorio()
        {
            InitializeComponent();
        }
        #endregion

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {
            try
            {
                this.con =// @"Data Source = LAB2653 - 02\SQLEXPRESS;Initial catalog=Cadastro;Intregarated Security=true";
                this.con = Properties.Settings.Default.ConexãoSQLServer;
                this.ocon = new SqlConnection(this.con);
                this.sql = "Select * from Cadastro";
                this.dt = new SqlDataAdapter(this.sql, this.ocon);
                this.dt.Fill(this.ds, "Cadastro");
                DataTable1BindingSource.DataSource = this.ds;
                DataTable1BindingSource.DataMember = "Cadastro";
                this.reportViewer1.RefreshReport();

            }
            catch (SqlException erro)
            {
                MessageBox.Show("Erro --> " + erro.Message, "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataTable1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
