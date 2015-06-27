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
    class daoParametros : daoBase
    {
        private string Insert = @"INSERT INTO PARAMETROS VALUES (@NOME, @VALOR)";
        private string Update = @"UPDATE PARAMETROS SET Nome = @NOME, Valor = @VALOR WHERE Id = @Id";
        private string Delete = @"DELETE FROM PARAMETROS WHERE Id = @Id";
        private string Select = @"SELECT NOME, VALOR FROM PARAMETROS";

        public daoParametros()
        {
            base.conexao = new SqlConnection(base.connString);
            base.comando = new SqlCommand();
        }
        
        public string InserirParametro(Parametros parametro)
        {
            var paramNome = new SqlParameter("@NOME", parametro.Nome);
            var paramValor = new SqlParameter("@VALOR", parametro.Valor);

            base.comando.CommandText = Insert;
            base.comando.Parameters.Add(paramNome);
            base.comando.Parameters.Add(paramValor);
            
            base.conexao.Open();
            base.comando.ExecuteNonQuery();

            return base.conexao.State.ToString();
        }
    }
}
