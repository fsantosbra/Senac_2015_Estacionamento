using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjEstacionamento.Sources.DAO;
using System.Data;

namespace prjEstacionamento.Sources.Class
{
    class Modelo
    {
        private daoModelo daoModelo { get; set; }


        public Modelo()
        {
            this.daoModelo = new daoModelo();
        }

        public DataTable listarModelos()
        {
            return this.daoModelo.listarModelos();
        }
    }
}
