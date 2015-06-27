using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstacionamento.Sources.DAO
{
    class daoBase
    {

        protected string connString = "Data Source=hr006nk9uk.database.windows.net; Initial Catalog=senacpos2015; User Id=senacpos2015; Password=Senac2015; Connect Timeout=30; Encrypt=true;Trusted_Connection=false;";
        protected SqlConnection conexao { get; set; }
        protected SqlCommand comando { get; set; }

        public daoBase()
        {
            conexao = new SqlConnection(connString);
            comando = new SqlCommand();
        }

    }
}
