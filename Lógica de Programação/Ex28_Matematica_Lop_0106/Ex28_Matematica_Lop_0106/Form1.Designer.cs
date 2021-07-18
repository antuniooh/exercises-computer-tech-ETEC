namespace Ex28_Matematica_Lop_0106
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtvalor1 = new System.Windows.Forms.TextBox();
            this.txtvalor2 = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdnAdd = new System.Windows.Forms.RadioButton();
            this.rdnSub = new System.Windows.Forms.RadioButton();
            this.rdnMulti = new System.Windows.Forms.RadioButton();
            this.rdnDivi = new System.Windows.Forms.RadioButton();
            this.rdnResto = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado:";
            // 
            // txtvalor1
            // 
            this.txtvalor1.Location = new System.Drawing.Point(12, 25);
            this.txtvalor1.Name = "txtvalor1";
            this.txtvalor1.Size = new System.Drawing.Size(64, 20);
            this.txtvalor1.TabIndex = 4;
            // 
            // txtvalor2
            // 
            this.txtvalor2.Location = new System.Drawing.Point(378, 25);
            this.txtvalor2.Name = "txtvalor2";
            this.txtvalor2.Size = new System.Drawing.Size(79, 20);
            this.txtvalor2.TabIndex = 5;
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(12, 153);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(64, 20);
            this.txtresultado.TabIndex = 7;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(378, 153);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 8;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdnResto);
            this.groupBox1.Controls.Add(this.rdnDivi);
            this.groupBox1.Controls.Add(this.rdnMulti);
            this.groupBox1.Controls.Add(this.rdnSub);
            this.groupBox1.Controls.Add(this.rdnAdd);
            this.groupBox1.Location = new System.Drawing.Point(84, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 151);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operadores:";
            // 
            // rdnAdd
            // 
            this.rdnAdd.AutoSize = true;
            this.rdnAdd.Location = new System.Drawing.Point(6, 19);
            this.rdnAdd.Name = "rdnAdd";
            this.rdnAdd.Size = new System.Drawing.Size(58, 17);
            this.rdnAdd.TabIndex = 10;
            this.rdnAdd.TabStop = true;
            this.rdnAdd.Text = "Adição";
            this.rdnAdd.UseVisualStyleBackColor = true;
            // 
            // rdnSub
            // 
            this.rdnSub.AutoSize = true;
            this.rdnSub.Location = new System.Drawing.Point(6, 42);
            this.rdnSub.Name = "rdnSub";
            this.rdnSub.Size = new System.Drawing.Size(74, 17);
            this.rdnSub.TabIndex = 11;
            this.rdnSub.TabStop = true;
            this.rdnSub.Text = "Subtração";
            this.rdnSub.UseVisualStyleBackColor = true;
            // 
            // rdnMulti
            // 
            this.rdnMulti.AutoSize = true;
            this.rdnMulti.Location = new System.Drawing.Point(6, 65);
            this.rdnMulti.Name = "rdnMulti";
            this.rdnMulti.Size = new System.Drawing.Size(87, 17);
            this.rdnMulti.TabIndex = 12;
            this.rdnMulti.TabStop = true;
            this.rdnMulti.Text = "Multiplicação";
            this.rdnMulti.UseVisualStyleBackColor = true;
            // 
            // rdnDivi
            // 
            this.rdnDivi.AutoSize = true;
            this.rdnDivi.Location = new System.Drawing.Point(6, 88);
            this.rdnDivi.Name = "rdnDivi";
            this.rdnDivi.Size = new System.Drawing.Size(60, 17);
            this.rdnDivi.TabIndex = 13;
            this.rdnDivi.TabStop = true;
            this.rdnDivi.Text = "Divisão";
            this.rdnDivi.UseVisualStyleBackColor = true;
            // 
            // rdnResto
            // 
            this.rdnResto.AutoSize = true;
            this.rdnResto.Location = new System.Drawing.Point(6, 111);
            this.rdnResto.Name = "rdnResto";
            this.rdnResto.Size = new System.Drawing.Size(106, 17);
            this.rdnResto.TabIndex = 14;
            this.rdnResto.TabStop = true;
            this.rdnResto.Text = "Resto da Divisão";
            this.rdnResto.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 197);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtvalor2);
            this.Controls.Add(this.txtvalor1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ex28_Matemática";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtvalor1;
        private System.Windows.Forms.TextBox txtvalor2;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdnResto;
        private System.Windows.Forms.RadioButton rdnDivi;
        private System.Windows.Forms.RadioButton rdnMulti;
        private System.Windows.Forms.RadioButton rdnSub;
        private System.Windows.Forms.RadioButton rdnAdd;
    }
}

