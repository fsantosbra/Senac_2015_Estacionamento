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
        }
    }
}
