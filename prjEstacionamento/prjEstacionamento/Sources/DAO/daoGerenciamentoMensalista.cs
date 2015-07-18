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
    class daoGerenciamentoMensalista : daoBase
    {
        private string Insert = @"INSERT INTO PrecoMensalista VALUES (@MensalistaId, @TipoVeiculoId, @Placa, @Valor, @DataInicioVigencia, @DataFimVigencia); SELECT SCOPE_IDENTITY();";
        private string Update = @"UPDATE PrecoMensalista SET TipoVeiculoId = @TipoVeiculoId, Placa = @Placa, Valor = @Valor, DataInicioVigencia = @DataInicioVigencia, DataFimVigencia = @DataFimVigencia WHERE Id = @Id";
        private string Delete = @"DELETE FROM PrecoMensalista WHERE Id = @Id";
        private string Select = @"SELECT MensalistaId, TipoVeiculoId, Placa, Valor, DataInicioVigencia, DataFimVigencia FROM PrecoMensalista WHERE MensalistaId = @MensalistaId and (Placa = @Placa or @Placa = '')";
        //private string SelectSpecific = @"SELECT MensalistaId, TipoVeiculoId, Placa, DataInicioVigencia, DataFimVigencia, Valor FROM PrecoMensalista WHERE Id = @Id";
        private string SelectPlacas = @"SELECT DISTINCT MensalistaId, Placa FROM PrecoMensalista WHERE MensalistaId = @MensalistaId and Placa = @Placa";

        public daoGerenciamentoMensalista()
        {
            base.conexao = new SqlConnection(base.connString);
            base.comando = new SqlCommand();
            base.comando.Connection = base.conexao;
        }

        public int InserirPagamento(GerenciamentoMensalista dadosPagamento)
        {
            var idPagamento = 0;
            //Por padrão a vigência será sempre de 30 dias
            var diasVigencia = 30;

            try
            {
                var pMensalistaId = new SqlParameter("@MensalistaId", dadosPagamento.MensalistaId);
                var pTipoVeiculoId = new SqlParameter("@TipoVeiculoId", dadosPagamento.TipoVeiculoId);
                var pPlaca = new SqlParameter("@Placa", dadosPagamento.Placa);
                var pValor = new SqlParameter("@Valor", dadosPagamento.Valor);
                var pInicioVigencia = new SqlParameter("@DataInicioVigencia", dadosPagamento.DataInicioVigencia);
                var pFimVigencia = new SqlParameter("@DataFimVigencia", dadosPagamento.DataInicioVigencia.AddDays(diasVigencia));

                base.comando.CommandText = Insert;
                base.comando.Parameters.Add(pMensalistaId);
                base.comando.Parameters.Add(pTipoVeiculoId);
                base.comando.Parameters.Add(pPlaca);
                base.comando.Parameters.Add(pValor);
                base.comando.Parameters.Add(pInicioVigencia);
                base.comando.Parameters.Add(pFimVigencia);

                base.conexao.Open();
                idPagamento = Convert.ToInt32(base.comando.ExecuteScalar());
            }
            finally
            {
                base.conexao.Close();
                base.comando.Parameters.Clear();
            }

            return idPagamento;
        }

        public DataTable ListarPagamentos(Int32 IdMensalista, string Placa)
        {
            try
            {
                var tabelaPagamentos = new DataTable();
                var pIdMensalista = new SqlParameter("@MensalistaId", IdMensalista);
                var pPlaca = new SqlParameter("@Placa", Placa);

                if (Placa == ""){
                    base.comando.CommandText = Select;
                } else{
                    base.comando.CommandText = SelectPlacas;
                }

                base.comando.Parameters.Add(pIdMensalista);
                base.comando.Parameters.Add(pPlaca);
                base.conexao.Open();
                var dataReader = base.comando.ExecuteReader();

                tabelaPagamentos.Load(dataReader);

                return tabelaPagamentos;
            }
            finally
            {
                base.conexao.Close();
                base.comando.Parameters.Clear();
            }
        }
    }
}
