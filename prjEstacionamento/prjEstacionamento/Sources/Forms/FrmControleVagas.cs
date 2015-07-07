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
            Vagas vagas = new Vagas();
            
            var dados = vagas.ListarVagas();
            if (dados != null)
            {
                //for(var r=0; r< dados.cou){
                //    lblQtdAvMt.Text = (dados[0]. - dados.QtdeMensalista).toString();
                //    lblQtdMensal.Text = r.QtdeMensal.toString();
                //    lblQtdMensalDisp.Text = (r.QtdeMensalista - dados.QtdeMensalistaCorrente).toString();
                //    lblQtdAvulsoDisp.Text = (r.QtdeVagasTotal - dados.QtdeMensalistaCorrente).toString();
                //}
            }
        }

        
    }
}
