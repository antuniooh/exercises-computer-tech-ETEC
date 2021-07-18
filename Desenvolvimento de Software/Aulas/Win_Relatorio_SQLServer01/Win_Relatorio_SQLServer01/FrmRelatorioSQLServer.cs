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

namespace Win_Relatorio_SQLServer01
{
    public partial class FrmRelatorioSQLServer : Form
    {
        #region Declaração de Componentes
        DataSet ds = new DataSet();
        SqlDataAdapter dt = new SqlDataAdapter();
        SqlConnection ocon = new SqlConnection();
        string sql, con;
        #endregion
        #region Método Construtor da Classe
        public FrmRelatorioSQLServer()
        {
            InitializeComponent();
        }
        #endregion
        private void FrmRelatorioSQLServer_Load(object sender, EventArgs e)
        {
            try
            {
                this.con =// @"Data Source = LAB2653 - 02\SQLEXPRESS;Initial catalog=Produtos;Intregarated Security=true";
                this.con = Properties.Settings.Default.ConexaoSQL;
                this.ocon = new SqlConnection(this.con);
                this.sql = "Select * from Produtos";
                this.dt = new SqlDataAdapter(this.sql, this.ocon);
                this.dt.Fill(this.ds, "Produtos");
                DataTable1BindingSource.DataSource = this.ds;
                DataTable1BindingSource.DataMember = "Produtos";
                this.reportViewer1.RefreshReport();

            }
            catch (SqlException erro)
            {
                MessageBox.Show("Erro --> " + erro.Message, "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
