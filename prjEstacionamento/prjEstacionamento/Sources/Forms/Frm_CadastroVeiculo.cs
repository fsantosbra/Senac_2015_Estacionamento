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
    public partial class Frm_CadastroVeiculo : Form
    {
        public Frm_CadastroVeiculo()
        {
            InitializeComponent();

            var ListaTipo = new CadastroVeiculo();
            cbx_Tipo.DataSource = ListaTipo.ExibirTipoVeiculos();
            cbx_Tipo.ValueMember = "ID";
            cbx_Tipo.DisplayMember = "TIPO";

            CarregarGridVeiculos();
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            var Veiculo = new CadastroVeiculo();
            Veiculo.Modelo = txt_Modelo.Text;
            Veiculo.Tipo = Convert.ToInt32(cbx_Tipo.SelectedValue);

            if (txt_Modelo.Text.Trim() == "")
            {
                MessageBox.Show("Favor digitar um modelo!");
                return;
            }
            
            Veiculo.InserirVeiculo(Veiculo);
            MessageBox.Show("Veículo adicionado com sucesso!");
            txt_Modelo.Text = "";
            CarregarGridVeiculos();
        }

        public void CarregarGridVeiculos()
        {
            var GridVeiculos = new CadastroVeiculo();
            dbg_Veiculos.DataSource = GridVeiculos.ExibirVeiculos();
        }


    }
}
