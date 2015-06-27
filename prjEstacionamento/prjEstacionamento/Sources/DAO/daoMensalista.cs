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
        private string Insert = @"INSERT INTO MENSALISTA VALUES (@NOME, @ENDERECOID, @ATIVO)";
        private string Update = @"UPDATE MENSALISTA SET Nome = @NOME, EnderecoId = @ENDERECOID, Ativo = @ATIVO WHERE Id = @Id";
        private string Delete = @"DELETE FROM MENSALISTA WHERE Id = @Id";
        private string Select = @"SELECT ID, NOME, ENDERECOID, ATIVO FROM MENSALISTA";
        private string SelectSpecific = @"SELECT ID, NOME, ENDERECOID, ATIVO FROM MENSALISTA WHERE NOME LIKE '%'+ @NOME +'%'";

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
                var paramEnderecoId = new SqlParameter("@ENDERECOID", mensalista.EnderecoId);
                var paramAtivo = new SqlParameter("@ATIVO", true);

                base.comando.CommandText = Insert;
                base.comando.Parameters.Add(paramNome);
                base.comando.Parameters.Add(paramEnderecoId);
                base.comando.Parameters.Add(paramAtivo);

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
                var tabelaMensalistas = new DataTable();

                base.comando.CommandText = Select;
                var dataReader = base.comando.ExecuteReader();

                tabelaMensalistas.Load(dataReader);

                return tabelaMensalistas;
            }
            finally
            {
                base.conexao.Close();
                base.comando.Parameters.Clear();
            }
        }
    }
}
