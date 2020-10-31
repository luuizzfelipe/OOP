using OOP.Entidades;
using OOP.Interface;
using OOP.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.View
{
    public partial class Form3 : Form, ICadastro
    {
        List<Setor> setores;

        public Form3()
        {
            setores = new List<Setor>();
            InitializeComponent();
            this.FormatarTelaCampoChave();

            this.tbUsuarioLogado.Text = " Usuario logado: " + DadosDeAcesso.usuario.login;
            this.tbUsuarioLogado.Text += " Data/Hora acesso: " + DadosDeAcesso.dataHoraAcesso;
        }

        private void FormatarTelaCampoChave()
        {
            this.tbNome.Clear();
            this.tbNumeroMaximoFuncionarios.Clear();
            this.tbTotalFuncionariosSetor.Clear();

            this.tbNome.Enabled = false;
            this.tbNumeroMaximoFuncionarios.Enabled = false;
            this.tbTotalFuncionariosSetor.Enabled = false;

            this.btExcluir.Enabled = false;
            this.btSalvar.Enabled = false;
            this.btIncluir.Enabled = true;

            this.tbCodigo.Enabled = true;
            this.tbCodigo.Focus();
        }
        private void FormatarTelaCampoTela()
        {
            this.tbCodigo.Enabled = false;

            this.tbNome.Enabled = true;
            this.tbNumeroMaximoFuncionarios.Enabled = true;
            this.tbTotalFuncionariosSetor.Enabled = true;

            this.btSalvar.Enabled = true;
            this.btIncluir.Enabled = false;

            this.tbNome.Focus();
        }

        public bool Alterar(Setor setor)
        {
            for (int i = 0; i < setores.Count; i++)
            { 
                if(setores[i].Codigo == setor.Codigo)
                {
                    setores[i] = setor;
                    return true;
                }
            }

            return false;
        }

        public Setor Consultar(int codigo)
        {
            foreach (Setor setor in setores)
            {
                if (setor.Codigo.Equals(codigo))
                    return setor;
            }

            return null;
        }

        public bool Excluir(int codigo)
        {
            try
            {
                foreach (Setor setor in setores)
                {
                    if (setor.Codigo.Equals(codigo))
                    {
                        setores.Remove(setor);
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return false;
        }

        public int Incluir(Setor setor)
        {
            int codigo = 0;

            if (setores.Count > 0)
            {
                Setor ultimoSetor = setores.Last<Setor>();
                codigo = ultimoSetor.Codigo;
            }
            if (codigo == 0)
                codigo = 100;
            codigo++;

            setor.Codigo = codigo;

            setores.Add(setor);

            return codigo;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.FormatarTelaCampoChave();
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            this.tbCodigo.Clear();
            this.FormatarTelaCampoTela();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Setor setor = new Setor();
            setor.Nome = this.tbNome.Text;
            setor.NumeroMaximoFuncionarios = Convert.ToInt32(this.tbNumeroMaximoFuncionarios.Text);
            setor.TotalFuncionariosSetor = Convert.ToInt32(this.tbTotalFuncionariosSetor.Text);
            if (String.IsNullOrEmpty(this.tbCodigo.Text))
            {
                int codigo = this.Incluir(setor);
                if(codigo > 0)
                    MessageBox.Show("Inclusão realizada com sucesso --> codigo: " + codigo);
                else
                    MessageBox.Show("Inclusão não realizada. Verifique");
            }
            else
            {
                setor.Codigo = Convert.ToInt32(this.tbCodigo.Text);
                if(this.Alterar(setor))
                    MessageBox.Show("Alteração realizada com sucesso --> codigo: " + setor.Codigo);
                else
                    MessageBox.Show("Alteração não realizada.");
            }

            this.FormatarTelaCampoChave();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.tbCodigo.Text))
            {
                MessageBox.Show("Para realizar a pesquisa informe o código");
                this.tbCodigo.Focus();
            }
            else
            {
                Setor setor = this.Consultar(Convert.ToInt32(this.tbCodigo.Text));
                if (setor == null)
                {
                    MessageBox.Show("Setor não encontrado");
                    this.tbCodigo.Focus();
                }
                else
                {
                    this.tbNome.Text = setor.Nome;
                    this.tbNumeroMaximoFuncionarios.Text = setor.NumeroMaximoFuncionarios.ToString();
                    this.tbTotalFuncionariosSetor.Text = setor.TotalFuncionariosSetor.ToString();

                    this.FormatarTelaCampoTela();
                    this.btExcluir.Enabled = true;
                    this.btPesquisar.Enabled = true;
                }
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Excluir(Convert.ToInt32(this.tbCodigo.Text)))
                    MessageBox.Show("Setor excluído com sucesso.");
                else
                    MessageBox.Show("Setor não foi excluído. Verifique.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Setor não foi excluído. Verifique. Erro: " + ex.Message);
            }

            this.FormatarTelaCampoChave();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }
    }
}
