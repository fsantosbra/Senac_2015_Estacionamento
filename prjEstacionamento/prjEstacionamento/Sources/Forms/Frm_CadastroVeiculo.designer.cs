namespace prjEstacionamento
{
    partial class Frm_CadastroVeiculo
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
            this.lbl_Modelo = new System.Windows.Forms.Label();
            this.lbl_Tipo = new System.Windows.Forms.Label();
            this.cbx_Tipo = new System.Windows.Forms.ComboBox();
            this.txt_Modelo = new System.Windows.Forms.TextBox();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.dbg_Veiculos = new System.Windows.Forms.DataGridView();
            this.btn_Exluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbg_Veiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Modelo
            // 
            this.lbl_Modelo.AutoSize = true;
            this.lbl_Modelo.Location = new System.Drawing.Point(12, 21);
            this.lbl_Modelo.Name = "lbl_Modelo";
            this.lbl_Modelo.Size = new System.Drawing.Size(42, 13);
            this.lbl_Modelo.TabIndex = 0;
            this.lbl_Modelo.Text = "Modelo";
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.Location = new System.Drawing.Point(380, 21);
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(28, 13);
            this.lbl_Tipo.TabIndex = 0;
            this.lbl_Tipo.Text = "Tipo";
            // 
            // cbx_Tipo
            // 
            this.cbx_Tipo.FormattingEnabled = true;
            this.cbx_Tipo.Location = new System.Drawing.Point(383, 37);
            this.cbx_Tipo.Name = "cbx_Tipo";
            this.cbx_Tipo.Size = new System.Drawing.Size(150, 21);
            this.cbx_Tipo.TabIndex = 3;
            // 
            // txt_Modelo
            // 
            this.txt_Modelo.Location = new System.Drawing.Point(15, 38);
            this.txt_Modelo.Name = "txt_Modelo";
            this.txt_Modelo.Size = new System.Drawing.Size(362, 20);
            this.txt_Modelo.TabIndex = 2;
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Adicionar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Adicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Adicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Adicionar.Location = new System.Drawing.Point(539, 35);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_Adicionar.TabIndex = 4;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // dbg_Veiculos
            // 
            this.dbg_Veiculos.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dbg_Veiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbg_Veiculos.Location = new System.Drawing.Point(15, 75);
            this.dbg_Veiculos.MultiSelect = false;
            this.dbg_Veiculos.Name = "dbg_Veiculos";
            this.dbg_Veiculos.Size = new System.Drawing.Size(680, 218);
            this.dbg_Veiculos.TabIndex = 5;
            this.dbg_Veiculos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dbg_Veiculos_MouseDoubleClick);
            // 
            // btn_Exluir
            // 
            this.btn_Exluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Exluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Exluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Exluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Exluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exluir.Location = new System.Drawing.Point(620, 35);
            this.btn_Exluir.Name = "btn_Exluir";
            this.btn_Exluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Exluir.TabIndex = 6;
            this.btn_Exluir.Text = "Excluir";
            this.btn_Exluir.UseVisualStyleBackColor = true;
            this.btn_Exluir.Click += new System.EventHandler(this.btn_Exluir_Click);
            // 
            // Frm_CadastroVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(708, 305);
            this.Controls.Add(this.btn_Exluir);
            this.Controls.Add(this.dbg_Veiculos);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.txt_Modelo);
            this.Controls.Add(this.cbx_Tipo);
            this.Controls.Add(this.lbl_Tipo);
            this.Controls.Add(this.lbl_Modelo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_CadastroVeiculo";
            this.ShowIcon = false;
            this.Text = "Cadastro de Veículos";
            ((System.ComponentModel.ISupportInitialize)(this.dbg_Veiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Modelo;
        private System.Windows.Forms.Label lbl_Tipo;
        private System.Windows.Forms.ComboBox cbx_Tipo;
        private System.Windows.Forms.TextBox txt_Modelo;
        public System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.DataGridView dbg_Veiculos;
        public System.Windows.Forms.Button btn_Exluir;
    }
}