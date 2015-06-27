using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstacionamento.Sources.DAO
{
    class daoTipoVeiculo : daoBase
    {
        private string Select = @"SELECT ID, NOME FROM TIPOVEICULO";


        public daoTipoVeiculo()
        {
            base.conexao = new SqlConnection(base.connString);
            base.comando = new SqlCommand();
            base.comando.Connection = base.conexao;
        }

        public DataTable ListarTipoVeiculos()
        {
            try
            {
                var tabelaTipoVeiculo = new DataTable();

                base.comando.CommandText = Select;
                var dataReader = base.comando.ExecuteReader();

                tabelaTipoVeiculo.Load(dataReader);

                return tabelaTipoVeiculo;
            }
            finally
            {

            }
        }
    }
}
