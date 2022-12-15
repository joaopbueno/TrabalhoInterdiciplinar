using System;
using System.Collections.Generic;
using System.Text;

namespace Trab_Interdiciplinar
{
    internal class Veiculo
    {
        public string placa;
        public string marca;
        public string modelo;
        public string tipoVeiculo;
        public int km;
        public DateTime dataUltimaManutencao;
        public bool precisaManutencao;
        public int quilometragemAndada;

        public Veiculo(string placa, string marca, string modelo, string tipoVeiculo, int km)
        {
            this.placa = placa;
            this.marca = marca;
            this.modelo = modelo;
            this.tipoVeiculo = tipoVeiculo;
            this.km = km;
            dataUltimaManutencao = DateTime.Now;
            precisaManutencao = false;
            quilometragemAndada = 0;
        }

        public Veiculo(string placa, string marca, string modelo, string tipoVeiculo, int km, DateTime dataUltimaAlteracao, bool precisaManutencao, int quilometragemAndada)
        {
            this.placa = placa;
            this.marca = marca;
            this.modelo = modelo;
            this.tipoVeiculo = tipoVeiculo;
            this.km = km;
            this.dataUltimaManutencao = dataUltimaAlteracao;
            this.precisaManutencao = precisaManutencao;
            this.quilometragemAndada = quilometragemAndada;
        }

        public string getInfoVeiculoToSql()
        {
            return $"'{placa}', '{marca}', '{modelo}', '{tipoVeiculo}', '{km}', '{dataUltimaManutencao}', '{precisaManutencao}', '{quilometragemAndada}'";
        }

    }
}
