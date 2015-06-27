namespace prjEstacionamento.Sources.Forms
{
    partial class frmCrudMensalista
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpPesquisa = new System.Windows.Forms.TabPage();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblPesquisaNome = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tpCadastro = new System.Windows.Forms.TabPage();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpFinalVigencia = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpInicioVigencia = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbTipoVeiculo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tpCadastro.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpPesquisa);
            this.tabControl1.Controls.Add(this.tpCadastro);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(585, 331);
            this.tabControl1.TabIndex = 0;
            // 
            // tpPesquisa
            // 
            this.tpPesquisa.Controls.Add(this.btnPesquisar);
            this.tpPesquisa.Controls.Add(this.lblPesquisaNome);
            this.tpPesquisa.Controls.Add(this.textBox1);
            this.tpPesquisa.Controls.Add(this.dataGridView1);
            this.tpPesquisa.Location = new System.Drawing.Point(4, 22);
            this.tpPesquisa.Name = "tpPesquisa";
            this.tpPesquisa.Padding = new System.Windows.Forms.Padding(3);
            this.tpPesquisa.Size = new System.Drawing.Size(577, 305);
            this.tpPesquisa.TabIndex = 0;
            this.tpPesquisa.Text = "Pesquisa";
            this.tpPesquisa.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(468, 35);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // lblPesquisaNome
            // 
            this.lblPesquisaNome.AutoSize = true;
            this.lblPesquisaNome.Location = new System.Drawing.Point(3, 22);
            this.lblPesquisaNome.Name = "lblPesquisaNome";
            this.lblPesquisaNome.Size = new System.Drawing.Size(35, 13);
            this.lblPesquisaNome.TabIndex = 2;
            this.lblPesquisaNome.Text = "Nome";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(574, 280);
            this.dataGridView1.TabIndex = 0;
            // 
            // tpCadastro
            // 
            this.tpCadastro.Controls.Add(this.btnSalvar);
            this.tpCadastro.Controls.Add(this.groupBox2);
            this.tpCadastro.Controls.Add(this.groupBox1);
            this.tpCadastro.Location = new System.Drawing.Point(4, 22);
            this.tpCadastro.Name = "tpCadastro";
            this.tpCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tpCadastro.Size = new System.Drawing.Size(577, 305);
            this.tpCadastro.TabIndex = 1;
            this.tpCadastro.Text = "Cadastro";
            this.tpCadastro.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(493, 276);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 21;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpFinalVigencia);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.dtpInicioVigencia);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtValor);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtPlaca);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cmbTipoVeiculo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(325, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 252);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Cobrança";
            // 
            // dtpFinalVigencia
            // 
            this.dtpFinalVigencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinalVigencia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpFinalVigencia.Location = new System.Drawing.Point(9, 211);
            this.dtpFinalVigencia.Name = "dtpFinalVigencia";
            this.dtpFinalVigencia.Size = new System.Drawing.Size(104, 20);
            this.dtpFinalVigencia.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Data Final Vigencia:";
            // 
            // dtpInicioVigencia
            // 
            this.dtpInicioVigencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicioVigencia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpInicioVigencia.Location = new System.Drawing.Point(9, 167);
            this.dtpInicioVigencia.Name = "dtpInicioVigencia";
            this.dtpInicioVigencia.Size = new System.Drawing.Size(104, 20);
            this.dtpInicioVigencia.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Data Inicial Vigencia:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(9, 124);
            this.txtValor.Mask = "#.###,00";
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(71, 20);
            this.txtValor.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Valor";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(9, 85);
            this.txtPlaca.Mask = "AAA-0000";
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(71, 20);
            this.txtPlaca.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Placa:";
            // 
            // cmbTipoVeiculo
            // 
            this.cmbTipoVeiculo.FormattingEnabled = true;
            this.cmbTipoVeiculo.Location = new System.Drawing.Point(9, 42);
            this.cmbTipoVeiculo.Name = "cmbTipoVeiculo";
            this.cmbTipoVeiculo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoVeiculo.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tipo Veiculo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTelefone);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCEP);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtEstado);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLogradouro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Location = new System.Drawing.Point(10, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 256);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Mensalista";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(113, 218);
            this.txtTelefone.Mask = "(99) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(110, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Telefone:";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(7, 218);
            this.txtCEP.Mask = "00000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(100, 20);
            this.txtCEP.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "CEP:";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(248, 171);
            this.txtEstado.MaxLength = 2;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(34, 20);
            this.txtEstado.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Estado:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(7, 171);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(235, 20);
            this.txtCidade.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cidade:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(7, 126);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(235, 20);
            this.txtBairro.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bairro:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(248, 80);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(44, 20);
            this.txtNumero.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(7, 80);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(235, 20);
            this.txtLogradouro.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Logradouro:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(7, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(235, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(4, 20);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // frmCrudMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 355);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmCrudMensalista";
            this.Text = "Mensalistas";
            this.tabControl1.ResumeLayout(false);
            this.tpPesquisa.ResumeLayout(false);
            this.tpPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tpCadastro.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpPesquisa;
        private System.Windows.Forms.TabPage tpCadastro;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblPesquisaNome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTipoVeiculo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtValor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpInicioVigencia;
        private System.Windows.Forms.DateTimePicker dtpFinalVigencia;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSalvar;
    }
}