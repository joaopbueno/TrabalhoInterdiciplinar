using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Trab_Interdiciplinar.Menu;

namespace Trab_Interdiciplinar.Inicio
{
    public partial class TelaPrincipal : Form
    {
        private int ImageNumber = 1;
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btn_Ajuda_Click(object sender, EventArgs e)
        {
            Ajuda ajuda = new Ajuda();
            ajuda.Show();
        }
        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btn_ListaCarro_Click(object sender, EventArgs e)
        {
            ListaCarro listaCarro = new ListaCarro();
            listaCarro.ShowDialog();
        }

        private void btn_Planejamento_Click(object sender, EventArgs e)
        {
            Planejamento planejamento = new Planejamento();
            planejamento.ShowDialog();
        }

        private void btn_CadastroCarro_Click(object sender, EventArgs e)
        {
            CadastroDeCarro cadastroCarro = new CadastroDeCarro();
            cadastroCarro.ShowDialog();
        }

        private void Slider()
        {
            if (ImageNumber == 3)
                ImageNumber = 1;

            //SliderFoto.ImageLocation = String.Format(@"Imagens\{0}.jpg", ImageNumber);
            ImageNumber ++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Slider();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void SliderFoto_Click(object sender, EventArgs e)
        {

        }
    }
}
