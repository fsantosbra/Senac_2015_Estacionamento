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
        private string Insert = @"INSERT INTO VAGAS VALUES (@TIPOVEICULOID, @QTDEVAGASTOTAL, @QTDEMENSALISTA, @QTDEVAGASTOTALCORRENTE, 
                                                            @QTDEMENSALISTACORRENTE);
                                  SELECT SCOPE_IDENTITY();";
        private string Update = @"UPDATE VAGAS SET TipoVeiculoId = @TIPOVEICULOID
                                                  ,QtdeVagasTotal = @QTDEVAGASTOTAL
                                                  ,QtdeVagasMensalista = @QTDEMENSALISTA
                                                  ,QtdeVagasTotalCorrente = @QTDEVAGASTOTALCORRENTE
                                                  ,QtdeMensalistaCorrente = @QTDEMENSALISTACORRENTE
                                  WHERE Id = @Id";
        
        private string Delete = @"DELETE FROM VAGAS WHERE Id = @Id";

        private string Select = @"SELECT VG.ID
                                        ,VG.TIPOVEICULOID
                                        ,VG.QTDEVAGASTOTAL
                                        ,VG.QTDEMENSALISTA
                                        ,(SELECT COUNT(ID) FROM USOVAGA 
                                          WHERE DATAENTRADA = GETDATE()
                                          AND DATASAIDA IS NOT NULL
                                          AND EHMENSALISTA IS NULL) AS QTDEVAGASTOTALCORRENTE
                                        ,(SELECT COUNT(MNS.ID) 
                                          FROM MENSALISTA MNS
                                          LEFT JOIN USOVAGA UV ON (UV.MENSALISTAID = MNS.ID)
                                          LEFT JOIN MODELO MOD ON (MOD.ID = UV.MODELOID)
                                          WHERE ATIVO IS NOT NULL) AS QTDEMENSALISTACORRENTE 
                                  FROM VAGAS VG";

        private string SelectSpecific = @"SELECT ID
                                                ,TIPOVEICULOID
                                                ,QTDEVAGASTOTAL
                                                ,QTDEMENSALISTA
                                                ,(SELECT COUNT(ID) FROM USOVAGA 
                                                  WHERE DATAENTRADA = GETDATE()
                                                  AND DATASAIDA IS NOT NULL
                                                  AND EHMENSALISTA IS NULL) AS QTDEVAGASTOTALCORRENTE
                                                ,(SELECT COUNT(ID) FROM MENSALISTA 
                                                  WHERE ATIVO IS NOT NULL) AS QTDEMENSALISTACORRENTE
                                         FROM VAGAS 
                                         WHERE @ID = @ID OR ID = @ID
                                         AND @QTDEVAGASTOTAL = @QTDEVAGASTOTAL OR QTDEVAGASTOTAL = @QTDEVAGASTOTAL
                                         AND @TIPOVEICULOID = @TIPOVEICULOID OR TIPOVEICULOID like %@TIPOVEICULOID
                                         AND @QTDEMENSALISTA = @QTDEMENSALISTA OR QTDEMENSALISTA = @QTDEMENSALISTA
                                         AND @QTDEVAGASTOTALCORRENTE = @QTDEVAGASTOTALCORRENTE OR QTDEVAGASTOTALCORRENTE = @QTDEVAGASTOTALCORRENTE
                                         AND @QTDEMENSALISTACORRENTE = @QTDEMENSALISTACORRENTE OR QTDEMENSALISTACORRENTE = @QTDEMENSALISTACORRENTE
                                         ";

        public daoVagas()
        {
            base.conexao = new SqlConnection(base.connString);
            base.comando = new SqlCommand();
            base.comando.Connection = base.conexao;
        }

        public int InserirVaga(Vagas vagas)
        {
            var vagaId = 0;

            try
            {
                var paramId = new SqlParameter("@ID", vagas.Id);
                var paramTipoVeiculoId = new SqlParameter("@TIPOVEICULOID", vagas.TipoVeiculoId);
                var paramQtdeVagasTotal = new SqlParameter("@QTDEVAGASTOTAL", vagas.QtdeVagasTotal);
                var paramQtdeMensalista = new SqlParameter("@QTDEMENSALISTA", vagas.QtdeMensalista);
                var paramQtdeVagasTotalCorrente = new SqlParameter("@QTDEVAGASTOTALCORRENTE", vagas.QtdeVagasTotalCorrente);
                var paramQtdeMensalistaCorrente = new SqlParameter("@QTDEMENSALISTACORRENTE", vagas.QtdeMensalistaCorrente);

                base.comando.CommandText = Insert;
                base.comando.Parameters.Add(paramId);
                base.comando.Parameters.Add(paramTipoVeiculoId);
                base.comando.Parameters.Add(paramQtdeVagasTotal);
                base.comando.Parameters.Add(paramQtdeMensalista);
                base.comando.Parameters.Add(paramQtdeVagasTotalCorrente);
                base.comando.Parameters.Add(paramQtdeMensalistaCorrente);

                base.conexao.Open();
                vagaId = Convert.ToInt32(base.comando.ExecuteScalar());
            }
            finally
            {
                base.conexao.Close();
                base.comando.Parameters.Clear();
            }

            return vagaId;
        }

        public DataTable ListarVagasTipo(Vagas Vagas)
        {
            try
            {
                DataTable tabelaVagas = new DataTable();
                Vagas.CommandString = this.SelectSpecific;
                tabelaVagas = GetDados(Vagas);
                
                return tabelaVagas;
            }
            finally
            {
                base.conexao.Close();
                base.comando.Parameters.Clear();
            }
        }

        public DataTable ListarVagas()
        {
            try
            {
                DataTable tabelaVagas = new DataTable();
                base.conexao.Open();
                base.comando.CommandText = Select;
                
                SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(comando);
                ObjDataAdapter.Fill(tabelaVagas);

                return tabelaVagas;
            }
            finally
            {
                base.conexao.Close();
                base.comando.Parameters.Clear();
            }
        }

        //public List<Vagas> GetDados(Vagas Vagas)
        public DataTable GetDados(Vagas Vagas)
        {
            try
            {
                var paramId = new SqlParameter("@ID", Vagas.Id);
                var paramTipoVeiculoId = new SqlParameter("@TIPOVEICULOID", Vagas.TipoVeiculoId);
                var paramQtdeVagasTotal = new SqlParameter("@QTDEVAGASTOTAL", Vagas.QtdeVagasTotal);
                var paramQtdeMensalista = new SqlParameter("@QTDEMENSALISTA", Vagas.QtdeMensalista);
                var paramQtdeVagasTotalCorrente = new SqlParameter("@QTDEVAGASTOTALCORRENTE", Vagas.QtdeVagasTotalCorrente);
                var paramQtdeMensalistaCorrente = new SqlParameter("@QTDEMENSALISTACORRENTE", Vagas.QtdeMensalistaCorrente);

                base.comando.Parameters.Add(paramId);
                base.comando.Parameters.Add(paramTipoVeiculoId);
                base.comando.Parameters.Add(paramQtdeVagasTotal);
                base.comando.Parameters.Add(paramQtdeMensalista);
                base.comando.Parameters.Add(paramQtdeVagasTotalCorrente);
                base.comando.Parameters.Add(paramQtdeMensalistaCorrente);

                DataTable tabelaVagas = new DataTable();
                base.conexao.Open();
                base.comando.CommandText = Vagas.CommandString;

                SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(comando);
                ObjDataAdapter.Fill(tabelaVagas);

                return tabelaVagas;
            }
            finally 
            {
                base.conexao.Open();
                base.comando.Parameters.Clear();
            }
        }
    }
}
