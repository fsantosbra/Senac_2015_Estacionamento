using prjEstacionamento.Sources.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace prjEstacionamento.Sources.Class
{
    class Vagas
    {
        public int Id { get; set; }
        public string TipoVeiculoId { get; set; }
        public int QtdeVagasTotal { get; set; }
        public int QtdeMensalista { get; set; }
        public int QtdeVagasTotalCorrente { get; set; }
        public int QtdeMensalistaCorrente { get; set; }
        
        public daoVagas daoVagas { get; set; }
        public Vagas()
        {
            daoVagas = new daoVagas();
        }

        public int InserirVaga(Vagas vagas)
        {
            return daoVagas.InserirVaga(vagas);
        }

        public DataTable ListarVagas()
        {
            return daoVagas.ListarVagas();
        }
    }
}
