using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Trab_Interdiciplinar
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtCargoUsuario.Text != "" && txtEmailUsuario.Text!="" && txtNomeUsuario.Text!="" && txtSenhaUsuario.Text!="")
            {
                Usuario usuario = new Usuario(txtNomeUsuario.Text, txtEmailUsuario.Text, txtSenhaUsuario.Text, txtCargoUsuario.Text);
                Conexao conexao = new Conexao();
                conexao.adicionarUsuario(usuario);
                conexao.fecharConexao();
                MessageBox.Show("Usuario cadastrado com sucesso", "Sucesso");
                limpaCampos();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos corretamente", "Erro");
            }
            
        }

        private void limpaCampos()
        {
            txtCargoUsuario.Clear();
            txtNomeUsuario.Clear();
            txtEmailUsuario.Clear();
            txtSenhaUsuario.Clear();
        }
    }
}
