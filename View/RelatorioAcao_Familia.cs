using CRUD_19_11.Controller;
using CRUD_19_11.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CRUD_19_11.View
{
    public partial class RelatorioAcao_Familia : Form
    {
        CadastroPessoa CadastroPessoa { get; set; }
        public RelatorioAcao_Familia()
        {
            InitializeComponent();
            rdbAcao.Checked = true;
            ttbCPF2.Visible = false;
        }

        private void btnNome_Acao_Click(object sender, EventArgs e)
        {
            ControllerAcao_Familia controller = new ControllerAcao_Familia();
            if (ttbBusca.Text.Length > 0)
            {
                if (rdbAcao.Checked)
                {
                    DataTable resultado1 = controller.buscarNome_Acao("%"+ttbBusca.Text+"%");
                    if (resultado1.Rows.Count > 0)
                    {
                        dgvNome_Acao.DataSource = resultado1;
                        ttbBusca.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Não encontramos resultado para a busca desejada!");
                    }

                }
                if (rdbFamilia.Checked)
                {
                    DataTable resultado1 = controller.buscarNome_Familia("%"+ttbBusca.Text+"%");
                    if (resultado1.Rows.Count > 0)
                    {
                        dgvNome_Acao.DataSource = resultado1;
                        ttbBusca.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Não encontramos resultado para a busca desejada!");
                    }
                }
                if (rdbNome_Pessoa.Checked)
                {
                    PessoaController controllerPessoa = new PessoaController();
                    if (controllerPessoa.buscarPessoapeloNome("%"+ttbBusca.Text+"%").Rows.Count > 0)
                    {
                        DataTable Pessoa = controllerPessoa.buscarPessoapeloNome("%"+ttbBusca.Text+"%");
                        int idFamilia = Convert.ToInt32(Pessoa.Rows[0]["Id_Familia"].ToString());
                        DataTable resultado1 = controller.buscarAcao_FamiliaporId_FamiliapeloNomePessoa(idFamilia);

                        if (resultado1.Rows.Count > 0)
                        {
                            dgvNome_Acao.DataSource = resultado1;
                            ttbBusca.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Não encontramos resultado para a busca desejada!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não existem registros cadastrados para essa pessoa!");
                    }

                }
            }
            else
            {
                if (rdbAcao.Checked)
                {
                    DataTable resultado1 = controller.buscarNome_AcaoTodas();
                    if (resultado1.Rows.Count > 0)
                    {
                        dgvNome_Acao.DataSource = resultado1;
                        ttbBusca.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Não encontramos resultado para a busca desejada!");
                    }

                }
                if (rdbFamilia.Checked)
                {
                    DataTable resultado1 = controller.buscarNome_FamiliaTodas();
                    if (resultado1.Rows.Count > 0)
                    {
                        dgvNome_Acao.DataSource = resultado1;
                        ttbBusca.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Não encontramos resultado para a busca desejada!");
                    }
                }
                if (rdbNome_Pessoa.Checked)
                {
                    DataTable resultado1 = controller.buscarNome_Pessoa();

                    if (resultado1.Rows.Count > 0)
                    {
                        dgvNome_Acao.DataSource = resultado1;
                        ttbBusca.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Não encontramos resultado para a busca desejada!");
                    }
                }
            }
            
            // Verifica se é consulta pelo CPF
            if (rdbCPF.Checked)
            {
                if (CadastroPessoa.ValidaCPF(ttbCPF2.Text))
                {
                    PessoaController controllerPessoa = new PessoaController();
                    if (controllerPessoa.buscarPessoapeloCPF(ttbCPF2.Text).Rows.Count > 0)
                    {
                        DataTable Pessoa = controllerPessoa.buscarPessoapeloCPF(ttbCPF2.Text);
                        int idFamilia = Convert.ToInt32(Pessoa.Rows[0]["Id_Familia"].ToString());
                        DataTable resultado1 = controller.buscarAcao_FamiliaporId_FamiliapeloNomePessoa(idFamilia);

                        if (resultado1.Rows.Count > 0)
                        {
                            dgvNome_Acao.DataSource = resultado1;
                            ttbCPF2.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Não encontramos resultado para a busca desejada!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não existem registros cadastrados para essa pessoa!");
                    }
                }
                else
                {
                    DataTable resultado1 = controller.buscarNome_Pessoa();
                    if (resultado1.Rows.Count > 0)
                    {
                        dgvNome_Acao.DataSource = resultado1;
                        ttbCPF2.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Não encontramos resultado para a busca desejada!");
                    }
                }
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ControllerAcao_Familia controller = new ControllerAcao_Familia();

            if (MessageBox.Show("Deseja realmente excluir este registro?", "Mensagem de confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                int elemento = Convert.ToInt32(dgvNome_Acao.CurrentRow.Cells[0].Value.ToString());

                if (controller.excluirAcao_Familia(elemento))
                {
                    MessageBox.Show("Registro removido!");
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Registro não encontrado!");
                }

            }
        }

        private void rdbCPF_CheckedChanged(object sender, EventArgs e)
        {
            ttbCPF2.Visible = true;
            ttbBusca.Visible = false;
        }

        private void rdbNome_Pessoa_CheckedChanged(object sender, EventArgs e)
        {
            ttbCPF2.Visible = false;
            ttbBusca.Visible = true;
        }

        private void rdbFamilia_CheckedChanged(object sender, EventArgs e)
        {
            ttbCPF2.Visible = false;
            ttbBusca.Visible = true;
        }

        private void rdbAcao_CheckedChanged(object sender, EventArgs e)
        {
            ttbCPF2.Visible = false;
            ttbBusca.Visible = true;
        }
    }
}
