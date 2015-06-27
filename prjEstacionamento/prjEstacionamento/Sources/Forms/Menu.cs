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
        public Menu()
        {
            InitializeComponent();
        }

        private void cadastroDeVagasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroDeDadosMestreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabelaDePreçosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroDeVeículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            frmTipoVeiculo frmTipoVeiculo = new frmTipoVeiculo();
            frmTipoVeiculo.MdiParent = this;
            frmTipoVeiculo.Show();
        }

        private void cadastroDeSaídaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void controleDeVagasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void controleDeEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            frmControleEntrada frmControleEntrada = new frmControleEntrada();
            frmControleEntrada.MdiParent = this;
            frmControleEntrada.Show();
        }

        private void controleDeSaídaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gerenciamentoDeMensalistasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vagasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabelaDePreçosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void veículosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void parceirosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar a aplicação ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            frmSeuForm frmSeuForm = new frmSeuForm();
            frmSeuForm.MdiParent = this;
            frmSeuForm.Show();
          
            /*Para que o seu Form seja aberto no clique do item do menu, 
              adicione o código acima no evento Click do MenuItem.
             * É necessário alterar todas instâncias da classe frmSeuForm para o nome da classe do seu
             * form. Para acessar o código do evento Click para o seu Form, 
             * dê um duplo clique no item desejado. */
        }

        private void cadastroDeMensalistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            frmCrudMensalista frmMensalista= new frmCrudMensalista();
            frmMensalista.MdiParent = this;
            frmMensalista.Show();
        }
    }
}
