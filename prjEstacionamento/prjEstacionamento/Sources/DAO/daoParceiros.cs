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
    class daoParceiros : daoBase
    {
        private string Insert = @"INSERT INTO PARCEIROS VALUES (@NOME, @DESCONTO)";
        private string Update = @"UPDATE P SET NOMEPARCEIRO = @NOME, DESCONTO = @DESCONTO FROM PARCEIROS P WHERE ID = @ID";
        private string Delete = @"DELETE FROM PARCEIROS WHERE ID = @ID";
        private string Select = @"SELECT P.ID, P.NOMEPARCEIRO, P.DESCONTO FROM PARCEIROS P";
        private string Pesquisa = @"SELECT P.ID, P.NOMEPARCEIRO, P.DESCONTO FROM PARCEIROS P WHERE P.NOMEPARCEIRO = @NOME";

        public daoParceiros()
        {
            base.conexao = new SqlConnection(base.connString);
            base.comando = new SqlCommand();
            base.comando.Connection = base.conexao;
        }

        public string InserirParceiros(CadastroParceiros Parceiro)
        {
            try
            {
                var paramNome = new SqlParameter("@NOME", Parceiro.Nome);
                var paramDesconto = new SqlParameter("@DESCONTO", Parceiro.Desconto);

                base.comando.CommandText = Insert;
                base.comando.Parameters.Add(paramNome);
                base.comando.Parameters.Add(paramDesconto);

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

        public string AlterarParceiro(CadastroParceiros Parceiro)
        {
            try
            {
                var paramNome = new SqlParameter("@NOME", Parceiro.Nome);
                var paramDesconto = new SqlParameter("@DESCONTO", Parceiro.Desconto);
                var paramId = new SqlParameter("@Id", Parceiro.Id);

                base.comando.CommandText = Update;
                base.comando.Parameters.Add(paramNome);
                base.comando.Parameters.Add(paramDesconto);
                base.comando.Parameters.Add(paramId);

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

        public string ExcluirParceiro(CadastroParceiros Parceiro)
        {
            try
            {
                var paramId = new SqlParameter("@Id", Parceiro.Id);

                base.comando.CommandText = Delete;
                base.comando.Parameters.Add(paramId);

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

        public DataTable ExibirParceiros()
        {
            try
            {
                var tabelaParceiros = new DataTable();

                base.comando.CommandText = Select;
                base.conexao.Open();
                var dataReader = base.comando.ExecuteReader();

                tabelaParceiros.Load(dataReader);

                return tabelaParceiros;
            }
            finally
            {

            }
        }

        public DataTable ExibirParceiroPesquisa(string Nome)
        {
            try
            {
                var tabelaParceiro = new DataTable();
                var paramNome = new SqlParameter("@NOME", Nome);

                base.comando.CommandText = Pesquisa;
                base.comando.Parameters.Add(paramNome);

                base.conexao.Open();
                var dataReader = base.comando.ExecuteReader();

                tabelaParceiro.Load(dataReader);

                return tabelaParceiro;
            }
            finally
            {

            }
        }
    }



}
