namespace EX01_Intro_TCI_19072017
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.RDNPreto = new System.Windows.Forms.RadioButton();
            this.RDNVermelho = new System.Windows.Forms.RadioButton();
            this.RDNVerde = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.LBLResposta = new System.Windows.Forms.Label();
            this.TxtEntrada = new System.Windows.Forms.TextBox();
            this.RDNf12 = new System.Windows.Forms.RadioButton();
            this.RDNf16 = new System.Windows.Forms.RadioButton();
            this.RDNf20 = new System.Windows.Forms.RadioButton();
            this.RDNmaiusculo = new System.Windows.Forms.RadioButton();
            this.RDNminúsculo = new System.Windows.Forms.RadioButton();
            this.RDNcaracteres = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(92, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(309, 198);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.RDNVerde);
            this.tabPage1.Controls.Add(this.RDNVermelho);
            this.tabPage1.Controls.Add(this.RDNPreto);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(301, 172);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.RDNf20);
            this.tabPage2.Controls.Add(this.RDNf16);
            this.tabPage2.Controls.Add(this.RDNf12);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(301, 172);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tamanho";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.RDNcaracteres);
            this.tabPage3.Controls.Add(this.RDNminúsculo);
            this.tabPage3.Controls.Add(this.RDNmaiusculo);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(301, 172);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Normalizar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // RDNPreto
            // 
            this.RDNPreto.AutoSize = true;
            this.RDNPreto.Location = new System.Drawing.Point(40, 28);
            this.RDNPreto.Name = "RDNPreto";
            this.RDNPreto.Size = new System.Drawing.Size(50, 17);
            this.RDNPreto.TabIndex = 0;
            this.RDNPreto.TabStop = true;
            this.RDNPreto.Text = "Preto";
            this.RDNPreto.UseVisualStyleBackColor = true;
            this.RDNPreto.CheckedChanged += new System.EventHandler(this.RDNPreto_CheckedChanged);
            // 
            // RDNVermelho
            // 
            this.RDNVermelho.AutoSize = true;
            this.RDNVermelho.Location = new System.Drawing.Point(40, 51);
            this.RDNVermelho.Name = "RDNVermelho";
            this.RDNVermelho.Size = new System.Drawing.Size(69, 17);
            this.RDNVermelho.TabIndex = 1;
            this.RDNVermelho.TabStop = true;
            this.RDNVermelho.Text = "Vermelho";
            this.RDNVermelho.UseVisualStyleBackColor = true;
            this.RDNVermelho.CheckedChanged += new System.EventHandler(this.RDNVermelho_CheckedChanged);
            // 
            // RDNVerde
            // 
            this.RDNVerde.AutoSize = true;
            this.RDNVerde.Location = new System.Drawing.Point(40, 74);
            this.RDNVerde.Name = "RDNVerde";
            this.RDNVerde.Size = new System.Drawing.Size(53, 17);
            this.RDNVerde.TabIndex = 2;
            this.RDNVerde.TabStop = true;
            this.RDNVerde.Text = "Verde";
            this.RDNVerde.UseVisualStyleBackColor = true;
            this.RDNVerde.CheckedChanged += new System.EventHandler(this.RDNVerde_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entrada:";
            // 
            // LBLResposta
            // 
            this.LBLResposta.Location = new System.Drawing.Point(93, 266);
            this.LBLResposta.Name = "LBLResposta";
            this.LBLResposta.Size = new System.Drawing.Size(308, 50);
            this.LBLResposta.TabIndex = 2;
            this.LBLResposta.Text = "Digite um texto:";
            // 
            // TxtEntrada
            // 
            this.TxtEntrada.Location = new System.Drawing.Point(178, 225);
            this.TxtEntrada.Name = "TxtEntrada";
            this.TxtEntrada.Size = new System.Drawing.Size(100, 20);
            this.TxtEntrada.TabIndex = 3;
            // 
            // RDNf12
            // 
            this.RDNf12.AutoSize = true;
            this.RDNf12.Location = new System.Drawing.Point(45, 19);
            this.RDNf12.Name = "RDNf12";
            this.RDNf12.Size = new System.Drawing.Size(67, 17);
            this.RDNf12.TabIndex = 0;
            this.RDNf12.TabStop = true;
            this.RDNf12.Text = "Fonte 12";
            this.RDNf12.UseVisualStyleBackColor = true;
            this.RDNf12.CheckedChanged += new System.EventHandler(this.RDNf12_CheckedChanged);
            // 
            // RDNf16
            // 
            this.RDNf16.AutoSize = true;
            this.RDNf16.Location = new System.Drawing.Point(45, 42);
            this.RDNf16.Name = "RDNf16";
            this.RDNf16.Size = new System.Drawing.Size(67, 17);
            this.RDNf16.TabIndex = 1;
            this.RDNf16.TabStop = true;
            this.RDNf16.Text = "Fonte 16";
            this.RDNf16.UseVisualStyleBackColor = true;
            this.RDNf16.CheckedChanged += new System.EventHandler(this.RDNf16_CheckedChanged);
            // 
            // RDNf20
            // 
            this.RDNf20.AutoSize = true;
            this.RDNf20.Location = new System.Drawing.Point(45, 65);
            this.RDNf20.Name = "RDNf20";
            this.RDNf20.Size = new System.Drawing.Size(67, 17);
            this.RDNf20.TabIndex = 2;
            this.RDNf20.TabStop = true;
            this.RDNf20.Text = "Fonte 20";
            this.RDNf20.UseVisualStyleBackColor = true;
            this.RDNf20.CheckedChanged += new System.EventHandler(this.RDNf20_CheckedChanged);
            // 
            // RDNmaiusculo
            // 
            this.RDNmaiusculo.AutoSize = true;
            this.RDNmaiusculo.Location = new System.Drawing.Point(51, 25);
            this.RDNmaiusculo.Name = "RDNmaiusculo";
            this.RDNmaiusculo.Size = new System.Drawing.Size(73, 17);
            this.RDNmaiusculo.TabIndex = 0;
            this.RDNmaiusculo.TabStop = true;
            this.RDNmaiusculo.Text = "Maiúsculo";
            this.RDNmaiusculo.UseVisualStyleBackColor = true;
            this.RDNmaiusculo.CheckedChanged += new System.EventHandler(this.RDNmaiusculo_CheckedChanged);
            // 
            // RDNminúsculo
            // 
            this.RDNminúsculo.AutoSize = true;
            this.RDNminúsculo.Location = new System.Drawing.Point(51, 48);
            this.RDNminúsculo.Name = "RDNminúsculo";
            this.RDNminúsculo.Size = new System.Drawing.Size(73, 17);
            this.RDNminúsculo.TabIndex = 1;
            this.RDNminúsculo.TabStop = true;
            this.RDNminúsculo.Text = "Minúsculo";
            this.RDNminúsculo.UseVisualStyleBackColor = true;
            this.RDNminúsculo.CheckedChanged += new System.EventHandler(this.RDNminúsculo_CheckedChanged);
            // 
            // RDNcaracteres
            // 
            this.RDNcaracteres.AutoSize = true;
            this.RDNcaracteres.Location = new System.Drawing.Point(51, 71);
            this.RDNcaracteres.Name = "RDNcaracteres";
            this.RDNcaracteres.Size = new System.Drawing.Size(76, 17);
            this.RDNcaracteres.TabIndex = 2;
            this.RDNcaracteres.TabStop = true;
            this.RDNcaracteres.Text = "Caracteres";
            this.RDNcaracteres.UseVisualStyleBackColor = true;
            this.RDNcaracteres.CheckedChanged += new System.EventHandler(this.RDNcaracteres_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 325);
            this.Controls.Add(this.TxtEntrada);
            this.Controls.Add(this.LBLResposta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "EX01_FORMATAÇÃO";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton RDNVerde;
        private System.Windows.Forms.RadioButton RDNVermelho;
        private System.Windows.Forms.RadioButton RDNPreto;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBLResposta;
        private System.Windows.Forms.TextBox TxtEntrada;
        private System.Windows.Forms.RadioButton RDNf20;
        private System.Windows.Forms.RadioButton RDNf16;
        private System.Windows.Forms.RadioButton RDNf12;
        private System.Windows.Forms.RadioButton RDNcaracteres;
        private System.Windows.Forms.RadioButton RDNminúsculo;
        private System.Windows.Forms.RadioButton RDNmaiusculo;
    }
}

