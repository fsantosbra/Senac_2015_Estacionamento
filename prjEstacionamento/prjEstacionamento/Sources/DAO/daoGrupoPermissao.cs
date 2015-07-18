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
    class daoGrupoPermissao : daoBase
    {
        private string Insert = @"INSERT INTO GRUPOPERMISSAO (NOMETELA, IDGRUPO)
                                    VALUES (@NOMETELA, @IDGRUPO)";
        private string Update = @"UPDATE GRUPOPERMISSAO 
                                     SET NOMETELA = @NOMETELA
                                   WHERE Id = @Id";
        private string Delete = @"DELETE 
                                    FROM GRUPOPERMISSAO 
                                   WHERE Id = @Id";
        private string Select = @"SELECT ID, 
                                         NOMETELA,
                                         IDGRUPO
                                    FROM GRUPOPERMISSAO
                                   WHERE IDGRUPO = @IDGRUPO";
        private string SelectId = @"SELECT ID, 
                                           NOMETELA,
                                           IDGRUPO
                                      FROM GRUPOPERMISSAO
                                     WHERE ID = @ID";

        public daoGrupoPermissao()
        {
            base.conexao = new SqlConnection(base.connString);
            base.comando = new SqlCommand();
            base.comando.Connection = base.conexao;
        }

        public void InserirGrupoPermissao(GrupoPermissao GrupoPermissao)
        {
            try
            {
                var paramNome = new SqlParameter("@NOMETELA", GrupoPermissao.nomeTela);
                var paramIdGrupo = new SqlParameter("@IDGRUPO", GrupoPermissao.IdGrupo);

                base.comando.CommandText = Insert;
                base.comando.Parameters.Add(paramNome);
                base.comando.Parameters.Add(paramIdGrupo);

                base.conexao.Open();
                base.comando.ExecuteNonQuery();
            }
            finally
            {
                base.conexao.Close();
                base.comando.Parameters.Clear();
            }
        }

        public void AlterarGrupoPermissao(GrupoPermissao GrupoPermissao)
        {
            try
            {
                var paramId = new SqlParameter("@ID", GrupoPermissao.Id);
                var paramNome = new SqlParameter("@NOMETELA", GrupoPermissao.nomeTela);

                base.comando.CommandText = Update;
                base.comando.Parameters.Add(paramId);
                base.comando.Parameters.Add(paramNome);

                base.conexao.Open();
                base.comando.ExecuteNonQuery();
            }
            finally
            {
                base.conexao.Close();
                base.comando.Parameters.Clear();
            }
        }

        public void DeletarGrupoUsuario(int id)
        {
            try
            {
                var paramId = new SqlParameter("@ID", id);
                base.comando.CommandText = Delete;
                base.comando.Parameters.Add(paramId);

                base.conexao.Open();
                base.comando.ExecuteNonQuery();
            }
            finally
            {
                base.conexao.Close();
                base.comando.Parameters.Clear();
            }
        }

        public DataTable ListarGrupoPermissao(int idGrupo)
        {
            try
            {
                var tabelaGrupoPermissao = new DataTable();
                var paramId = new SqlParameter("@IDGRUPO", idGrupo);

                base.comando.CommandText = Select;
                base.comando.Parameters.Add(paramId);
                base.conexao.Open();
                var dataReader = base.comando.ExecuteReader();

                tabelaGrupoPermissao.Load(dataReader);

                return tabelaGrupoPermissao;
            }
            finally
            {
                base.conexao.Close();
                base.comando.Parameters.Clear();
            }
        }

        public GrupoPermissao retornaGrupoPermissao(int id)
        {
            GrupoPermissao GrupoPermissao = new GrupoPermissao();
            try
            {
                var tabelaUsuarios = new DataTable();

                var paramId = new SqlParameter("@ID", id);
                base.comando.CommandText = SelectId;
                base.comando.Parameters.Add(paramId);
                base.conexao.Open();

                var dataReader = base.comando.ExecuteReader();

                tabelaUsuarios.Load(dataReader);

                if (tabelaUsuarios.Rows.Count > 0)
                {
                    GrupoPermissao.Id = Convert.ToInt32(tabelaUsuarios.Rows[0]["ID"]);
                    GrupoPermissao.nomeTela = Convert.ToString(tabelaUsuarios.Rows[0]["NOMETELA"]);
                    GrupoPermissao.IdGrupo = Convert.ToInt32(tabelaUsuarios.Rows[0]["IDGRUPO"]);
                }
            }
            finally
            {
                base.conexao.Close();
                base.comando.Parameters.Clear();
            }
            return GrupoPermissao;
        }

    }
}
