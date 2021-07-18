namespace Ex27_Imagem_Lop_2505
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbImagem = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione a opção de imagem:";
            // 
            // cbImagem
            // 
            this.cbImagem.FormattingEnabled = true;
            this.cbImagem.Items.AddRange(new object[] {
            "Circulo",
            "Quadrado",
            "Retângulo",
            "Elipse",
            "Pizza",
            "Circulo Cheio",
            "Quadrado Cheio",
            "Retângulo Cheio",
            "Elipse Cheia ",
            "Pizza Cheia"});
            this.cbImagem.Location = new System.Drawing.Point(172, 26);
            this.cbImagem.Name = "cbImagem";
            this.cbImagem.Size = new System.Drawing.Size(121, 21);
            this.cbImagem.TabIndex = 1;
            this.cbImagem.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 208);
            this.Controls.Add(this.cbImagem);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbImagem;
    }
}

