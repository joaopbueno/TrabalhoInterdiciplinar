using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Trab_Interdiciplinar
{
    public partial class CadastroDeCarro : Form
    {
        public CadastroDeCarro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CadastroDeCarro_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrarCarro_Click(object sender, EventArgs e)
        {
            if (txtMarcaCarro.Text!= "" && txtModeloCarro.Text != "" && txtPlacaCarro.Text!="" && txtTipoCarro.Text != "" && txtQuilometragem.Text != "")
            {
                Veiculo veiculo = new Veiculo(txtPlacaCarro.Text, txtMarcaCarro.Text, txtModeloCarro.Text, txtTipoCarro.Text, int.Parse(txtQuilometragem.Text));
                Conexao conexao = new Conexao();
                conexao.adicionarVeiculo(veiculo);
                conexao.fecharConexao();
                MessageBox.Show("Veiculo cadastrado com sucesso", "Sucesso");
                limpaCampos();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos corretamente", "Falha");
            }
            
        }

        private void limpaCampos()
        {
            txtMarcaCarro.Clear();
            txtTipoCarro.Clear();
            txtModeloCarro.Clear();
            txtPlacaCarro.Clear();
            txtQuilometragem.Clear();
        }
    }
}
