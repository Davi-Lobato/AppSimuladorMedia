namespace AppSimuladorMedia.Formulários
{
    partial class FormSimularMedia
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
            this.lbNomeAcademico = new System.Windows.Forms.Label();
            this.lbNota1 = new System.Windows.Forms.Label();
            this.lbNota2 = new System.Windows.Forms.Label();
            this.lbMediaAcademica = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(126, 35);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(241, 25);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Calculadora de média";
            this.lbTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbNomeAcademico
            // 
            this.lbNomeAcademico.AutoSize = true;
            this.lbNomeAcademico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeAcademico.Location = new System.Drawing.Point(44, 104);
            this.lbNomeAcademico.Name = "lbNomeAcademico";
            this.lbNomeAcademico.Size = new System.Drawing.Size(92, 20);
            this.lbNomeAcademico.TabIndex = 1;
            this.lbNomeAcademico.Text = "Seu Nome";
            this.lbNomeAcademico.Click += new System.EventHandler(this.lbNomeAcademico_Click);
            // 
            // lbNota1
            // 
            this.lbNota1.AutoSize = true;
            this.lbNota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNota1.Location = new System.Drawing.Point(44, 160);
            this.lbNota1.Name = "lbNota1";
            this.lbNota1.Size = new System.Drawing.Size(146, 20);
            this.lbNota1.TabIndex = 2;
            this.lbNota1.Text = "Nota da 1° Etapa";
            this.lbNota1.Click += new System.EventHandler(this.lbNota1_Click);
            // 
            // lbNota2
            // 
            this.lbNota2.AutoSize = true;
            this.lbNota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNota2.Location = new System.Drawing.Point(44, 229);
            this.lbNota2.Name = "lbNota2";
            this.lbNota2.Size = new System.Drawing.Size(146, 20);
            this.lbNota2.TabIndex = 3;
            this.lbNota2.Text = "Nota da 2° Etapa";
            this.lbNota2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lbNota2.Click += new System.EventHandler(this.lbNota2_Click);
            // 
            // lbMediaAcademica
            // 
            this.lbMediaAcademica.AutoSize = true;
            this.lbMediaAcademica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMediaAcademica.Location = new System.Drawing.Point(195, 308);
            this.lbMediaAcademica.Name = "lbMediaAcademica";
            this.lbMediaAcademica.Size = new System.Drawing.Size(94, 20);
            this.lbMediaAcademica.TabIndex = 4;
            this.lbMediaAcademica.Text = "Sua média";
            this.lbMediaAcademica.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lbMediaAcademica.Click += new System.EventHandler(this.lbMediaAcademica_Click);
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(292, 104);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(139, 73);
            this.btCalcular.TabIndex = 5;
            this.btCalcular.Text = "CALCULAR";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(292, 205);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(139, 71);
            this.btNovo.TabIndex = 6;
            this.btNovo.Text = "NOVO CÁLCULO";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(48, 128);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(142, 20);
            this.txtNome.TabIndex = 7;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(48, 194);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(142, 20);
            this.txtNota1.TabIndex = 8;
            this.txtNota1.TextChanged += new System.EventHandler(this.txtNota1_TextChanged);
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(48, 256);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(142, 20);
            this.txtNota2.TabIndex = 9;
            this.txtNota2.TextChanged += new System.EventHandler(this.txtNota2_TextChanged);
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(48, 331);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(383, 20);
            this.txtMedia.TabIndex = 10;
            this.txtMedia.TextChanged += new System.EventHandler(this.txtMedia_TextChanged);
            // 
            // FormSimularMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 450);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.lbMediaAcademica);
            this.Controls.Add(this.lbNota2);
            this.Controls.Add(this.lbNota1);
            this.Controls.Add(this.lbNomeAcademico);
            this.Controls.Add(this.lbTitulo);
            this.Name = "FormSimularMedia";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbNomeAcademico;
        private System.Windows.Forms.Label lbNota1;
        private System.Windows.Forms.Label lbNota2;
        private System.Windows.Forms.Label lbMediaAcademica;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtMedia;
    }
}