using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Entidades
{
    public class Proprietario : Colaborador
    {
        public decimal valorProlabore { get; set; }
        public decimal percentualParticipacao { get; set; }

        public decimal CalcularImposto(decimal valorBase)
        {
            decimal valorImposto = 0;
            valorImposto = base.CalcularImposto(valorBase);
            valorImposto -= valorImposto * 20.00m / 100.00m;
            return valorImposto;
        }
    }
}
