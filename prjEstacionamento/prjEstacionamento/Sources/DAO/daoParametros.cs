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

        public daoParametros()
        {
            base.conexao = new SqlConnection(base.connString);
            base.comando = new SqlCommand();
        }
        
        public string TestaConexao()
        {
            base.conexao.Open();

            return base.conexao.State.ToString();
        }
    }
}
