namespace Exercicio15._08._17
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtmed = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtconc = new System.Windows.Forms.TextBox();
            this.txtnota2 = new System.Windows.Forms.TextBox();
            this.txtnota = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.btnfechar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnfoto = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblmed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnfechar2 = new System.Windows.Forms.Button();
            this.btnlimp = new System.Windows.Forms.Button();
            this.btnremov = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.Número = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Média = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Conceito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagem = new System.Windows.Forms.DataGridViewImageColumn();
            this.caixadialogo = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(779, 335);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.txtmed);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.txtconc);
            this.tabPage1.Controls.Add(this.txtnota2);
            this.tabPage1.Controls.Add(this.txtnota);
            this.tabPage1.Controls.Add(this.txtnome);
            this.tabPage1.Controls.Add(this.txtnumero);
            this.tabPage1.Controls.Add(this.btnfechar);
            this.tabPage1.Controls.Add(this.btncancelar);
            this.tabPage1.Controls.Add(this.btnincluir);
            this.tabPage1.Controls.Add(this.btncalcular);
            this.tabPage1.Controls.Add(this.btnfoto);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.lblmed);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(771, 309);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro de Aluno";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtmed
            // 
            this.txtmed.Location = new System.Drawing.Point(67, 162);
            this.txtmed.Name = "txtmed";
            this.txtmed.Size = new System.Drawing.Size(100, 20);
            this.txtmed.TabIndex = 36;
            this.txtmed.TextChanged += new System.EventHandler(this.txtmed_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(620, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 136);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // txtconc
            // 
            this.txtconc.Location = new System.Drawing.Point(67, 198);
            this.txtconc.Name = "txtconc";
            this.txtconc.Size = new System.Drawing.Size(309, 20);
            this.txtconc.TabIndex = 34;
            // 
            // txtnota2
            // 
            this.txtnota2.Location = new System.Drawing.Point(67, 130);
            this.txtnota2.Name = "txtnota2";
            this.txtnota2.Size = new System.Drawing.Size(100, 20);
            this.txtnota2.TabIndex = 32;
            this.txtnota2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnota2_KeyPress);
            // 
            // txtnota
            // 
            this.txtnota.Location = new System.Drawing.Point(67, 93);
            this.txtnota.Name = "txtnota";
            this.txtnota.Size = new System.Drawing.Size(100, 20);
            this.txtnota.TabIndex = 31;
            this.txtnota.TextChanged += new System.EventHandler(this.txtnota_TextChanged);
            this.txtnota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnota_KeyPress);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(67, 57);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(309, 20);
            this.txtnome.TabIndex = 30;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            this.txtnome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnome_KeyPress);
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(67, 20);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 20);
            this.txtnumero.TabIndex = 29;
            this.txtnumero.TextChanged += new System.EventHandler(this.txtnum_TextChanged);
            this.txtnumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnum_KeyPress);
            // 
            // btnfechar
            // 
            this.btnfechar.Image = ((System.Drawing.Image)(resources.GetObject("btnfechar.Image")));
            this.btnfechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfechar.Location = new System.Drawing.Point(620, 247);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(123, 48);
            this.btnfechar.TabIndex = 28;
            this.btnfechar.Text = "Fechar";
            this.btnfechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(476, 247);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(123, 48);
            this.btncancelar.TabIndex = 27;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Image = ((System.Drawing.Image)(resources.GetObject("btnincluir.Image")));
            this.btnincluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnincluir.Location = new System.Drawing.Point(321, 250);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(123, 46);
            this.btnincluir.TabIndex = 26;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.Image = ((System.Drawing.Image)(resources.GetObject("btncalcular.Image")));
            this.btncalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncalcular.Location = new System.Drawing.Point(171, 250);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(123, 44);
            this.btncalcular.TabIndex = 25;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnfoto
            // 
            this.btnfoto.Image = ((System.Drawing.Image)(resources.GetObject("btnfoto.Image")));
            this.btnfoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfoto.Location = new System.Drawing.Point(620, 165);
            this.btnfoto.Name = "btnfoto";
            this.btnfoto.Size = new System.Drawing.Size(123, 53);
            this.btnfoto.TabIndex = 24;
            this.btnfoto.Text = "Foto";
            this.btnfoto.UseVisualStyleBackColor = true;
            this.btnfoto.Click += new System.EventHandler(this.btnfoto_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Conceito";
            // 
            // lblmed
            // 
            this.lblmed.AutoSize = true;
            this.lblmed.Location = new System.Drawing.Point(18, 165);
            this.lblmed.Name = "lblmed";
            this.lblmed.Size = new System.Drawing.Size(36, 13);
            this.lblmed.TabIndex = 22;
            this.lblmed.Text = "Média";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "2ª Nota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "1ª Nota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Número";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnfechar2);
            this.tabPage2.Controls.Add(this.btnlimp);
            this.tabPage2.Controls.Add(this.btnremov);
            this.tabPage2.Controls.Add(this.dgv1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(771, 309);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar Dados do Aluno";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnfechar2
            // 
            this.btnfechar2.Image = ((System.Drawing.Image)(resources.GetObject("btnfechar2.Image")));
            this.btnfechar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfechar2.Location = new System.Drawing.Point(646, 246);
            this.btnfechar2.Name = "btnfechar2";
            this.btnfechar2.Size = new System.Drawing.Size(122, 47);
            this.btnfechar2.TabIndex = 3;
            this.btnfechar2.Text = "Fechar";
            this.btnfechar2.UseVisualStyleBackColor = true;
            this.btnfechar2.Click += new System.EventHandler(this.btnfechar2_Click);
            // 
            // btnlimp
            // 
            this.btnlimp.Image = ((System.Drawing.Image)(resources.GetObject("btnlimp.Image")));
            this.btnlimp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlimp.Location = new System.Drawing.Point(507, 246);
            this.btnlimp.Name = "btnlimp";
            this.btnlimp.Size = new System.Drawing.Size(122, 47);
            this.btnlimp.TabIndex = 2;
            this.btnlimp.Text = "Limpar";
            this.btnlimp.UseVisualStyleBackColor = true;
            this.btnlimp.Click += new System.EventHandler(this.btnlimp_Click);
            // 
            // btnremov
            // 
            this.btnremov.Image = ((System.Drawing.Image)(resources.GetObject("btnremov.Image")));
            this.btnremov.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnremov.Location = new System.Drawing.Point(369, 246);
            this.btnremov.Name = "btnremov";
            this.btnremov.Size = new System.Drawing.Size(122, 47);
            this.btnremov.TabIndex = 1;
            this.btnremov.Text = "Remover";
            this.btnremov.UseVisualStyleBackColor = true;
            this.btnremov.Click += new System.EventHandler(this.btnremov_Click);
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Número,
            this.Nome,
            this.Nota1,
            this.Nota2,
            this.Média,
            this.Conceito,
            this.Imagem});
            this.dgv1.Location = new System.Drawing.Point(8, 0);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(766, 225);
            this.dgv1.TabIndex = 0;
            // 
            // Número
            // 
            this.Número.HeaderText = "Número";
            this.Número.Name = "Número";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Nota1
            // 
            this.Nota1.HeaderText = "1ª Nota";
            this.Nota1.Name = "Nota1";
            // 
            // Nota2
            // 
            this.Nota2.HeaderText = "2ª Nota";
            this.Nota2.Name = "Nota2";
            // 
            // Média
            // 
            this.Média.HeaderText = "Média";
            this.Média.Name = "Média";
            // 
            // Conceito
            // 
            this.Conceito.HeaderText = "Conceito";
            this.Conceito.Name = "Conceito";
            // 
            // Imagem
            // 
            this.Imagem.HeaderText = "Imagem";
            this.Imagem.Name = "Imagem";
            this.Imagem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Imagem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // caixadialogo
            // 
            this.caixadialogo.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Form1_Load);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(779, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 4;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 338);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(786, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 363);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Aula15.08";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtconc;
        private System.Windows.Forms.TextBox txtnota2;
        private System.Windows.Forms.TextBox txtnota;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnfoto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblmed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtmed;
        private System.Windows.Forms.Button btnfechar2;
        private System.Windows.Forms.Button btnlimp;
        private System.Windows.Forms.Button btnremov;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.OpenFileDialog caixadialogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Número;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Média;
        private System.Windows.Forms.DataGridViewTextBoxColumn Conceito;
        private System.Windows.Forms.DataGridViewImageColumn Imagem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}

