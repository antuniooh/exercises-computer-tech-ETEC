namespace WindowsFormsApplication1
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
            this.btnadd = new System.Windows.Forms.Button();
            this.Lista = new System.Windows.Forms.ListBox();
            this.txttodosnum = new System.Windows.Forms.TextBox();
            this.txtpositivo = new System.Windows.Forms.TextBox();
            this.txtzero = new System.Windows.Forms.TextBox();
            this.lbldigite = new System.Windows.Forms.Label();
            this.lblpositivo = new System.Windows.Forms.Label();
            this.lblnegativo = new System.Windows.Forms.Label();
            this.txtnegativo = new System.Windows.Forms.TextBox();
            this.lblzero = new System.Windows.Forms.Label();
            this.lbltodosnum = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(206, 13);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 20);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Adicionar";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // Lista
            // 
            this.Lista.FormattingEnabled = true;
            this.Lista.Location = new System.Drawing.Point(75, 52);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(187, 95);
            this.Lista.TabIndex = 1;
            // 
            // txttodosnum
            // 
            this.txttodosnum.Location = new System.Drawing.Point(180, 233);
            this.txttodosnum.Name = "txttodosnum";
            this.txttodosnum.Size = new System.Drawing.Size(28, 20);
            this.txttodosnum.TabIndex = 2;
            // 
            // txtpositivo
            // 
            this.txtpositivo.Location = new System.Drawing.Point(180, 165);
            this.txtpositivo.Name = "txtpositivo";
            this.txtpositivo.Size = new System.Drawing.Size(28, 20);
            this.txtpositivo.TabIndex = 3;
            // 
            // txtzero
            // 
            this.txtzero.Location = new System.Drawing.Point(180, 211);
            this.txtzero.Name = "txtzero";
            this.txtzero.Size = new System.Drawing.Size(28, 20);
            this.txtzero.TabIndex = 4;
            // 
            // lbldigite
            // 
            this.lbldigite.AutoSize = true;
            this.lbldigite.Location = new System.Drawing.Point(72, 13);
            this.lbldigite.Name = "lbldigite";
            this.lbldigite.Size = new System.Drawing.Size(94, 13);
            this.lbldigite.TabIndex = 5;
            this.lbldigite.Text = "Digite um Número:";
            // 
            // lblpositivo
            // 
            this.lblpositivo.AutoSize = true;
            this.lblpositivo.Location = new System.Drawing.Point(72, 168);
            this.lblpositivo.Name = "lblpositivo";
            this.lblpositivo.Size = new System.Drawing.Size(102, 13);
            this.lblpositivo.TabIndex = 6;
            this.lblpositivo.Text = "Quantidade Positivo";
            // 
            // lblnegativo
            // 
            this.lblnegativo.AutoSize = true;
            this.lblnegativo.Location = new System.Drawing.Point(72, 191);
            this.lblnegativo.Name = "lblnegativo";
            this.lblnegativo.Size = new System.Drawing.Size(106, 13);
            this.lblnegativo.TabIndex = 7;
            this.lblnegativo.Text = "Quantidade negativo";
            // 
            // txtnegativo
            // 
            this.txtnegativo.Location = new System.Drawing.Point(180, 188);
            this.txtnegativo.Name = "txtnegativo";
            this.txtnegativo.Size = new System.Drawing.Size(28, 20);
            this.txtnegativo.TabIndex = 8;
            // 
            // lblzero
            // 
            this.lblzero.AutoSize = true;
            this.lblzero.Location = new System.Drawing.Point(59, 214);
            this.lblzero.Name = "lblzero";
            this.lblzero.Size = new System.Drawing.Size(119, 13);
            this.lblzero.TabIndex = 10;
            this.lblzero.Text = "Quantidade igual a zero";
            // 
            // lbltodosnum
            // 
            this.lbltodosnum.AutoSize = true;
            this.lbltodosnum.Location = new System.Drawing.Point(2, 236);
            this.lbltodosnum.Name = "lbltodosnum";
            this.lbltodosnum.Size = new System.Drawing.Size(177, 13);
            this.lbltodosnum.TabIndex = 11;
            this.lbltodosnum.Text = "Valor total dos numeros adicionados";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(172, 13);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(28, 20);
            this.txtnumero.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "---------------------------------------------------------------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "----------------------------------------------------------------------------";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 291);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.lbltodosnum);
            this.Controls.Add(this.lblzero);
            this.Controls.Add(this.txtnegativo);
            this.Controls.Add(this.lblnegativo);
            this.Controls.Add(this.lblpositivo);
            this.Controls.Add(this.lbldigite);
            this.Controls.Add(this.txtzero);
            this.Controls.Add(this.txtpositivo);
            this.Controls.Add(this.txttodosnum);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.btnadd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.TextBox txttodosnum;
        private System.Windows.Forms.TextBox txtpositivo;
        private System.Windows.Forms.TextBox txtzero;
        private System.Windows.Forms.Label lbldigite;
        private System.Windows.Forms.Label lblpositivo;
        private System.Windows.Forms.Label lblnegativo;
        private System.Windows.Forms.TextBox txtnegativo;
        private System.Windows.Forms.Label lblzero;
        private System.Windows.Forms.Label lbltodosnum;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

