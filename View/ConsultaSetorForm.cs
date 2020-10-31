using Db4objects.Db4o;
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
    public partial class ConsultaSetorForm : Form
    {
        DataSetOOP.SetorDataTable setDT;


        public Setor retornoSetor { get; set; }

        public ConsultaSetorForm()
        {
            InitializeComponent();

            this.tbPesquisa.Focus();

            setDT = new DataSetOOP.SetorDataTable();
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            IList<Setor> setores = ConexaoDB4O.GetConexao().Query<Setor>(delegate (Setor al)
            {
                if (al.Nome.Contains(tbPesquisa.Text))
                    return true;

                return false;
            });




            CarregarDadosGridSetorList(setores);
        }

        private void CarregarDadosGridSetorDataTable(IList<Setor> setores)
        {
            foreach(Setor st in setores)
            {
                DataRow linha = setDT.NewRow();

                linha["DC_Codigo"] = st.Codigo;
                linha["DC_Nome"] = st.Nome;

                setDT.Rows.Add(linha);
            }
            this.dataGridViewSetores.DataSource = setDT;
        }

        private void CarregarDadosGridSetorList(IList<Setor> setores)
        {
            this.dataGridViewSetores.Rows.Clear();

            foreach (Setor s in setores)
            {
                // primeira opção
                //int indice = dataGridViewSetores.Rows.Add();
                //DataGridViewRow linha = this.dataGridViewSetores.Rows[indice];
                //linha.Cells["codigo"].Value = s.Codigo;
                //linha.Cells["nome"].Value = s.Nome;

                //segunda opção
                DataGridViewRow linha = new DataGridViewRow();
                linha.CreateCells(dataGridViewSetores);
                linha.Cells[0].Value = s.Codigo;
                linha.Cells[1].Value = s.Nome;
                dataGridViewSetores.Rows.Add(linha);
            }
        }

        private void dataGridViewSetores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int codigo = Convert.ToInt32(this.dataGridViewSetores.Rows[e.RowIndex].Cells["codigo"].Value);
            IObjectSet result = ConexaoDB4O.GetConexao().QueryByExample(new Setor { Codigo = codigo });
            if (result.HasNext())
                retornoSetor = (Setor)result.Next();

            this.Dispose();
        }
    }
}

