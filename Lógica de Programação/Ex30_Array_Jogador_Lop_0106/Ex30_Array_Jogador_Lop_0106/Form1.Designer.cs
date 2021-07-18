namespace Ex30_Array_Jogador_Lop_0106
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
            this.txtjogador = new System.Windows.Forms.TextBox();
            this.txtfalta = new System.Windows.Forms.TextBox();
            this.btnjogador = new System.Windows.Forms.Button();
            this.btnfalta = new System.Windows.Forms.Button();
            this.btnarray = new System.Windows.Forms.Button();
            this.Lista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jogador:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Faltas:";
            // 
            // txtjogador
            // 
            this.txtjogador.Location = new System.Drawing.Point(52, 9);
            this.txtjogador.Name = "txtjogador";
            this.txtjogador.Size = new System.Drawing.Size(185, 20);
            this.txtjogador.TabIndex = 2;
            // 
            // txtfalta
            // 
            this.txtfalta.Location = new System.Drawing.Point(52, 48);
            this.txtfalta.Name = "txtfalta";
            this.txtfalta.Size = new System.Drawing.Size(184, 20);
            this.txtfalta.TabIndex = 3;
            // 
            // btnjogador
            // 
            this.btnjogador.Location = new System.Drawing.Point(243, 6);
            this.btnjogador.Name = "btnjogador";
            this.btnjogador.Size = new System.Drawing.Size(75, 23);
            this.btnjogador.TabIndex = 4;
            this.btnjogador.Text = "Jogador";
            this.btnjogador.UseVisualStyleBackColor = true;
            this.btnjogador.Click += new System.EventHandler(this.btnjogador_Click);
            // 
            // btnfalta
            // 
            this.btnfalta.Location = new System.Drawing.Point(242, 45);
            this.btnfalta.Name = "btnfalta";
            this.btnfalta.Size = new System.Drawing.Size(75, 23);
            this.btnfalta.TabIndex = 5;
            this.btnfalta.Text = "Falta";
            this.btnfalta.UseVisualStyleBackColor = true;
            this.btnfalta.Click += new System.EventHandler(this.btnfalta_Click);
            // 
            // btnarray
            // 
            this.btnarray.Location = new System.Drawing.Point(242, 84);
            this.btnarray.Name = "btnarray";
            this.btnarray.Size = new System.Drawing.Size(76, 23);
            this.btnarray.TabIndex = 6;
            this.btnarray.Text = "Array";
            this.btnarray.UseVisualStyleBackColor = true;
            this.btnarray.Click += new System.EventHandler(this.btnarray_Click);
            // 
            // Lista
            // 
            this.Lista.FormattingEnabled = true;
            this.Lista.Location = new System.Drawing.Point(5, 113);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(312, 238);
            this.Lista.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 360);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.btnarray);
            this.Controls.Add(this.btnfalta);
            this.Controls.Add(this.btnjogador);
            this.Controls.Add(this.txtfalta);
            this.Controls.Add(this.txtjogador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ex 30 Array Jogador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtjogador;
        private System.Windows.Forms.TextBox txtfalta;
        private System.Windows.Forms.Button btnjogador;
        private System.Windows.Forms.Button btnfalta;
        private System.Windows.Forms.Button btnarray;
        private System.Windows.Forms.ListBox Lista;
    }
}

