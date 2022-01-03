
namespace CRUD_19_11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.famíliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açõesRealizadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ttbAcao2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ttbCPF2 = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(541, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoaToolStripMenuItem,
            this.famíliaToolStripMenuItem,
            this.açãoToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(66, 20);
            this.toolStripMenuItem1.Text = "Cadastro";
            // 
            // pessoaToolStripMenuItem
            // 
            this.pessoaToolStripMenuItem.Name = "pessoaToolStripMenuItem";
            this.pessoaToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.pessoaToolStripMenuItem.Text = "Pessoa";
            this.pessoaToolStripMenuItem.Click += new System.EventHandler(this.pessoaToolStripMenuItem_Click);
            // 
            // famíliaToolStripMenuItem
            // 
            this.famíliaToolStripMenuItem.Name = "famíliaToolStripMenuItem";
            this.famíliaToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.famíliaToolStripMenuItem.Text = "Família";
            this.famíliaToolStripMenuItem.Click += new System.EventHandler(this.famíliaToolStripMenuItem_Click);
            // 
            // açãoToolStripMenuItem
            // 
            this.açãoToolStripMenuItem.Name = "açãoToolStripMenuItem";
            this.açãoToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.açãoToolStripMenuItem.Text = "Ação";
            this.açãoToolStripMenuItem.Click += new System.EventHandler(this.açãoToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açõesRealizadasToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // açõesRealizadasToolStripMenuItem
            // 
            this.açõesRealizadasToolStripMenuItem.Name = "açõesRealizadasToolStripMenuItem";
            this.açõesRealizadasToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.açõesRealizadasToolStripMenuItem.Text = "Ações realizadas";
            this.açõesRealizadasToolStripMenuItem.Click += new System.EventHandler(this.açõesRealizadasToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(149, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cadastro de Ações e Famílias";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome Ação";
            // 
            // ttbAcao2
            // 
            this.ttbAcao2.Location = new System.Drawing.Point(177, 91);
            this.ttbAcao2.Name = "ttbAcao2";
            this.ttbAcao2.Size = new System.Drawing.Size(191, 23);
            this.ttbAcao2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "CPF do Responsável";
            // 
            // ttbCPF2
            // 
            this.ttbCPF2.Location = new System.Drawing.Point(226, 166);
            this.ttbCPF2.Mask = "000,000,000-00";
            this.ttbCPF2.Name = "ttbCPF2";
            this.ttbCPF2.Size = new System.Drawing.Size(100, 23);
            this.ttbCPF2.TabIndex = 6;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(237, 212);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 266);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.ttbCPF2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ttbAcao2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pessoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem famíliaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açãoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ttbAcao2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox ttbCPF2;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açõesRealizadasToolStripMenuItem;
    }
}

