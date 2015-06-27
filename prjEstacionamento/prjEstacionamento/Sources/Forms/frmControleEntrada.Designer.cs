namespace prjEstacionamento.Sources.Forms
{
    partial class frmControleEntrada
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
            this.tpPrincipal = new System.Windows.Forms.TabControl();
            this.tpPesquisa = new System.Windows.Forms.TabPage();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.gbChavePesquisa = new System.Windows.Forms.GroupBox();
            this.dgVagasEntrada = new System.Windows.Forms.DataGridView();
            this.tpCadastro = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDataEntrada = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.cbMensalista = new System.Windows.Forms.ComboBox();
            this.tpPrincipal.SuspendLayout();
            this.tpPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVagasEntrada)).BeginInit();
            this.tpCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpPrincipal
            // 
            this.tpPrincipal.Controls.Add(this.tpPesquisa);
            this.tpPrincipal.Controls.Add(this.tpCadastro);
            this.tpPrincipal.Location = new System.Drawing.Point(12, 12);
            this.tpPrincipal.Name = "tpPrincipal";
            this.tpPrincipal.SelectedIndex = 0;
            this.tpPrincipal.Size = new System.Drawing.Size(607, 370);
            this.tpPrincipal.TabIndex = 0;
            // 
            // tpPesquisa
            // 
            this.tpPesquisa.Controls.Add(this.btnPesquisar);
            this.tpPesquisa.Controls.Add(this.gbChavePesquisa);
            this.tpPesquisa.Controls.Add(this.dgVagasEntrada);
            this.tpPesquisa.Location = new System.Drawing.Point(4, 22);
            this.tpPesquisa.Name = "tpPesquisa";
            this.tpPesquisa.Padding = new System.Windows.Forms.Padding(3);
            this.tpPesquisa.Size = new System.Drawing.Size(599, 344);
            this.tpPesquisa.TabIndex = 0;
            this.tpPesquisa.Text = "Pesquisa";
            this.tpPesquisa.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(510, 15);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(83, 23);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // gbChavePesquisa
            // 
            this.gbChavePesquisa.Location = new System.Drawing.Point(6, 6);
            this.gbChavePesquisa.Name = "gbChavePesquisa";
            this.gbChavePesquisa.Size = new System.Drawing.Size(498, 157);
            this.gbChavePesquisa.TabIndex = 1;
            this.gbChavePesquisa.TabStop = false;
            this.gbChavePesquisa.Text = "Chave de Pesquisa";
            // 
            // dgVagasEntrada
            // 
            this.dgVagasEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVagasEntrada.Location = new System.Drawing.Point(6, 169);
            this.dgVagasEntrada.Name = "dgVagasEntrada";
            this.dgVagasEntrada.Size = new System.Drawing.Size(587, 169);
            this.dgVagasEntrada.TabIndex = 0;
            // 
            // tpCadastro
            // 
            this.tpCadastro.Controls.Add(this.cbMensalista);
            this.tpCadastro.Controls.Add(this.label5);
            this.tpCadastro.Controls.Add(this.btnCancelar);
            this.tpCadastro.Controls.Add(this.btnOK);
            this.tpCadastro.Controls.Add(this.label4);
            this.tpCadastro.Controls.Add(this.txtDataEntrada);
            this.tpCadastro.Controls.Add(this.label3);
            this.tpCadastro.Controls.Add(this.txtCor);
            this.tpCadastro.Controls.Add(this.label2);
            this.tpCadastro.Controls.Add(this.txtPlaca);
            this.tpCadastro.Controls.Add(this.label1);
            this.tpCadastro.Controls.Add(this.cbModelo);
            this.tpCadastro.Location = new System.Drawing.Point(4, 22);
            this.tpCadastro.Name = "tpCadastro";
            this.tpCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tpCadastro.Size = new System.Drawing.Size(599, 344);
            this.tpCadastro.TabIndex = 1;
            this.tpCadastro.Text = "Cadastro";
            this.tpCadastro.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mensalista:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(518, 315);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(437, 315);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data/Hora Entrada:";
            // 
            // txtDataEntrada
            // 
            this.txtDataEntrada.Location = new System.Drawing.Point(6, 92);
            this.txtDataEntrada.Mask = "00/00/0000 90:00:00";
            this.txtDataEntrada.Name = "txtDataEntrada";
            this.txtDataEntrada.Size = new System.Drawing.Size(177, 20);
            this.txtDataEntrada.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cor:";
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(308, 31);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(158, 20);
            this.txtCor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Placa:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(230, 31);
            this.txtPlaca.Mask = "AAA-0000";
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(60, 20);
            this.txtPlaca.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modelo:";
            // 
            // cbModelo
            // 
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Location = new System.Drawing.Point(6, 31);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(209, 21);
            this.cbModelo.TabIndex = 0;
            // 
            // cbMensalista
            // 
            this.cbMensalista.FormattingEnabled = true;
            this.cbMensalista.Location = new System.Drawing.Point(230, 92);
            this.cbMensalista.Name = "cbMensalista";
            this.cbMensalista.Size = new System.Drawing.Size(236, 21);
            this.cbMensalista.TabIndex = 12;
            // 
            // frmControleEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 394);
            this.Controls.Add(this.tpPrincipal);
            this.Name = "frmControleEntrada";
            this.Text = "Controle Entrada";
            this.Load += new System.EventHandler(this.frmControleEntrada_Load);
            this.tpPrincipal.ResumeLayout(false);
            this.tpPesquisa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVagasEntrada)).EndInit();
            this.tpCadastro.ResumeLayout(false);
            this.tpCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tpPrincipal;
        private System.Windows.Forms.TabPage tpPesquisa;
        private System.Windows.Forms.TabPage tpCadastro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.MaskedTextBox txtDataEntrada;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox gbChavePesquisa;
        private System.Windows.Forms.DataGridView dgVagasEntrada;
        private System.Windows.Forms.ComboBox cbMensalista;
    }
}