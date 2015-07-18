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

            cbxMensalista.DataSource = listaMensalistas.ListarMensalistas();
            cbxMensalista.ValueMember = "Id";
            cbxMensalista.DisplayMember = "Nome";
        }

        private void cbxMensalista_SelectedValueChanged(object sender, EventArgs e)
        {
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
            cbxPlaca.DisplayMember = "Placa";
        }

        private void carregaDadosPlaca(int idMensalista, string pPlaca)
        {
            grdLancamentos.DataSource = listaPagamentos.ListarPagamentosMensalista(idMensalista, pPlaca);

            DataColumnCollection columns = table.Columns;

    if (columns.Contains(columnName))
    {
       ....
    }}

            grdLancamentos.Columns["MensalistaId"].Visible = false;
            grdLancamentos.Columns["TipoVeiculoId"].Visible = false;
            grdLancamentos.Columns["Placa"].Visible = false;
            grdLancamentos.Columns["Valor"].DefaultCellStyle.Format = "R$ ########,##";
            grdLancamentos.ReadOnly = true;
        }

        private void cbxPlaca_SelectedValueChanged(object sender, EventArgs e)
        {
            int idMensalista = validaSelecaoMensalista();
            string pPlaca = "";
            if (cbxPlaca.Items.Count > 0)
            {
                pPlaca = cbxPlaca.SelectedValue.ToString();
            }
            else
            {
                cbxPlaca.Text = "";
            }
            carregaDadosPlaca(idMensalista, pPlaca);
        }
    }
}
