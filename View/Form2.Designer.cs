namespace OOP.View
{
    partial class Form2
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
            this.lbCartaoFuncionario = new System.Windows.Forms.ListBox();
            this.btCartaoFuncionario = new System.Windows.Forms.Button();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDebitoCredito = new System.Windows.Forms.ComboBox();
            this.btAlterarSaldo = new System.Windows.Forms.Button();
            this.btAumento = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAumento = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbCartaoFuncionario
            // 
            this.lbCartaoFuncionario.FormattingEnabled = true;
            this.lbCartaoFuncionario.Location = new System.Drawing.Point(12, 41);
            this.lbCartaoFuncionario.Name = "lbCartaoFuncionario";
            this.lbCartaoFuncionario.Size = new System.Drawing.Size(348, 147);
            this.lbCartaoFuncionario.TabIndex = 9;
            // 
            // btCartaoFuncionario
            // 
            this.btCartaoFuncionario.Location = new System.Drawing.Point(12, 12);
            this.btCartaoFuncionario.Name = "btCartaoFuncionario";
            this.btCartaoFuncionario.Size = new System.Drawing.Size(348, 23);
            this.btCartaoFuncionario.TabIndex = 8;
            this.btCartaoFuncionario.Text = "Cartões dos funcionarios";
            this.btCartaoFuncionario.UseVisualStyleBackColor = true;
            this.btCartaoFuncionario.Click += new System.EventHandler(this.btCartaoFuncionario_Click);
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(50, 194);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(133, 20);
            this.tbValor.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Valor";
            // 
            // cmbDebitoCredito
            // 
            this.cmbDebitoCredito.FormattingEnabled = true;
            this.cmbDebitoCredito.Items.AddRange(new object[] {
            "Débito",
            "Crédito"});
            this.cmbDebitoCredito.Location = new System.Drawing.Point(239, 193);
            this.cmbDebitoCredito.Name = "cmbDebitoCredito";
            this.cmbDebitoCredito.Size = new System.Drawing.Size(121, 21);
            this.cmbDebitoCredito.TabIndex = 12;
            // 
            // btAlterarSaldo
            // 
            this.btAlterarSaldo.Location = new System.Drawing.Point(16, 220);
            this.btAlterarSaldo.Name = "btAlterarSaldo";
            this.btAlterarSaldo.Size = new System.Drawing.Size(348, 23);
            this.btAlterarSaldo.TabIndex = 13;
            this.btAlterarSaldo.Text = "Alterar saldo do cartão";
            this.btAlterarSaldo.UseVisualStyleBackColor = true;
            this.btAlterarSaldo.Click += new System.EventHandler(this.btAlterarSaldo_Click);
            // 
            // btAumento
            // 
            this.btAumento.Location = new System.Drawing.Point(16, 274);
            this.btAumento.Name = "btAumento";
            this.btAumento.Size = new System.Drawing.Size(348, 23);
            this.btAumento.TabIndex = 16;
            this.btAumento.Text = "Aumentar salário";
            this.btAumento.UseVisualStyleBackColor = true;
            this.btAumento.Click += new System.EventHandler(this.btAumento_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Percentual";
            // 
            // tbAumento
            // 
            this.tbAumento.Location = new System.Drawing.Point(77, 248);
            this.tbAumento.Name = "tbAumento";
            this.tbAumento.Size = new System.Drawing.Size(106, 20);
            this.tbAumento.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 336);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(348, 20);
            this.textBox1.TabIndex = 17;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btAumento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAumento);
            this.Controls.Add(this.btAlterarSaldo);
            this.Controls.Add(this.cmbDebitoCredito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.lbCartaoFuncionario);
            this.Controls.Add(this.btCartaoFuncionario);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCartaoFuncionario;
        private System.Windows.Forms.Button btCartaoFuncionario;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDebitoCredito;
        private System.Windows.Forms.Button btAlterarSaldo;
        private System.Windows.Forms.Button btAumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAumento;
        private System.Windows.Forms.TextBox textBox1;
    }
}