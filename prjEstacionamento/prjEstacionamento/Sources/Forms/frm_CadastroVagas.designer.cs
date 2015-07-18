namespace prjEstacionamento
{
    partial class Frm_CadastroVagas
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
            this.lbl_Qtde = new System.Windows.Forms.Label();
            this.lbl_Tipo = new System.Windows.Forms.Label();
            this.cbx_Tipo = new System.Windows.Forms.ComboBox();
            this.txt_QntdeTotal = new System.Windows.Forms.TextBox();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.dbg_Vagas = new System.Windows.Forms.DataGridView();
            this.txtQntdeMensal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbg_Vagas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Qtde
            // 
            this.lbl_Qtde.AutoSize = true;
            this.lbl_Qtde.Location = new System.Drawing.Point(177, 21);
            this.lbl_Qtde.Name = "lbl_Qtde";
            this.lbl_Qtde.Size = new System.Drawing.Size(89, 13);
            this.lbl_Qtde.TabIndex = 0;
            this.lbl_Qtde.Text = "Quantidade Total";
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.Location = new System.Drawing.Point(9, 20);
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(83, 13);
            this.lbl_Tipo.TabIndex = 0;
            this.lbl_Tipo.Text = "Tipo de Veículo";
            // 
            // cbx_Tipo
            // 
            this.cbx_Tipo.FormattingEnabled = true;
            this.cbx_Tipo.Items.AddRange(new object[] {
            "Avulso",
            "Mensal",
            "Total"});
            this.cbx_Tipo.Location = new System.Drawing.Point(12, 37);
            this.cbx_Tipo.Name = "cbx_Tipo";
            this.cbx_Tipo.Size = new System.Drawing.Size(150, 21);
            this.cbx_Tipo.TabIndex = 3;
            // 
            // txt_QntdeTotal
            // 
            this.txt_QntdeTotal.Location = new System.Drawing.Point(180, 38);
            this.txt_QntdeTotal.Name = "txt_QntdeTotal";
            this.txt_QntdeTotal.Size = new System.Drawing.Size(70, 20);
            this.txt_QntdeTotal.TabIndex = 2;
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Adicionar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Adicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Adicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Adicionar.Location = new System.Drawing.Point(381, 36);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_Adicionar.TabIndex = 4;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // dbg_Vagas
            // 
            this.dbg_Vagas.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dbg_Vagas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbg_Vagas.Location = new System.Drawing.Point(15, 137);
            this.dbg_Vagas.MultiSelect = false;
            this.dbg_Vagas.Name = "dbg_Vagas";
            this.dbg_Vagas.Size = new System.Drawing.Size(683, 156);
            this.dbg_Vagas.TabIndex = 5;
            // 
            // txtQntdeMensal
            // 
            this.txtQntdeMensal.Location = new System.Drawing.Point(270, 38);
            this.txtQntdeMensal.Name = "txtQntdeMensal";
            this.txtQntdeMensal.Size = new System.Drawing.Size(70, 20);
            this.txtQntdeMensal.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quantidade Mensal";
            // 
            // Frm_CadastroVagas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(711, 305);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQntdeMensal);
            this.Controls.Add(this.dbg_Vagas);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.txt_QntdeTotal);
            this.Controls.Add(this.cbx_Tipo);
            this.Controls.Add(this.lbl_Tipo);
            this.Controls.Add(this.lbl_Qtde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_CadastroVagas";
            this.ShowIcon = false;
            this.Text = "Cadastro de Vagas";
            ((System.ComponentModel.ISupportInitialize)(this.dbg_Vagas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Qtde;
        private System.Windows.Forms.Label lbl_Tipo;
        private System.Windows.Forms.ComboBox cbx_Tipo;
        private System.Windows.Forms.TextBox txt_QntdeTotal;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.DataGridView dbg_Vagas;
        private System.Windows.Forms.TextBox txtQntdeMensal;
        private System.Windows.Forms.Label label1;
    }
}