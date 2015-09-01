using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaAdmin.Cadastros;

namespace CinemaAdmin
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void generoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGenero genero = new frmGenero();
            genero.MdiParent = this;
            genero.Show();
        }
    }
}
