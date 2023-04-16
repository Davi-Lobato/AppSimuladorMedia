namespace AppSimuladorMedia.Formulários
{
    partial class FormMediaFinal
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
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.txtExame = new System.Windows.Forms.TextBox();
            this.txtMediaFinal = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btNovo = new System.Windows.Forms.Button();
            this.btCalcular = new System.Windows.Forms.Button();
            this.lbMediaAcademica = new System.Windows.Forms.Label();
            this.lbNotaExame = new System.Windows.Forms.Label();
            this.lbMediaFinal = new System.Windows.Forms.Label();
            this.lbNomeAcademico = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(62, 352);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(383, 20);
            this.txtMedia.TabIndex = 21;
            // 
            // txtExame
            // 
            this.txtExame.Location = new System.Drawing.Point(62, 277);
            this.txtExame.Name = "txtExame";
            this.txtExame.Size = new System.Drawing.Size(142, 20);
            this.txtExame.TabIndex = 20;
            // 
            // txtMediaFinal
            // 
            this.txtMediaFinal.Location = new System.Drawing.Point(62, 215);
            this.txtMediaFinal.Name = "txtMediaFinal";
            this.txtMediaFinal.Size = new System.Drawing.Size(142, 20);
            this.txtMediaFinal.TabIndex = 19;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(62, 149);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(142, 20);
            this.txtNome.TabIndex = 18;
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(306, 226);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(139, 71);
            this.btNovo.TabIndex = 17;
            this.btNovo.Text = "NOVO CÁLCULO";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(306, 125);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(139, 73);
            this.btCalcular.TabIndex = 16;
            this.btCalcular.Text = "CALCULAR";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // lbMediaAcademica
            // 
            this.lbMediaAcademica.AutoSize = true;
            this.lbMediaAcademica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMediaAcademica.Location = new System.Drawing.Point(209, 329);
            this.lbMediaAcademica.Name = "lbMediaAcademica";
            this.lbMediaAcademica.Size = new System.Drawing.Size(94, 20);
            this.lbMediaAcademica.TabIndex = 15;
            this.lbMediaAcademica.Text = "Sua média";
            this.lbMediaAcademica.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbNotaExame
            // 
            this.lbNotaExame.AutoSize = true;
            this.lbNotaExame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotaExame.Location = new System.Drawing.Point(58, 250);
            this.lbNotaExame.Name = "lbNotaExame";
            this.lbNotaExame.Size = new System.Drawing.Size(129, 20);
            this.lbNotaExame.TabIndex = 14;
            this.lbNotaExame.Text = "Nota do exame";
            this.lbNotaExame.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbMediaFinal
            // 
            this.lbMediaFinal.AutoSize = true;
            this.lbMediaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMediaFinal.Location = new System.Drawing.Point(58, 181);
            this.lbMediaFinal.Name = "lbMediaFinal";
            this.lbMediaFinal.Size = new System.Drawing.Size(164, 20);
            this.lbMediaFinal.TabIndex = 13;
            this.lbMediaFinal.Text = "Nota da média final";
            // 
            // lbNomeAcademico
            // 
            this.lbNomeAcademico.AutoSize = true;
            this.lbNomeAcademico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeAcademico.Location = new System.Drawing.Point(58, 125);
            this.lbNomeAcademico.Name = "lbNomeAcademico";
            this.lbNomeAcademico.Size = new System.Drawing.Size(92, 20);
            this.lbNomeAcademico.TabIndex = 12;
            this.lbNomeAcademico.Text = "Seu Nome";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(140, 56);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(300, 25);
            this.lbTitulo.TabIndex = 11;
            this.lbTitulo.Text = "Calculadora de média Final";
            this.lbTitulo.Click += new System.EventHandler(this.lbTitulo_Click);
            // 
            // FormMediaFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 450);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.txtExame);
            this.Controls.Add(this.txtMediaFinal);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.lbMediaAcademica);
            this.Controls.Add(this.lbNotaExame);
            this.Controls.Add(this.lbMediaFinal);
            this.Controls.Add(this.lbNomeAcademico);
            this.Controls.Add(this.lbTitulo);
            this.Name = "FormMediaFinal";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.TextBox txtExame;
        private System.Windows.Forms.TextBox txtMediaFinal;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label lbMediaAcademica;
        private System.Windows.Forms.Label lbNotaExame;
        private System.Windows.Forms.Label lbMediaFinal;
        private System.Windows.Forms.Label lbNomeAcademico;
        private System.Windows.Forms.Label lbTitulo;
    }
}