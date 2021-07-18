namespace ExPizza_Lop
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
            this.lblV1 = new System.Windows.Forms.Label();
            this.lblV2 = new System.Windows.Forms.Label();
            this.lblV3 = new System.Windows.Forms.Label();
            this.txtV1 = new System.Windows.Forms.TextBox();
            this.txtV2 = new System.Windows.Forms.TextBox();
            this.txtV3 = new System.Windows.Forms.TextBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblV1
            // 
            this.lblV1.AutoSize = true;
            this.lblV1.Location = new System.Drawing.Point(238, 57);
            this.lblV1.Name = "lblV1";
            this.lblV1.Size = new System.Drawing.Size(87, 13);
            this.lblV1.TabIndex = 0;
            this.lblV1.Text = "Valor 1(Amarelo):";
            this.lblV1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblV2
            // 
            this.lblV2.AutoSize = true;
            this.lblV2.Location = new System.Drawing.Point(256, 94);
            this.lblV2.Name = "lblV2";
            this.lblV2.Size = new System.Drawing.Size(69, 13);
            this.lblV2.TabIndex = 1;
            this.lblV2.Text = "Valor 2(Azul):";
            // 
            // lblV3
            // 
            this.lblV3.AutoSize = true;
            this.lblV3.Location = new System.Drawing.Point(232, 130);
            this.lblV3.Name = "lblV3";
            this.lblV3.Size = new System.Drawing.Size(93, 13);
            this.lblV3.TabIndex = 2;
            this.lblV3.Text = "Valor 3(Vermelho):";
            // 
            // txtV1
            // 
            this.txtV1.Location = new System.Drawing.Point(331, 50);
            this.txtV1.Name = "txtV1";
            this.txtV1.Size = new System.Drawing.Size(100, 20);
            this.txtV1.TabIndex = 3;
            this.txtV1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtV2
            // 
            this.txtV2.Location = new System.Drawing.Point(331, 87);
            this.txtV2.Name = "txtV2";
            this.txtV2.Size = new System.Drawing.Size(100, 20);
            this.txtV2.TabIndex = 4;
            // 
            // txtV3
            // 
            this.txtV3.Location = new System.Drawing.Point(331, 123);
            this.txtV3.Name = "txtV3";
            this.txtV3.Size = new System.Drawing.Size(100, 20);
            this.txtV3.TabIndex = 5;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(331, 160);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 6;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 342);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.txtV3);
            this.Controls.Add(this.txtV2);
            this.Controls.Add(this.txtV1);
            this.Controls.Add(this.lblV3);
            this.Controls.Add(this.lblV2);
            this.Controls.Add(this.lblV1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblV1;
        private System.Windows.Forms.Label lblV2;
        private System.Windows.Forms.Label lblV3;
        private System.Windows.Forms.TextBox txtV1;
        private System.Windows.Forms.TextBox txtV2;
        private System.Windows.Forms.TextBox txtV3;
        private System.Windows.Forms.Button btnGerar;
    }
}

