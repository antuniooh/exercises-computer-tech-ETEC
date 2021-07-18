namespace ExerciciosRepetição
{
    partial class Exercicio
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
            this.lblfator = new System.Windows.Forms.Label();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblfator
            // 
            this.lblfator.BackColor = System.Drawing.Color.Honeydew;
            this.lblfator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblfator.Location = new System.Drawing.Point(23, 36);
            this.lblfator.Name = "lblfator";
            this.lblfator.Size = new System.Drawing.Size(161, 244);
            this.lblfator.TabIndex = 7;
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(250, 57);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(75, 43);
            this.btnExibir.TabIndex = 8;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(250, 106);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 55);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "button2";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(250, 220);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 10);
            this.button3.TabIndex = 10;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Exercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 426);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.lblfator);
            this.Name = "Exercicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Exercicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblfator;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button button3;
    }
}

