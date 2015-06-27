using prjEstacionamento.Sources.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstacionamento.Sources.Class
{
    class TipoVeiculo
    {
        public string Nome { get; set; }
        public daoTipoVeiculo daoTipoVeiculo { get; set; }

        public TipoVeiculo()
        {
            this.daoTipoVeiculo = new daoTipoVeiculo();
        }


        public DataTable ListarTipoVeiculos()
        {
            return this.daoTipoVeiculo.ListarTipoVeiculos();
        }

    }
}
