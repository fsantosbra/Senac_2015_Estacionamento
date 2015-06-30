using prjEstacionamento.Sources.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstacionamento.Sources.Class
{
    class Vagas
    {
        public int Id { get; set; }
        public string TipoVeiculoId { get; set; }
        public int QtdeVagasTotal { get; set; }
        public string QtdeMensalista { get; set; }
        public string QtdeVagasTotalCorrente { get; set; }
        public string QtdeMensalistaCorrente { get; set; }
        public daoVagas daoVagas { get; set; }
        public Vagas()
        {
            this.daoVagas = new daoVagas();
        }

        public int InserirVaga(Vagas vagas)
        {
            return this.daoVagas.InserirVaga(vagas);
        }
    }
}
