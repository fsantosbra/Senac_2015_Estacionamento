using prjEstacionamento.Sources.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstacionamento.Sources.Class
{
    class GrupoAcesso
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public daoGrupoAcesso daoGrupoAcesso { get; set; }

        public GrupoAcesso()
        {
            this.daoGrupoAcesso = new daoGrupoAcesso();
        }

        public void InserirGrupoUsuario(GrupoAcesso grupoAcesso)
        {
            this.daoGrupoAcesso.InserirGrupoUsuario(grupoAcesso);
        }

        public void AlterarGrupoUsuario(GrupoAcesso grupoAcesso)
        {
            this.daoGrupoAcesso.AlterarGrupoUsuario(grupoAcesso);
        }

        public void ExcluirGrupoUsuario(GrupoAcesso grupoAcesso)
        {
            this.daoGrupoAcesso.DeletarGrupoUsuario(grupoAcesso.Id);
        }

        public DataTable ListarGrupoUsuarios()
        {
            return this.daoGrupoAcesso.ListarGrupoUsuarios();
        }

        public GrupoAcesso retornaGrupoUsuario(GrupoAcesso grupoAcesso)
        {
            return this.daoGrupoAcesso.retornaGrupoUsuario(grupoAcesso.Id);
        }
    }
}
