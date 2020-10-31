using Db4objects.Db4o;
using Db4objects.Db4o.Query;
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
    public partial class Form4 : Form, ICadastro
    {
        public Form4()
        {
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
            Setor s = new Setor();
            s.Codigo = setor.Codigo;
            IObjectSet result = ConexaoDB4O.GetConexao().QueryByExample(s);
            if (result.HasNext())
            {
                s = (Setor)result.Next();

                s.Nome = setor.Nome;
                s.NumeroMaximoFuncionarios = setor.NumeroMaximoFuncionarios;
                s.TotalFuncionariosSetor = setor.TotalFuncionariosSetor;

                ConexaoDB4O.GetConexao().Store(s);

                return true;
            }

            return false;
        }

        public Setor Consultar(int codigo)
        {
            /*            Setor s = new Setor();
                        IList<Setor> setores = ConexaoDB4O.GetConexao().Query<Setor>(delegate (Setor al)
                        {
                            if (al.Nome.Contains(tbPesquisa.Text))
                                return true;

                            return false;
                        });

                        if (setores.Count > 0)
                            return setores[0];


                        Setor setor = new Setor();
                        setor.Codigo = codigo;
                        if (!String.IsNullOrEmpty(this.tbPesquisa.Text))
                            setor.Nome = this.tbPesquisa.Text;

                        IObjectSet result = ConexaoDB4O.GetConexao().QueryByExample(setor);
                        if (result.HasNext())
                            return (Setor)result.Next();

                        return null;
                        */
            return null;
        }

        public bool Excluir(int codigo)
        {
            Setor s = new Setor();
            s.Codigo = codigo;
            IObjectSet result = ConexaoDB4O.GetConexao().QueryByExample(s);
            if (result.HasNext())
            {
                s = (Setor)result.Next();
                ConexaoDB4O.GetConexao().Delete(s);
                return true;
            }

            return false;
        }

        public int Incluir(Setor setor)
        {
            int codigo = 0;

            /*          Setor s = new Setor();
                        IList<Setor> setores = ConexaoDB4O.GetConexao().Query<Setor>(delegate (Setor al)
                        {
                            return true;
                        });

                        if(setores.Count > 0)
                        {
                            s = setores.Last<Setor>();
                            codigo = s.Codigo;
                        }
            */

            Setor s = new Setor();
            IQuery registro = ConexaoDB4O.GetConexao().Query();
            registro.Constrain(typeof(Setor));
            registro.Descend("codigo").OrderDescending();
            IObjectSet result = null;
            try
            {
                result = registro.Execute();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            if (result != null && result.HasNext())
            {
                s = (Setor)result.Next();
                codigo = s.Codigo;
            }
            codigo++;

            setor.Codigo = codigo;

            ConexaoDB4O.GetConexao().Store(setor);

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

/*        private void btPesquisar_Click(object sender, EventArgs e)
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
        */

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
        private void btSair_Click(object sender, EventArgs e)
        {
            ConexaoDB4O.FecharConexao();
            Application.Exit();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConexaoDB4O.FecharConexao();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            ConexaoDB4O.FecharConexao();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            ConsultaSetorForm cs = new ConsultaSetorForm();
            cs.ShowDialog();

            if (cs.retornoSetor != null)
            {
                this.tbCodigo.Text = cs.retornoSetor.Codigo.ToString();
                this.tbNome.Text = cs.retornoSetor.Nome;
                this.tbNumeroMaximoFuncionarios.Text = cs.retornoSetor.NumeroMaximoFuncionarios.ToString();
                this.tbTotalFuncionariosSetor.Text = cs.retornoSetor.TotalFuncionariosSetor.ToString();

                this.FormatarTelaCampoTela();
                this.btExcluir.Enabled = true;
                this.btPesquisar.Enabled = true;
            }
            else
            {
                this.tbCodigo.Focus();
            }
        }
    }
}
