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
        
        private string Select = @"SELECT ID
                                        ,TIPOVEICULOID
                                        ,QTDEVAGASTOTAL
                                        ,QTDEMENSALISTA
                                        ,QTDEVAGASTOTALCORRENTE
                                        ,QTDEMENSALISTACORRENTE 
                                  FROM VAGAS";
        private string SelectSpecific = @"SELECT ID
                                                ,TIPOVEICULOID
                                                ,QTDEVAGASTOTAL
                                                ,QTDEMENSALISTA
                                                ,QTDEVAGASTOTALCORRENTE
                                                ,QTDEMENSALISTACORRENTE  
                                         FROM VAGAS WHERE TIPOVEICULOID =  like %'@TIPOVEICULOID'";

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

                //var paramId = new SqlParameter("@ID", Vagas.Id);
                //var paramTipoVeiculoId = new SqlParameter("@TIPOVEICULOID", Vagas.TipoVeiculoId);
                //var paramQtdeVagasTotal = new SqlParameter("@QTDEVAGASTOTAL", Vagas.QtdeVagasTotal);
                //var paramQtdeMensalista = new SqlParameter("@QTDEMENSALISTA", Vagas.QtdeMensalista);
                //var paramQtdeVagasTotalCorrente = new SqlParameter("@QTDEVAGASTOTALCORRENTE", Vagas.QtdeVagasTotalCorrente);
                //var paramQtdeMensalistaCorrente = new SqlParameter("@QTDEMENSALISTACORRENTE", Vagas.QtdeMensalistaCorrente);

                //base.comando.Parameters.Add(paramTipoVeiculoId);
                //base.comando.CommandText = SelectSpecific;

                //var dataReader = base.comando.ExecuteReader();

                //tabelaVagas.Load(dataReader);

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
                var dataReader = base.comando.ExecuteReader();
                dataReader.Read();

                tabelaVagas.Load(dataReader.Read());

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
            var paramId = new SqlParameter("@ID", Vagas.Id);
            var paramTipoVeiculoId = new SqlParameter("@TIPOVEICULOID", Vagas.TipoVeiculoId);
            var paramQtdeVagasTotal = new SqlParameter("@QTDEVAGASTOTAL", Vagas.QtdeVagasTotal);
            var paramQtdeMensalista = new SqlParameter("@QTDEMENSALISTA", Vagas.QtdeMensalista);
            var paramQtdeVagasTotalCorrente = new SqlParameter("@QTDEVAGASTOTALCORRENTE", Vagas.QtdeVagasTotalCorrente);
            var paramQtdeMensalistaCorrente = new SqlParameter("@QTDEMENSALISTACORRENTE", Vagas.QtdeMensalistaCorrente);

            base.comando.CommandText = Vagas.CommandString ;
            base.comando.Parameters.Add(paramId);
            base.comando.Parameters.Add(paramTipoVeiculoId);
            base.comando.Parameters.Add(paramQtdeVagasTotal);
            base.comando.Parameters.Add(paramQtdeMensalista);
            base.comando.Parameters.Add(paramQtdeVagasTotalCorrente);
            base.comando.Parameters.Add(paramQtdeMensalistaCorrente);
            
            base.conexao.Open();
            var readerVagas = base.comando.ExecuteReader();
            DataTable tbRetorno = new DataTable();
            tbRetorno.Load(readerVagas);
            /*
            DataTable newDataTable = readerVagas.GetSchemaTable();
            
            
            foreach (DataRow r in newDataTable.Rows)
            {
                if (!newDataTable.Columns.Contains(r["ID"].ToString())) 
                { 
                    DataColumn col = new DataColumn(){
                        ColumnName = r["ID"].ToString(), 
                        Unique = Convert.ToBoolean(r["IsUnique"]), 
                        AllowDBNull = Convert.ToBoolean(r["AllowDBNull"]), 
                        ReadOnly = Convert.ToBoolean(r["IsReadOnly"]) 
                    };
                    tbRetorno.Columns.Add(col); 
                } 
            }

            while (readerVagas.Read())
            { 
                DataRow novaLinha = tbRetorno.NewRow(); 
                for(int i = 0; i<tbRetorno.Columns.Count;i++) {
                    novaLinha[i] = readerVagas.GetValue(i); 
                } tbRetorno.Rows.Add(novaLinha); 
            } 
            */
            //return tbRetorno;
            return tbRetorno;
        }
    }
}
