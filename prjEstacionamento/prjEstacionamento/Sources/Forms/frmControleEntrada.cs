﻿using System;
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
    public partial class frmControleEntrada : Form
    {
        public frmControleEntrada()
        {
            InitializeComponent();
            txtDataEntrada.Text = DateTime.Now.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmControleEntrada_Load(object sender, EventArgs e)
        {

        }
    }
}
