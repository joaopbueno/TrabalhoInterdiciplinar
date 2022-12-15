using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Trab_Interdiciplinar.Menu
{
    public partial class Planejamento : Form
    {
        public Planejamento()
        {
            InitializeComponent();
            configuraDataGrid();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Sair_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAtualizarDados_Click(object sender, EventArgs e)
        {
            AtualizarDados atualizarDados = new AtualizarDados();
            atualizarDados.Show();
        }

        private void configuraDataGrid()
        {
            Conexao conexao = new Conexao();
            List<Veiculo> veiculosTemp = conexao.getInfoVeiculo();
            List<Veiculo> veiculos = new List<Veiculo>();
            foreach(Veiculo veiculo in veiculosTemp)
            {
                if(veiculo.quilometragemAndada >= 200)
                {
                    veiculos.Add(veiculo);
                }
            }
            var list  = new BindingList<Veiculo>(veiculos);
            var source = new BindingSource(list, null);
            dgvListaDeCarros.DataSource = source;
            conexao.fecharConexao();
        }

        private void dgvListaDeCarros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
