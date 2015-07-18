using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjEstacionamento.Sources.Forms;

namespace prjEstacionamento
{
    public partial class Menu : Form
    {
        public frmLogin login;

        public int idUsuario;

        public DataTable permissoes;

        public Menu()
        {
            InitializeComponent();
        }

        private void cadastroDeVagasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!temPermissao("Cadastro de Vagas"))
                return;
            this.IsMdiContainer = true;
            frmCadastroVagas frmCadastroVagas = new frmCadastroVagas();
            frmCadastroVagas.MdiParent = this;
            frmCadastroVagas.Show();
// daikiti
//            this.IsMdiContainer = true;
//            Frm_CadastroVagas Frm_CadastroVagas = new Frm_CadastroVagas();
//            Frm_CadastroVagas.MdiParent = this;
//            Frm_CadastroVagas.Show();
// daikiti
        }

        private void cadastroDeDadosMestreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!temPermissao("Cadastro de Dados Mestre"))
                return;
        }

        private void tabelaDePreçosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroDeVeículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!temPermissao("Cadastro de Veículos"))
                return;
            this.IsMdiContainer = true;
            Frm_CadastroVeiculo frmCadastroVeiculo = new Frm_CadastroVeiculo();
            frmCadastroVeiculo.MdiParent = this;
            frmCadastroVeiculo.Show();
        }

        private void cadastroDeSaídaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!temPermissao("Consulta de Logs"))
                return;
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void controleDeVagasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!temPermissao("Controle de Vagas"))
                return;
            this.IsMdiContainer = true;
            FrmControleVagas FrmControleVagas = new FrmControleVagas();
            FrmControleVagas.MdiParent = this;
            FrmControleVagas.Show();
        }

        private void controleDeEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!temPermissao("Controle de Entrada"))
                return;
            this.IsMdiContainer = true;
            frmControleEntrada frmControleEntrada = new frmControleEntrada();
            frmControleEntrada.MdiParent = this;
            frmControleEntrada.Show();
        }

        private void controleDeSaídaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!temPermissao("Controle de Saída"))
                return;
        }

        private void gerenciamentoDeMensalistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!temPermissao("Gerenciamento de Mensalistas"))
                return;
            this.IsMdiContainer = true;
            frmGerenciarMensalista frmGerenciarMensalista = new frmGerenciarMensalista();
            frmGerenciarMensalista.MdiParent = this;
            frmGerenciarMensalista.Show();
        }

        private void vagasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!temPermissao("Consulta de Vagas"))
                return;
        }

        private void tabelaDePreçosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!temPermissao("Consulta de Tabela de Preços"))
                return;
        }

        private void veículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!temPermissao("Consulta de Veículos"))
                return;
        }

        private void parceirosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!temPermissao("Consulta de Parceiros"))
                return;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*this.IsMdiContainer = true;
            frmSeuForm frmSeuForm = new frmSeuForm();
            frmSeuForm.MdiParent = this;
            frmSeuForm.Show();*/

            login.limpaCampos();
            login.Visible = true;            
            this.Close();
          
            /*Para que o seu Form seja aberto no clique do item do menu, 
              adicione o código acima no evento Click do MenuItem.
             * É necessário alterar todas instâncias da classe frmSeuForm para o nome da classe do seu
             * form. Para acessar o código do evento Click para o seu Form, 
             * dê um duplo clique no item desejado. */            
        }

        private void cadastroDeMensalistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!temPermissao("Cadastro de Mensalistas"))
                return;
            this.IsMdiContainer = true;
            frmCrudMensalista frmMensalista= new frmCrudMensalista();
            frmMensalista.MdiParent = this;
            frmMensalista.Show();
        }

        private void avulsoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!temPermissao("Cadastro da Tabela de Preços - Avulso"))
                return;
            this.IsMdiContainer = true;
            frmPrecoAvulso frmPrecoAvulso = new frmPrecoAvulso();
            frmPrecoAvulso.MdiParent = this;
            frmPrecoAvulso.Show();
        }

        private void mensalistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!temPermissao("Cadastro da Tabela de Preços - Mensalista"))
                return;
            this.IsMdiContainer = true;
            frmPrecoMensalista frmPrecoMensalista = new frmPrecoMensalista();
            frmPrecoMensalista.MdiParent = this;
            frmPrecoMensalista.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void cadastroDeParceiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!temPermissao("Cadastro de Parceiros"))
                return;
            this.IsMdiContainer = true;
            Frm_CadastroParceiro frmCadastroParceiro = new Frm_CadastroParceiro();
            frmCadastroParceiro.MdiParent = this;
            frmCadastroParceiro.Show();
        }

        private void cadastroDeGrupoDeAcessoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!temPermissao("Cadastro de Grupo de Acesso"))
                return;
            this.IsMdiContainer = true;
            frmGrupoAcesso frmGrupoAcesso = new frmGrupoAcesso();
            frmGrupoAcesso.MdiParent = this;
            frmGrupoAcesso.formmenu = this;
            frmGrupoAcesso.podeAcessarTelaPermissoes = temPermissao("Cadastro de Permissões");
            frmGrupoAcesso.Show();
        }

        private void cadastroDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!temPermissao("Cadastro de Usuários"))
                return;
            this.IsMdiContainer = true;
            frmUsuario frmUsuario = new frmUsuario();
            frmUsuario.MdiParent = this;
            frmUsuario.Show();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            if (login.Visible)
            {
                e.Cancel = false;
                return;
            }
               
            if (MessageBox.Show("Deseja encerrar a aplicação?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;               
                login.Close();
                Application.Exit();
            }
        }

        private bool temPermissao(string nometela)
        {
            bool resposta = true;

            if (idUsuario == -1)
                return true;

            if (permissoes == null)
                resposta = false;

            DataRow[] row = permissoes.Select(String.Format("NOMETELA = '{0}'", nometela));
            if (row.Length == 0)
                resposta = false;

            if ((!resposta) && (!nometela.Equals("Cadastro de Permissões")))
            {
                MessageBox.Show("Usuário não tem permissão para acessar essa tela.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return resposta;
        }

        private void sintéticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!temPermissao("Relatório de Entrada e Saída - Sintético"))
                return;
        }

        private void analíticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!temPermissao("Relatório de Entrada e Saída - Analítico"))
                return;
        }

        private void mensalistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!temPermissao("Relatório de Mensalistas"))
                return;
        }

        private void fluxoDeVeículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!temPermissao("Relatório de Fluxo de Veículos"))
                return;
        }

        private void logDeOperaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!temPermissao("Relatórios de Log de Operações"))
                return;
        }
    }
}
