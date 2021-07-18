namespace Aula2_ex06_lop_230217_parte2
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
            this.label2 = new System.Windows.Forms.Label();
            this.BntCalcular = new System.Windows.Forms.Button();
            this.LblSoma = new System.Windows.Forms.Label();
            this.LblProduto = new System.Windows.Forms.Label();
            this.LblQuadrado = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite valor 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite valor 2";
            // 
            // BntCalcular
            // 
            this.BntCalcular.Location = new System.Drawing.Point(13, 98);
            this.BntCalcular.Name = "BntCalcular";
            this.BntCalcular.Size = new System.Drawing.Size(212, 23);
            this.BntCalcular.TabIndex = 2;
            this.BntCalcular.Text = "Calcular";
            this.BntCalcular.UseVisualStyleBackColor = true;
            this.BntCalcular.Click += new System.EventHandler(this.BntCalcular_Click);
            // 
            // LblSoma
            // 
            this.LblSoma.AutoSize = true;
            this.LblSoma.Location = new System.Drawing.Point(13, 139);
            this.LblSoma.Name = "LblSoma";
            this.LblSoma.Size = new System.Drawing.Size(57, 13);
            this.LblSoma.TabIndex = 3;
            this.LblSoma.Text = "20% Soma";
            // 
            // LblProduto
            // 
            this.LblProduto.AutoSize = true;
            this.LblProduto.Location = new System.Drawing.Point(13, 165);
            this.LblProduto.Name = "LblProduto";
            this.LblProduto.Size = new System.Drawing.Size(81, 13);
            this.LblProduto.TabIndex = 4;
            this.LblProduto.Text = "30% do produto";
            // 
            // LblQuadrado
            // 
            this.LblQuadrado.AutoSize = true;
            this.LblQuadrado.Location = new System.Drawing.Point(13, 191);
            this.LblQuadrado.Name = "LblQuadrado";
            this.LblQuadrado.Size = new System.Drawing.Size(90, 13);
            this.LblQuadrado.TabIndex = 5;
            this.LblQuadrado.Text = "40% do quadrado";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(125, 33);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 6;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(125, 63);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 225);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.LblQuadrado);
            this.Controls.Add(this.LblProduto);
            this.Controls.Add(this.LblSoma);
            this.Controls.Add(this.BntCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Exercicio 06 LOP 230217";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BntCalcular;
        private System.Windows.Forms.Label LblSoma;
        private System.Windows.Forms.Label LblProduto;
        private System.Windows.Forms.Label LblQuadrado;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
    }
}

