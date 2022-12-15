using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Trab_Interdiciplinar
{
    internal class Conexao
    {
        private string con = @"Data Source=.\SQLEXPRESS;Initial Catalog=Revisão_Veicular;Persist Security Info=True;User ID=sa;Password=sqladmin";
        SqlConnection conn;

        public Conexao()
        {
            conn = new SqlConnection(con);
            conn.Open();
        }

        public void adicionarVeiculo(Veiculo veiculo)
        {
            SqlCommand c = new SqlCommand($"INSERT INTO Veiculo (Placa, Marca, Modelo, TipoVeiculo, KM, DataUltimaManutencao, PrecisaManutencao, QuilometragemAndada) Values ({veiculo.getInfoVeiculoToSql()})", conn);
            c.ExecuteReader();
        }

        public void adicionarUsuario(Usuario usuario)
        {
            SqlCommand c = new SqlCommand($"INSERT INTO Usuario (Nome, Email, Senha, Cargo) Values ({usuario.getInfoUsuario()})", conn);
            c.ExecuteReader();
        }

        public void editarVeiculo(Veiculo veiculo)
        {
            int manutencao = (veiculo.precisaManutencao)?1 : 0;
            SqlCommand c = new SqlCommand($"UPDATE Veiculo SET QuilometragemAndada = '{veiculo.quilometragemAndada}', PrecisaManutencao = '{manutencao}', KM = {veiculo.km}, DataUltimaManutencao = '{veiculo.dataUltimaManutencao}' WHERE Placa = '{veiculo.placa}'", conn);
            c.ExecuteReader();
        }

        public void removerVeiculo(Veiculo veiculo)
        {
            SqlCommand c = new SqlCommand($"DELETE from Veiculo where Placa = '{veiculo.placa}'", conn);
            c.ExecuteReader();
        }

        public void removerUsuario(Usuario usuario)
        {
            SqlCommand c = new SqlCommand($"DELETE from Usuario where Email = '{usuario.email}'", conn);
            c.ExecuteReader();
        }

        public List<Veiculo> getInfoVeiculo()
        {
            SqlCommand c = new SqlCommand("SELECT * FROM Veiculo", conn);
            SqlDataReader sqlDataReader = c.ExecuteReader();
            List<Veiculo> veiculos = new List<Veiculo>();

            while (sqlDataReader.Read())
            {
                veiculos.Add(new Veiculo(sqlDataReader["Placa"].ToString(), sqlDataReader["Marca"].ToString(), sqlDataReader["Modelo"].ToString(), sqlDataReader["TipoVeiculo"].ToString(), (int)sqlDataReader["KM"], (DateTime)sqlDataReader["DataUltimaManutencao"], (bool)sqlDataReader["PrecisaManutencao"], (int)sqlDataReader["QuilometragemAndada"]));
            }
            return veiculos;
        }

        public List<Usuario> getInfoUsuario()
        {
            SqlCommand c = new SqlCommand("SELECT * FROM Usuario", conn);
            SqlDataReader sqlDataReader = c.ExecuteReader();
            List<Usuario> usuarios = new List<Usuario>();

            while (sqlDataReader.Read())
            {
                usuarios.Add(new Usuario(sqlDataReader["Nome"].ToString(), sqlDataReader["Email"].ToString(), sqlDataReader["Senha"].ToString(), sqlDataReader["Cargo"].ToString()));
            }

            return usuarios;
        }

        public bool usuarioValido(string email, string senha)
        {
            List<Usuario> usuarios = getInfoUsuario();
            foreach(Usuario usuario in usuarios)
            {
                if (usuario.email.Equals(email) && usuario.senha.Equals(senha))
                    return true;
            }
            return false;
        }

        public void fecharConexao()
        {
            conn.Close();
        }

        public Veiculo getInfoVeiculoEspecifico(string placa)
        {
            SqlCommand c = new SqlCommand("SELECT * FROM Veiculo", conn);
            SqlDataReader sqlDataReader = c.ExecuteReader();

            while (sqlDataReader.Read())
            {
                if (sqlDataReader["Placa"].Equals(placa))
                    return new Veiculo(sqlDataReader["Placa"].ToString(), sqlDataReader["Marca"].ToString(), sqlDataReader["Modelo"].ToString(), sqlDataReader["TipoVeiculo"].ToString(), (int)sqlDataReader["KM"], (DateTime)sqlDataReader["DataUltimaManutencao"], (bool)sqlDataReader["PrecisaManutencao"], (int)sqlDataReader["QuilometragemAndada"]);
            }

            return null;
        }

    }
}
