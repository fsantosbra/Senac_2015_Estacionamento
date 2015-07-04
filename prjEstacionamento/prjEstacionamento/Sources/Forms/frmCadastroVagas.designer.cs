namespace prjEstacionamento.Sources.Forms
{
    partial class frmCadastroVagas
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
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxTipoVeiculo = new System.Windows.Forms.ComboBox();
            this.txtTotalVagas = new System.Windows.Forms.TextBox();
            this.txtQtdMensalistas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(222, 261);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(141, 261);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo da Vaga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantidade total de vagas";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantidade de mensalistas";
            // 
            // cbxTipoVeiculo
            // 
            this.cbxTipoVeiculo.FormattingEnabled = true;
            this.cbxTipoVeiculo.Location = new System.Drawing.Point(222, 34);
            this.cbxTipoVeiculo.Name = "cbxTipoVeiculo";
            this.cbxTipoVeiculo.Size = new System.Drawing.Size(75, 21);
            this.cbxTipoVeiculo.TabIndex = 7;
            // 
            // txtTotalVagas
            // 
            this.txtTotalVagas.Location = new System.Drawing.Point(222, 68);
            this.txtTotalVagas.Name = "txtTotalVagas";
            this.txtTotalVagas.Size = new System.Drawing.Size(75, 20);
            this.txtTotalVagas.TabIndex = 8;
            // 
            // txtQtdMensalistas
            // 
            this.txtQtdMensalistas.Location = new System.Drawing.Point(222, 100);
            this.txtQtdMensalistas.Name = "txtQtdMensalistas";
            this.txtQtdMensalistas.Size = new System.Drawing.Size(75, 20);
            this.txtQtdMensalistas.TabIndex = 9;
            // 
            // frmCadastroVagas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 316);
            this.Controls.Add(this.txtQtdMensalistas);
            this.Controls.Add(this.txtTotalVagas);
            this.Controls.Add(this.cbxTipoVeiculo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnInserir);
            this.Name = "frmCadastroVagas";
            this.Text = "frmCadastroVagas";
            this.Load += new System.EventHandler(this.frmCadastroVagas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxTipoVeiculo;
        private System.Windows.Forms.TextBox txtTotalVagas;
        private System.Windows.Forms.TextBox txtQtdMensalistas;
    }
}