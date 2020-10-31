namespace OOP.View
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
            this.btFuncionarios = new System.Windows.Forms.Button();
            this.lbFuncionarios = new System.Windows.Forms.ListBox();
            this.lbCartoes = new System.Windows.Forms.ListBox();
            this.btCartoes = new System.Windows.Forms.Button();
            this.lbSetores = new System.Windows.Forms.ListBox();
            this.btSetores = new System.Windows.Forms.Button();
            this.lbCartaoFuncionario = new System.Windows.Forms.ListBox();
            this.btCartaoFuncionario = new System.Windows.Forms.Button();
            this.lbProprietarios = new System.Windows.Forms.ListBox();
            this.btProprietarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btFuncionarios
            // 
            this.btFuncionarios.Location = new System.Drawing.Point(12, 12);
            this.btFuncionarios.Name = "btFuncionarios";
            this.btFuncionarios.Size = new System.Drawing.Size(171, 23);
            this.btFuncionarios.TabIndex = 0;
            this.btFuncionarios.Text = "Funcionários";
            this.btFuncionarios.UseVisualStyleBackColor = true;
            this.btFuncionarios.Click += new System.EventHandler(this.btFuncionarios_Click);
            // 
            // lbFuncionarios
            // 
            this.lbFuncionarios.FormattingEnabled = true;
            this.lbFuncionarios.Location = new System.Drawing.Point(12, 41);
            this.lbFuncionarios.Name = "lbFuncionarios";
            this.lbFuncionarios.Size = new System.Drawing.Size(171, 147);
            this.lbFuncionarios.TabIndex = 1;
            // 
            // lbCartoes
            // 
            this.lbCartoes.FormattingEnabled = true;
            this.lbCartoes.Location = new System.Drawing.Point(189, 41);
            this.lbCartoes.Name = "lbCartoes";
            this.lbCartoes.Size = new System.Drawing.Size(171, 147);
            this.lbCartoes.TabIndex = 3;
            // 
            // btCartoes
            // 
            this.btCartoes.Location = new System.Drawing.Point(189, 12);
            this.btCartoes.Name = "btCartoes";
            this.btCartoes.Size = new System.Drawing.Size(171, 23);
            this.btCartoes.TabIndex = 2;
            this.btCartoes.Text = "Cartões";
            this.btCartoes.UseVisualStyleBackColor = true;
            this.btCartoes.Click += new System.EventHandler(this.btCartoes_Click);
            // 
            // lbSetores
            // 
            this.lbSetores.FormattingEnabled = true;
            this.lbSetores.Location = new System.Drawing.Point(366, 41);
            this.lbSetores.Name = "lbSetores";
            this.lbSetores.Size = new System.Drawing.Size(171, 147);
            this.lbSetores.TabIndex = 5;
            // 
            // btSetores
            // 
            this.btSetores.Location = new System.Drawing.Point(366, 12);
            this.btSetores.Name = "btSetores";
            this.btSetores.Size = new System.Drawing.Size(171, 23);
            this.btSetores.TabIndex = 4;
            this.btSetores.Text = "Setores";
            this.btSetores.UseVisualStyleBackColor = true;
            this.btSetores.Click += new System.EventHandler(this.btSetores_Click);
            // 
            // lbCartaoFuncionario
            // 
            this.lbCartaoFuncionario.FormattingEnabled = true;
            this.lbCartaoFuncionario.Location = new System.Drawing.Point(12, 223);
            this.lbCartaoFuncionario.Name = "lbCartaoFuncionario";
            this.lbCartaoFuncionario.Size = new System.Drawing.Size(525, 147);
            this.lbCartaoFuncionario.TabIndex = 7;
            // 
            // btCartaoFuncionario
            // 
            this.btCartaoFuncionario.Location = new System.Drawing.Point(12, 194);
            this.btCartaoFuncionario.Name = "btCartaoFuncionario";
            this.btCartaoFuncionario.Size = new System.Drawing.Size(525, 23);
            this.btCartaoFuncionario.TabIndex = 6;
            this.btCartaoFuncionario.Text = "Cartões dos funcionarios";
            this.btCartaoFuncionario.UseVisualStyleBackColor = true;
            this.btCartaoFuncionario.Click += new System.EventHandler(this.btCartaoFuncionario_Click);
            // 
            // lbProprietarios
            // 
            this.lbProprietarios.FormattingEnabled = true;
            this.lbProprietarios.Location = new System.Drawing.Point(12, 405);
            this.lbProprietarios.Name = "lbProprietarios";
            this.lbProprietarios.Size = new System.Drawing.Size(525, 147);
            this.lbProprietarios.TabIndex = 9;
            // 
            // btProprietarios
            // 
            this.btProprietarios.Location = new System.Drawing.Point(12, 376);
            this.btProprietarios.Name = "btProprietarios";
            this.btProprietarios.Size = new System.Drawing.Size(525, 23);
            this.btProprietarios.TabIndex = 8;
            this.btProprietarios.Text = "Proprietários";
            this.btProprietarios.UseVisualStyleBackColor = true;
            this.btProprietarios.Click += new System.EventHandler(this.btProprietarios_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 508);
            this.Controls.Add(this.lbProprietarios);
            this.Controls.Add(this.btProprietarios);
            this.Controls.Add(this.lbCartaoFuncionario);
            this.Controls.Add(this.btCartaoFuncionario);
            this.Controls.Add(this.lbSetores);
            this.Controls.Add(this.btSetores);
            this.Controls.Add(this.lbCartoes);
            this.Controls.Add(this.btCartoes);
            this.Controls.Add(this.lbFuncionarios);
            this.Controls.Add(this.btFuncionarios);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btFuncionarios;
        private System.Windows.Forms.ListBox lbFuncionarios;
        private System.Windows.Forms.ListBox lbCartoes;
        private System.Windows.Forms.Button btCartoes;
        private System.Windows.Forms.ListBox lbSetores;
        private System.Windows.Forms.Button btSetores;
        private System.Windows.Forms.ListBox lbCartaoFuncionario;
        private System.Windows.Forms.Button btCartaoFuncionario;
        private System.Windows.Forms.ListBox lbProprietarios;
        private System.Windows.Forms.Button btProprietarios;
    }
}

