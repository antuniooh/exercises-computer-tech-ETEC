namespace ProjetoBetaPizzaria_v1._0_260517
{
    partial class FrmFornecedor
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.grbForn = new System.Windows.Forms.GroupBox();
            this.txtFone_Forn = new System.Windows.Forms.MaskedTextBox();
            this.cbStatus_Forn = new System.Windows.Forms.ComboBox();
            this.txtEnd_Forn = new System.Windows.Forms.TextBox();
            this.txtCNPJ_Forn = new System.Windows.Forms.MaskedTextBox();
            this.btnlocalizar = new System.Windows.Forms.Button();
            this.txtRazao_Forn = new System.Windows.Forms.TextBox();
            this.txtCod_Forn = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCont_Forn = new System.Windows.Forms.TextBox();
            this.grbForn.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(387, 292);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(265, 292);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(150, 292);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(18, 292);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(-144, 253);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(75, 23);
            this.btnincluir.TabIndex = 7;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            // 
            // grbForn
            // 
            this.grbForn.Controls.Add(this.txtCont_Forn);
            this.grbForn.Controls.Add(this.txtFone_Forn);
            this.grbForn.Controls.Add(this.cbStatus_Forn);
            this.grbForn.Controls.Add(this.txtEnd_Forn);
            this.grbForn.Controls.Add(this.txtCNPJ_Forn);
            this.grbForn.Controls.Add(this.btnlocalizar);
            this.grbForn.Controls.Add(this.txtRazao_Forn);
            this.grbForn.Controls.Add(this.txtCod_Forn);
            this.grbForn.Controls.Add(this.label10);
            this.grbForn.Controls.Add(this.label9);
            this.grbForn.Controls.Add(this.label8);
            this.grbForn.Controls.Add(this.label5);
            this.grbForn.Controls.Add(this.label4);
            this.grbForn.Controls.Add(this.label3);
            this.grbForn.Controls.Add(this.label1);
            this.grbForn.Location = new System.Drawing.Point(12, 23);
            this.grbForn.Name = "grbForn";
            this.grbForn.Size = new System.Drawing.Size(450, 263);
            this.grbForn.TabIndex = 6;
            this.grbForn.TabStop = false;
            this.grbForn.Text = "Dados do Fornecedor";
            // 
            // txtFone_Forn
            // 
            this.txtFone_Forn.Location = new System.Drawing.Point(274, 109);
            this.txtFone_Forn.Mask = "(00)0-0000-0000";
            this.txtFone_Forn.Name = "txtFone_Forn";
            this.txtFone_Forn.Size = new System.Drawing.Size(124, 20);
            this.txtFone_Forn.TabIndex = 20;
            // 
            // cbStatus_Forn
            // 
            this.cbStatus_Forn.FormattingEnabled = true;
            this.cbStatus_Forn.Items.AddRange(new object[] {
            "Afastado",
            "Aposentado",
            "Demitido",
            "Efetivo",
            "Licenciado",
            "Temporario"});
            this.cbStatus_Forn.Location = new System.Drawing.Point(67, 135);
            this.cbStatus_Forn.Name = "cbStatus_Forn";
            this.cbStatus_Forn.Size = new System.Drawing.Size(99, 21);
            this.cbStatus_Forn.TabIndex = 17;
            // 
            // txtEnd_Forn
            // 
            this.txtEnd_Forn.Location = new System.Drawing.Point(69, 80);
            this.txtEnd_Forn.Name = "txtEnd_Forn";
            this.txtEnd_Forn.Size = new System.Drawing.Size(341, 20);
            this.txtEnd_Forn.TabIndex = 14;
            // 
            // txtCNPJ_Forn
            // 
            this.txtCNPJ_Forn.Location = new System.Drawing.Point(295, 19);
            this.txtCNPJ_Forn.Mask = "00.000.000/0000-00";
            this.txtCNPJ_Forn.Name = "txtCNPJ_Forn";
            this.txtCNPJ_Forn.Size = new System.Drawing.Size(122, 20);
            this.txtCNPJ_Forn.TabIndex = 13;
            // 
            // btnlocalizar
            // 
            this.btnlocalizar.Location = new System.Drawing.Point(172, 17);
            this.btnlocalizar.Name = "btnlocalizar";
            this.btnlocalizar.Size = new System.Drawing.Size(75, 23);
            this.btnlocalizar.TabIndex = 12;
            this.btnlocalizar.Text = "Localizar";
            this.btnlocalizar.UseVisualStyleBackColor = true;
            // 
            // txtRazao_Forn
            // 
            this.txtRazao_Forn.Location = new System.Drawing.Point(67, 51);
            this.txtRazao_Forn.Name = "txtRazao_Forn";
            this.txtRazao_Forn.Size = new System.Drawing.Size(343, 20);
            this.txtRazao_Forn.TabIndex = 11;
            // 
            // txtCod_Forn
            // 
            this.txtCod_Forn.Location = new System.Drawing.Point(67, 19);
            this.txtCod_Forn.Name = "txtCod_Forn";
            this.txtCod_Forn.Size = new System.Drawing.Size(99, 20);
            this.txtCod_Forn.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Contato:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(172, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Telefone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Endereço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CNPJ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Razão:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // txtCont_Forn
            // 
            this.txtCont_Forn.Location = new System.Drawing.Point(66, 106);
            this.txtCont_Forn.MaxLength = 30;
            this.txtCont_Forn.Name = "txtCont_Forn";
            this.txtCont_Forn.Size = new System.Drawing.Size(100, 20);
            this.txtCont_Forn.TabIndex = 25;
            // 
            // FrmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 382);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnincluir);
            this.Controls.Add(this.grbForn);
            this.Name = "FrmFornecedor";
            this.Text = "Cadastro Fornecedor";
            this.grbForn.ResumeLayout(false);
            this.grbForn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.GroupBox grbForn;
        private System.Windows.Forms.MaskedTextBox txtFone_Forn;
        private System.Windows.Forms.ComboBox cbStatus_Forn;
        private System.Windows.Forms.TextBox txtEnd_Forn;
        private System.Windows.Forms.MaskedTextBox txtCNPJ_Forn;
        private System.Windows.Forms.Button btnlocalizar;
        private System.Windows.Forms.TextBox txtRazao_Forn;
        private System.Windows.Forms.TextBox txtCod_Forn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCont_Forn;
    }
}