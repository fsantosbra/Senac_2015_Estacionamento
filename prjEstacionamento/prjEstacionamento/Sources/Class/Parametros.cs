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

        private string Nome { get; set; }
        private string Valor { get; set; }

        public Parametros()
        {

        }

        public string TestaConexao()
        {
            var daoParametro = new daoParametros();

            var estadoconexao = daoParametro.TestaConexao();

            return estadoconexao;
        }





    }
}
