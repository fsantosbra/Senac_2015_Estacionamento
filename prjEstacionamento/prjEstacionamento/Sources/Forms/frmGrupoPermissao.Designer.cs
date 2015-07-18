namespace prjEstacionamento.Sources.Forms
{
    partial class frmGrupoPermissao
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTelas = new System.Windows.Forms.ComboBox();
            this.btn_Exluir = new System.Windows.Forms.Button();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.dbgGrupoPermissao = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dbgGrupoPermissao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tela";
            // 
            // cmbTelas
            // 
            this.cmbTelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTelas.FormattingEnabled = true;
            this.cmbTelas.Items.AddRange(new object[] {
            "Cadastro de Vagas",
            "Cadastro de Dados Mestre",
            "Cadastro da Tabela de Preços - Avulso",
            "Cadastro da Tabela de Preços - Mensalista",
            "Cadastro de Veículos",
            "Cadastro de Parceiros",
            "Cadastro de Mensalistas",
            "Cadastro de Usuários",
            "Cadastro de Grupo de Acesso",
            "Cadastro de Permissões",
            "Consulta de Logs",
            "Relatório de Entrada e Saída - Sintético",
            "Relatório de Entrada e Saída - Analítico",
            "Relatório de Mensalistas",
            "Relatório de Fluxo de Veículos",
            "Relatórios de Log de Operações",
            "Consulta de Vagas",
            "Consulta de Tabela de Preços",
            "Consulta de Veículos",
            "Consulta de Parceiros",
            "Controle de Vagas",
            "Controle de Entrada",
            "Controle de Saída",
            "Gerenciamento de Mensalistas"});
            this.cmbTelas.Location = new System.Drawing.Point(12, 25);
            this.cmbTelas.Name = "cmbTelas";
            this.cmbTelas.Size = new System.Drawing.Size(381, 21);
            this.cmbTelas.TabIndex = 1;
            // 
            // btn_Exluir
            // 
            this.btn_Exluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Exluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Exluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Exluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Exluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exluir.Location = new System.Drawing.Point(408, 52);
            this.btn_Exluir.Name = "btn_Exluir";
            this.btn_Exluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Exluir.TabIndex = 14;
            this.btn_Exluir.Text = "Excluir";
            this.btn_Exluir.UseVisualStyleBackColor = true;
            this.btn_Exluir.Click += new System.EventHandler(this.btn_Exluir_Click);
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Adicionar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Adicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Adicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Adicionar.Location = new System.Drawing.Point(408, 23);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_Adicionar.TabIndex = 13;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // dbgGrupoPermissao
            // 
            this.dbgGrupoPermissao.AllowUserToAddRows = false;
            this.dbgGrupoPermissao.AllowUserToDeleteRows = false;
            this.dbgGrupoPermissao.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dbgGrupoPermissao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgGrupoPermissao.Location = new System.Drawing.Point(12, 81);
            this.dbgGrupoPermissao.MultiSelect = false;
            this.dbgGrupoPermissao.Name = "dbgGrupoPermissao";
            this.dbgGrupoPermissao.Size = new System.Drawing.Size(471, 186);
            this.dbgGrupoPermissao.TabIndex = 15;
            this.dbgGrupoPermissao.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dbgGrupoPermissao_MouseDoubleClick);
            // 
            // frmGrupoPermissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(494, 284);
            this.Controls.Add(this.dbgGrupoPermissao);
            this.Controls.Add(this.btn_Exluir);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.cmbTelas);
            this.Controls.Add(this.label1);
            this.Name = "frmGrupoPermissao";
            this.Text = "frmGrupoPermissao";
            ((System.ComponentModel.ISupportInitialize)(this.dbgGrupoPermissao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTelas;
        private System.Windows.Forms.Button btn_Exluir;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.DataGridView dbgGrupoPermissao;
    }
}