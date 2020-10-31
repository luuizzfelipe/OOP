using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Entidades
{
    public class Colaborador
    {
        public int codigo { get; set; }
        public string nome { get; set; }

        private decimal percentualImposto;
        public decimal PercentualImposto
        {
            get { return percentualImposto * 100; }
            set { this.percentualImposto = value / 100; }
        }
        public decimal CalcularImposto(decimal valorBase)
        {
            decimal valorImposto = 0;

            valorImposto = valorBase * percentualImposto;
            valorImposto -= valorImposto * 5.00m / 100.00m;

            return valorImposto;
        }
    }
}
