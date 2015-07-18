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

            CarregarListaTipoVeiculo();

            CarregarGridVeiculos();
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            var Veiculo = new CadastroVeiculo();
            Veiculo.Modelo = txt_Modelo.Text;
            Veiculo.Tipo = Convert.ToInt32(cbx_Tipo.SelectedValue);

            if (txt_Modelo.Text.Trim() == "")
            {
                MessageBox.Show("Favor digitar um modelo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (btn_Adicionar.Text == "Adicionar")
            {
                Veiculo.InserirVeiculo(Veiculo);
                MessageBox.Show("Veículo adicionado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);           
            }
            else if (btn_Adicionar.Text == "Alterar")
            {
                int row = dbg_Veiculos.CurrentRow.Index;
                Veiculo.Id = Convert.ToInt32(dbg_Veiculos[0,row].Value);
                Veiculo.AlterarVeiculo(Veiculo);
                btn_Adicionar.Text = "Adicionar";
                btn_Exluir.Text = "Excluir";
                dbg_Veiculos.Enabled = true;
                MessageBox.Show("Veículo alterado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txt_Modelo.Text = "";
            CarregarGridVeiculos();
        }

        public void CarregarGridVeiculos()
        {
            var GridVeiculos = new CadastroVeiculo();
            dbg_Veiculos.DataSource = GridVeiculos.ExibirVeiculos();
            dbg_Veiculos.Columns["ID"].Visible = false;
            dbg_Veiculos.Columns["Modelo"].Width = 535;
            dbg_Veiculos.Columns["Tipo"].Width = 100;
            dbg_Veiculos.ReadOnly = true;
        }

        public void CarregarListaTipoVeiculo()
        {
            var ListaTipo = new CadastroVeiculo();
            cbx_Tipo.DataSource = ListaTipo.ExibirTipoVeiculos();
            cbx_Tipo.ValueMember = "ID";
            cbx_Tipo.DisplayMember = "TIPO";
        }

        private void btn_Exluir_Click(object sender, EventArgs e)
        {
            if (btn_Exluir.Text == "Excluir")
            {
                DialogResult confirma = MessageBox.Show("Confima a exclusão do veículo selecionado?", "Apagar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirma.Equals(DialogResult.Yes))
                {
                    var Veiculo = new CadastroVeiculo();
                    int row = dbg_Veiculos.CurrentRow.Index;
                    Veiculo.Id = Convert.ToInt32(dbg_Veiculos[0, row].Value);
                    Veiculo.ExcluirVeiculo(Veiculo);
                    MessageBox.Show("Veículo excluído com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (btn_Exluir.Text == "Cancelar")
            {
                btn_Adicionar.Text = "Adicionar";
                btn_Exluir.Text = "Excluir";
                dbg_Veiculos.Enabled = true;
                txt_Modelo.Text = "";
            }

            CarregarGridVeiculos();
        }

        private void dbg_Veiculos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult confirma = MessageBox.Show("Confima a seleção do veículo para alteração?", "Alterar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirma.Equals(DialogResult.Yes))
            {
                int row = dbg_Veiculos.CurrentRow.Index;
                txt_Modelo.Text = dbg_Veiculos[1, row].Value.ToString();
                cbx_Tipo.Text = dbg_Veiculos[2, row].Value.ToString();
                
                dbg_Veiculos.Enabled = false;
                btn_Adicionar.Text = "Alterar";
                btn_Exluir.Text = "Cancelar";
            }
        }

    }
}
