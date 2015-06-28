using prjEstacionamento.Sources.Class;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstacionamento.Sources.DAO
{
    class daoEntradaVeiculo : daoBase
    {
        private string Insert = @"INSERT INTO USOVAGA(MODELOID, PLACA, DATAENTRADA, MENSALISTAID, CORVEICULO) 
                                  VALUES (@MODELOID, @PLACA, @DATAENTRADA, @MENSALISTAID, @CORVEICULO); SELECT SCOPE_IDENTITY();";

        public daoEntradaVeiculo()
        {
            base.conexao = new SqlConnection(base.connString);
            base.comando = new SqlCommand();
            base.comando.Connection = base.conexao;
        }

        public string inserirEntradaVeiculo(CadastroEntradaVeiculo entradaVeiculo)
        {
            try
            {
                base.comando.CommandText = Insert;

                base.comando.Parameters.Add("@MODELOID", entradaVeiculo.modeloId);
                base.comando.Parameters.Add("@PLACA", entradaVeiculo.placa);
                base.comando.Parameters.Add("@DATAENTRADA", entradaVeiculo.dataEntrada);
                base.comando.Parameters.Add("@MENSALISTAID", entradaVeiculo.mensalistaId);
                base.comando.Parameters.Add("@CORVEICULO", entradaVeiculo.corVeiculo);

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
