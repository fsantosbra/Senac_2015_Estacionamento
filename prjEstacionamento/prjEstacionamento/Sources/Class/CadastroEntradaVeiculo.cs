using prjEstacionamento.Sources.DAO;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstacionamento.Sources.Class
{
    class CadastroEntradaVeiculo
    {
        public int Id { get; set; }
        public int modeloId { get; set; }
        public String placa { get; set; }
        public DateTime dataEntrada { get; set; }
        public DateTime dataSaida { get; set; }
        public int mensalistaId { get; set; }
        public String corVeiculo { get; set; }
        public int parceiroId { get; set; }

        public daoEntradaVeiculo daoEntradaVeiculo { get; set; }



        public void inserirEntradaVeiculo(CadastroEntradaVeiculo entradaVeiculo)
        {
            entradaVeiculo.daoEntradaVeiculo = new daoEntradaVeiculo();
            this.daoEntradaVeiculo.inserirEntradaVeiculo(entradaVeiculo);
        }

        public DataTable SelectToday() 
        {
            DataTable Dados = daoEntradaVeiculo.SelectToday();
            return Dados;
        }
    }
}
