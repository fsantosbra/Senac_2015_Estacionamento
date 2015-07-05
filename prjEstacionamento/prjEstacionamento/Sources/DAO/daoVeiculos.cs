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
    class daoVeiculos : daoBase
    {
        private string Insert = @"INSERT INTO MODELO VALUES (@MODELO, @TIPO)";
        private string Update = @"UPDATE M SET MODELO = @MODELO, TIPOVEICULOID = @TIPO FROM MODELO M WHERE ID = @ID";
        private string Delete = @"DELETE FROM MODELO WHERE ID = @ID";
        private string SelectTipo = @"SELECT ID, TIPO FROM TIPOVEICULO";
        private string Select = @"SELECT M.ID, M.MODELO, TV.TIPO FROM MODELO M INNER JOIN TIPOVEICULO TV ON TV.ID = M.TIPOVEICULOID";

        public daoVeiculos()
        {
            base.conexao = new SqlConnection(base.connString);
            base.comando = new SqlCommand();
            base.comando.Connection = base.conexao;
        }

        public string InserirVeiculo(CadastroVeiculo Veiculo)
        {
            try
            {
                var paramModelo = new SqlParameter("@MODELO", Veiculo.Modelo);
                var paramTipo = new SqlParameter("@TIPO", Veiculo.Tipo);

                base.comando.CommandText = Insert;
                base.comando.Parameters.Add(paramModelo);
                base.comando.Parameters.Add(paramTipo);

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

        public string AlterarVeiculo(CadastroVeiculo Veiculo)
        {
            try
            {
                var paramModelo = new SqlParameter("@MODELO", Veiculo.Modelo);
                var paramTipo   = new SqlParameter("@TIPO", Veiculo.Tipo);
                var paramId     = new SqlParameter("@Id", Veiculo.Id);

                base.comando.CommandText = Update;
                base.comando.Parameters.Add(paramModelo);
                base.comando.Parameters.Add(paramTipo);
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

        public string ExcluirVeiculo(CadastroVeiculo Veiculo)
        {
            try
            {
                var paramId     = new SqlParameter("@Id", Veiculo.Id);

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

        public DataTable ExibirVeiculos()
        {
            try
            {
                var tabelaVeiculos = new DataTable();

                base.comando.CommandText = Select;
                base.conexao.Open();
                var dataReader = base.comando.ExecuteReader();

                tabelaVeiculos.Load(dataReader);

                return tabelaVeiculos;
            }
            finally
            {

            }
        }

        public DataTable ExibirTipoVeiculos()
        {
            try
            {
                var tabelaTipoVeiculos = new DataTable();

                base.comando.CommandText = SelectTipo;
                base.conexao.Open();
                var dataReader = base.comando.ExecuteReader();

                tabelaTipoVeiculos.Load(dataReader);

                return tabelaTipoVeiculos;
            }
            finally
            {

            }
        }
}

    

}
