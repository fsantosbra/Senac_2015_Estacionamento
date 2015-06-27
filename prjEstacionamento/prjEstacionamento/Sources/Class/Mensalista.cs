using System;
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
        public string Valor { get; set; }
        public daoMensalista daoMensalista { get; set; }

        public Mensalista()
        {
            this.daoMensalista = new daoMensalista();
        }

        public void InserirParametro(Mensalista parametro)
        {
            this.daoMensalista.InserirParametro(parametro);
        }

        public DataTable ListarParametros()
        {
            return this.daoMensalista.ListarParametros();
        }





    }
}
