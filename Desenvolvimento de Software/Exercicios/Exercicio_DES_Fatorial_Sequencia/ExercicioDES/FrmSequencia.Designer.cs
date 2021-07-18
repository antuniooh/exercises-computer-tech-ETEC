namespace ExercicioDES
{
    partial class FrmSequencia
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
            this.lblSequencia = new System.Windows.Forms.Label();
            this.lblFechar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSequencia
            // 
            this.lblSequencia.BackColor = System.Drawing.SystemColors.Control;
            this.lblSequencia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSequencia.Location = new System.Drawing.Point(12, 9);
            this.lblSequencia.Name = "lblSequencia";
            this.lblSequencia.Size = new System.Drawing.Size(161, 244);
            this.lblSequencia.TabIndex = 8;
            // 
            // lblFechar
            // 
            this.lblFechar.AutoSize = true;
            this.lblFechar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFechar.Location = new System.Drawing.Point(216, 239);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(42, 15);
            this.lblFechar.TabIndex = 9;
            this.lblFechar.Text = "Fechar";
            this.lblFechar.Click += new System.EventHandler(this.lblFechar_Click);
            // 
            // FrmSequencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 362);
            this.Controls.Add(this.lblFechar);
            this.Controls.Add(this.lblSequencia);
            this.Name = "FrmSequencia";
            this.Text = "FrmSequencia";
            this.Load += new System.EventHandler(this.FrmSequencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSequencia;
        private System.Windows.Forms.Label lblFechar;
    }
}