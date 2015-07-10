using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjEstacionamento.Sources.DAO;
using System.Data;

namespace prjEstacionamento.Sources.Class
{
    class CadastroParceiros
    {
        public string Nome    { get; set; }
        public decimal Desconto { get; set; }
        public int Id         { get; set; }
        public daoParceiros daoParceiros { get; set; }

        public CadastroParceiros()
        {
            this.daoParceiros = new daoParceiros();
        }

        public void InserirParceiro(CadastroParceiros Parceiro)
        {
            this.daoParceiros.InserirParceiros(Parceiro);
        }

        public void AlterarParceiro(CadastroParceiros Parceiro)
        {
            this.daoParceiros.AlterarParceiro(Parceiro);
        }

        public void ExcluirParceiro(CadastroParceiros Parceiro)
        {
            this.daoParceiros.ExcluirParceiro(Parceiro);
        }

        public DataTable ExibirParceiros()
        {
            return this.daoParceiros.ExibirParceiros();
        }
    }
}
