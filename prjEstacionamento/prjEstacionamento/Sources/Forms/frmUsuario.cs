using prjEstacionamento.Sources.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjEstacionamento.Sources.Forms
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();

            CarregarListaGrupo();
            CarregarGridUsuarios();
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            var Usuario = new Usuario();
            Usuario.funcionario = txtFuncionario.Text;
            Usuario.login = txtLogin.Text;
            MD5 md5Hash = MD5.Create();
            string hash = GetMd5Hash(md5Hash, txtSenha.Text);
            Usuario.senha = hash;
            Usuario.idgrupo = Convert.ToInt32(cmbGrupo.SelectedValue);

            if (txtFuncionario.Text.Trim() == "")
            {
                MessageBox.Show("Nome do Funcionário obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtLogin.Text.Trim() == "")
            {
                MessageBox.Show("Login obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtSenha.Text.Trim() == "")
            {
                MessageBox.Show("Senha obrigatória!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbGrupo.SelectedValue.ToString() == String.Empty)
            {
                MessageBox.Show("Grupo obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (btn_Adicionar.Text == "Adicionar")
            {
                Usuario.InserirUsuario(Usuario);
                MessageBox.Show("Usuário adicionado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (btn_Adicionar.Text == "Alterar")
            {
                int row = dbgUsuarios.CurrentRow.Index;
                Usuario.Id = Convert.ToInt32(dbgUsuarios["ID", row].Value);
                Usuario.AlterarUsuario(Usuario);
                btn_Adicionar.Text = "Adicionar";
                btn_Exluir.Text = "Excluir";
                dbgUsuarios.Enabled = true;
                MessageBox.Show("Veículo alterado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtFuncionario.Text = "";
            txtLogin.Text = "";
            txtSenha.Text = "";
            cmbGrupo.SelectedIndex = 0;
            CarregarGridUsuarios();
        }

        public void CarregarGridUsuarios()
        {
            var GridUsuarios = new Usuario();
            dbgUsuarios.DataSource = GridUsuarios.ListarUsuarios();
            dbgUsuarios.Columns["ID"].Visible = false;
            dbgUsuarios.Columns["Funcionario"].Width = 200;
            dbgUsuarios.Columns["Login"].Width = 200;
            dbgUsuarios.Columns["Senha"].Visible = false;
            dbgUsuarios.Columns["IdGrupo"].Visible = false;
            dbgUsuarios.Columns["Grupo"].Width = 200;
            dbgUsuarios.ReadOnly = true;
            dbgUsuarios.Enabled = !(dbgUsuarios.RowCount == 0);
        }

        private void btn_Exluir_Click(object sender, EventArgs e)
        {
            if (btn_Exluir.Text == "Excluir")
            {
                DialogResult confirma = MessageBox.Show("Confima a exclusão do usuário selecionado?", "Apagar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirma.Equals(DialogResult.Yes))
                {
                    var Usuario = new Usuario();
                    int row = dbgUsuarios.CurrentRow.Index;
                    Usuario.Id = Convert.ToInt32(dbgUsuarios["ID", row].Value);
                    Usuario.ExcluirUsuario(Usuario);
                    MessageBox.Show("Usuário excluído com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (btn_Exluir.Text == "Cancelar")
            {
                btn_Adicionar.Text = "Adicionar";
                btn_Exluir.Text = "Excluir";
                dbgUsuarios.Enabled = true;
                txtFuncionario.Text = "";
                txtLogin.Text = "";
                txtSenha.Text = "";
                cmbGrupo.SelectedIndex = 0;
            }

            CarregarGridUsuarios();
        }

        private void dbgUsuarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult confirma = MessageBox.Show("Confima a seleção do usuário para alteração?", "Alterar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirma.Equals(DialogResult.Yes))
            {
                int row = dbgUsuarios.CurrentRow.Index;
                txtFuncionario.Text = dbgUsuarios["FUNCIONARIO", row].Value.ToString();
                txtLogin.Text = dbgUsuarios["LOGIN", row].Value.ToString();;
                txtSenha.Text = dbgUsuarios["SENHA", row].Value.ToString();;
                cmbGrupo.SelectedValue = dbgUsuarios["IDGRUPO", row].Value.ToString();

                dbgUsuarios.Enabled = false;
                btn_Adicionar.Text = "Alterar";
                btn_Exluir.Text = "Cancelar";
            }
        }

        public void CarregarListaGrupo()
        {
            var ListaGrupo = new GrupoAcesso();
            cmbGrupo.DataSource = ListaGrupo.ListarGrupoUsuarios();
            cmbGrupo.ValueMember = "ID";
            cmbGrupo.DisplayMember = "NOME";
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }
}
