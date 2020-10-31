using OOP.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interface
{
    public interface ICadastro
    {
        int Incluir(Setor setor);
        Boolean Excluir(int codigo);
        Boolean Alterar(Setor setor);
        Setor Consultar(int codigo);
    }
}
