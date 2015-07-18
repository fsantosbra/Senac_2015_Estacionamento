using prjEstacionamento.Sources.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjEstacionamento.Sources.Forms
{
    public partial class frmGrupoPermissao : Form
    {
        public int idGrupo;

        public frmGrupoPermissao()
        {
            InitializeComponent();

            CarregarGridGrupoPermissao();

            cmbTelas.SelectedIndex = 0;
        }

        public void CarregarGridGrupoPermissao()
        {
            var GridGrupoPermissao = new GrupoPermissao();
            dbgGrupoPermissao.DataSource = GridGrupoPermissao.ListarGrupoPermissao(idGrupo);
            dbgGrupoPermissao.Columns["ID"].Visible = false;
            dbgGrupoPermissao.Columns["NOMETELA"].Width = 535;
            dbgGrupoPermissao.Columns["IDGRUPO"].Visible = false;
            dbgGrupoPermissao.ReadOnly = true;

            dbgGrupoPermissao.Enabled = !(dbgGrupoPermissao.RowCount == 0);
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            var GrupoPermissao = new GrupoPermissao();
            GrupoPermissao.IdGrupo = idGrupo;
            GrupoPermissao.nomeTela = Convert.ToString(cmbTelas.SelectedItem);

            if (btn_Adicionar.Text == "Adicionar")
            {
                GrupoPermissao.InserirGrupoPermissao(GrupoPermissao);
                MessageBox.Show("Permissão adicionada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (btn_Adicionar.Text == "Alterar")
            {
                int row = dbgGrupoPermissao.CurrentRow.Index;
                GrupoPermissao.Id = Convert.ToInt32(dbgGrupoPermissao["ID", row].Value);
                GrupoPermissao.AlterarGrupoPermissao(GrupoPermissao);
                btn_Adicionar.Text = "Adicionar";
                btn_Exluir.Text = "Excluir";
                dbgGrupoPermissao.Enabled = true;
                MessageBox.Show("Permissão alterada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            cmbTelas.SelectedIndex = 0;
            CarregarGridGrupoPermissao();
        }

        private void btn_Exluir_Click(object sender, EventArgs e)
        {
            if (btn_Exluir.Text == "Excluir")
            {
                DialogResult confirma = MessageBox.Show("Confima a exclusão da permissão selecionada?", "Apagar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirma.Equals(DialogResult.Yes))
                {
                    var GrupoPermissao = new GrupoPermissao();
                    int row = dbgGrupoPermissao.CurrentRow.Index;
                    GrupoPermissao.Id = Convert.ToInt32(dbgGrupoPermissao["ID", row].Value);
                    GrupoPermissao.ExcluirGrupoPermissao(GrupoPermissao);
                    MessageBox.Show("Permissão excluída com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (btn_Exluir.Text == "Cancelar")
            {
                btn_Adicionar.Text = "Adicionar";
                btn_Exluir.Text = "Excluir";
                dbgGrupoPermissao.Enabled = true;
                cmbTelas.SelectedIndex = 0;
            }

            CarregarGridGrupoPermissao();
        }

        private void dbgGrupoPermissao_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult confirma = MessageBox.Show("Confima a seleção da permissão para alteração?", "Alterar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirma.Equals(DialogResult.Yes))
            {
                int row = dbgGrupoPermissao.CurrentRow.Index;
                cmbTelas.SelectedItem = dbgGrupoPermissao["NOMETELA", row].Value.ToString();

                dbgGrupoPermissao.Enabled = false;
                btn_Adicionar.Text = "Alterar";
                btn_Exluir.Text = "Cancelar";
            }
        }
    }
}
