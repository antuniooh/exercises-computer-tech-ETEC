namespace Win_Banco01_SQLSERVER
{
    partial class BancoDeDados_SQLServer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BancoDeDados_SQLServer));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ConsultaGeral = new System.Windows.Forms.TabPage();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ConsultaEspecífica = new System.Windows.Forms.TabPage();
            this.btnFechar2 = new System.Windows.Forms.Button();
            this.btnLimpar2 = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.CadatrarDados = new System.Windows.Forms.TabPage();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btncadastro = new System.Windows.Forms.Button();
            this.txtcodigoi = new System.Windows.Forms.TextBox();
            this.txtnomei = new System.Windows.Forms.TextBox();
            this.txtdesci = new System.Windows.Forms.TextBox();
            this.txtvalori = new System.Windows.Forms.TextBox();
            this.txtforncedori = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ModificarDados = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.fechar22 = new System.Windows.Forms.Button();
            this.btncacelar2 = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtforncedor2 = new System.Windows.Forms.TextBox();
            this.txtvalor2 = new System.Windows.Forms.TextBox();
            this.txtdesc2 = new System.Windows.Forms.TextBox();
            this.txtnome2 = new System.Windows.Forms.TextBox();
            this.txtcodigo2 = new System.Windows.Forms.TextBox();
            this.ExcluirDados = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtfornecedor3 = new System.Windows.Forms.TextBox();
            this.txtvalor3 = new System.Windows.Forms.TextBox();
            this.txtdesc3 = new System.Windows.Forms.TextBox();
            this.txtnome3 = new System.Windows.Forms.TextBox();
            this.txtcodigo3 = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btncancelar3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.ConsultaGeral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ConsultaEspecífica.SuspendLayout();
            this.CadatrarDados.SuspendLayout();
            this.ModificarDados.SuspendLayout();
            this.ExcluirDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ConsultaGeral);
            this.tabControl1.Controls.Add(this.ConsultaEspecífica);
            this.tabControl1.Controls.Add(this.CadatrarDados);
            this.tabControl1.Controls.Add(this.ModificarDados);
            this.tabControl1.Controls.Add(this.ExcluirDados);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 17);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(696, 292);
            this.tabControl1.TabIndex = 3;
            // 
            // ConsultaGeral
            // 
            this.ConsultaGeral.Controls.Add(this.btnFechar);
            this.ConsultaGeral.Controls.Add(this.btnLimpar);
            this.ConsultaGeral.Controls.Add(this.btnConsultar);
            this.ConsultaGeral.Controls.Add(this.dataGridView1);
            this.ConsultaGeral.Controls.Add(this.label2);
            this.ConsultaGeral.Controls.Add(this.label1);
            this.ConsultaGeral.Location = new System.Drawing.Point(4, 27);
            this.ConsultaGeral.Name = "ConsultaGeral";
            this.ConsultaGeral.Padding = new System.Windows.Forms.Padding(3);
            this.ConsultaGeral.Size = new System.Drawing.Size(688, 261);
            this.ConsultaGeral.TabIndex = 0;
            this.ConsultaGeral.Text = "Consulta Geral";
            this.ConsultaGeral.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnFechar.Location = new System.Drawing.Point(584, 214);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(101, 41);
            this.btnFechar.TabIndex = 12;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnLimpar.Location = new System.Drawing.Point(479, 214);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(101, 41);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnConsultar.Location = new System.Drawing.Point(372, 214);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(101, 41);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nomee,
            this.Descrição,
            this.Valor,
            this.Fornecedor});
            this.dataGridView1.Location = new System.Drawing.Point(3, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(663, 193);
            this.dataGridView1.TabIndex = 6;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 84;
            // 
            // Nomee
            // 
            this.Nomee.HeaderText = "Nome";
            this.Nomee.Name = "Nomee";
            this.Nomee.Width = 74;
            // 
            // Descrição
            // 
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            this.Descrição.Width = 104;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.Width = 68;
            // 
            // Fornecedor
            // 
            this.Fornecedor.HeaderText = "Fornecedor";
            this.Fornecedor.Name = "Fornecedor";
            this.Fornecedor.Width = 116;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 2;
            // 
            // ConsultaEspecífica
            // 
            this.ConsultaEspecífica.Controls.Add(this.btnFechar2);
            this.ConsultaEspecífica.Controls.Add(this.btnLimpar2);
            this.ConsultaEspecífica.Controls.Add(this.btnPesquisar);
            this.ConsultaEspecífica.Controls.Add(this.label7);
            this.ConsultaEspecífica.Controls.Add(this.label6);
            this.ConsultaEspecífica.Controls.Add(this.label5);
            this.ConsultaEspecífica.Controls.Add(this.label4);
            this.ConsultaEspecífica.Controls.Add(this.label3);
            this.ConsultaEspecífica.Controls.Add(this.txtFornecedor);
            this.ConsultaEspecífica.Controls.Add(this.txtValor);
            this.ConsultaEspecífica.Controls.Add(this.txtDescricao);
            this.ConsultaEspecífica.Controls.Add(this.txtProduto);
            this.ConsultaEspecífica.Controls.Add(this.txtCodigo);
            this.ConsultaEspecífica.Location = new System.Drawing.Point(4, 27);
            this.ConsultaEspecífica.Name = "ConsultaEspecífica";
            this.ConsultaEspecífica.Padding = new System.Windows.Forms.Padding(3);
            this.ConsultaEspecífica.Size = new System.Drawing.Size(688, 261);
            this.ConsultaEspecífica.TabIndex = 1;
            this.ConsultaEspecífica.Text = "Consulta Específica";
            this.ConsultaEspecífica.UseVisualStyleBackColor = true;
            // 
            // btnFechar2
            // 
            this.btnFechar2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnFechar2.Location = new System.Drawing.Point(496, 210);
            this.btnFechar2.Name = "btnFechar2";
            this.btnFechar2.Size = new System.Drawing.Size(101, 41);
            this.btnFechar2.TabIndex = 21;
            this.btnFechar2.Text = "&Fechar";
            this.btnFechar2.UseVisualStyleBackColor = true;
            this.btnFechar2.Click += new System.EventHandler(this.btnFechar2_Click);
            // 
            // btnLimpar2
            // 
            this.btnLimpar2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnLimpar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar2.Location = new System.Drawing.Point(389, 211);
            this.btnLimpar2.Name = "btnLimpar2";
            this.btnLimpar2.Size = new System.Drawing.Size(101, 41);
            this.btnLimpar2.TabIndex = 20;
            this.btnLimpar2.Text = "&Limpar";
            this.btnLimpar2.UseVisualStyleBackColor = true;
            this.btnLimpar2.Click += new System.EventHandler(this.btnLimpar2_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(282, 211);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(101, 41);
            this.btnPesquisar.TabIndex = 19;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Fornecedor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Valor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Descrição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Código";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(124, 159);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(76, 25);
            this.txtFornecedor.TabIndex = 13;
            // 
            // txtValor
            // 
            this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValor.Location = new System.Drawing.Point(124, 126);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(76, 25);
            this.txtValor.TabIndex = 12;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(124, 88);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(208, 25);
            this.txtDescricao.TabIndex = 11;
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(124, 53);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(208, 25);
            this.txtProduto.TabIndex = 10;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(124, 18);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(76, 25);
            this.txtCodigo.TabIndex = 8;
            // 
            // CadatrarDados
            // 
            this.CadatrarDados.Controls.Add(this.btncancel);
            this.CadatrarDados.Controls.Add(this.btnclose);
            this.CadatrarDados.Controls.Add(this.btncadastro);
            this.CadatrarDados.Controls.Add(this.txtcodigoi);
            this.CadatrarDados.Controls.Add(this.txtnomei);
            this.CadatrarDados.Controls.Add(this.txtdesci);
            this.CadatrarDados.Controls.Add(this.txtvalori);
            this.CadatrarDados.Controls.Add(this.txtforncedori);
            this.CadatrarDados.Controls.Add(this.label12);
            this.CadatrarDados.Controls.Add(this.label11);
            this.CadatrarDados.Controls.Add(this.label10);
            this.CadatrarDados.Controls.Add(this.label9);
            this.CadatrarDados.Controls.Add(this.label8);
            this.CadatrarDados.Location = new System.Drawing.Point(4, 27);
            this.CadatrarDados.Name = "CadatrarDados";
            this.CadatrarDados.Padding = new System.Windows.Forms.Padding(3);
            this.CadatrarDados.Size = new System.Drawing.Size(688, 261);
            this.CadatrarDados.TabIndex = 2;
            this.CadatrarDados.Text = "Cadastrar Dados";
            this.CadatrarDados.UseVisualStyleBackColor = true;
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(503, 212);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 43);
            this.btncancel.TabIndex = 11;
            this.btncancel.Text = "Limpar";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click_1);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(594, 212);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 42);
            this.btnclose.TabIndex = 10;
            this.btnclose.Text = "Fechar";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btncadastro
            // 
            this.btncadastro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastro.Location = new System.Drawing.Point(398, 212);
            this.btncadastro.Name = "btncadastro";
            this.btncadastro.Size = new System.Drawing.Size(87, 43);
            this.btncadastro.TabIndex = 6;
            this.btncadastro.Text = "Cadastrar";
            this.btncadastro.UseVisualStyleBackColor = true;
            this.btncadastro.Click += new System.EventHandler(this.btncadastro_Click);
            // 
            // txtcodigoi
            // 
            this.txtcodigoi.Location = new System.Drawing.Point(100, 25);
            this.txtcodigoi.Name = "txtcodigoi";
            this.txtcodigoi.Size = new System.Drawing.Size(100, 25);
            this.txtcodigoi.TabIndex = 9;
            // 
            // txtnomei
            // 
            this.txtnomei.Location = new System.Drawing.Point(100, 56);
            this.txtnomei.Name = "txtnomei";
            this.txtnomei.Size = new System.Drawing.Size(163, 25);
            this.txtnomei.TabIndex = 8;
            // 
            // txtdesci
            // 
            this.txtdesci.Location = new System.Drawing.Point(100, 92);
            this.txtdesci.Name = "txtdesci";
            this.txtdesci.Size = new System.Drawing.Size(163, 25);
            this.txtdesci.TabIndex = 7;
            // 
            // txtvalori
            // 
            this.txtvalori.Location = new System.Drawing.Point(100, 123);
            this.txtvalori.Name = "txtvalori";
            this.txtvalori.Size = new System.Drawing.Size(100, 25);
            this.txtvalori.TabIndex = 6;
            // 
            // txtforncedori
            // 
            this.txtforncedori.Location = new System.Drawing.Point(100, 154);
            this.txtforncedori.Name = "txtforncedori";
            this.txtforncedori.Size = new System.Drawing.Size(100, 25);
            this.txtforncedori.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 18);
            this.label12.TabIndex = 4;
            this.label12.Text = "Fornecedor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 18);
            this.label11.TabIndex = 3;
            this.label11.Text = "Valor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "Descrição";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "Nome";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Codigo";
            // 
            // ModificarDados
            // 
            this.ModificarDados.Controls.Add(this.button1);
            this.ModificarDados.Controls.Add(this.fechar22);
            this.ModificarDados.Controls.Add(this.btncacelar2);
            this.ModificarDados.Controls.Add(this.btnmodificar);
            this.ModificarDados.Controls.Add(this.label13);
            this.ModificarDados.Controls.Add(this.label14);
            this.ModificarDados.Controls.Add(this.label15);
            this.ModificarDados.Controls.Add(this.label16);
            this.ModificarDados.Controls.Add(this.label17);
            this.ModificarDados.Controls.Add(this.txtforncedor2);
            this.ModificarDados.Controls.Add(this.txtvalor2);
            this.ModificarDados.Controls.Add(this.txtdesc2);
            this.ModificarDados.Controls.Add(this.txtnome2);
            this.ModificarDados.Controls.Add(this.txtcodigo2);
            this.ModificarDados.Location = new System.Drawing.Point(4, 27);
            this.ModificarDados.Name = "ModificarDados";
            this.ModificarDados.Padding = new System.Windows.Forms.Padding(3);
            this.ModificarDados.Size = new System.Drawing.Size(688, 261);
            this.ModificarDados.TabIndex = 3;
            this.ModificarDados.Text = "Modificar Dados";
            this.ModificarDados.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(209, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 36);
            this.button1.TabIndex = 35;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fechar22
            // 
            this.fechar22.Font = new System.Drawing.Font("Arial", 9.75F);
            this.fechar22.Location = new System.Drawing.Point(489, 198);
            this.fechar22.Name = "fechar22";
            this.fechar22.Size = new System.Drawing.Size(101, 41);
            this.fechar22.TabIndex = 34;
            this.fechar22.Text = "&Fechar";
            this.fechar22.UseVisualStyleBackColor = true;
            this.fechar22.Click += new System.EventHandler(this.fechar22_Click);
            // 
            // btncacelar2
            // 
            this.btncacelar2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btncacelar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncacelar2.Location = new System.Drawing.Point(382, 199);
            this.btncacelar2.Name = "btncacelar2";
            this.btncacelar2.Size = new System.Drawing.Size(101, 41);
            this.btncacelar2.TabIndex = 33;
            this.btncacelar2.Text = "&Cancelar";
            this.btncacelar2.UseVisualStyleBackColor = true;
            this.btncacelar2.Click += new System.EventHandler(this.btncacelar2_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmodificar.Location = new System.Drawing.Point(275, 199);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(101, 41);
            this.btnmodificar.TabIndex = 32;
            this.btnmodificar.Text = "&Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 18);
            this.label13.TabIndex = 31;
            this.label13.Text = "Fornecedor";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 18);
            this.label14.TabIndex = 30;
            this.label14.Text = "Valor";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 18);
            this.label15.TabIndex = 29;
            this.label15.Text = "Descrição";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(26, 41);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 18);
            this.label16.TabIndex = 28;
            this.label16.Text = "Nome";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 7);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 18);
            this.label17.TabIndex = 27;
            this.label17.Text = "Código";
            // 
            // txtforncedor2
            // 
            this.txtforncedor2.Location = new System.Drawing.Point(117, 147);
            this.txtforncedor2.Name = "txtforncedor2";
            this.txtforncedor2.Size = new System.Drawing.Size(76, 25);
            this.txtforncedor2.TabIndex = 26;
            // 
            // txtvalor2
            // 
            this.txtvalor2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtvalor2.Location = new System.Drawing.Point(117, 114);
            this.txtvalor2.Name = "txtvalor2";
            this.txtvalor2.Size = new System.Drawing.Size(76, 25);
            this.txtvalor2.TabIndex = 25;
            // 
            // txtdesc2
            // 
            this.txtdesc2.Location = new System.Drawing.Point(117, 76);
            this.txtdesc2.Name = "txtdesc2";
            this.txtdesc2.Size = new System.Drawing.Size(208, 25);
            this.txtdesc2.TabIndex = 24;
            // 
            // txtnome2
            // 
            this.txtnome2.Location = new System.Drawing.Point(117, 41);
            this.txtnome2.Name = "txtnome2";
            this.txtnome2.Size = new System.Drawing.Size(208, 25);
            this.txtnome2.TabIndex = 23;
            // 
            // txtcodigo2
            // 
            this.txtcodigo2.Location = new System.Drawing.Point(117, 6);
            this.txtcodigo2.Name = "txtcodigo2";
            this.txtcodigo2.Size = new System.Drawing.Size(76, 25);
            this.txtcodigo2.TabIndex = 22;
            // 
            // ExcluirDados
            // 
            this.ExcluirDados.Controls.Add(this.btncancelar3);
            this.ExcluirDados.Controls.Add(this.button2);
            this.ExcluirDados.Controls.Add(this.button3);
            this.ExcluirDados.Controls.Add(this.btnexcluir);
            this.ExcluirDados.Controls.Add(this.label18);
            this.ExcluirDados.Controls.Add(this.label19);
            this.ExcluirDados.Controls.Add(this.label20);
            this.ExcluirDados.Controls.Add(this.label21);
            this.ExcluirDados.Controls.Add(this.label22);
            this.ExcluirDados.Controls.Add(this.txtfornecedor3);
            this.ExcluirDados.Controls.Add(this.txtvalor3);
            this.ExcluirDados.Controls.Add(this.txtdesc3);
            this.ExcluirDados.Controls.Add(this.txtnome3);
            this.ExcluirDados.Controls.Add(this.txtcodigo3);
            this.ExcluirDados.Location = new System.Drawing.Point(4, 27);
            this.ExcluirDados.Name = "ExcluirDados";
            this.ExcluirDados.Padding = new System.Windows.Forms.Padding(3);
            this.ExcluirDados.Size = new System.Drawing.Size(688, 261);
            this.ExcluirDados.TabIndex = 4;
            this.ExcluirDados.Text = "Excluir Dados";
            this.ExcluirDados.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(215, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 36);
            this.button2.TabIndex = 49;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.button3.Location = new System.Drawing.Point(495, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 41);
            this.button3.TabIndex = 48;
            this.button3.Text = "&Fechar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexcluir.Location = new System.Drawing.Point(281, 204);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(101, 41);
            this.btnexcluir.TabIndex = 46;
            this.btnexcluir.Text = "&Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(18, 153);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 18);
            this.label18.TabIndex = 45;
            this.label18.Text = "Fornecedor";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(18, 118);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 18);
            this.label19.TabIndex = 44;
            this.label19.Text = "Valor";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(18, 82);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 18);
            this.label20.TabIndex = 43;
            this.label20.Text = "Descrição";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(32, 46);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 18);
            this.label21.TabIndex = 42;
            this.label21.Text = "Nome";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(18, 12);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 18);
            this.label22.TabIndex = 41;
            this.label22.Text = "Código";
            // 
            // txtfornecedor3
            // 
            this.txtfornecedor3.Location = new System.Drawing.Point(123, 152);
            this.txtfornecedor3.Name = "txtfornecedor3";
            this.txtfornecedor3.Size = new System.Drawing.Size(76, 25);
            this.txtfornecedor3.TabIndex = 40;
            // 
            // txtvalor3
            // 
            this.txtvalor3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtvalor3.Location = new System.Drawing.Point(123, 119);
            this.txtvalor3.Name = "txtvalor3";
            this.txtvalor3.Size = new System.Drawing.Size(76, 25);
            this.txtvalor3.TabIndex = 39;
            // 
            // txtdesc3
            // 
            this.txtdesc3.Location = new System.Drawing.Point(123, 81);
            this.txtdesc3.Name = "txtdesc3";
            this.txtdesc3.Size = new System.Drawing.Size(208, 25);
            this.txtdesc3.TabIndex = 38;
            // 
            // txtnome3
            // 
            this.txtnome3.Location = new System.Drawing.Point(123, 46);
            this.txtnome3.Name = "txtnome3";
            this.txtnome3.Size = new System.Drawing.Size(208, 25);
            this.txtnome3.TabIndex = 37;
            // 
            // txtcodigo3
            // 
            this.txtcodigo3.Location = new System.Drawing.Point(123, 11);
            this.txtcodigo3.Name = "txtcodigo3";
            this.txtcodigo3.Size = new System.Drawing.Size(76, 25);
            this.txtcodigo3.TabIndex = 36;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 60;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.Width = 65;
            // 
            // btncancelar3
            // 
            this.btncancelar3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btncancelar3.Location = new System.Drawing.Point(388, 204);
            this.btncancelar3.Name = "btncancelar3";
            this.btncancelar3.Size = new System.Drawing.Size(101, 41);
            this.btncancelar3.TabIndex = 50;
            this.btncancelar3.Text = "&Fechar";
            this.btncancelar3.UseVisualStyleBackColor = true;
            this.btncancelar3.Click += new System.EventHandler(this.btncancelar3_Click);
            // 
            // BancoDeDados_SQLServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 324);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BancoDeDados_SQLServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco de Dados - SQL Server";
            this.Load += new System.EventHandler(this.BancoDeDados_SQLServer_Load);
            this.tabControl1.ResumeLayout(false);
            this.ConsultaGeral.ResumeLayout(false);
            this.ConsultaGeral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ConsultaEspecífica.ResumeLayout(false);
            this.ConsultaEspecífica.PerformLayout();
            this.CadatrarDados.ResumeLayout(false);
            this.CadatrarDados.PerformLayout();
            this.ModificarDados.ResumeLayout(false);
            this.ModificarDados.PerformLayout();
            this.ExcluirDados.ResumeLayout(false);
            this.ExcluirDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ConsultaGeral;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage ConsultaEspecífica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnFechar2;
        private System.Windows.Forms.Button btnLimpar2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fornecedor;
        private System.Windows.Forms.TabPage CadatrarDados;
        private System.Windows.Forms.TextBox txtcodigoi;
        private System.Windows.Forms.TextBox txtnomei;
        private System.Windows.Forms.TextBox txtdesci;
        private System.Windows.Forms.TextBox txtvalori;
        private System.Windows.Forms.TextBox txtforncedori;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btncadastro;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.TabPage ModificarDados;
        private System.Windows.Forms.Button fechar22;
        private System.Windows.Forms.Button btncacelar2;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtforncedor2;
        private System.Windows.Forms.TextBox txtvalor2;
        private System.Windows.Forms.TextBox txtdesc2;
        private System.Windows.Forms.TextBox txtnome2;
        private System.Windows.Forms.TextBox txtcodigo2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage ExcluirDados;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtfornecedor3;
        private System.Windows.Forms.TextBox txtvalor3;
        private System.Windows.Forms.TextBox txtdesc3;
        private System.Windows.Forms.TextBox txtnome3;
        private System.Windows.Forms.TextBox txtcodigo3;
        private System.Windows.Forms.Button btncancelar3;
    }
}

