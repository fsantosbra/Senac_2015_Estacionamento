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
    public partial class frmCadastroVagas : Form
    {
        public frmCadastroVagas()
        {
            InitializeComponent();

            var tipoVeiculo = new TipoVeiculo();
            var ListaTipo = new Vagas();
            cbxTipoVeiculo.DataSource = tipoVeiculo.ListarTipoVeiculos();
            cbxTipoVeiculo.ValueMember = "ID";
            cbxTipoVeiculo.DisplayMember = "TIPO";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            var Vaga = new Vagas();
            Vaga.TipoVeiculo = Convert.ToInt32(cbxTipoVeiculo.SelectedValue);
            Vaga.QtdTotalVagas = Convert.ToInt32(txtTotalVagas.Text);
            Vaga.QtdTotalMensalistas = Convert.ToInt32(txtQtdMensalistas.Text);

            Vaga.InserirVagas(Vaga);
            MessageBox.Show("Vagas adicionadas com sucesso!");
        }

        private void frmCadastroVagas_Load(object sender, EventArgs e)
        {

        }
    }
}
