using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjEstacionamento.Sources.DAO;
using System.Data;

namespace prjEstacionamento.Sources.Class
{
    class Pagamento
    {

        private DateTime vEntrada;
        private DateTime vSaida;
        private int vTicket;
        private double vPrimeiraHora;
        private double vDemaisHoras;

        public Pagamento(int id)
        {
            this.vTicket = id;
        }
            
        public double calculaPreco()
        {
            return 0;
        }

        private DataTable selecionaDados()
        {
            daoPagamento dao = new daoPagamento();
            return dao.SelecionaDadosTicket(this.vTicket);
        }



            //selecionar todos os dados da tabela usoVagas (modeloid, dataentrada, datasaida, teveparceiro, ehmensalista,mensalistaid)
            //qual o tipo de veiculo? (pequeno, grande, moto)
            //preencher a primeira hora e as outrashoras conforme o tipo
            //quantas horas foram utilizadas? totalHoras = (datasaida - dataentrada)
            //arredonta o totalHoras
            //é mensalista ativo? (ehmensalista != null)
                //totalhoras = 0
            //senao é mensalista, tem parceiro? (teveparceiro != null)
                    //qual é o desconto do parceiro?
                        //total - desconto = total
                            //se total < 0 , total = 0
            
            //separceiro
                //preco = totalhoras * vDemaisHoras
            //semensalista
                //preco =  0
            //senao
                //se totalhoras > 1
                    //preco = ((totalhoras-1)*vDemaisHoras)+vPrimeiraHora;
                //senao
                    //preco = VprimeiraHora;

            //retorna preco;
                              


    }
}
