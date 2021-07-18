using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Exercicio_DES_XML
{
    public partial class Form1 : Form
    {
        String caminho = AppDomain.CurrentDomain.BaseDirectory;

        public Form1()
        {
            InitializeComponent();
        }
        public static string CaminhoDadosXML(string caminho)
        {
            if (caminho.IndexOf("\\bin\\Debug") != 0)
            {
                caminho = caminho.Replace("\\bin\\Debug", "");
            }
            return caminho;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;
        }

        private static readonly Random getrandom = new Random();
        private static readonly object syncLock = new object();

        public static int GetRandomNumber(int min, int max)
        {
            lock (syncLock)
            {// sincroniza
                return getrandom.Next(min, max);
            }
        }

        void LimparTextBox(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    LimparTextBox(c);
            }
            lbProdutos.Items.Clear();
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparTextBox(this);
            btnSalvar.Enabled = true;
            txtCodigo.Text = Convert.ToString(GetRandomNumber(1, 9999));
            txtNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                using (DataSet dsResultado = new DataSet())
                {
                    dsResultado.ReadXml(CaminhoDadosXML(caminho) + @"Dados\Produtos.xml");
                    if (dsResultado.Tables.Count == 0)
                    {
                        // cria uma instancia do produto e atribui valores as propriedades
                        Produto oProduto = new Produto();
                        oProduto.Codigo = Convert.ToInt32(txtCodigo.Text);
                        oProduto.Nome = txtNome.Text;
                        oProduto.Preco = Convert.ToDecimal(txtPreco.Text);
                        oProduto.Estoque = Convert.ToInt32(txtEstoque.Text);
                        oProduto.Descricao = txtDescricao.Text;

                        XmlTextWriter writer = new XmlTextWriter(CaminhoDadosXML(caminho) + @"Dados\Produtos.xml", System.Text.Encoding.UTF8);
                        writer.WriteStartDocument(true);
                        writer.Formatting = Formatting.Indented;
                        writer.Indentation = 2;
                        writer.WriteStartElement("Produtos");
                        writer.WriteStartElement("Produto");
                        writer.WriteStartElement("Codigo");
                        writer.WriteString(oProduto.Codigo.ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("Nome");
                        writer.WriteString(oProduto.Nome);
                        writer.WriteEndElement();
                        writer.WriteStartElement("Preco");
                        writer.WriteString(oProduto.Preco.ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("Estoque");
                        writer.WriteString(oProduto.Estoque.ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("Descricao");
                        writer.WriteString(oProduto.Descricao);
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        writer.WriteEndDocument();
                        writer.Close();
                        dsResultado.ReadXml(CaminhoDadosXML(caminho) + @"Dados\Produtos.xml");
                    }
                    else
                    {
                        //inclui os dados no dataset

                        dsResultado.Tables[0].Rows.Add(dsResultado.Tables[0].NewRow());
                        dsResultado.Tables[0].Rows[dsResultado.Tables[0].Rows.Count - 1]["Codigo"] = txtCodigo.Text;
                        dsResultado.Tables[0].Rows[dsResultado.Tables[0].Rows.Count - 1]["Nome"] = txtNome.Text;
                        dsResultado.Tables[0].Rows[dsResultado.Tables[0].Rows.Count - 1]["Preco"] = txtPreco.Text;
                        dsResultado.Tables[0].Rows[dsResultado.Tables[0].Rows.Count - 1]["Estoque"] = txtEstoque.Text;
                        dsResultado.Tables[0].Rows[dsResultado.Tables[0].Rows.Count - 1]["Descricao"] = txtDescricao.Text;
                        dsResultado.AcceptChanges();
                        // -- Escreve para o arquivo XML final usando o metodo write
                        dsResultado.WriteXml(CaminhoDadosXML(caminho) + @"Dados\Produtos.xml",
                        XmlWriteMode.IgnoreSchema);
                    }
                    // exibe os dadios no datagridview
                    dgvDados.DataSource = dsResultado.Tables[0];
                    MessageBox.Show("dados salvos com sucesso");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            GetDados();
        }
        public void GetDados()
        {
            try
            {
                DataSet dsResultado = new DataSet();
                dsResultado.WriteXml(CaminhoDadosXML(caminho) + @"Dados\Produtos.xml");
                if(dsResultado.Tables[0].Rows.Count > 0)
                {
                    dgvDados.DataSource = dsResultado.Tables[0];
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void btnListarProdutos_Click(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load((CaminhoDadosXML(caminho) + @"Dados\Produtos.xml"));
            var prods = from p in doc.Descendants("Produto")
                        select new
                        {
                            NomeProduto = p.Element("Nome").Value,
                            PrecoProduto = p.Element()
                        }
        }
    }
}
