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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btFuncionarios_Click(object sender, EventArgs e)
        {
            this.lbFuncionarios.Items.Clear();

            Funcionario fun1 = new Funcionario();
            fun1.codigo = 1;
            fun1.nome = "Konagai Haji Fadil";
            fun1.salario = 5800.00m;

            Funcionario fun2 = new Funcionario();
            fun2.codigo = 2;
            fun2.nome = "Bruno Brunelli Lima";
            fun2.salario = 6200.00m;

            this.lbFuncionarios.Items.Add(
                fun1.codigo + " " + 
                fun1.nome + " " + fun1.salario.ToString("n2")
                );

            this.lbFuncionarios.Items.Add(
                fun2.codigo + " " + 
                fun2.nome + " " + fun2.salario.ToString("n2")
                );
        }

        private void btCartoes_Click(object sender, EventArgs e)
        {
            this.lbCartoes.Items.Clear();

            Cartao cartao = new Cartao();
            cartao.numero = 123456789;
            cartao.dataValidade = new DateTime(2021, 12, 31);
            cartao.limite = 1000.00m;

            this.lbCartoes.Items.Add(
                cartao.numero + "  " +
                cartao.dataValidade.ToString("dd/MM/yyyy") + " " +
                cartao.limite.ToString("n2")
                );

            cartao = new Cartao();
            cartao.numero = 987654321;
            cartao.dataValidade = DateTime.Now;
            cartao.limite = 800.00m;

            this.lbCartoes.Items.Add(
                cartao.numero + "  " +
                cartao.dataValidade.ToString("dd/MM/yyyy") + " " +
                cartao.limite.ToString("n2")
                );
        }

        private void btSetores_Click(object sender, EventArgs e)
        {
            this.lbSetores.Items.Clear();

            Setor setor = new Setor();
            setor.Codigo = 1;
            setor.Nome = "T.I";
            setor.NumeroMaximoFuncionarios = 10;
            setor.TotalFuncionariosSetor = 3;

            string txtSetor =
            setor.Codigo + " " +
            setor.Nome + " " +
            setor.NumeroMaximoFuncionarios + " " +
            setor.TotalFuncionariosSetor;

            this.lbSetores.Items.Add(txtSetor);

            setor.Codigo = 2;
            setor.Nome = "CONTABILIDADE";
            setor.NumeroMaximoFuncionarios = 5;
            setor.TotalFuncionariosSetor = 2;

            txtSetor =
            setor.Codigo + " " +
            setor.Nome + " " +
            setor.NumeroMaximoFuncionarios + " " +
            setor.TotalFuncionariosSetor;

            this.lbSetores.Items.Add(txtSetor);
        }

        private void btCartaoFuncionario_Click(object sender, EventArgs e)
        {
            this.lbCartaoFuncionario.Items.Clear();
            Funcionario funcionario = 
                new Funcionario(1, "Konagai Haji Fadil");
            //funcionario.salario = 5800.00m;

/*            Funcionario funcionario =
                new Funcionario
                {
                    codigo = 1,
                    nome = "Konagai Haji Fadil",
                    salario = 5800.00m
                };

            Cartao cartao = new Cartao(
                new Funcionario { codigo = 1, nome = "tatatat", salario = 1000 }
                );*/

            Cartao cartao = new Cartao(funcionario);
            cartao.numero = 123456789;
            cartao.dataValidade = new DateTime(2021, 12, 31);

            this.lbCartaoFuncionario.Items.Add(
                cartao.numero + "  " +
                cartao.dataValidade.ToString("dd/MM/yyyy") + " " +
                cartao.limite.ToString("n2") + " " +
                cartao.funcionario.codigo + " " +
                cartao.funcionario.nome + " " +
                cartao.funcionario.salario.ToString("n2") + " " +
                cartao.funcionario.PercentualImposto.ToString("n2") + " " +
                cartao.funcionario.CalcularImposto(cartao.funcionario.salario)
                );

        }

        private void btProprietarios_Click(object sender, EventArgs e)
        {
            this.lbProprietarios.Items.Clear();

            Proprietario p = new Proprietario();
            p.codigo = 1;
            p.nome = "Geovanna Sversutti";
            p.valorProlabore = 8000.00m;
            p.PercentualImposto = 15;
            p.percentualParticipacao = 51;

            this.lbProprietarios.Items.Add(
                p.codigo + " " +
                p.nome + " " +
                p.valorProlabore.ToString("n2") + " " +
                p.percentualParticipacao.ToString("n2") + " " +
                p.PercentualImposto.ToString("n2") + " " +
                p.CalcularImposto(p.valorProlabore)
                );
        }
    }
}
