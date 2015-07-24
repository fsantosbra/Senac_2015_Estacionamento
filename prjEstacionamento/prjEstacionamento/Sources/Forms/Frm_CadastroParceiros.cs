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
    public partial class Frm_CadastroParceiro : Form
    {
        public Frm_CadastroParceiro()
        {
            InitializeComponent();

            CarregarGridParceiros();
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            var Parceiro = new CadastroParceiros();
            Parceiro.Nome = txt_NomeParceiro.Text;
            
            if (txt_Desconto.Text.Trim() == "")
            {
                txt_Desconto.Text = "0.00";
            }

            Parceiro.Desconto = Convert.ToDecimal(txt_Desconto.Text);

            if (txt_NomeParceiro.Text.Trim() == "")
            {
                MessageBox.Show("Favor digitar o nome do parceiro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txt_Desconto.Text.Trim() == "")
            {
                MessageBox.Show("Favor digitar o valor do desconto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (btn_Adicionar.Text == "Adicionar")
            {
                Parceiro.InserirParceiro(Parceiro);
                MessageBox.Show("Parceiro adicionado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarGridParceiros();
            }
            else if (btn_Adicionar.Text == "Alterar")
            {
                int row = dbg_Parceiros.CurrentRow.Index;
                Parceiro.Id = Convert.ToInt32(dbg_Parceiros[0, row].Value);
                Parceiro.AlterarParceiro(Parceiro);
                btn_Adicionar.Text = "Adicionar";
                btn_Exluir.Text = "Excluir";
                dbg_Parceiros.Enabled = true;
                MessageBox.Show("Parceiro alterado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarGridParceiros();
            }
            else
            {
                dbg_Parceiros.DataSource = Parceiro.ExibirParceiroPesquisa(Parceiro.Nome);
                dbg_Parceiros.Columns["ID"].Visible = false;
                dbg_Parceiros.Columns["NOMEPARCEIRO"].Width = 535;
                dbg_Parceiros.Columns["DESCONTO"].Width = 100;
                dbg_Parceiros.Columns["NOMEPARCEIRO"].HeaderText = "PARCEIRO";
                dbg_Parceiros.ReadOnly = true;
            }

            txt_NomeParceiro.Text = "";
            txt_Desconto.Text = "";

        }

        public void CarregarGridParceiros()
        {
            var GridParceiros = new CadastroParceiros();
            dbg_Parceiros.DataSource = GridParceiros.ExibirParceiros();
            dbg_Parceiros.Columns["ID"].Visible = false;
            dbg_Parceiros.Columns["NOMEPARCEIRO"].Width = 535;
            dbg_Parceiros.Columns["DESCONTO"].Width = 100;
            dbg_Parceiros.Columns["NOMEPARCEIRO"].HeaderText = "PARCEIRO";
            dbg_Parceiros.ReadOnly = true;
        }

        private void btn_Exluir_Click(object sender, EventArgs e)
        {
            if (btn_Exluir.Text == "Excluir")
            {
                DialogResult confirma = MessageBox.Show("Confima a exclusão do parceiro selecionado?", "Apagar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirma.Equals(DialogResult.Yes))
                {
                    var Parceiro = new CadastroParceiros();
                    int row = dbg_Parceiros.CurrentRow.Index;
                    Parceiro.Id = Convert.ToInt32(dbg_Parceiros[0, row].Value);
                    Parceiro.ExcluirParceiro(Parceiro);
                    MessageBox.Show("Parceiro excluído com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (btn_Exluir.Text == "Cancelar")
            {
                btn_Adicionar.Text = "Adicionar";
                btn_Exluir.Text = "Excluir";
                dbg_Parceiros.Enabled = true;
                txt_NomeParceiro.Text = "";
                txt_Desconto.Text = "";
            }

            CarregarGridParceiros();
        }


        private void txt_Desconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }

        private void dbg_Parceiros_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (btn_Adicionar.Text == "Pesquisar")
            {
                return;
            }

            DialogResult confirma = MessageBox.Show("Confima a seleção do parceiro para alteração?", "Alterar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirma.Equals(DialogResult.Yes))
            {
                int row = dbg_Parceiros.CurrentRow.Index;
                txt_NomeParceiro.Text = dbg_Parceiros[1, row].Value.ToString();
                txt_Desconto.Text = dbg_Parceiros[2, row].Value.ToString();

                dbg_Parceiros.Enabled = false;
                btn_Adicionar.Text = "Alterar";
                btn_Exluir.Text = "Cancelar";
            }
        }
    }
}
