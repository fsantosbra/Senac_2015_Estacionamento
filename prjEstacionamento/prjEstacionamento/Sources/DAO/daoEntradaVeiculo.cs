using prjEstacionamento.Sources.Class;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstacionamento.Sources.DAO
{
    class daoEntradaVeiculo : daoBase
    {
        private string Insert = @"INSERT INTO USOVAGA(MODELOID, PLACA, DATAENTRADA, MENSALISTAID, CORVEICULO) 
                                  VALUES (@MODELOID, @PLACA, @DATAENTRADA, @MENSALISTAID, @CORVEICULO); SELECT SCOPE_IDENTITY();";

        private string Select = @"SELECT MODELOID, PLACA, DATAENTRADA, MENSALISTAID, CORVEICULO FROM USOVAGA";

        private string SelectEspecific = @"SELECT MODELOID, PLACA, DATAENTRADA, MENSALISTAID, CORVEICULO FROM USOVAGA
                                  WHERE DATAENTRADA = @DATAENTRADA";

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

        public DataTable SelectToday()
        {
            CadastroEntradaVeiculo entradaVeiculo = new CadastroEntradaVeiculo();
            entradaVeiculo.dataEntrada = DateTime.Today;
            try
            {
                var paramId = new SqlParameter("@ID", entradaVeiculo.Id);
                var paramModeloId = new SqlParameter("@MODELOID", entradaVeiculo.modeloId);
                var paramPlaca = new SqlParameter("@PLACA", entradaVeiculo.placa);
                var paramDataEntrada = new SqlParameter("@DATAENTRADA", entradaVeiculo.dataEntrada);
                var paramDataSaida = new SqlParameter("@DATASAIDA", entradaVeiculo.dataSaida);
                var paramMensalistaId = new SqlParameter("@MENSALISTAID", entradaVeiculo.mensalistaId);
                var paramCorVeiculo = new SqlParameter("@CORVEICULO", entradaVeiculo.corVeiculo);
                var paramParceiroId = new SqlParameter("@PARCEIROID", entradaVeiculo.parceiroId);

                base.comando.CommandText = SelectEspecific;
                base.comando.Parameters.Add("@MODELOID", entradaVeiculo.modeloId);
                base.comando.Parameters.Add("@PLACA", entradaVeiculo.placa);
                base.comando.Parameters.Add("@DATAENTRADA", entradaVeiculo.dataEntrada);
                base.comando.Parameters.Add("@DATASAIDA", entradaVeiculo.dataSaida);
                base.comando.Parameters.Add("@MENSALISTAID", entradaVeiculo.mensalistaId);
                base.comando.Parameters.Add("@CORVEICULO", entradaVeiculo.corVeiculo);
                base.comando.Parameters.Add("@PARCEIROID", entradaVeiculo.parceiroId);

                base.conexao.Open();
                var readerEntrada = base.comando.ExecuteReader();
                DataTable tbRetorno = new DataTable();
                tbRetorno.Load(readerEntrada);
                return tbRetorno;
            }
            finally 
            {
                base.conexao.Open();
                base.comando.Parameters.Clear();
            }
        }
    }
}
