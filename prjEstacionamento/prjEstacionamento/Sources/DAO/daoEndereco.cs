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
    class daoEndereco : daoBase
    {
        private string Insert = @"INSERT INTO ENDERECO VALUES (@LOGRADOURO, @NUMERO, @BAIRRO, @CIDADE, 
                                                               @ESTADO, @CEP, @TELEFONE)";
        private string Update = @"UPDATE MENSALISTA SET Logradouro = @LOGRADOURO, Numero = @NUMERO, 
                                    Bairro = @BAIRRO, Cidade = @CIDADE, Estado = @ESTADO, 
                                    CEP = @CEP, Telefone = @TELEFONE 
                                    WHERE Id = @Id";
        private string Delete = @"DELETE FROM ENDERECO WHERE Id = @Id";
        private string Select = @"SELECT ID, LOGRADOURO, NUMERO, BAIRRO, 
                                  CIDADE, ESTADO, CEP, TELEFONE 
                                  FROM MENSALISTA";
        private string SelectSpecific = @"SELECT ID, LOGRADOURO, NUMERO, BAIRRO, 
                                  CIDADE, ESTADO, CEP, TELEFONE 
                                  FROM MENSALISTA WHERE LOGRADOURO LIKE '%'+ @LOGRADOURO +'%'";

        public daoEndereco()
        {
            base.conexao = new SqlConnection(base.connString);
            base.comando = new SqlCommand();
            base.comando.Connection = base.conexao;
        }

        public void InserirEndereco(Endereco endereco)
        {
            try
            {
                var paramLogradouro = new SqlParameter("@LOGRADOURO", endereco.Logradouro);
                var paramNumero = new SqlParameter("@NUMERO", endereco.Numero);
                var paramBairro = new SqlParameter("@BAIRRO", endereco.Bairro);
                var paramCidade = new SqlParameter("@CIDADE", endereco.Cidade);
                var paramEstado = new SqlParameter("@ESTADO", endereco.Estado);
                var paramCEP = new SqlParameter("@CEP", endereco.CEP);
                var paramTelefone = new SqlParameter("@NUMERO", endereco.Telefone);

                base.comando.CommandText = Insert;
                base.comando.Parameters.Add(paramLogradouro);
                base.comando.Parameters.Add(paramNumero);
                base.comando.Parameters.Add(paramBairro);
                base.comando.Parameters.Add(paramCidade);
                base.comando.Parameters.Add(paramEstado);
                base.comando.Parameters.Add(paramCEP);
                base.comando.Parameters.Add(paramTelefone);

                base.conexao.Open();
                base.comando.ExecuteNonQuery();
            }
            finally
            {
                base.conexao.Close();
                base.comando.Parameters.Clear();
            }
        }

        public DataTable ListarEnderecos()
        {
            try
            {
                var tabelaEnderecos = new DataTable();

                base.comando.CommandText = Select;
                var dataReader = base.comando.ExecuteReader();

                tabelaEnderecos.Load(dataReader);

                return tabelaEnderecos;
            }
            finally
            {
                base.conexao.Close();
                base.comando.Parameters.Clear();
            }
        }
    }
}
