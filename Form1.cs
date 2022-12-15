using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trab_Interdiciplinar.Inicio;

namespace Trab_Interdiciplinar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_NovoRegistro_Click(object sender, EventArgs e)
        {
           /* Cadastro cadastro = new Cadastro();
            cadastro.Show();
           */
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            /* Conexao conexao = new Conexao();
             if (conexao.usuarioValido(txtEmail.Text, txtSenha.Text))
             {
                 TelaPrincipal telaPrincipal = new TelaPrincipal();
                 telaPrincipal.ShowDialog();
                 Close();
             }
             else
             {
                 MessageBox.Show("Usuario invalido", "Erro");
             }
             */
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.ShowDialog();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
