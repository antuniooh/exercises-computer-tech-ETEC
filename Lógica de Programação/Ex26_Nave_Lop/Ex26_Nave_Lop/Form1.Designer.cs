namespace Ex26_Nave_Lop
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
            this.picCima = new System.Windows.Forms.PictureBox();
            this.picNave = new System.Windows.Forms.PictureBox();
            this.picBaixo = new System.Windows.Forms.PictureBox();
            this.picDireita = new System.Windows.Forms.PictureBox();
            this.picEsquerda = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBaixo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDireita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEsquerda)).BeginInit();
            this.SuspendLayout();
            // 
            // picCima
            // 
            this.picCima.Image = global::Ex26_Nave_Lop.Properties.Resources.ParaCima;
            this.picCima.Location = new System.Drawing.Point(224, 260);
            this.picCima.Name = "picCima";
            this.picCima.Size = new System.Drawing.Size(44, 43);
            this.picCima.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCima.TabIndex = 0;
            this.picCima.TabStop = false;
            this.picCima.Click += new System.EventHandler(this.picCima_Click);
            // 
            // picNave
            // 
            this.picNave.Image = global::Ex26_Nave_Lop.Properties.Resources.Nave;
            this.picNave.Location = new System.Drawing.Point(211, 123);
            this.picNave.Name = "picNave";
            this.picNave.Size = new System.Drawing.Size(75, 103);
            this.picNave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picNave.TabIndex = 1;
            this.picNave.TabStop = false;
            this.picNave.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // picBaixo
            // 
            this.picBaixo.Image = global::Ex26_Nave_Lop.Properties.Resources.ParaBaixo;
            this.picBaixo.Location = new System.Drawing.Point(224, 300);
            this.picBaixo.Name = "picBaixo";
            this.picBaixo.Size = new System.Drawing.Size(44, 38);
            this.picBaixo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBaixo.TabIndex = 2;
            this.picBaixo.TabStop = false;
            this.picBaixo.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // picDireita
            // 
            this.picDireita.Image = global::Ex26_Nave_Lop.Properties.Resources.ParaDireita;
            this.picDireita.Location = new System.Drawing.Point(274, 300);
            this.picDireita.Name = "picDireita";
            this.picDireita.Size = new System.Drawing.Size(48, 38);
            this.picDireita.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picDireita.TabIndex = 3;
            this.picDireita.TabStop = false;
            this.picDireita.Click += new System.EventHandler(this.picDireita_Click);
            // 
            // picEsquerda
            // 
            this.picEsquerda.Image = global::Ex26_Nave_Lop.Properties.Resources.ParaEsquerda;
            this.picEsquerda.Location = new System.Drawing.Point(172, 300);
            this.picEsquerda.Name = "picEsquerda";
            this.picEsquerda.Size = new System.Drawing.Size(46, 38);
            this.picEsquerda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picEsquerda.TabIndex = 4;
            this.picEsquerda.TabStop = false;
            this.picEsquerda.Click += new System.EventHandler(this.picEsquerda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 342);
            this.Controls.Add(this.picEsquerda);
            this.Controls.Add(this.picDireita);
            this.Controls.Add(this.picBaixo);
            this.Controls.Add(this.picNave);
            this.Controls.Add(this.picCima);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBaixo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDireita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEsquerda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCima;
        private System.Windows.Forms.PictureBox picNave;
        private System.Windows.Forms.PictureBox picBaixo;
        private System.Windows.Forms.PictureBox picDireita;
        private System.Windows.Forms.PictureBox picEsquerda;
    }
}

