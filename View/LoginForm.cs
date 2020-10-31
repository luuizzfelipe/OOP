using OOP.Entidades;
using OOP.Repositorio;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btLogar_Click(object sender, EventArgs e)
        {
            string login = this.tbLogin.Text;
            string senha = this.tbSenha.Text;

            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Credenciais devem ser informadas. Tente novamente");
            }
            else
            {
                if (login.Equals("konagai") && senha.Equals("haji"))
                {
                    Usuario usuario = new Usuario();
                    usuario.login = login;

                    DadosDeAcesso.usuario = usuario;
                    DadosDeAcesso.dataHoraAcesso = DateTime.Now;

                    if (ConexaoDB4O.GetConexao() != null)
                    {
                        this.Hide();
                        Form4 f = new Form4();
                        f.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Conexão não estabelecida");
                    }

                }
                else
                    MessageBox.Show("Credenciais inválidas.");
            }
        }
    }
}
