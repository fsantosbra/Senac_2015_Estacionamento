using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjEstacionamento.Sources.DAO;

namespace prjEstacionamento.Sources.Class
{
    class Parametros
    {

        public string Nome { get; set; }
        public string Valor { get; set; }

        public Parametros()
        {

        }

        public void InserirParametro(Parametros parametro)
        {
            var daoParametro = new daoParametros();
            daoParametro.InserirParametro(parametro);
        }





    }
}
