﻿using prjEstacionamento.Sources.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstacionamento.Sources.Class
{
    class PrecoMensalista
    {

        public int Id { get; set; }
        public int MensalistaId { get; set; }
        public int TipoVeiculoId { get; set; }
        public string Placa { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataInicioVigencia { get; set; }
        public DateTime DataFimVigencia { get; set; }
        public daoPrecoMensalista daoPrecoMensalista { get; set; }
        public PrecoMensalista()
        {
            this.daoPrecoMensalista = new daoPrecoMensalista();
        }

        internal void InserirPrecoMensalista(PrecoMensalista precoMensalista)
        {
            this.daoPrecoMensalista.InserirPrecoMensalista(precoMensalista);
        }
    }
}
