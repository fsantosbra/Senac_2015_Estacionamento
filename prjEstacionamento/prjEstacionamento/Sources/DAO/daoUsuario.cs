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
    class daoUsuario : daoBase
    {
        private string Insert = @"INSERT INTO ACESSO (FUNCIONARIO, LOGIN, SENHA, IDGRUPO)
                                    VALUES (@FUNCIONARIO, @LOGIN, @SENHA, @IDGRUPO)";
        private string Update = @"UPDATE ACESSO 
                                     SET FUNCIONARIO = @FUNCIONARIO, 
                                         LOGIN = @LOGIN, 
                                         SENHA = @SENHA, 
                                         IDGRUPO = @IDGRUPO
                                   WHERE Id = @Id";
        private string Delete = @"DELETE 
                                    FROM ACESSO 
                                   WHERE Id = @Id";
        private string Select = @"SELECT A.ID, 
                                         A.FUNCIONARIO, 
                                         A.LOGIN, 
                                         A.SENHA, 
                                         A.IDGRUPO,
                                         B.NOME GRUPO
                                    FROM ACESSO A,
                                         GRUPOACESSO B
                                   WHERE A.IDGRUPO = B.ID";
        private string SelectId = @"SELECT ID, 
                                           FUNCIONARIO, 
                                           LOGIN, 
                                           SENHA, 
                                           IDGRUPO 
                                      FROM ACESSO
                                     WHERE ID = @ID";

        private string SelectLogin = @"SELECT ID, 
                                           FUNCIONARIO, 
                                           LOGIN, 
                                           SENHA, 
                                           IDGRUPO 
                                      FROM ACESSO
                                     WHERE LOGIN = @LOGIN";


        public daoUsuario()
        {
            base.conexao = new SqlConnection(base.connString);
            base.comando = new SqlCommand();
            base.comando.Connection = base.conexao;
        }

        public void InserirUsuario(Usuario usuario)
        {
            try
            {
                var paramFuncionario = new SqlParameter("@FUNCIONARIO", usuario.funcionario);
                var paramLogin = new SqlParameter("@LOGIN", usuario.login);
                var paramSenha = new SqlParameter("@SENHA", usuario.senha);
                var paramIdGrupo = new SqlParameter("@IDGRUPO", usuario.idgrupo);

                base.comando.CommandText = Insert;
                base.comando.Parameters.Add(paramFuncionario);
                base.comando.Parameters.Add(paramLogin);
                base.comando.Parameters.Add(paramSenha);
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

        public void AlterarUsuario(Usuario usuario)
        {
            try
            {
                var paramId = new SqlParameter("@ID", usuario.Id);
                var paramFuncionario = new SqlParameter("@FUNCIONARIO", usuario.funcionario);
                var paramLogin = new SqlParameter("@LOGIN", usuario.login);
                var paramSenha = new SqlParameter("@SENHA", usuario.senha);
                var paramIdGrupo = new SqlParameter("@IDGRUPO", usuario.idgrupo);

                base.comando.CommandText = Update;
                base.comando.Parameters.Add(paramId);
                base.comando.Parameters.Add(paramFuncionario);
                base.comando.Parameters.Add(paramLogin);
                base.comando.Parameters.Add(paramSenha);
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

        public void DeletarUsuario(int id)
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

        public DataTable ListarUsuarios()
        {
            try
            {
                var tabelaUsuarios = new DataTable();

                base.comando.CommandText = Select;
                base.conexao.Open();
                var dataReader = base.comando.ExecuteReader();

                tabelaUsuarios.Load(dataReader);

                return tabelaUsuarios;
            }
            finally
            {
                base.conexao.Close();
                base.comando.Parameters.Clear();
            }
        }

        public Usuario retornaUsuario(int id)
        {
            Usuario usuario = new Usuario();
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
                    usuario.Id = Convert.ToInt32(tabelaUsuarios.Rows[0]["ID"]);
                    usuario.funcionario = Convert.ToString(tabelaUsuarios.Rows[0]["FUNCIONARIO"]);
                    usuario.login = Convert.ToString(tabelaUsuarios.Rows[0]["LOGIN"]);
                    usuario.senha = Convert.ToString(tabelaUsuarios.Rows[0]["SENHA"]);
                    usuario.idgrupo = Convert.ToInt32(tabelaUsuarios.Rows[0]["IDGRUPO"]);
                }
            }
            finally
            {                
                base.conexao.Close();
                base.comando.Parameters.Clear();                
            }
            return usuario;
        }

        public Usuario retornaUsuarioLogin(string login)
        {
            Usuario usuario = new Usuario();
            try
            {
                DataTable tabelaUsuarios = new DataTable();

                var paramLogin = new SqlParameter("@LOGIN", login);
                base.comando.CommandText = SelectLogin;
                base.comando.Parameters.Add(paramLogin);
                base.conexao.Open();

                var dataReader = base.comando.ExecuteReader();

                tabelaUsuarios.Load(dataReader);

                if (tabelaUsuarios.Rows.Count > 0)
                {
                    usuario.Id = Convert.ToInt32(tabelaUsuarios.Rows[0]["ID"]);
                    usuario.funcionario = Convert.ToString(tabelaUsuarios.Rows[0]["FUNCIONARIO"]);
                    usuario.login = Convert.ToString(tabelaUsuarios.Rows[0]["LOGIN"]);
                    usuario.senha = Convert.ToString(tabelaUsuarios.Rows[0]["SENHA"]);
                    usuario.idgrupo = Convert.ToInt32(tabelaUsuarios.Rows[0]["IDGRUPO"]);
                }
            }
            finally
            {
                base.conexao.Close();
                base.comando.Parameters.Clear();
            }
            return usuario;
        }
    }
}
