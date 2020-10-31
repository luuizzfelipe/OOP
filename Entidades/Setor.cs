using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Entidades
{
    public class Setor
    {
        private int codigo;
        private string nome;
        private int numeroMaximoFuncionarios;
        private int totalFuncionariosSetor;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nome {
            get { return nome; }
            set { nome = value; }
        }
        public int NumeroMaximoFuncionarios 
        {
            get { return numeroMaximoFuncionarios; }
            set { numeroMaximoFuncionarios = value; }
        }
        public int TotalFuncionariosSetor
        {
            get { return totalFuncionariosSetor; }
            set { totalFuncionariosSetor = value; }
        }

    }
}
