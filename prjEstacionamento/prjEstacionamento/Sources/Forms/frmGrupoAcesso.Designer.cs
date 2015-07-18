namespace prjEstacionamento.Sources.Forms
{
    partial class frmGrupoAcesso
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btn_Exluir = new System.Windows.Forms.Button();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.dbgGrupoPermissao = new System.Windows.Forms.DataGridView();
            this.btnPermissoes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbgGrupoPermissao)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(302, 20);
            this.txtNome.TabIndex = 2;
            // 
            // btn_Exluir
            // 
            this.btn_Exluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Exluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Exluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Exluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Exluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exluir.Location = new System.Drawing.Point(406, 54);
            this.btn_Exluir.Name = "btn_Exluir";
            this.btn_Exluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Exluir.TabIndex = 12;
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
            this.btn_Adicionar.Location = new System.Drawing.Point(406, 25);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_Adicionar.TabIndex = 11;
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
            this.dbgGrupoPermissao.Location = new System.Drawing.Point(11, 90);
            this.dbgGrupoPermissao.MultiSelect = false;
            this.dbgGrupoPermissao.Name = "dbgGrupoPermissao";
            this.dbgGrupoPermissao.Size = new System.Drawing.Size(471, 186);
            this.dbgGrupoPermissao.TabIndex = 13;
            this.dbgGrupoPermissao.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dbgGrupoUsuarios_MouseDoubleClick);
            // 
            // btnPermissoes
            // 
            this.btnPermissoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPermissoes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPermissoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPermissoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPermissoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPermissoes.Location = new System.Drawing.Point(406, 286);
            this.btnPermissoes.Name = "btnPermissoes";
            this.btnPermissoes.Size = new System.Drawing.Size(75, 23);
            this.btnPermissoes.TabIndex = 14;
            this.btnPermissoes.Text = "Permissões";
            this.btnPermissoes.UseVisualStyleBackColor = true;
            this.btnPermissoes.Click += new System.EventHandler(this.btnPermissoes_Click);
            // 
            // frmGrupoAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(493, 321);
            this.Controls.Add(this.btnPermissoes);
            this.Controls.Add(this.dbgGrupoPermissao);
            this.Controls.Add(this.btn_Exluir);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "frmGrupoAcesso";
            this.Text = "Grupos de Acesso";
            ((System.ComponentModel.ISupportInitialize)(this.dbgGrupoPermissao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btn_Exluir;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.DataGridView dbgGrupoPermissao;
        private System.Windows.Forms.Button btnPermissoes;
    }
}