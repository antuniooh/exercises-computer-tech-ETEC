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
        private SqlConnection objCnx = new SqlConnection();
        private SqlCommand objCmd = new SqlCommand();
        private SqlDataReader objDados;
        
        private DataSet ds = new DataSet();
        private SqlDataAdapter dt = new SqlDataAdapter();
        string strql, con;

        public FrmRelatorio()
        {
            InitializeComponent();
        }
      
        private void FrmRelatorio_Load(object sender, EventArgs e)
        {
            this.con = @"Data Source = LAB2653-03\SQLEXPRESS;Initial Catalog=Cadastro;Integrated Security=True";
            this.objCnx = new SqlConnection(this.con);
            this.strql = "Select * from Cadastro";
            this.dt = new SqlDataAdapter(this.strql, this.objCnx);
            this.dt.Fill(this.ds, "Cadastro");
            DataTable1BindingSource.DataSource = this.ds;
            DataTable1BindingSource.DataSource = "Cadastro";
            this.reportViewer1.RefreshReport();
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
    }
}
