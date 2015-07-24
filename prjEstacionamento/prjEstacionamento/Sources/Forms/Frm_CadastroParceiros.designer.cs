namespace prjEstacionamento
{
    partial class Frm_CadastroParceiro
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
            this.lbl_NomeParceiro = new System.Windows.Forms.Label();
            this.lbl_Desconto = new System.Windows.Forms.Label();
            this.txt_NomeParceiro = new System.Windows.Forms.TextBox();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.dbg_Parceiros = new System.Windows.Forms.DataGridView();
            this.btn_Exluir = new System.Windows.Forms.Button();
            this.txt_Desconto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dbg_Parceiros)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_NomeParceiro
            // 
            this.lbl_NomeParceiro.AutoSize = true;
            this.lbl_NomeParceiro.Location = new System.Drawing.Point(12, 21);
            this.lbl_NomeParceiro.Name = "lbl_NomeParceiro";
            this.lbl_NomeParceiro.Size = new System.Drawing.Size(92, 13);
            this.lbl_NomeParceiro.TabIndex = 0;
            this.lbl_NomeParceiro.Text = "Nome do Parceiro";
            // 
            // lbl_Desconto
            // 
            this.lbl_Desconto.AutoSize = true;
            this.lbl_Desconto.Location = new System.Drawing.Point(380, 21);
            this.lbl_Desconto.Name = "lbl_Desconto";
            this.lbl_Desconto.Size = new System.Drawing.Size(53, 13);
            this.lbl_Desconto.TabIndex = 0;
            this.lbl_Desconto.Text = "Desconto";
            // 
            // txt_NomeParceiro
            // 
            this.txt_NomeParceiro.Location = new System.Drawing.Point(15, 38);
            this.txt_NomeParceiro.Name = "txt_NomeParceiro";
            this.txt_NomeParceiro.Size = new System.Drawing.Size(362, 20);
            this.txt_NomeParceiro.TabIndex = 1;
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
            this.btn_Adicionar.TabIndex = 3;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // dbg_Parceiros
            // 
            this.dbg_Parceiros.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dbg_Parceiros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbg_Parceiros.Location = new System.Drawing.Point(15, 75);
            this.dbg_Parceiros.MultiSelect = false;
            this.dbg_Parceiros.Name = "dbg_Parceiros";
            this.dbg_Parceiros.Size = new System.Drawing.Size(680, 218);
            this.dbg_Parceiros.TabIndex = 5;
            this.dbg_Parceiros.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dbg_Parceiros_MouseDoubleClick);
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
            this.btn_Exluir.TabIndex = 4;
            this.btn_Exluir.Text = "Excluir";
            this.btn_Exluir.UseVisualStyleBackColor = true;
            this.btn_Exluir.Click += new System.EventHandler(this.btn_Exluir_Click);
            // 
            // txt_Desconto
            // 
            this.txt_Desconto.Location = new System.Drawing.Point(383, 38);
            this.txt_Desconto.Name = "txt_Desconto";
            this.txt_Desconto.Size = new System.Drawing.Size(150, 20);
            this.txt_Desconto.TabIndex = 2;
            this.txt_Desconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Desconto_KeyPress);
            // 
            // Frm_CadastroParceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(708, 305);
            this.Controls.Add(this.txt_Desconto);
            this.Controls.Add(this.btn_Exluir);
            this.Controls.Add(this.dbg_Parceiros);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.txt_NomeParceiro);
            this.Controls.Add(this.lbl_Desconto);
            this.Controls.Add(this.lbl_NomeParceiro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_CadastroParceiro";
            this.ShowIcon = false;
            this.Text = "Cadastro de Parceiros";
            ((System.ComponentModel.ISupportInitialize)(this.dbg_Parceiros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_NomeParceiro;
        private System.Windows.Forms.Label lbl_Desconto;
        private System.Windows.Forms.TextBox txt_NomeParceiro;
        public System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.DataGridView dbg_Parceiros;
        public System.Windows.Forms.Button btn_Exluir;
        private System.Windows.Forms.TextBox txt_Desconto;
    }
}