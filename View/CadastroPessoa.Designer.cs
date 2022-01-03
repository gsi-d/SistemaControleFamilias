
namespace CRUD_19_11.View
{
    partial class CadastroPessoa
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
            this.ttbCPF = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ttbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lbIndice = new System.Windows.Forms.Label();
            this.ttbRG = new System.Windows.Forms.TextBox();
            this.ttbNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ttbFamilia = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF";
            // 
            // ttbCPF
            // 
            this.ttbCPF.Location = new System.Drawing.Point(13, 27);
            this.ttbCPF.Mask = "000,000,000-00";
            this.ttbCPF.Name = "ttbCPF";
            this.ttbCPF.Size = new System.Drawing.Size(100, 23);
            this.ttbCPF.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "RG";
            // 
            // ttbTelefone
            // 
            this.ttbTelefone.Location = new System.Drawing.Point(13, 181);
            this.ttbTelefone.Mask = "(00)00000-0000";
            this.ttbTelefone.Name = "ttbTelefone";
            this.ttbTelefone.Size = new System.Drawing.Size(100, 23);
            this.ttbTelefone.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data de nascimento";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(108, 280);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(13, 234);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(264, 23);
            this.dtpData.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(161, 27);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(202, 280);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(12, 280);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lbIndice
            // 
            this.lbIndice.AutoSize = true;
            this.lbIndice.Location = new System.Drawing.Point(172, 13);
            this.lbIndice.Name = "lbIndice";
            this.lbIndice.Size = new System.Drawing.Size(0, 15);
            this.lbIndice.TabIndex = 9;
            // 
            // ttbRG
            // 
            this.ttbRG.Location = new System.Drawing.Point(161, 181);
            this.ttbRG.Name = "ttbRG";
            this.ttbRG.Size = new System.Drawing.Size(100, 23);
            this.ttbRG.TabIndex = 5;
            // 
            // ttbNome
            // 
            this.ttbNome.Location = new System.Drawing.Point(13, 80);
            this.ttbNome.MaxLength = 50;
            this.ttbNome.Name = "ttbNome";
            this.ttbNome.Size = new System.Drawing.Size(248, 23);
            this.ttbNome.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Família";
            // 
            // ttbFamilia
            // 
            this.ttbFamilia.Location = new System.Drawing.Point(13, 131);
            this.ttbFamilia.Mask = "000";
            this.ttbFamilia.Name = "ttbFamilia";
            this.ttbFamilia.Size = new System.Drawing.Size(64, 23);
            this.ttbFamilia.TabIndex = 3;
            this.ttbFamilia.ValidatingType = typeof(int);
            // 
            // CadastroPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 313);
            this.Controls.Add(this.ttbFamilia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ttbNome);
            this.Controls.Add(this.ttbRG);
            this.Controls.Add(this.lbIndice);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ttbTelefone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ttbCPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroPessoa";
            this.Text = "Cadastrar Pessoa";

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox ttbCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox ttbTelefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lbIndice;
        private System.Windows.Forms.TextBox ttbRG;
        private System.Windows.Forms.TextBox ttbNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox ttbFamilia;
    }
}