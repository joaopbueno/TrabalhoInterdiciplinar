using System;
using System.Collections.Generic;
using System.Text;

namespace Trab_Interdiciplinar
{
    internal class Usuario
    {
        public string nome;
        public string email;
        public string senha;
        public string cargo;

        public Usuario(string nome, string email, string senha, string cargo)
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
            this.cargo = cargo;
        }

        public string getInfoUsuario()
        {
            return $"'{nome}', '{email}', '{senha}', '{cargo}'";
        }

    }
}
