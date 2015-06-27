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
    class daoMensalista : daoBase
    {
        private string Insert = @"INSERT INTO PARAMETROS VALUES (@NOME, @VALOR)";
        private string Update = @"UPDATE PARAMETROS SET Nome = @NOME, Valor = @VALOR WHERE Id = @Id";
        private string Delete = @"DELETE FROM PARAMETROS WHERE Id = @Id";
        private string Select = @"SELECT NOME, VALOR FROM PARAMETROS";
        private string SelectSpecific = @"SELECT NOME, VALOR FROM PARAMETROS WHERE NOME LIKE '%'+ @NOME +'%'";

        public daoMensalista()
        {
            base.conexao = new SqlConnection(base.connString);
            base.comando = new SqlCommand();
            base.comando.Connection = base.conexao;
        }

        public void InserirMensalista(Mensalista mensalista)
        {
            try
            {
                var paramNome = new SqlParameter("@NOME", mensalista.Nome);
                var paramValor = new SqlParameter("@VALOR", mensalista.Valor);

                base.comando.CommandText = Insert;
                base.comando.Parameters.Add(paramNome);
                base.comando.Parameters.Add(paramValor);

                base.conexao.Open();
                base.comando.ExecuteNonQuery();

            }
            finally
            {
                base.conexao.Close();
                base.comando.Parameters.Clear();
            }
        }

        public DataTable ListarMensalistas()
        {
            try
            {
                var tabelaParametros = new DataTable();

                base.comando.CommandText = Select;
                var dataReader = base.comando.ExecuteReader();

                tabelaParametros.Load(dataReader);

                return tabelaParametros;
            }
            finally
            {

            }
        }
    }
}
