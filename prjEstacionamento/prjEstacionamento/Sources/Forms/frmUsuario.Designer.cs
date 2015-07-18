namespace prjEstacionamento.Sources.Forms
{
    partial class frmUsuario
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.btn_Exluir = new System.Windows.Forms.Button();
            this.dbgUsuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dbgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Funcionario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Grupo";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(15, 126);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(235, 20);
            this.txtSenha.TabIndex = 2;
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Location = new System.Drawing.Point(15, 25);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(316, 20);
            this.txtFuncionario.TabIndex = 0;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(15, 76);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(235, 20);
            this.txtLogin.TabIndex = 1;
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Location = new System.Drawing.Point(15, 177);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(235, 21);
            this.cmbGrupo.TabIndex = 3;
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Adicionar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Adicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Adicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Adicionar.Location = new System.Drawing.Point(408, 22);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_Adicionar.TabIndex = 4;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // btn_Exluir
            // 
            this.btn_Exluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Exluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Exluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Exluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Exluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exluir.Location = new System.Drawing.Point(408, 51);
            this.btn_Exluir.Name = "btn_Exluir";
            this.btn_Exluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Exluir.TabIndex = 5;
            this.btn_Exluir.Text = "Excluir";
            this.btn_Exluir.UseVisualStyleBackColor = true;
            this.btn_Exluir.Click += new System.EventHandler(this.btn_Exluir_Click);
            // 
            // dbgUsuarios
            // 
            this.dbgUsuarios.AllowUserToAddRows = false;
            this.dbgUsuarios.AllowUserToDeleteRows = false;
            this.dbgUsuarios.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dbgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgUsuarios.Location = new System.Drawing.Point(12, 204);
            this.dbgUsuarios.MultiSelect = false;
            this.dbgUsuarios.Name = "dbgUsuarios";
            this.dbgUsuarios.Size = new System.Drawing.Size(471, 186);
            this.dbgUsuarios.TabIndex = 6;
            this.dbgUsuarios.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dbgUsuarios_MouseDoubleClick);
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(495, 405);
            this.Controls.Add(this.dbgUsuarios);
            this.Controls.Add(this.btn_Exluir);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.cmbGrupo);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtFuncionario);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUsuario";
            this.Text = "Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.dbgUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.Button btn_Exluir;
        private System.Windows.Forms.DataGridView dbgUsuarios;
    }
}