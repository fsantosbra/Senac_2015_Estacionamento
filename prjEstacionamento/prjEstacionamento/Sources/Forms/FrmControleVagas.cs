using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjEstacionamento.Sources.DAO;
using prjEstacionamento.Sources.Class;

namespace prjEstacionamento.Sources.Forms
{
    public partial class FrmControleVagas : Form
    {
        public FrmControleVagas()
        {
            InitializeComponent();
        }

        private void ControleVagas_Load(object sender, EventArgs e)
        {
            Vagas Vagas = new Vagas();
            var tabelaVagas = Vagas.ListarVagas();
            lblQtdAvulso.Text = (tabelaVagas.QtdeVagasTotal - tabelaVagas.QtdeMensalista).toString();
            lblQtdMensal.Text = tabelaVagas.QtdeMensal.toString();
            lblQtdMensalDisp.Text = (tabelaVagas.QtdeMensalista - tabelaVagas.QtdeMensalistaCorrente);
            lblQtdAvulsoDisp.Text = (tabelaVagas.QtdeVagasTotal - tabelaVagas.QtdeMensalistaCorrente);
        }
    }
}
