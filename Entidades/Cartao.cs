using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Entidades
{
    public class Cartao
    {
        public int numero { get; set; }
        public decimal limite { get; set; }
        public Funcionario funcionario { get; set; }
        public DateTime dataValidade { get; set; }

        /*public int Numero
        {
            get { return this.numero; }
            set { this.numero = value + 9000000; }
        }*/

        public Cartao() { }
        public Cartao(Funcionario f)
        {
            InicializarAtributos(f, 1000);
        }
        public Cartao(Funcionario f, decimal l)
        {
            InicializarAtributos(f, l);
        }
        
        private void InicializarAtributos(Funcionario f, decimal l)
        {
            this.funcionario = f;
            this.limite = l;
        }

        public void Creditar(decimal valor)
        {
            limite += valor;
        }

        public void Debitar(decimal valor)
        {
            limite -= valor;
        }

        public decimal SaldoAtual()
        {
            return limite;
        }
    }
}
