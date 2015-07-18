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

namespace prjEstacionamento.Sources.Forms
{
    public partial class frmGrupoAcesso : Form
    {
        private frmGrupoPermissao frmGrupoPermissao;

        public Menu formmenu;

        public bool podeAcessarTelaPermissoes;

        public frmGrupoAcesso()
        {
            InitializeComponent();

            CarregarGridGrupoUsuarios();
        }

        public void CarregarGridGrupoUsuarios()
        {
            var GridGrupoUsuarios = new GrupoAcesso();
            dbgGrupoPermissao.DataSource = GridGrupoUsuarios.ListarGrupoUsuarios();
            dbgGrupoPermissao.Columns["ID"].Visible = false;
            dbgGrupoPermissao.Columns["NOME"].Width = 535;
            dbgGrupoPermissao.ReadOnly = true;

            dbgGrupoPermissao.Enabled = !(dbgGrupoPermissao.RowCount == 0);
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            var GrupoAcesso = new GrupoAcesso();
            GrupoAcesso.nome = txtNome.Text;

            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Nome do Grupo obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (btn_Adicionar.Text == "Adicionar")
            {
                GrupoAcesso.InserirGrupoUsuario(GrupoAcesso);
                MessageBox.Show("Grupo adicionado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (btn_Adicionar.Text == "Alterar")
            {
                int row = dbgGrupoPermissao.CurrentRow.Index;
                GrupoAcesso.Id = Convert.ToInt32(dbgGrupoPermissao["ID", row].Value);
                GrupoAcesso.AlterarGrupoUsuario(GrupoAcesso);
                btn_Adicionar.Text = "Adicionar";
                btn_Exluir.Text = "Excluir";
                dbgGrupoPermissao.Enabled = true;
                MessageBox.Show("Grupo alterado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtNome.Text = "";
            CarregarGridGrupoUsuarios();
        }

        private void btn_Exluir_Click(object sender, EventArgs e)
        {
            if (btn_Exluir.Text == "Excluir")
            {
                DialogResult confirma = MessageBox.Show("Confima a exclusão do grupo selecionado?", "Apagar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirma.Equals(DialogResult.Yes))
                {
                    var GrupoAcesso = new GrupoAcesso();
                    int row = dbgGrupoPermissao.CurrentRow.Index;
                    GrupoAcesso.Id = Convert.ToInt32(dbgGrupoPermissao["ID", row].Value);
                    GrupoAcesso.ExcluirGrupoUsuario(GrupoAcesso);
                    MessageBox.Show("Grupo excluído com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (btn_Exluir.Text == "Cancelar")
            {
                btn_Adicionar.Text = "Adicionar";
                btn_Exluir.Text = "Excluir";
                dbgGrupoPermissao.Enabled = true;
                txtNome.Text = "";
            }

            CarregarGridGrupoUsuarios();
        }

        private void dbgGrupoUsuarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult confirma = MessageBox.Show("Confima a seleção do grupo para alteração?", "Alterar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirma.Equals(DialogResult.Yes))
            {
                int row = dbgGrupoPermissao.CurrentRow.Index;
                txtNome.Text = dbgGrupoPermissao["NOME", row].Value.ToString();

                dbgGrupoPermissao.Enabled = false;
                btn_Adicionar.Text = "Alterar";
                btn_Exluir.Text = "Cancelar";
            }
        }

        private void btnPermissoes_Click(object sender, EventArgs e)
        {
            if (!podeAcessarTelaPermissoes)
            {
                MessageBox.Show("Usuário não tem permissão para acessar essa tela.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int row = dbgGrupoPermissao.CurrentRow.Index;            
            frmGrupoPermissao = new frmGrupoPermissao();
            frmGrupoPermissao.idGrupo = Convert.ToInt32(dbgGrupoPermissao["ID", row].Value);
            frmGrupoPermissao.MdiParent = this.MdiParent;
            frmGrupoPermissao.Show();
        }
    }
}
