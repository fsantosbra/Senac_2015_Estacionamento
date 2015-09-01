namespace CinemaAdmin.Cadastros
{
    partial class frmGenero
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
            this.tbGenero = new System.Windows.Forms.TabControl();
            this.tbLista = new System.Windows.Forms.TabPage();
            this.tbCadastro = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCadGenero = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbGenero.SuspendLayout();
            this.tbLista.SuspendLayout();
            this.tbCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbGenero
            // 
            this.tbGenero.Controls.Add(this.tbLista);
            this.tbGenero.Controls.Add(this.tbCadastro);
            this.tbGenero.Location = new System.Drawing.Point(12, 58);
            this.tbGenero.Name = "tbGenero";
            this.tbGenero.SelectedIndex = 0;
            this.tbGenero.Size = new System.Drawing.Size(253, 167);
            this.tbGenero.TabIndex = 1;
            // 
            // tbLista
            // 
            this.tbLista.Controls.Add(this.dataGridView1);
            this.tbLista.Location = new System.Drawing.Point(4, 22);
            this.tbLista.Name = "tbLista";
            this.tbLista.Padding = new System.Windows.Forms.Padding(3);
            this.tbLista.Size = new System.Drawing.Size(245, 141);
            this.tbLista.TabIndex = 0;
            this.tbLista.Text = "Lista";
            this.tbLista.UseVisualStyleBackColor = true;
            // 
            // tbCadastro
            // 
            this.tbCadastro.Controls.Add(this.btnCancel);
            this.tbCadastro.Controls.Add(this.btnSave);
            this.tbCadastro.Controls.Add(this.lblGenero);
            this.tbCadastro.Controls.Add(this.textBox1);
            this.tbCadastro.Location = new System.Drawing.Point(4, 22);
            this.tbCadastro.Name = "tbCadastro";
            this.tbCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tbCadastro.Size = new System.Drawing.Size(245, 141);
            this.tbCadastro.TabIndex = 1;
            this.tbCadastro.Text = "Cadastro";
            this.tbCadastro.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(233, 129);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblCadGenero
            // 
            this.lblCadGenero.AutoSize = true;
            this.lblCadGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadGenero.Location = new System.Drawing.Point(12, 9);
            this.lblCadGenero.Name = "lblCadGenero";
            this.lblCadGenero.Size = new System.Drawing.Size(206, 25);
            this.lblCadGenero.TabIndex = 2;
            this.lblCadGenero.Text = "Cadastro de Genero";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 20);
            this.textBox1.TabIndex = 0;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(6, 12);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(55, 13);
            this.lblGenero.TabIndex = 1;
            this.lblGenero.Text = "Descrição";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(108, 92);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(27, 92);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(276, 237);
            this.Controls.Add(this.lblCadGenero);
            this.Controls.Add(this.tbGenero);
            this.MaximizeBox = false;
            this.Name = "frmGenero";
            this.Text = "Cadastro Genero";
            this.tbGenero.ResumeLayout(false);
            this.tbLista.ResumeLayout(false);
            this.tbCadastro.ResumeLayout(false);
            this.tbCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbGenero;
        private System.Windows.Forms.TabPage tbLista;
        private System.Windows.Forms.TabPage tbCadastro;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCadGenero;

    }
}