﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjEstacionamento.Sources.DAO;
using System.Data;

namespace prjEstacionamento.Sources.Class
{
    class Mensalista
    {

        public string Nome { get; set; }
        public int EnderecoId { get; set; }
        public bool Ativo { get; set; }

        public daoMensalista daoMensalista { get; set; }

        public Mensalista()
        {
            this.daoMensalista = new daoMensalista();
        }

        public int InserirMensalista(Mensalista mensalista)
        {
            return this.daoMensalista.InserirMensalista(mensalista);
        }

        public DataTable ListarMensalistas()
        {
            return this.daoMensalista.ListarMensalistas();
        }


        public DataTable FiltrarPesquisa(string nomeMensalista)
        {
            return this.daoMensalista.FiltrarPesquisa(nomeMensalista);
        }

        public DataTable FiltrarMensalista(object mensalistaId)
        {
            return this.daoMensalista.FiltrarMensalista(mensalistaId);
        }
    }
}
