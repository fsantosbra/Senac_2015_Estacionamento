using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjEstacionamento.Sources.Class;

namespace prjEstacionamento.Sources.Forms
{
    public partial class frmGerenciarMensalista : Form
    {
        GerenciamentoMensalista listaPagamentos;

        public frmGerenciarMensalista()
        {
            InitializeComponent();
            var listaMensalistas = new Mensalista();
            listaPagamentos = new GerenciamentoMensalista();

            cbxMensalista.DataSource = listaMensalistas.ListarParametros();
            cbxMensalista.ValueMember = "Id";
            cbxMensalista.DisplayMember = "Nome";

            carregaDadosMensalista();
        }

        private void cbxMensalista_SelectedValueChanged(object sender, EventArgs e)
        {
            cbxPlaca.Text = "";
            carregaDadosMensalista();
        }

        private int validaSelecaoMensalista()
        {
            int idMensalista = -1;
            Int32.TryParse(cbxMensalista.SelectedValue.ToString(), out idMensalista);           
            return idMensalista;
        }

        private void carregaDadosMensalista()
        {
            int idMensalista = validaSelecaoMensalista();
            cbxPlaca.DataSource = listaPagamentos.ListarPagamentosMensalista(idMensalista, "");
            cbxPlaca.ValueMember = "Placa";
            cbxMensalista.DisplayMember = "Placa";

            grdLancamentos.AutoGenerateColumns = true;
            grdLancamentos.DataSource = listaPagamentos.ListarPagamentosMensalista(idMensalista, cbxMensalista.SelectedValue.ToString());
            grdLancamentos.Columns.Remove("MensalistaId");
            grdLancamentos.Columns.Remove("TipoVeiculoId");
            grdLancamentos.Columns.Remove("Placa");
            grdLancamentos.ReadOnly = true;
        }
    }
}
