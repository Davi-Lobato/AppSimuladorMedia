namespace AppSimuladorMedia.Formulários
{
    partial class FormNotaMinima
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.txtNotaM = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btNovo = new System.Windows.Forms.Button();
            this.btCalcular = new System.Windows.Forms.Button();
            this.lbNotaMinima = new System.Windows.Forms.Label();
            this.lbNomeAcademico = new System.Windows.Forms.Label();
            this.lbMediaF = new System.Windows.Forms.Label();
            this.txtMediaF = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(101, 45);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(308, 25);
            this.lbTitulo.TabIndex = 1;
            this.lbTitulo.Text = "Calculadora de Nota mínima";
            // 
            // txtNotaM
            // 
            this.txtNotaM.Location = new System.Drawing.Point(70, 283);
            this.txtNotaM.Name = "txtNotaM";
            this.txtNotaM.Size = new System.Drawing.Size(383, 20);
            this.txtNotaM.TabIndex = 20;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(70, 126);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(142, 20);
            this.txtNome.TabIndex = 17;
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(314, 171);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(124, 41);
            this.btNovo.TabIndex = 16;
            this.btNovo.Text = "NOVO CÁLCULO";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(314, 102);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(124, 44);
            this.btCalcular.TabIndex = 15;
            this.btCalcular.Text = "CALCULAR";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // lbNotaMinima
            // 
            this.lbNotaMinima.AutoSize = true;
            this.lbNotaMinima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotaMinima.Location = new System.Drawing.Point(158, 260);
            this.lbNotaMinima.Name = "lbNotaMinima";
            this.lbNotaMinima.Size = new System.Drawing.Size(199, 20);
            this.lbNotaMinima.TabIndex = 14;
            this.lbNotaMinima.Text = "Pontos para aprovação:";
            this.lbNotaMinima.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbNomeAcademico
            // 
            this.lbNomeAcademico.AutoSize = true;
            this.lbNomeAcademico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeAcademico.Location = new System.Drawing.Point(66, 102);
            this.lbNomeAcademico.Name = "lbNomeAcademico";
            this.lbNomeAcademico.Size = new System.Drawing.Size(92, 20);
            this.lbNomeAcademico.TabIndex = 11;
            this.lbNomeAcademico.Text = "Seu Nome";
            // 
            // lbMediaF
            // 
            this.lbMediaF.AutoSize = true;
            this.lbMediaF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMediaF.Location = new System.Drawing.Point(66, 158);
            this.lbMediaF.Name = "lbMediaF";
            this.lbMediaF.Size = new System.Drawing.Size(182, 20);
            this.lbMediaF.TabIndex = 12;
            this.lbMediaF.Text = "Digite sua média final";
            // 
            // txtMediaF
            // 
            this.txtMediaF.Location = new System.Drawing.Point(70, 192);
            this.txtMediaF.Name = "txtMediaF";
            this.txtMediaF.Size = new System.Drawing.Size(142, 20);
            this.txtMediaF.TabIndex = 18;
            // 
            // FormNotaMinima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.txtNotaM);
            this.Controls.Add(this.txtMediaF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.lbNotaMinima);
            this.Controls.Add(this.lbMediaF);
            this.Controls.Add(this.lbNomeAcademico);
            this.Controls.Add(this.lbTitulo);
            this.Name = "FormNotaMinima";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.TextBox txtNotaM;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label lbNotaMinima;
        private System.Windows.Forms.Label lbNomeAcademico;
        private System.Windows.Forms.Label lbMediaF;
        private System.Windows.Forms.TextBox txtMediaF;
    }
}