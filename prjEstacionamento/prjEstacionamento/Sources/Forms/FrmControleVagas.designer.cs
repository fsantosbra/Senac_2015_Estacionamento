namespace prjEstacionamento.Sources.Forms
{
    partial class FrmControleVagas
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
            this.lblQtdAvulso = new System.Windows.Forms.Label();
            this.lblQtdMensal = new System.Windows.Forms.Label();
            this.lblQtdAvulsoDisp = new System.Windows.Forms.Label();
            this.lblQtdMensalDisp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade de Vagas Avulso: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade de Vagas Mensal: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(263, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade de Vagas Mensal Disponíveis: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(265, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantidade de Vagas Avulso Disponíveis: ";
            // 
            // lblQtdAvulso
            // 
            this.lblQtdAvulso.AutoSize = true;
            this.lblQtdAvulso.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdAvulso.Location = new System.Drawing.Point(68, 56);
            this.lblQtdAvulso.Name = "lblQtdAvulso";
            this.lblQtdAvulso.Size = new System.Drawing.Size(135, 32);
            this.lblQtdAvulso.TabIndex = 4;
            this.lblQtdAvulso.Text = "QtdAvulso";
            // 
            // lblQtdMensal
            // 
            this.lblQtdMensal.AutoSize = true;
            this.lblQtdMensal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdMensal.Location = new System.Drawing.Point(66, 155);
            this.lblQtdMensal.Name = "lblQtdMensal";
            this.lblQtdMensal.Size = new System.Drawing.Size(139, 32);
            this.lblQtdMensal.TabIndex = 5;
            this.lblQtdMensal.Text = "QtdMensal";
            // 
            // lblQtdAvulsoDisp
            // 
            this.lblQtdAvulsoDisp.AutoSize = true;
            this.lblQtdAvulsoDisp.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdAvulsoDisp.Location = new System.Drawing.Point(300, 56);
            this.lblQtdAvulsoDisp.Name = "lblQtdAvulsoDisp";
            this.lblQtdAvulsoDisp.Size = new System.Drawing.Size(186, 32);
            this.lblQtdAvulsoDisp.TabIndex = 6;
            this.lblQtdAvulsoDisp.Text = "QtdAvulsoDisp";
            // 
            // lblQtdMensalDisp
            // 
            this.lblQtdMensalDisp.AutoSize = true;
            this.lblQtdMensalDisp.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdMensalDisp.Location = new System.Drawing.Point(297, 155);
            this.lblQtdMensalDisp.Name = "lblQtdMensalDisp";
            this.lblQtdMensalDisp.Size = new System.Drawing.Size(190, 32);
            this.lblQtdMensalDisp.TabIndex = 7;
            this.lblQtdMensalDisp.Text = "QtdMensalDisp";
            // 
            // FrmControleVagas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(557, 261);
            this.Controls.Add(this.lblQtdMensalDisp);
            this.Controls.Add(this.lblQtdAvulsoDisp);
            this.Controls.Add(this.lblQtdMensal);
            this.Controls.Add(this.lblQtdAvulso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmControleVagas";
            this.Text = "Controle de Vagas";
            this.Load += new System.EventHandler(this.ControleVagas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblQtdAvulso;
        private System.Windows.Forms.Label lblQtdMensal;
        private System.Windows.Forms.Label lblQtdAvulsoDisp;
        private System.Windows.Forms.Label lblQtdMensalDisp;
    }
}