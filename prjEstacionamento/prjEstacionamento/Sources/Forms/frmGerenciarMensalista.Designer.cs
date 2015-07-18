namespace prjEstacionamento.Sources.Forms
{
    partial class frmGerenciarMensalista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbsAcoes = new System.Windows.Forms.TabControl();
            this.tbsLancarPgto = new System.Windows.Forms.TabPage();
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblDataPgto = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.chkValorPersonalizado = new System.Windows.Forms.CheckBox();
            this.dtpDataPgto = new System.Windows.Forms.DateTimePicker();
            this.tabConsultarPgtos = new System.Windows.Forms.TabPage();
            this.grdLancamentos = new System.Windows.Forms.DataGridView();
            this.cbxMensalista = new System.Windows.Forms.ComboBox();
            this.cbxPlaca = new System.Windows.Forms.ComboBox();
            this.lblMensalista = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.tbsAcoes.SuspendLayout();
            this.tbsLancarPgto.SuspendLayout();
            this.tabConsultarPgtos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLancamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // tbsAcoes
            // 
            this.tbsAcoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbsAcoes.Controls.Add(this.tbsLancarPgto);
            this.tbsAcoes.Controls.Add(this.tabConsultarPgtos);
            this.tbsAcoes.Location = new System.Drawing.Point(0, 64);
            this.tbsAcoes.Multiline = true;
            this.tbsAcoes.Name = "tbsAcoes";
            this.tbsAcoes.SelectedIndex = 0;
            this.tbsAcoes.Size = new System.Drawing.Size(678, 268);
            this.tbsAcoes.TabIndex = 0;
            // 
            // tbsLancarPgto
            // 
            this.tbsLancarPgto.Controls.Add(this.txtValor);
            this.tbsLancarPgto.Controls.Add(this.btnOk);
            this.tbsLancarPgto.Controls.Add(this.btnCancelar);
            this.tbsLancarPgto.Controls.Add(this.lblDataPgto);
            this.tbsLancarPgto.Controls.Add(this.lblValor);
            this.tbsLancarPgto.Controls.Add(this.chkValorPersonalizado);
            this.tbsLancarPgto.Controls.Add(this.dtpDataPgto);
            this.tbsLancarPgto.Location = new System.Drawing.Point(4, 22);
            this.tbsLancarPgto.Name = "tbsLancarPgto";
            this.tbsLancarPgto.Padding = new System.Windows.Forms.Padding(3);
            this.tbsLancarPgto.Size = new System.Drawing.Size(670, 242);
            this.tbsLancarPgto.TabIndex = 0;
            this.tbsLancarPgto.Text = "Lançar Pagamento";
            this.tbsLancarPgto.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            this.txtValor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValor.Location = new System.Drawing.Point(71, 43);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(464, 20);
            this.txtValor.TabIndex = 15;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(508, 216);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "Gravar";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(589, 216);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblDataPgto
            // 
            this.lblDataPgto.AutoSize = true;
            this.lblDataPgto.Location = new System.Drawing.Point(36, 23);
            this.lblDataPgto.Name = "lblDataPgto";
            this.lblDataPgto.Size = new System.Drawing.Size(30, 13);
            this.lblDataPgto.TabIndex = 11;
            this.lblDataPgto.Text = "Data";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(34, 46);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 12;
            this.lblValor.Text = "Valor";
            // 
            // chkValorPersonalizado
            // 
            this.chkValorPersonalizado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkValorPersonalizado.AutoSize = true;
            this.chkValorPersonalizado.Location = new System.Drawing.Point(541, 42);
            this.chkValorPersonalizado.Name = "chkValorPersonalizado";
            this.chkValorPersonalizado.Size = new System.Drawing.Size(119, 17);
            this.chkValorPersonalizado.TabIndex = 10;
            this.chkValorPersonalizado.Text = "Valor Personalizado";
            this.chkValorPersonalizado.UseVisualStyleBackColor = true;
            // 
            // dtpDataPgto
            // 
            this.dtpDataPgto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataPgto.Location = new System.Drawing.Point(72, 17);
            this.dtpDataPgto.Name = "dtpDataPgto";
            this.dtpDataPgto.Size = new System.Drawing.Size(586, 20);
            this.dtpDataPgto.TabIndex = 8;
            // 
            // tabConsultarPgtos
            // 
            this.tabConsultarPgtos.Controls.Add(this.grdLancamentos);
            this.tabConsultarPgtos.Location = new System.Drawing.Point(4, 22);
            this.tabConsultarPgtos.Name = "tabConsultarPgtos";
            this.tabConsultarPgtos.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultarPgtos.Size = new System.Drawing.Size(670, 242);
            this.tabConsultarPgtos.TabIndex = 1;
            this.tabConsultarPgtos.Text = "Consultar Pagamentos";
            this.tabConsultarPgtos.UseVisualStyleBackColor = true;
            // 
            // grdLancamentos
            // 
            this.grdLancamentos.AllowUserToAddRows = false;
            this.grdLancamentos.AllowUserToDeleteRows = false;
            this.grdLancamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdLancamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLancamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdLancamentos.Location = new System.Drawing.Point(3, 3);
            this.grdLancamentos.Name = "grdLancamentos";
            this.grdLancamentos.ReadOnly = true;
            this.grdLancamentos.Size = new System.Drawing.Size(664, 236);
            this.grdLancamentos.TabIndex = 0;
            // 
            // cbxMensalista
            // 
            this.cbxMensalista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMensalista.FormattingEnabled = true;
            this.cbxMensalista.Location = new System.Drawing.Point(76, 6);
            this.cbxMensalista.Name = "cbxMensalista";
            this.cbxMensalista.Size = new System.Drawing.Size(595, 21);
            this.cbxMensalista.TabIndex = 1;
            this.cbxMensalista.SelectedValueChanged += new System.EventHandler(this.cbxMensalista_SelectedValueChanged);
            // 
            // cbxPlaca
            // 
            this.cbxPlaca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxPlaca.FormattingEnabled = true;
            this.cbxPlaca.Location = new System.Drawing.Point(76, 33);
            this.cbxPlaca.Name = "cbxPlaca";
            this.cbxPlaca.Size = new System.Drawing.Size(595, 21);
            this.cbxPlaca.TabIndex = 2;
            this.cbxPlaca.SelectedValueChanged += new System.EventHandler(this.cbxPlaca_SelectedValueChanged);
            // 
            // lblMensalista
            // 
            this.lblMensalista.AutoSize = true;
            this.lblMensalista.Location = new System.Drawing.Point(12, 9);
            this.lblMensalista.Name = "lblMensalista";
            this.lblMensalista.Size = new System.Drawing.Size(57, 13);
            this.lblMensalista.TabIndex = 3;
            this.lblMensalista.Text = "Mensalista";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(35, 36);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(34, 13);
            this.lblPlaca.TabIndex = 4;
            this.lblPlaca.Text = "Placa";
            // 
            // frmGerenciarMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 332);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblMensalista);
            this.Controls.Add(this.cbxPlaca);
            this.Controls.Add(this.cbxMensalista);
            this.Controls.Add(this.tbsAcoes);
            this.Name = "frmGerenciarMensalista";
            this.Text = "Gerenciamento de Mensalistas";
            this.tbsAcoes.ResumeLayout(false);
            this.tbsLancarPgto.ResumeLayout(false);
            this.tbsLancarPgto.PerformLayout();
            this.tabConsultarPgtos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdLancamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbsAcoes;
        private System.Windows.Forms.TabPage tbsLancarPgto;
        private System.Windows.Forms.TabPage tabConsultarPgtos;
        private System.Windows.Forms.ComboBox cbxMensalista;
        private System.Windows.Forms.ComboBox cbxPlaca;
        private System.Windows.Forms.Label lblMensalista;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblDataPgto;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.CheckBox chkValorPersonalizado;
        private System.Windows.Forms.DateTimePicker dtpDataPgto;
        private System.Windows.Forms.MaskedTextBox txtValor;
        private System.Windows.Forms.DataGridView grdLancamentos;
    }
}