namespace Ex29_Texto_Vetor_0106
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
            this.grbentrada = new System.Windows.Forms.GroupBox();
            this.grbSaida = new System.Windows.Forms.GroupBox();
            this.btnclassificar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnSaida = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnome1 = new System.Windows.Forms.TextBox();
            this.txtnome2 = new System.Windows.Forms.TextBox();
            this.txtnome3 = new System.Windows.Forms.TextBox();
            this.txtnome4 = new System.Windows.Forms.TextBox();
            this.txtnome5 = new System.Windows.Forms.TextBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.grbentrada.SuspendLayout();
            this.grbSaida.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de nomes";
            // 
            // grbentrada
            // 
            this.grbentrada.Controls.Add(this.txtnome5);
            this.grbentrada.Controls.Add(this.txtnome4);
            this.grbentrada.Controls.Add(this.txtnome3);
            this.grbentrada.Controls.Add(this.txtnome2);
            this.grbentrada.Controls.Add(this.txtnome1);
            this.grbentrada.Controls.Add(this.label6);
            this.grbentrada.Controls.Add(this.lbl1);
            this.grbentrada.Controls.Add(this.label5);
            this.grbentrada.Controls.Add(this.label3);
            this.grbentrada.Controls.Add(this.label4);
            this.grbentrada.Location = new System.Drawing.Point(12, 146);
            this.grbentrada.Name = "grbentrada";
            this.grbentrada.Size = new System.Drawing.Size(200, 197);
            this.grbentrada.TabIndex = 1;
            this.grbentrada.TabStop = false;
            this.grbentrada.Text = "Entrada:";
            // 
            // grbSaida
            // 
            this.grbSaida.Controls.Add(this.lblResposta);
            this.grbSaida.Location = new System.Drawing.Point(231, 146);
            this.grbSaida.Name = "grbSaida";
            this.grbSaida.Size = new System.Drawing.Size(200, 197);
            this.grbSaida.TabIndex = 2;
            this.grbSaida.TabStop = false;
            this.grbSaida.Text = "Saida:";
            this.grbSaida.Visible = false;
            // 
            // btnclassificar
            // 
            this.btnclassificar.Location = new System.Drawing.Point(9, 349);
            this.btnclassificar.Name = "btnclassificar";
            this.btnclassificar.Size = new System.Drawing.Size(75, 23);
            this.btnclassificar.TabIndex = 3;
            this.btnclassificar.Text = "Classificar";
            this.btnclassificar.UseVisualStyleBackColor = true;
            this.btnclassificar.Click += new System.EventHandler(this.btnclassificar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(91, 349);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 4;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnSaida
            // 
            this.btnSaida.Location = new System.Drawing.Point(356, 349);
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Size = new System.Drawing.Size(75, 23);
            this.btnSaida.TabIndex = 5;
            this.btnSaida.Text = "Sair";
            this.btnSaida.UseVisualStyleBackColor = true;
            this.btnSaida.Click += new System.EventHandler(this.btnSaida_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(55, 28);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(47, 13);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "Nome 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nome 3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nome 4:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nome 5:";
            // 
            // txtnome1
            // 
            this.txtnome1.Location = new System.Drawing.Point(96, 21);
            this.txtnome1.Name = "txtnome1";
            this.txtnome1.Size = new System.Drawing.Size(100, 20);
            this.txtnome1.TabIndex = 11;
            // 
            // txtnome2
            // 
            this.txtnome2.BackColor = System.Drawing.Color.White;
            this.txtnome2.Location = new System.Drawing.Point(96, 44);
            this.txtnome2.Name = "txtnome2";
            this.txtnome2.Size = new System.Drawing.Size(100, 20);
            this.txtnome2.TabIndex = 12;
            // 
            // txtnome3
            // 
            this.txtnome3.Location = new System.Drawing.Point(96, 68);
            this.txtnome3.Name = "txtnome3";
            this.txtnome3.Size = new System.Drawing.Size(100, 20);
            this.txtnome3.TabIndex = 13;
            // 
            // txtnome4
            // 
            this.txtnome4.Location = new System.Drawing.Point(96, 94);
            this.txtnome4.Name = "txtnome4";
            this.txtnome4.Size = new System.Drawing.Size(100, 20);
            this.txtnome4.TabIndex = 14;
            // 
            // txtnome5
            // 
            this.txtnome5.Location = new System.Drawing.Point(96, 117);
            this.txtnome5.Name = "txtnome5";
            this.txtnome5.Size = new System.Drawing.Size(100, 20);
            this.txtnome5.TabIndex = 15;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(6, 21);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(50, 13);
            this.lblResposta.TabIndex = 6;
            this.lblResposta.Text = "Reposta:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 462);
            this.Controls.Add(this.btnSaida);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnclassificar);
            this.Controls.Add(this.grbSaida);
            this.Controls.Add(this.grbentrada);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ex29 Texto Vetor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbentrada.ResumeLayout(false);
            this.grbentrada.PerformLayout();
            this.grbSaida.ResumeLayout(false);
            this.grbSaida.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbentrada;
        private System.Windows.Forms.GroupBox grbSaida;
        private System.Windows.Forms.Button btnclassificar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnSaida;
        private System.Windows.Forms.TextBox txtnome5;
        private System.Windows.Forms.TextBox txtnome4;
        private System.Windows.Forms.TextBox txtnome3;
        private System.Windows.Forms.TextBox txtnome2;
        private System.Windows.Forms.TextBox txtnome1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResposta;
    }
}

