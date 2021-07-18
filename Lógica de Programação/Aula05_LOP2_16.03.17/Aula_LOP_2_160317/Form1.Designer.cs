namespace Aula_LOP_2_160317
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
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.btnex08 = new System.Windows.Forms.Button();
            this.btnex01 = new System.Windows.Forms.Button();
            this.btnex02 = new System.Windows.Forms.Button();
            this.labekl = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite um Número:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtn1
            // 
            this.txtn1.Location = new System.Drawing.Point(114, 27);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(100, 20);
            this.txtn1.TabIndex = 1;
            // 
            // btnex08
            // 
            this.btnex08.Location = new System.Drawing.Point(80, 73);
            this.btnex08.Name = "btnex08";
            this.btnex08.Size = new System.Drawing.Size(75, 23);
            this.btnex08.TabIndex = 2;
            this.btnex08.Text = "Exercício 8";
            this.btnex08.UseVisualStyleBackColor = true;
            this.btnex08.Click += new System.EventHandler(this.btnex08_Click);
            // 
            // btnex01
            // 
            this.btnex01.Location = new System.Drawing.Point(80, 102);
            this.btnex01.Name = "btnex01";
            this.btnex01.Size = new System.Drawing.Size(75, 23);
            this.btnex01.TabIndex = 4;
            this.btnex01.Text = "exercicio 11";
            this.btnex01.UseVisualStyleBackColor = true;
            this.btnex01.Click += new System.EventHandler(this.btnex01_Click);
            // 
            // btnex02
            // 
            this.btnex02.Location = new System.Drawing.Point(80, 131);
            this.btnex02.Name = "btnex02";
            this.btnex02.Size = new System.Drawing.Size(75, 23);
            this.btnex02.TabIndex = 5;
            this.btnex02.Text = "exercício 12";
            this.btnex02.UseVisualStyleBackColor = true;
            this.btnex02.Click += new System.EventHandler(this.btnex02_Click);
            // 
            // labekl
            // 
            this.labekl.AutoSize = true;
            this.labekl.Location = new System.Drawing.Point(141, 171);
            this.labekl.Name = "labekl";
            this.labekl.Size = new System.Drawing.Size(0, 13);
            this.labekl.TabIndex = 6;
            this.labekl.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(77, 171);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(58, 13);
            this.lblresultado.TabIndex = 7;
            this.lblresultado.Text = "Resultado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.labekl);
            this.Controls.Add(this.btnex02);
            this.Controls.Add(this.btnex01);
            this.Controls.Add(this.btnex08);
            this.Controls.Add(this.txtn1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.Button btnex08;
        private System.Windows.Forms.Button btnex01;
        private System.Windows.Forms.Button btnex02;
        private System.Windows.Forms.Label labekl;
        private System.Windows.Forms.Label lblresultado;
    }
}

