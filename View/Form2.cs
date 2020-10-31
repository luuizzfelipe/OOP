using OOP.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.View
{
    public partial class Form2 : Form
    {
        Funcionario funcionario = new Funcionario();
        Cartao cartao = new Cartao();
        public Form2()
        {
            InitializeComponent();

            textBox1.Text = DadosDeAcesso.usuario.login;
        }

        private void btCartaoFuncionario_Click(object sender, EventArgs e)
        {
            CarregarDadosPadrao(1000m, 5800m);
            AtualizarListBox();
        }

        private void btAlterarSaldo_Click(object sender, EventArgs e)
        {
            decimal valor;

            if (String.IsNullOrEmpty(tbValor.Text))
                MessageBox.Show("Informe o valor");
            else
            {
                valor = Convert.ToDecimal(tbValor.Text);
                if (cmbDebitoCredito.SelectedIndex == 0)
                    cartao.Debitar(valor);
                if (cmbDebitoCredito.SelectedIndex == 1)
                    cartao.Creditar(valor);
            }

            CarregarDadosPadrao(0,0);
            AtualizarListBox();
        }
        private void CarregarDadosPadrao(decimal limiteInicial, decimal salarioInicial)
        {
            this.lbCartaoFuncionario.Items.Clear();

            funcionario.codigo = 1;
            funcionario.nome = "Konagai Haji Fadil";
            if (salarioInicial > 0)
                funcionario.salario = salarioInicial;

            cartao.numero = 123456789;
            cartao.dataValidade = new DateTime(2021, 12, 31);
            if (limiteInicial > 0)
                cartao.limite = limiteInicial;
            cartao.funcionario = funcionario;
        }
        private void AtualizarListBox()
        {
            this.lbCartaoFuncionario.Items.Add(
                cartao.numero + "  " +
                cartao.dataValidade.ToString("dd/MM/yyyy") + " " +
                cartao.limite.ToString("n2") + " " +
                cartao.funcionario.codigo + " " +
                cartao.funcionario.nome + " " +
                cartao.funcionario.salario.ToString("n2")
                );
        }

        private void btAumento_Click(object sender, EventArgs e)
        {
            decimal perc = Convert.ToDecimal(tbAumento.Text);
            if (perc > 0)
            {
                if(perc == 5)
                    funcionario.AumentarSalario(perc, 100);
                else
                    funcionario.AumentarSalario(perc);
            }
            else
                funcionario.AumentarSalario();

            CarregarDadosPadrao(0, 0);
            AtualizarListBox();
        }
    }
}
