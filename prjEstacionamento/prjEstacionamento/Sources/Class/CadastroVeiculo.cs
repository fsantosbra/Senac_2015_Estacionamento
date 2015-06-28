using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjEstacionamento.Sources.DAO;
using System.Data;

namespace prjEstacionamento.Sources.Class
{
    class CadastroVeiculo
    {
        public string Modelo { get; set; }
        public int    Tipo   { get; set; }
        public daoVeiculos daoVeiculos { get; set; }

        public CadastroVeiculo()
        {
            this.daoVeiculos = new daoVeiculos();
        }

        public void InserirVeiculo(CadastroVeiculo Veiculo)
        {
            this.daoVeiculos.InserirVeiculo(Veiculo);
        }

        public DataTable ExibirVeiculos()
        {
            return this.daoVeiculos.ExibirVeiculos();
        }

        public DataTable ExibirTipoVeiculos()
        {
            return this.daoVeiculos.ExibirTipoVeiculos();
        }
    }
}
