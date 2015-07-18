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
        private string Insert = @"INSERT INTO MENSALISTA VALUES (@NOME, @ENDERECOID, @ATIVO); SELECT SCOPE_IDENTITY();";
        private string Update = @"UPDATE MENSALISTA SET Nome = @NOME, EnderecoId = @ENDERECOID, Ativo = @ATIVO WHERE Id = @Id";
        private string Delete = @"DELETE FROM MENSALISTA WHERE Id = @Id";
        private string Select = @"SELECT ID, NOME, ATIVO FROM MENSALISTA";
        private string SelectSpecific = @"SELECT ID, NOME, ATIVO FROM MENSALISTA WHERE NOME LIKE '%'+ @NOME +'%'";
        private string SelectById = @"SELECT M.ID, M.NOME, M.ATIVO, 
                                        E.LOGRADOURO, E.NUMERO, E.BAIRRO, E.CIDADE, E.ESTADO, E.CEP, E.TELEFONE,
                                        PM.PLACA, PM.VALOR, PM.DATAINICIOVIGENCIA, PM.DATAFIMVIGENCIA,
                                        TV.TIPO
                                        FROM MENSALISTA M
                                        INNER JOIN Endereco E ON
                                        M.EnderecoId = E.Id
                                        INNER JOIN PrecoMensalista PM ON
                                        PM.MensalistaId = M.Id
                                        INNER JOIN TipoVeiculo TV ON
                                        PM.TipoVeiculoId = TV.Id
                                        WHERE M.ID = @ID";

        public daoMensalista()
        {
            base.conexao = new SqlConnection(base.connString);
            base.comando = new SqlCommand();
            base.comando.Connection = base.conexao;
        }

        public int InserirMensalista(Mensalista mensalista)
        {
            var mensalistaId = 0;

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
                mensalistaId = Convert.ToInt32(base.comando.ExecuteScalar());
            }
            finally
            {
                base.conexao.Close();
                base.comando.Parameters.Clear();
            }

            return mensalistaId;
        }

        public DataTable ListarMensalistas()
        {
            try
            {
                var tabelaMensalistas = new DataTable();

                base.comando.CommandText = Select;
                base.conexao.Open();
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

        public DataTable FiltrarPesquisa(string nomeMensalista)
        {
            try
            {
                var tabelaMensalistas = new DataTable();

                base.comando.CommandText = SelectSpecific;
                var paramNome = new SqlParameter("@NOME", nomeMensalista);
                base.comando.Parameters.Add(paramNome);
                base.conexao.Open();
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

        public DataTable FiltrarMensalista(object mensalistaId)
        {
            try
            {
                var tabelaMensalistas = new DataTable();

                base.comando.CommandText = SelectById;
                var paramId = new SqlParameter("@ID", mensalistaId);
                base.comando.Parameters.Add(paramId);
                base.conexao.Open();
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
