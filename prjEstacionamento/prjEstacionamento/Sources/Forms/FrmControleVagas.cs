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
                for(var cont = 0;cont<dados.Rows.Count;cont++){
                    switch (dados.Rows[cont]["TipoVeiculoId"].ToString())
                    {

                        case "1":
                            lblQtdAvMt.Text = (Convert.ToInt16(dados.Rows[cont]["QtdeVagasTotal"]) - Convert.ToInt16(dados.Rows[cont]["QtdeMensalista"])).ToString();
                            lblQtdMsMt.Text = dados.Rows[cont]["QtdeMensalista"].ToString();
                            lblQtdAvDspMt.Text = dados.Rows[cont]["QtdeMensalista"].ToString();
                            lblQtdMsDspMt.Text = (Convert.ToInt16(dados.Rows[cont]["QtdeMensalista"]) - Convert.ToInt16(dados.Rows[cont]["QtdeMensalistaCorrente"])).ToString();
                            break;
                        case "3":
                            lblQtdAvPq.Text = (Convert.ToInt16(dados.Rows[cont]["QtdeVagasTotal"]) - Convert.ToInt16(dados.Rows[cont]["QtdeMensalista"])).ToString();
                            lblQtdMsPq.Text = dados.Rows[cont]["QtdeMensalista"].ToString();
                            lblQtdAvDspPq.Text = dados.Rows[cont]["QtdeMensalistaCorrente"].ToString();
                            lblQtdMsDspPq.Text = (Convert.ToInt16(dados.Rows[cont]["QtdeMensalista"]) - Convert.ToInt16(dados.Rows[cont]["QtdeMensalistaCorrente"])).ToString();
                            break;
                        case "2":
                            lblQtdAvGd.Text = (Convert.ToInt16(dados.Rows[cont]["QtdeVagasTotal"]) - Convert.ToInt16(dados.Rows[cont]["QtdeMensalista"])).ToString();
                            lblQtdMsGd.Text = dados.Rows[cont]["QtdeMensalista"].ToString();
                            lblQtdAvDsGd.Text = dados.Rows[cont]["QtdeMensalistaCorrente"].ToString();
                            lblQtdMsDspGd.Text = (Convert.ToInt16(dados.Rows[cont]["QtdeMensalista"]) - Convert.ToInt16(dados.Rows[cont]["QtdeMensalistaCorrente"])).ToString();
                            break;
                    }
                        //lblQtdMensal.Text = r.QtdeMensal.toString();
                    //lblQtdMensalDisp.Text = (r.QtdeMensalista - dados.QtdeMensalistaCorrente).toString();
                    //lblQtdAvulsoDisp.Text = (r.QtdeVagasTotal - dados.QtdeMensalistaCorrente).toString();
                }
            }
        }

        
    }
}
