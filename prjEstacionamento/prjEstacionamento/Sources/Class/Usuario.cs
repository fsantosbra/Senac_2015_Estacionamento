using prjEstacionamento.Sources.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstacionamento.Sources.Class
{
    class Usuario
    {
        public int Id { get; set; }
        public string funcionario { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public int idgrupo { get; set; }
        public daoUsuario daoUsuario { get; set; }

        public Usuario()
        {
            this.daoUsuario = new daoUsuario();
        }

        public void InserirUsuario(Usuario Usuario)
        {
            this.daoUsuario.InserirUsuario(Usuario);
        }

        public void AlterarUsuario(Usuario Usuario)
        {
            this.daoUsuario.AlterarUsuario(Usuario);
        }

        public void ExcluirUsuario(Usuario Usuario)
        {
            this.daoUsuario.DeletarUsuario(Usuario.Id);
        }

        public DataTable ListarUsuarios()
        {
            return this.daoUsuario.ListarUsuarios();
        }

        public Usuario retornaUsuario(int id)
        {
            return this.daoUsuario.retornaUsuario(id);
        }

        public Usuario retornaUsuario(string login)
        {
            return this.daoUsuario.retornaUsuarioLogin(login);
        }
    }
}
