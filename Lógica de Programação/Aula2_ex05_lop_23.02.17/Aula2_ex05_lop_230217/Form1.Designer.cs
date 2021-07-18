namespace Aula2_ex05_lop_230217
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
            this.TempC = new System.Windows.Forms.Label();
            this.TempF = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TempC
            // 
            this.TempC.AutoSize = true;
            this.TempC.Location = new System.Drawing.Point(12, 52);
            this.TempC.Name = "TempC";
            this.TempC.Size = new System.Drawing.Size(94, 13);
            this.TempC.TabIndex = 0;
            this.TempC.Text = "Temperatura em C";
            // 
            // TempF
            // 
            this.TempF.AutoSize = true;
            this.TempF.Location = new System.Drawing.Point(13, 82);
            this.TempF.Name = "TempF";
            this.TempF.Size = new System.Drawing.Size(93, 13);
            this.TempF.TabIndex = 1;
            this.TempF.Text = "Temperatura em F";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // but
            // 
            this.but.Location = new System.Drawing.Point(294, 49);
            this.but.Name = "but";
            this.but.Size = new System.Drawing.Size(97, 59);
            this.but.TabIndex = 4;
            this.but.Text = "Converter";
            this.but.UseVisualStyleBackColor = true;
            this.but.Click += new System.EventHandler(this.but_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 171);
            this.Controls.Add(this.but);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TempF);
            this.Controls.Add(this.TempC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TempC;
        private System.Windows.Forms.Label TempF;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button but;
    }
}

