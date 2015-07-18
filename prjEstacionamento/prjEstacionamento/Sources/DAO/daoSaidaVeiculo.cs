using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace prjEstacionamento.Sources.DAO
{
    class daoSaidaVeiculo : daoBase
    {
        private string Select = @"select u.id, u.Placa, u.DataEntrada, m.Modelo 
                                  from UsoVaga u, modelo m
                                  where u.ModeloId = m.Id and
                                  u.DataSaida is null";
        public daoSaidaVeiculo()
        {
          base.conexao = new SqlConnection(base.connString);
          base.comando = new SqlCommand();
          base.comando.Connection = base.conexao;
        }
        
        public DataTable listarModelos()
        {
            try
            {
                var tabelaSaida = new DataTable();
                base.comando.CommandText = Select;
                base.conexao.Open();
                var dataReader = base.comando.ExecuteReader();

                tabelaSaida.Load(dataReader);

                return tabelaSaida;
            }
            finally
            {
                base.conexao.Close();
                base.comando.Parameters.Clear();
            }
        }

    }
}
