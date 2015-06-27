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

namespace prjEstacionamento
{
    public partial class frmParametros : Form
    {
        public frmParametros()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var parametro = new Parametros();
            parametro.Nome = txtNome.Text;
            parametro.Valor = txtValor.Text;

            parametro.InserirParametro(parametro);            
        }
    }
}
