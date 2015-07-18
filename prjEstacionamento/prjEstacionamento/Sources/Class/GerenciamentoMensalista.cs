using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjEstacionamento.Sources.DAO;
using System.Data;

namespace prjEstacionamento.Sources.Class
{
    class GerenciamentoMensalista
    {
        public int MensalistaId { get; set; }
        public int TipoVeiculoId { get; set; }
        public string Placa { get; set; }
        public float Valor { get; set; }
        public DateTime DataInicioVigencia { get; set; }
        public DateTime DataFimVigencia { get; set; }

        public daoGerenciamentoMensalista daoGerenciamentoMensalista { get; set; }

        public GerenciamentoMensalista()
        {
            this.daoGerenciamentoMensalista = new daoGerenciamentoMensalista();
        }

        public int InserirPagamento(GerenciamentoMensalista dadosPagamento)
        {
            return this.daoGerenciamentoMensalista.InserirPagamento(dadosPagamento);
        }

        public DataTable ListarPagamentosMensalista(Int32 IdMensalista, string Placa)
        {
            return this.daoGerenciamentoMensalista.ListarPagamentos(IdMensalista, Placa);
        }
    }
}
