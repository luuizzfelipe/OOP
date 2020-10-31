using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Repositorio
{
    public static class ConexaoDB4O
    {
        static IObjectContainer conexao = null;
        static string localizacaoBanco = @"c:\temp\oop.db";

        public static IObjectContainer GetConexao()
        {
            if(conexao == null)
                conexao = Db4oFactory.OpenFile(localizacaoBanco);

            return conexao;
        }

        public static void FecharConexao()
        {
            if (conexao != null)
                conexao.Close();
        }
    }
}
