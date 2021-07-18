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
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CadastrarDados = new System.Windows.Forms.TabPage();
            this.ModificarDados = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFornecedor1 = new System.Windows.Forms.TextBox();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtDescricao1 = new System.Windows.Forms.TextBox();
            this.txtProduto1 = new System.Windows.Forms.TextBox();
            this.txtCodigo1 = new System.Windows.Forms.TextBox();
            this.btnFechar3 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnFechar1 = new System.Windows.Forms.Button();
            this.btnCancelar1 = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtFornecedor2 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.txtDescricao2 = new System.Windows.Forms.TextBox();
            this.txtProduto2 = new System.Windows.Forms.TextBox();
            this.txtCodigo2 = new System.Windows.Forms.TextBox();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.ConsultaGeral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ConsultaEspecífica.SuspendLayout();
            this.CadastrarDados.SuspendLayout();
            this.ModificarDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ConsultaGeral);
            this.tabControl1.Controls.Add(this.ConsultaEspecífica);
            this.tabControl1.Controls.Add(this.CadastrarDados);
            this.tabControl1.Controls.Add(this.ModificarDados);
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
            this.btnFechar2.Location = new System.Drawing.Point(581, 214);
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
            this.btnLimpar2.Location = new System.Drawing.Point(474, 215);
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
            this.btnPesquisar.Location = new System.Drawing.Point(367, 215);
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
            this.label7.Location = new System.Drawing.Point(6, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Fornecedor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Valor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Descrição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Código";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(111, 172);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(76, 25);
            this.txtFornecedor.TabIndex = 13;
            // 
            // txtValor
            // 
            this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValor.Location = new System.Drawing.Point(111, 139);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(76, 25);
            this.txtValor.TabIndex = 12;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(111, 101);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(208, 25);
            this.txtDescricao.TabIndex = 11;
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(111, 66);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(208, 25);
            this.txtProduto.TabIndex = 10;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(111, 31);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(76, 25);
            this.txtCodigo.TabIndex = 8;
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
            // CadastrarDados
            // 
            this.CadastrarDados.Controls.Add(this.btnFechar3);
            this.CadastrarDados.Controls.Add(this.btnCancelar);
            this.CadastrarDados.Controls.Add(this.btnCadastrar);
            this.CadastrarDados.Controls.Add(this.label8);
            this.CadastrarDados.Controls.Add(this.label9);
            this.CadastrarDados.Controls.Add(this.label10);
            this.CadastrarDados.Controls.Add(this.label11);
            this.CadastrarDados.Controls.Add(this.label12);
            this.CadastrarDados.Controls.Add(this.txtFornecedor1);
            this.CadastrarDados.Controls.Add(this.txtValor1);
            this.CadastrarDados.Controls.Add(this.txtDescricao1);
            this.CadastrarDados.Controls.Add(this.txtProduto1);
            this.CadastrarDados.Controls.Add(this.txtCodigo1);
            this.CadastrarDados.Location = new System.Drawing.Point(4, 27);
            this.CadastrarDados.Name = "CadastrarDados";
            this.CadastrarDados.Padding = new System.Windows.Forms.Padding(3);
            this.CadastrarDados.Size = new System.Drawing.Size(688, 261);
            this.CadastrarDados.TabIndex = 2;
            this.CadastrarDados.Text = "Cadastrar Dados";
            this.CadastrarDados.UseVisualStyleBackColor = true;
            // 
            // ModificarDados
            // 
            this.ModificarDados.Controls.Add(this.btnLocalizar);
            this.ModificarDados.Controls.Add(this.btnFechar1);
            this.ModificarDados.Controls.Add(this.btnCancelar1);
            this.ModificarDados.Controls.Add(this.btnModificar);
            this.ModificarDados.Controls.Add(this.label13);
            this.ModificarDados.Controls.Add(this.label14);
            this.ModificarDados.Controls.Add(this.label15);
            this.ModificarDados.Controls.Add(this.label16);
            this.ModificarDados.Controls.Add(this.label17);
            this.ModificarDados.Controls.Add(this.txtFornecedor2);
            this.ModificarDados.Controls.Add(this.txtValor2);
            this.ModificarDados.Controls.Add(this.txtDescricao2);
            this.ModificarDados.Controls.Add(this.txtProduto2);
            this.ModificarDados.Controls.Add(this.txtCodigo2);
            this.ModificarDados.Location = new System.Drawing.Point(4, 27);
            this.ModificarDados.Name = "ModificarDados";
            this.ModificarDados.Padding = new System.Windows.Forms.Padding(3);
            this.ModificarDados.Size = new System.Drawing.Size(688, 261);
            this.ModificarDados.TabIndex = 3;
            this.ModificarDados.Text = "Modificar Dados";
            this.ModificarDados.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 18);
            this.label8.TabIndex = 28;
            this.label8.Text = "Fornecedor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 18);
            this.label9.TabIndex = 27;
            this.label9.Text = "Valor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 18);
            this.label10.TabIndex = 26;
            this.label10.Text = "Descrição";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 18);
            this.label11.TabIndex = 25;
            this.label11.Text = "Produto";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 18);
            this.label12.TabIndex = 24;
            this.label12.Text = "Código";
            // 
            // txtFornecedor1
            // 
            this.txtFornecedor1.Location = new System.Drawing.Point(111, 175);
            this.txtFornecedor1.Name = "txtFornecedor1";
            this.txtFornecedor1.Size = new System.Drawing.Size(76, 25);
            this.txtFornecedor1.TabIndex = 23;
            // 
            // txtValor1
            // 
            this.txtValor1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValor1.Location = new System.Drawing.Point(111, 142);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(76, 25);
            this.txtValor1.TabIndex = 22;
            // 
            // txtDescricao1
            // 
            this.txtDescricao1.Location = new System.Drawing.Point(111, 104);
            this.txtDescricao1.Name = "txtDescricao1";
            this.txtDescricao1.Size = new System.Drawing.Size(208, 25);
            this.txtDescricao1.TabIndex = 21;
            // 
            // txtProduto1
            // 
            this.txtProduto1.Location = new System.Drawing.Point(111, 69);
            this.txtProduto1.Name = "txtProduto1";
            this.txtProduto1.Size = new System.Drawing.Size(208, 25);
            this.txtProduto1.TabIndex = 20;
            // 
            // txtCodigo1
            // 
            this.txtCodigo1.Location = new System.Drawing.Point(111, 34);
            this.txtCodigo1.Name = "txtCodigo1";
            this.txtCodigo1.Size = new System.Drawing.Size(76, 25);
            this.txtCodigo1.TabIndex = 19;
            // 
            // btnFechar3
            // 
            this.btnFechar3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnFechar3.Location = new System.Drawing.Point(581, 214);
            this.btnFechar3.Name = "btnFechar3";
            this.btnFechar3.Size = new System.Drawing.Size(101, 41);
            this.btnFechar3.TabIndex = 31;
            this.btnFechar3.Text = "&Fechar";
            this.btnFechar3.UseVisualStyleBackColor = true;
            this.btnFechar3.Click += new System.EventHandler(this.btnFechar3_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(474, 215);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 41);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(367, 215);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(101, 41);
            this.btnCadastrar.TabIndex = 29;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnFechar1
            // 
            this.btnFechar1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnFechar1.Location = new System.Drawing.Point(581, 210);
            this.btnFechar1.Name = "btnFechar1";
            this.btnFechar1.Size = new System.Drawing.Size(101, 41);
            this.btnFechar1.TabIndex = 44;
            this.btnFechar1.Text = "&Fechar";
            this.btnFechar1.UseVisualStyleBackColor = true;
            this.btnFechar1.Click += new System.EventHandler(this.btnFechar1_Click);
            // 
            // btnCancelar1
            // 
            this.btnCancelar1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnCancelar1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar1.Location = new System.Drawing.Point(474, 211);
            this.btnCancelar1.Name = "btnCancelar1";
            this.btnCancelar1.Size = new System.Drawing.Size(101, 41);
            this.btnCancelar1.TabIndex = 43;
            this.btnCancelar1.Text = "&Cancelar";
            this.btnCancelar1.UseVisualStyleBackColor = true;
            this.btnCancelar1.Click += new System.EventHandler(this.btnCancelar1_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(367, 211);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(101, 41);
            this.btnModificar.TabIndex = 42;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 18);
            this.label13.TabIndex = 41;
            this.label13.Text = "Fornecedor";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 142);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 18);
            this.label14.TabIndex = 40;
            this.label14.Text = "Valor";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 106);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 18);
            this.label15.TabIndex = 39;
            this.label15.Text = "Descrição";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 71);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 18);
            this.label16.TabIndex = 38;
            this.label16.Text = "Produto";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 18);
            this.label17.TabIndex = 37;
            this.label17.Text = "Código";
            // 
            // txtFornecedor2
            // 
            this.txtFornecedor2.Location = new System.Drawing.Point(111, 176);
            this.txtFornecedor2.Name = "txtFornecedor2";
            this.txtFornecedor2.Size = new System.Drawing.Size(76, 25);
            this.txtFornecedor2.TabIndex = 36;
            // 
            // txtValor2
            // 
            this.txtValor2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValor2.Location = new System.Drawing.Point(111, 143);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(76, 25);
            this.txtValor2.TabIndex = 35;
            // 
            // txtDescricao2
            // 
            this.txtDescricao2.Location = new System.Drawing.Point(111, 105);
            this.txtDescricao2.Name = "txtDescricao2";
            this.txtDescricao2.Size = new System.Drawing.Size(208, 25);
            this.txtDescricao2.TabIndex = 34;
            // 
            // txtProduto2
            // 
            this.txtProduto2.Location = new System.Drawing.Point(111, 70);
            this.txtProduto2.Name = "txtProduto2";
            this.txtProduto2.Size = new System.Drawing.Size(208, 25);
            this.txtProduto2.TabIndex = 33;
            // 
            // txtCodigo2
            // 
            this.txtCodigo2.Location = new System.Drawing.Point(111, 35);
            this.txtCodigo2.Name = "txtCodigo2";
            this.txtCodigo2.Size = new System.Drawing.Size(76, 25);
            this.txtCodigo2.TabIndex = 32;
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizar.Image = global::Win_Banco01_SQLSERVER.Properties.Resources._225;
            this.btnLocalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalizar.Location = new System.Drawing.Point(193, 6);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(61, 59);
            this.btnLocalizar.TabIndex = 45;
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // BancoDeDados_SQLServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 320);
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
            this.CadastrarDados.ResumeLayout(false);
            this.CadastrarDados.PerformLayout();
            this.ModificarDados.ResumeLayout(false);
            this.ModificarDados.PerformLayout();
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
        private System.Windows.Forms.TabPage CadastrarDados;
        private System.Windows.Forms.Button btnFechar3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFornecedor1;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtDescricao1;
        private System.Windows.Forms.TextBox txtProduto1;
        private System.Windows.Forms.TextBox txtCodigo1;
        private System.Windows.Forms.TabPage ModificarDados;
        private System.Windows.Forms.Button btnFechar1;
        private System.Windows.Forms.Button btnCancelar1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtFornecedor2;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.TextBox txtDescricao2;
        private System.Windows.Forms.TextBox txtProduto2;
        private System.Windows.Forms.TextBox txtCodigo2;
        private System.Windows.Forms.Button btnLocalizar;
    }
}

