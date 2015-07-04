using prjEstacionamento.Sources.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstacionamento.Sources.Class
{
    class Endereco
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public string Telefone { get; set; }
        public daoEndereco daoEndereco { get; set; }
        public Endereco()
        {
            this.daoEndereco = new daoEndereco();
        }

        public int InserirEndereco(Endereco endereco)
        {
            return this.daoEndereco.InserirEndereco(endereco);
        }
    }
}
