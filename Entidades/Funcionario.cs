using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP.Entidades
{
    public class Funcionario : Colaborador
    {
        public decimal salario { get; set; }

        public Funcionario() { }
        public Funcionario(int codigo, string nome)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.salario = 1500;
            this.PercentualImposto = 5;
        }

        public void AumentarSalario(decimal percentual)
        {
            decimal aumento;
            aumento = (salario * percentual / 100);
            salario += aumento;

            decimal valorImposto = aumento * percentual;
        }

        public void AumentarSalario()
        {
            this.AumentarSalario(10);
        }

        public void AumentarSalario(decimal percentual, decimal bonificacao)
        {
            this.AumentarSalario(percentual);
            salario += bonificacao;
        }
    }
}
