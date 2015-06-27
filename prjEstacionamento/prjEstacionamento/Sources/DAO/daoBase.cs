using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstacionamento.Sources.DAO
{
    class daoBase
    {

        protected string connString { get; set; }
        protected SqlConnection conexao { get; set; }
        protected SqlCommand comando { get; set; }

        public daoBase()
        {
            conexao = new SqlConnection();
            comando = new SqlCommand();
        }

    }
}
