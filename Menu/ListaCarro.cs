using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Trab_Interdiciplinar.Menu
{
    public partial class ListaCarro : Form
    {
        private string con = @"Data Source=.\SQLEXPRESS;Initial Catalog=Revisão_Veicular;Persist Security Info=True;User ID=sa;Password=sqladmin";
        SqlConnection conn;

        public ListaCarro()
        {
            InitializeComponent();
            configuraDataGridView();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Sair_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void configuraDataGridView()
        {
            conn = new SqlConnection(con);
            conn.Open();

            var sqlQuery = "SELECT * FROM Veiculo";
            using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, conn))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    dgvListaCarros.DataSource = dt;
                }
            }
        }
    }
}
