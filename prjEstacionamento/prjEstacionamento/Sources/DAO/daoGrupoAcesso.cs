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
    class daoGrupoAcesso : daoBase
    {
        private string Insert = @"INSERT INTO GRUPOACESSO (NOME)
                                    VALUES (@NOME)";
        private string Update = @"UPDATE GRUPOACESSO 
                                     SET NOME = @NOME
                                   WHERE Id = @Id";
        private string Delete = @"DELETE 
                                    FROM GRUPOACESSO 
                                   WHERE Id = @Id";
        private string Select = @"SELECT ID, 
                                         NOME
                                    FROM GRUPOACESSO";
        private string SelectId = @"SELECT ID, 
                                           NOME
                                      FROM GRUPOACESSO
                                     WHERE ID = @ID";

        public daoGrupoAcesso()
        {
            base.conexao = new SqlConnection(base.connString);
            base.comando = new SqlCommand();
            base.comando.Connection = base.conexao;
        }

        public void InserirGrupoUsuario(GrupoAcesso GrupoAcesso)
        {
            try
            {
                var paramNome = new SqlParameter("@NOME", GrupoAcesso.nome);

                base.comando.CommandText = Insert;
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

        public void AlterarGrupoUsuario(GrupoAcesso GrupoAcesso)
        {
            try
            {
                var paramId = new SqlParameter("@ID", GrupoAcesso.Id);
                var paramNome = new SqlParameter("@NOME", GrupoAcesso.nome);

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

        public DataTable ListarGrupoUsuarios()
        {
            try
            {
                var tabelaGrupoUsuarios = new DataTable();

                base.comando.CommandText = Select;
                base.conexao.Open();
                var dataReader = base.comando.ExecuteReader();

                tabelaGrupoUsuarios.Load(dataReader);

                return tabelaGrupoUsuarios;
            }
            finally
            {
                base.conexao.Close();
                base.comando.Parameters.Clear();
            }
        }

        public GrupoAcesso retornaGrupoUsuario(int id)
        {
            GrupoAcesso GrupoAcesso = new GrupoAcesso();
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
                    GrupoAcesso.Id = Convert.ToInt32(tabelaUsuarios.Rows[0]["ID"]);
                    GrupoAcesso.nome = Convert.ToString(tabelaUsuarios.Rows[0]["NOME"]);
                }
            }
            finally
            {                
                base.conexao.Close();
                base.comando.Parameters.Clear();                
            }
            return GrupoAcesso;
        }
    }
}
