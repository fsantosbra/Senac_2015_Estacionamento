using prjEstacionamento.Sources.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstacionamento.Sources.Class
{
    class Vagas
    {
        public int TipoVeiculo { get; set; }
        public int QtdTotalVagas   { get; set; }
        public int QtdTotalMensalistas   { get; set; }
        public daoVagas daoVagas { get; set; }

        public Vagas()
        {
            this.daoVagas = new daoVagas();
        }

        public void InserirVagas(Vagas vagas)
        {
            this.daoVagas.InserirVagas(vagas);
        }
    }
}
