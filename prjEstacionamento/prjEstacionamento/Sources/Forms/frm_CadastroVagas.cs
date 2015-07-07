using prjEstacionamento.Sources.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjEstacionamento
{
    public partial class Frm_CadastroVagas : Form
    {
        public Frm_CadastroVagas()
        {
            InitializeComponent();

            var ListaTipo = new CadastroVeiculo();
            var ListaTipoVeiculo = new TipoVeiculo();
            cbx_Tipo.DataSource = ListaTipoVeiculo.ListarTipoVeiculos();
            cbx_Tipo.ValueMember = "ID";
            cbx_Tipo.DisplayMember = "TIPO";

            CarregarGridVagas();
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            var Vaga = new Vagas();
            Vaga.QtdeVagasTotal = int.Parse(txt_QntdeTotal.Text);
            Vaga.TipoVeiculoId = int.Parse(cbx_Tipo.SelectedValue.ToString());

            if (txt_QntdeTotal.Text.Trim() == "")
            {
                MessageBox.Show("Favor digitar a quantidade Total de Vagas!");
                return;
            }
            
            Vaga.InserirVaga(Vaga);
            MessageBox.Show("Vaga adicionada com sucesso!");
            txt_QntdeTotal.Text = "";
            CarregarGridVagas();
        }

        public void CarregarGridVagas()
        {
            var GridVagas = new Vagas();
            dbg_Vagas.DataSource = GridVagas.ListarVagas();
        }


    }
}
