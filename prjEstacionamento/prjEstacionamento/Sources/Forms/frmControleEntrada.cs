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
    public partial class frmControleEntrada : Form
    {
        public frmControleEntrada()
        {
            InitializeComponent();

            txtDataHoraEntrada.Text = DateTime.Now.ToString();

            var listaMensalista = new Mensalista();
            cbMensalista.DataSource = listaMensalista.ListarParametros();
            cbMensalista.ValueMember = "ID";
            cbMensalista.DisplayMember = "NOME";

            var listaModelo = new Modelo();
            cbModelo.DataSource = listaModelo.listarModelos();
            cbModelo.ValueMember = "ID";
            cbModelo.DisplayMember = "MODELO";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var entradaVeiculo = new CadastroEntradaVeiculo();

            entradaVeiculo.modeloId = Convert.ToInt32(cbModelo.SelectedValue);
            entradaVeiculo.placa = txtPlaca.Text;
            entradaVeiculo.dataEntrada = Convert.ToDateTime(txtDataHoraEntrada.Text);
            entradaVeiculo.corVeiculo = cbCor.SelectedItem.ToString();
            entradaVeiculo.mensalistaId = Convert.ToInt32(cbMensalista.SelectedValue);

            if(txtDataHoraEntrada.Text.Trim() == ""){
                MessageBox.Show("Obrigatório Preenchimento da Data de Entrada do Veículo");
                txtDataHoraEntrada.Focus();
                return;
            }

            if(txtPlaca.Text.Trim() == ""){
                MessageBox.Show("Obrigatório Preenchimento da Placa do Veículo");
                txtPlaca.Focus();
                return;
            }else if(txtPlaca.Text.Trim().Count() < 8){
                MessageBox.Show("Placa do Veículo Inválida! Favor Informar a Placa no Formato Correto.");
                txtPlaca.Focus();
                return;
            }

            if (cbCor.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Obrigatório Preenchimento da Cor do Veículo");
                cbCor.Focus();
                return;
            }

            if(Convert.ToDateTime(txtDataHoraEntrada.Text) > DateTime.Now){
                MessageBox.Show("Impossível Definir a Data de Entrada do Veículo MAIOR que a Data Atual");
                txtDataHoraEntrada.Text = DateTime.Now.ToString();
                return;
            }

            entradaVeiculo.inserirEntradaVeiculo(entradaVeiculo);
            MessageBox.Show("Entrada Registrada com Sucesso!");
            this.Dispose();


        }
    }
}
