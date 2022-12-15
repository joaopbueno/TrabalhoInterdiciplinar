using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Trab_Interdiciplinar.Menu
{
    public partial class AtualizarDados : Form
    {
        public AtualizarDados()
        {
            InitializeComponent();
        }

        private Veiculo veiculo;

        private void btnConsultarVeiculo_Click(object sender, EventArgs e)
        {
            limpaLabels();
            ckbManutencaoRealizada.Visible = false;
            lblNovaQuilometragem.Visible = false;
            txtNovaQuilometragem.Visible = false;
            btnAtualizarDados.Visible = false;
            if (txtPlacaVeiculo.Text != "")
            {
                Conexao conexao = new Conexao();
                veiculo = conexao.getInfoVeiculoEspecifico(txtPlacaVeiculo.Text);
                if (veiculo != null)
                {
                    lblMarca.Text = veiculo.marca;
                    lblModelo.Text = veiculo.modelo;
                    lblPlaca.Text = veiculo.placa;
                    lblQuilometragem.Text = Convert.ToString(veiculo.km);
                    lblTipo.Text = veiculo.tipoVeiculo;
                    lblDataUltimaManutencao.Text = veiculo.dataUltimaManutencao.GetDateTimeFormats()[0];
                    btnAtualizarDados.Visible = true;
                    ckbManutencaoRealizada.Visible = true;
                    lblNovaQuilometragem.Visible = true;
                    txtNovaQuilometragem.Visible = true;
                }
                else
                {
                    MessageBox.Show("Placa Nao Encontrada", "Falha");
                }
            }
            else
            {
                MessageBox.Show("Digite uma placa valida","Falha");
            }
        }

        private void limpaLabels()
        {
            lblMarca.Text = "";
            lblModelo.Text = "";
            lblPlaca.Text = "";
            lblQuilometragem.Text = "";
            lblTipo.Text = "";
            lblDataUltimaManutencao.Text = "";
        }

        private void btnAtualizarDados_Click(object sender, EventArgs e)
        {
            if (ckbManutencaoRealizada.Checked)
            {
                veiculo.dataUltimaManutencao = DateTime.Now;
            }
            if (txtNovaQuilometragem.Text != "")
            {
                if (veiculo.dataUltimaManutencao != DateTime.Now)
                {
                    veiculo.quilometragemAndada += int.Parse(txtNovaQuilometragem.Text) - veiculo.km;
                }
                else
                {
                    veiculo.quilometragemAndada = 0;
                    veiculo.precisaManutencao = false;
                }
                veiculo.km = int.Parse(txtNovaQuilometragem.Text);
            }
            Conexao conexao = new Conexao();
            conexao.editarVeiculo(veiculo);
            conexao.fecharConexao();
        }

        private void AtualizarDados_Load(object sender, EventArgs e)
        {

        }
    }
}
