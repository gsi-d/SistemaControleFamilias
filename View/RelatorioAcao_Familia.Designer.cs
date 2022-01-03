
namespace CRUD_19_11.View
{
    partial class RelatorioAcao_Familia
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
            this.ttbBusca = new System.Windows.Forms.TextBox();
            this.btnNome_Acao = new System.Windows.Forms.Button();
            this.dgvNome_Acao = new System.Windows.Forms.DataGridView();
            this.rdbAcao = new System.Windows.Forms.RadioButton();
            this.rdbFamilia = new System.Windows.Forms.RadioButton();
            this.rdbNome_Pessoa = new System.Windows.Forms.RadioButton();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.rdbCPF = new System.Windows.Forms.RadioButton();
            this.ttbCPF2 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNome_Acao)).BeginInit();
            this.SuspendLayout();
            // 
            // ttbBusca
            // 
            this.ttbBusca.Location = new System.Drawing.Point(9, 47);
            this.ttbBusca.Name = "ttbBusca";
            this.ttbBusca.Size = new System.Drawing.Size(191, 23);
            this.ttbBusca.TabIndex = 8;
            // 
            // btnNome_Acao
            // 
            this.btnNome_Acao.Location = new System.Drawing.Point(236, 47);
            this.btnNome_Acao.Name = "btnNome_Acao";
            this.btnNome_Acao.Size = new System.Drawing.Size(75, 23);
            this.btnNome_Acao.TabIndex = 11;
            this.btnNome_Acao.Text = "Pesquisar";
            this.btnNome_Acao.UseVisualStyleBackColor = true;
            this.btnNome_Acao.Click += new System.EventHandler(this.btnNome_Acao_Click);
            // 
            // dgvNome_Acao
            // 
            this.dgvNome_Acao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNome_Acao.Location = new System.Drawing.Point(0, 135);
            this.dgvNome_Acao.Name = "dgvNome_Acao";
            this.dgvNome_Acao.RowTemplate.Height = 25;
            this.dgvNome_Acao.Size = new System.Drawing.Size(629, 201);
            this.dgvNome_Acao.TabIndex = 12;
            // 
            // rdbAcao
            // 
            this.rdbAcao.AutoSize = true;
            this.rdbAcao.Location = new System.Drawing.Point(9, 13);
            this.rdbAcao.Name = "rdbAcao";
            this.rdbAcao.Size = new System.Drawing.Size(104, 19);
            this.rdbAcao.TabIndex = 13;
            this.rdbAcao.TabStop = true;
            this.rdbAcao.Text = "Nome da Ação";
            this.rdbAcao.UseVisualStyleBackColor = true;
            this.rdbAcao.CheckedChanged += new System.EventHandler(this.rdbAcao_CheckedChanged);
            // 
            // rdbFamilia
            // 
            this.rdbFamilia.AutoSize = true;
            this.rdbFamilia.Location = new System.Drawing.Point(141, 13);
            this.rdbFamilia.Name = "rdbFamilia";
            this.rdbFamilia.Size = new System.Drawing.Size(115, 19);
            this.rdbFamilia.TabIndex = 14;
            this.rdbFamilia.TabStop = true;
            this.rdbFamilia.Text = "Nome da Família";
            this.rdbFamilia.UseVisualStyleBackColor = true;
            this.rdbFamilia.CheckedChanged += new System.EventHandler(this.rdbFamilia_CheckedChanged);
            // 
            // rdbNome_Pessoa
            // 
            this.rdbNome_Pessoa.AutoSize = true;
            this.rdbNome_Pessoa.Location = new System.Drawing.Point(279, 12);
            this.rdbNome_Pessoa.Name = "rdbNome_Pessoa";
            this.rdbNome_Pessoa.Size = new System.Drawing.Size(113, 19);
            this.rdbNome_Pessoa.TabIndex = 15;
            this.rdbNome_Pessoa.TabStop = true;
            this.rdbNome_Pessoa.Text = "Nome da Pessoa";
            this.rdbNome_Pessoa.UseVisualStyleBackColor = true;
            this.rdbNome_Pessoa.CheckedChanged += new System.EventHandler(this.rdbNome_Pessoa_CheckedChanged);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(340, 47);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // rdbCPF
            // 
            this.rdbCPF.AutoSize = true;
            this.rdbCPF.Location = new System.Drawing.Point(407, 13);
            this.rdbCPF.Name = "rdbCPF";
            this.rdbCPF.Size = new System.Drawing.Size(46, 19);
            this.rdbCPF.TabIndex = 15;
            this.rdbCPF.TabStop = true;
            this.rdbCPF.Text = "CPF";
            this.rdbCPF.UseVisualStyleBackColor = true;
            this.rdbCPF.CheckedChanged += new System.EventHandler(this.rdbCPF_CheckedChanged);
            // 
            // ttbCPF2
            // 
            this.ttbCPF2.Location = new System.Drawing.Point(50, 48);
            this.ttbCPF2.Mask = "000,000,000-00";
            this.ttbCPF2.Name = "ttbCPF2";
            this.ttbCPF2.Size = new System.Drawing.Size(100, 23);
            this.ttbCPF2.TabIndex = 17;
            this.ttbCPF2.Visible = false;
            // 
            // RelatorioAcao_Familia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 336);
            this.Controls.Add(this.ttbCPF2);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.rdbCPF);
            this.Controls.Add(this.rdbNome_Pessoa);
            this.Controls.Add(this.rdbFamilia);
            this.Controls.Add(this.rdbAcao);
            this.Controls.Add(this.dgvNome_Acao);
            this.Controls.Add(this.btnNome_Acao);
            this.Controls.Add(this.ttbBusca);
            this.Name = "RelatorioAcao_Familia";
            this.Text = "RelatorioAcao_Familia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNome_Acao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ttbBusca;
        private System.Windows.Forms.Button btnNome_Acao;
        private System.Windows.Forms.DataGridView dgvNome_Acao;
        private System.Windows.Forms.RadioButton rdbAcao;
        private System.Windows.Forms.RadioButton rdbFamilia;
        private System.Windows.Forms.RadioButton rdbNome_Pessoa;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.RadioButton rdbCPF;
        private System.Windows.Forms.MaskedTextBox ttbCPF2;
    }
}