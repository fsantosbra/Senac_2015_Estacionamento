using System;
using System.Collections.Generic;
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
            base.conexao = new SqlConnection();
            base.comando = new SqlCommand();
        }
        

    }
}
