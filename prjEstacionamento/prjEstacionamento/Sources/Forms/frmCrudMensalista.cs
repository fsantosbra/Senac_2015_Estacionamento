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
    public partial class frmCrudMensalista : Form
    {
        public frmCrudMensalista()
        {
            InitializeComponent();

            var tipoVeiculo = new TipoVeiculo();
            cmbTipoVeiculo.DataSource = tipoVeiculo.ListarTipoVeiculos();
            cmbTipoVeiculo.ValueMember = "Id";
            cmbTipoVeiculo.DisplayMember = "Tipo";

            ListarMensalistas();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var enderecoId = AdicionaEndereco();
            var mensalistaid = AdicionaMensalista(enderecoId);
            AdicionaPrecoMensalista(mensalistaid, Convert.ToInt32(cmbTipoVeiculo.SelectedValue));

            MessageBox.Show("Mensalista cadastrado com sucesso!");
        }

        private void AdicionaPrecoMensalista(int mensalistaid, int tipoVeiculoId)
        {
            var precoMensalista = new PrecoMensalista();

            precoMensalista.MensalistaId = mensalistaid;
            precoMensalista.TipoVeiculoId = tipoVeiculoId;
            precoMensalista.Placa = txtPlaca.Text;
            precoMensalista.Valor = Convert.ToDecimal(txtValor.Text);
            precoMensalista.DataInicioVigencia = dtpInicioVigencia.Value;
            precoMensalista.DataFimVigencia = dtpFinalVigencia.Value;

            precoMensalista.InserirPrecoMensalista(precoMensalista);
        }

        private int AdicionaMensalista(int enderecoId)
        {
            var mensalista = new Mensalista();
            mensalista.Nome = txtNome.Text;
            mensalista.EnderecoId = enderecoId;
            mensalista.Ativo = true;

            return mensalista.InserirMensalista(mensalista);
        }

        private int AdicionaEndereco()
        {
            var endereco = new Endereco();
            endereco.Logradouro = txtLogradouro.Text;
            endereco.Numero = Convert.ToInt32(txtNumero.Text);
            endereco.Bairro = txtBairro.Text;
            endereco.Cidade = txtCidade.Text;
            endereco.Estado = txtEstado.Text;
            endereco.CEP = txtCEP.Text;
            endereco.Telefone = txtTelefone.Text;

            return endereco.InserirEndereco(endereco);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var mensalista = new Mensalista();
            dgvMensalistas.DataSource = mensalista.FiltrarPesquisa(txtPesquisaNome.Text);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ListarMensalistas();
        }

        private void ListarMensalistas()
        {
            var mensalista = new Mensalista();
            dgvMensalistas.DataSource = mensalista.ListarMensalistas();
        }

        private void dgvMensalistas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var mensalistaId = dgvMensalistas.Rows[e.RowIndex].Cells[0].Value;

            var mensalista = new Mensalista();
            var dadosMensalista = mensalista.FiltrarMensalista(mensalistaId);

            PreencheCamposMensalista(dadosMensalista);
        }

        private void PreencheCamposMensalista(DataTable dadosMensalista)
        {
            var mensalista = dadosMensalista.Rows[0];

            txtNome.Text = mensalista.Field<string>(1);

            tpCadastro.Show();
        }
    }
}
