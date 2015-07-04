using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using prjEstacionamento.Sources.Class;

namespace prjEstacionamento.Sources.DAO
{
    class daoModelo : daoBase
    {
        private string Select = @"SELECT ID, MODELO, TIPOVEICULOID FROM MODELO";

        public daoModelo()
        {
            base.conexao = new SqlConnection(base.connString);
            base.comando = new SqlCommand();
            base.comando.Connection = base.conexao;
        }

        public DataTable listarModelos()
        {
            try
            {
                var tabelaModelo = new DataTable();
                base.comando.CommandText = Select;
                base.conexao.Open();
                var dataReader = base.comando.ExecuteReader();

                tabelaModelo.Load(dataReader);

                return tabelaModelo;
            }
            finally
            {
                base.conexao.Close();
                base.comando.Parameters.Clear();
            }
        }
    }
}
