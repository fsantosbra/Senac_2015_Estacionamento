using prjEstacionamento.Sources.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstacionamento.Sources.DAO
{
    class daoVagas : daoBase
    {
        private string Insert = @"INSERT INTO VAGAS (TipoVeiculoId, QtdeVagasTotal, QtdeMensalista) VALUES (@TipoVeiculoId, @QtdeVagasTotal, @QtdeMensalista)";

        public daoVagas()
        {
            base.conexao = new SqlConnection(base.connString);
            base.comando = new SqlCommand();
            base.comando.Connection = base.conexao;
        }

        public string InserirVagas(Vagas vagas)
        {
            try
            {
                var paramTipoVeiculo = new SqlParameter("@TipoVeiculoId", vagas.TipoVeiculo);
                var paramQtdeVagas = new SqlParameter("@QtdeVagasTotal", vagas.QtdTotalVagas);
                var paramQtdeMensalista = new SqlParameter("@QtdeMensalista", vagas.QtdTotalMensalistas);

                base.comando.CommandText = Insert;
                base.comando.Parameters.Add(paramTipoVeiculo);
                base.comando.Parameters.Add(paramQtdeVagas);
                base.comando.Parameters.Add(paramQtdeMensalista);

                base.conexao.Open();
                base.comando.ExecuteNonQuery();

                return base.conexao.State.ToString();
            }
            finally
            {
                base.conexao.Close();
                base.comando.Parameters.Clear();
            }

        }
    }
}
