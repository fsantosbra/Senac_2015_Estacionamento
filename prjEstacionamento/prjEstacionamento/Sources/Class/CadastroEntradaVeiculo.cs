using prjEstacionamento.Sources.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstacionamento.Sources.Class
{
    class CadastroEntradaVeiculo
    {
        public int modeloId { get; set; }
        public String placa { get; set; }
        public DateTime dataEntrada { get; set; }
        public int mensalistaId { get; set; }
        public String corVeiculo { get; set; }
        public daoEntradaVeiculo daoEntradaVeiculo { get; set; }



        public void inserirEntradaVeiculo(CadastroEntradaVeiculo entradaVeiculo)
        {
            entradaVeiculo.daoEntradaVeiculo = new daoEntradaVeiculo();
            this.daoEntradaVeiculo.inserirEntradaVeiculo(entradaVeiculo);
        }
    }
}
