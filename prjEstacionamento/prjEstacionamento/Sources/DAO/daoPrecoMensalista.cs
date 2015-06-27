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
    class daoPrecoMensalista : daoBase
    {
        private string Insert = @"INSERT INTO PRECOMENSALISTA VALUES (@MENSALISTAID, @TIPOVEICULOID, 
                                                @PLACA, @VALOR, 
                                                @DATAINICIOVIGENCIA, @DATAFIMVIGENCIA)";
        private string Update = @"UPDATE PRECOMENSALISTA SET MensalistaId = @MENSALISTAID, TipoVeiculoId = @TIPOVEICULOID, 
                                    Placa = @PLACA, Valor = @VALOR, 
                                    DataInicioVigencia = @DATAINICIOVIGENCIA, 
                                    DataFimVigencia = @DATAFIMVIGENCIA,
                                    WHERE Id = @Id";
        private string Delete = @"DELETE FROM PRECOMENSALISTA WHERE Id = @Id";
        private string Select = @"SELECT ID, MENSALISTAID, TIPOVEICULOID, PLACA, 
                                  VALOR, DATAINICIOVIGENCIA, DATAFIMVIGENCIA 
                                  FROM PRECOMENSALISTA";
        private string SelectSpecific = @"SELECT ID, MENSALISTAID, TIPOVEICULOID, PLACA, 
                                  VALOR, DATAINICIOVIGENCIA, DATAFIMVIGENCIA 
                                  FROM PRECOMENSALISTA WHERE PLACA LIKE '%'+ @PLACA +'%'";

        public daoPrecoMensalista()
        {
            base.conexao = new SqlConnection(base.connString);
            base.comando = new SqlCommand();
            base.comando.Connection = base.conexao;
        }

        public void InserirPrecoMensalista(PrecoMensalista precoMensalista)
        {
            try
            {
                var paramMensalistaId = new SqlParameter("@MENSALISTAID", precoMensalista.MensalistaId);
                var paramTipoVeiculoId = new SqlParameter("@TIPOVEICULOID", precoMensalista.MensalistaId);
                var paramPlaca = new SqlParameter("@PLACA", precoMensalista.Placa);
                var paramValor = new SqlParameter("@VALOR", precoMensalista.Valor);
                var paramDataInicioVigencia = new SqlParameter("@DATAINICIOVIGENCIA", precoMensalista.DataInicioVigencia);
                var paramDataFimVigencia = new SqlParameter("@DATAFIMVIGENCIA", precoMensalista.DataFimVigencia);

                base.comando.CommandText = Insert;
                base.comando.Parameters.Add(paramMensalistaId);
                base.comando.Parameters.Add(paramTipoVeiculoId);
                base.comando.Parameters.Add(paramPlaca);
                base.comando.Parameters.Add(paramValor);
                base.comando.Parameters.Add(paramDataInicioVigencia);
                base.comando.Parameters.Add(paramDataFimVigencia);

                base.conexao.Open();
                base.comando.ExecuteNonQuery();
            }
            finally
            {
                base.conexao.Close();
                base.comando.Parameters.Clear();
            }
        }

        public DataTable ListarPrecosMensalistas()
        {
            try
            {
                var tabelaPrecosMensalistas = new DataTable();

                base.comando.CommandText = Select;
                var dataReader = base.comando.ExecuteReader();

                tabelaPrecosMensalistas.Load(dataReader);

                return tabelaPrecosMensalistas;
            }
            finally
            {
                base.conexao.Close();
                base.comando.Parameters.Clear();
            }
        }
    }
}
