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
    public partial class frmControleSaida : Form
    {
        public frmControleSaida()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btOk_Click(object sender, EventArgs e)
        {

        }

        private void frmControleSaida_Load(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM usovagas WHERE datasaida IS NULL"
        }
    }
}
