namespace AppSimuladorMedia
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btSimularMedia = new System.Windows.Forms.Button();
            this.btNotaMinima = new System.Windows.Forms.Button();
            this.btMediaFinal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSimularMedia
            // 
            this.btSimularMedia.BackColor = System.Drawing.SystemColors.Highlight;
            this.btSimularMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSimularMedia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSimularMedia.Location = new System.Drawing.Point(251, 68);
            this.btSimularMedia.Name = "btSimularMedia";
            this.btSimularMedia.Size = new System.Drawing.Size(279, 82);
            this.btSimularMedia.TabIndex = 0;
            this.btSimularMedia.Text = "Simular média";
            this.btSimularMedia.UseVisualStyleBackColor = false;
            this.btSimularMedia.Click += new System.EventHandler(this.btSimularMedia_Click);
            // 
            // btNotaMinima
            // 
            this.btNotaMinima.BackColor = System.Drawing.SystemColors.Highlight;
            this.btNotaMinima.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNotaMinima.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btNotaMinima.Location = new System.Drawing.Point(251, 184);
            this.btNotaMinima.Name = "btNotaMinima";
            this.btNotaMinima.Size = new System.Drawing.Size(279, 82);
            this.btNotaMinima.TabIndex = 1;
            this.btNotaMinima.Text = " Nota mínima para ser aprovado no Exame";
            this.btNotaMinima.UseVisualStyleBackColor = false;
            this.btNotaMinima.Click += new System.EventHandler(this.btNotaMinima_Click);
            // 
            // btMediaFinal
            // 
            this.btMediaFinal.BackColor = System.Drawing.SystemColors.Highlight;
            this.btMediaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMediaFinal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btMediaFinal.Location = new System.Drawing.Point(251, 303);
            this.btMediaFinal.Name = "btMediaFinal";
            this.btMediaFinal.Size = new System.Drawing.Size(279, 82);
            this.btMediaFinal.TabIndex = 2;
            this.btMediaFinal.Text = "Verificar a média final após a nota do Exame Final";
            this.btMediaFinal.UseVisualStyleBackColor = false;
            this.btMediaFinal.Click += new System.EventHandler(this.btMediaFinal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btMediaFinal);
            this.Controls.Add(this.btNotaMinima);
            this.Controls.Add(this.btSimularMedia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSimularMedia;
        private System.Windows.Forms.Button btNotaMinima;
        private System.Windows.Forms.Button btMediaFinal;
    }
}

