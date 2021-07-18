namespace Ex19_LOP_Loop_27042017
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
            this.Lista = new System.Windows.Forms.ListBox();
            this.btnEnquanto = new System.Windows.Forms.Button();
            this.btnPara = new System.Windows.Forms.Button();
            this.txtControle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lista
            // 
            this.Lista.FormattingEnabled = true;
            this.Lista.Location = new System.Drawing.Point(46, 107);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(263, 186);
            this.Lista.TabIndex = 0;
            // 
            // btnEnquanto
            // 
            this.btnEnquanto.Location = new System.Drawing.Point(46, 36);
            this.btnEnquanto.Name = "btnEnquanto";
            this.btnEnquanto.Size = new System.Drawing.Size(76, 37);
            this.btnEnquanto.TabIndex = 1;
            this.btnEnquanto.Text = "Computador Enquanto";
            this.btnEnquanto.UseVisualStyleBackColor = true;
            this.btnEnquanto.Click += new System.EventHandler(this.btnEnquanto_Click);
            // 
            // btnPara
            // 
            this.btnPara.Location = new System.Drawing.Point(237, 36);
            this.btnPara.Name = "btnPara";
            this.btnPara.Size = new System.Drawing.Size(72, 37);
            this.btnPara.TabIndex = 2;
            this.btnPara.Text = "Computador Para";
            this.btnPara.UseVisualStyleBackColor = true;
            this.btnPara.Click += new System.EventHandler(this.btnPara_Click);
            // 
            // txtControle
            // 
            this.txtControle.Location = new System.Drawing.Point(139, 45);
            this.txtControle.Name = "txtControle";
            this.txtControle.Size = new System.Drawing.Size(70, 20);
            this.txtControle.TabIndex = 3;
            this.txtControle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 485);
            this.Controls.Add(this.txtControle);
            this.Controls.Add(this.btnPara);
            this.Controls.Add(this.btnEnquanto);
            this.Controls.Add(this.Lista);
            this.Name = "Form1";
            this.Text = "Ex19_LOP_Loop_270417";
            this.Load += new System.EventHandler(this.Ex19_LOP_Loop_270417_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.Button btnEnquanto;
        private System.Windows.Forms.Button btnPara;
        private System.Windows.Forms.TextBox txtControle;
    }
}

