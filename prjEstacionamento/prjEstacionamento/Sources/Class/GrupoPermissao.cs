using prjEstacionamento.Sources.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstacionamento.Sources.Class
{
    class GrupoPermissao
    {
        public int Id { get; set; }
        public string nomeTela { get; set; }
        public int IdGrupo { get; set; }

        public daoGrupoPermissao daoGrupoPermissao { get; set; }

        public GrupoPermissao()
        {
            this.daoGrupoPermissao = new daoGrupoPermissao();
        }

        public void InserirGrupoPermissao(GrupoPermissao GrupoPermissao)
        {
            this.daoGrupoPermissao.InserirGrupoPermissao(GrupoPermissao);
        }

        public void AlterarGrupoPermissao(GrupoPermissao GrupoPermissao)
        {
            this.daoGrupoPermissao.AlterarGrupoPermissao(GrupoPermissao);
        }

        public void ExcluirGrupoPermissao(GrupoPermissao GrupoPermissao)
        {
            this.daoGrupoPermissao.DeletarGrupoUsuario(GrupoPermissao.Id);
        }

        public DataTable ListarGrupoPermissao(int idGrupo)
        {
            return this.daoGrupoPermissao.ListarGrupoPermissao(idGrupo);
        }

        public GrupoPermissao retornaGrupoUsuario(GrupoPermissao GrupoPermissao)
        {
            return this.daoGrupoPermissao.retornaGrupoPermissao(GrupoPermissao.Id);
        }
    }
}
