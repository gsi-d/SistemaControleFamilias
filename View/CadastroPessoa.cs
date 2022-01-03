using CRUD_19_11.Controller;
using CRUD_19_11.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CRUD_19_11.View
{
    public partial class CadastroPessoa : Form
    {
        public CadastroPessoa()
        {
            InitializeComponent();
            ttbNome.Enabled = false;
            ttbRG.Enabled = false;
            ttbFamilia.Enabled = false;
            ttbTelefone.Enabled = false;
            dtpData.Enabled = false;
            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = false;
            lbIndice.Visible = false;
        }



        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            List<string> listaErros = new List<string>();
            DateTime nascimento = dtpData.Value;
            FamiliaController controllerFamilia = new FamiliaController();

            if (ttbNome.Text.Length <= 0)
                listaErros.Add("Verifique o campo nome!");

            if (!ValidaCPF(ttbCPF.Text))
                listaErros.Add("CPF Inválido!");

            if (ttbFamilia.Text == "")
                listaErros.Add("Família inválida");

            if (controllerFamilia.buscarFamilia(Convert.ToInt32(ttbFamilia.Text)).Rows.Count <= 0)
                listaErros.Add("Família inexistente!");

            if (ttbRG.Text == "")
                listaErros.Add("Preencha o RG!");

            if (ttbTelefone.Text == "(  )     -")
                listaErros.Add("Preencha o telefone!");

            if (!validaNascimento(nascimento))
                listaErros.Add("Data de Nascimento inválida!");

            if (listaErros.Count == 0)
            {
                //grava
                PessoaController controller = new PessoaController();
                Pessoa pessoa = new Pessoa(0, Convert.ToInt32(ttbFamilia.Text),ttbNome.Text, ttbCPF.Text, ttbRG.Text, ttbTelefone.Text, nascimento);
                if (controller.buscarPessoa(ttbCPF.Text).Rows.Count == 0)
                {
                    if (controller.GravarPessoa(pessoa))
                    {
                        MessageBox.Show("Pessoa cadastrada com sucesso!");
                        ttbNome.Clear();
                        ttbCPF.Clear();
                        ttbFamilia.Clear();
                        ttbRG.Clear();
                        ttbTelefone.Clear();
                        dtpData.Value = DateTime.Now;
                        ttbNome.Focus();
                        ttbNome.Enabled = false;
                        ttbFamilia.Enabled = false;
                        ttbRG.Enabled = false;
                        ttbTelefone.Enabled = false;
                        dtpData.Enabled = false;
                        btnAlterar.Enabled = false;
                        btnCadastrar.Enabled = false;
                        btnExcluir.Enabled = false;
                        ttbCPF.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Já existe um registro com este CPF cadastrado!");
                }
                
            }
            else
            {
                //gera mensagens de erro
                string erro = "";
                for (int i = 0; i < listaErros.Count; i++)
                    erro = erro + listaErros[i] + "\n";

                MessageBox.Show("Verifique os campos abaixo: \n" + erro , "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            PessoaController controller = new PessoaController();
            DataTable result = controller.buscarPessoa(ttbCPF.Text);
            if (result.Rows.Count > 0)
            {
                lbIndice.Text = result.Rows[0]["Id_Pessoa"].ToString();
                ttbNome.Text = result.Rows[0]["Nome_Pessoa"].ToString();
                ttbRG.Text = result.Rows[0]["RG"].ToString();
                ttbFamilia.Text = result.Rows[0]["Id_Familia"].ToString();
                ttbTelefone.Text = result.Rows[0]["Telefone"].ToString();
                dtpData.Value = Convert.ToDateTime(result.Rows[0]["Dt_nasc"].ToString());
                ttbNome.Enabled = true;
                ttbFamilia.Enabled = true;
                ttbRG.Enabled = true;
                ttbCPF.Enabled = false;
                ttbTelefone.Enabled = true;
                dtpData.Enabled = false;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
            }
            else
            {
                MessageBox.Show("Pessoa não encontrada!");
                ttbNome.Enabled = true;
                ttbFamilia.Enabled = true;
                ttbRG.Enabled = true;
                ttbTelefone.Enabled = true;
                dtpData.Enabled = true;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnCadastrar.Enabled = true;
                ttbCPF.Enabled = false;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            PessoaController controller = new PessoaController();
            ControllerAcao_Familia controllerAcao_Familia = new ControllerAcao_Familia();

            if (MessageBox.Show("Deseja realmente excluir este registro?", "Mensagem de confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if(controllerAcao_Familia.buscarAcao_FamiliaporId_Familia(Convert.ToInt32(lbIndice.Text)) == null)
                {
                    if (controller.ExcluirPessoa(Convert.ToInt32(lbIndice.Text)))
                    {
                        MessageBox.Show("Pessoa excluída!");
                        ttbNome.Clear();
                        ttbCPF.Clear();
                        ttbFamilia.Clear();
                        ttbRG.Clear();
                        ttbTelefone.Clear();
                        dtpData.Value = DateTime.Now;
                        ttbNome.Focus();
                        ttbNome.Enabled = false;
                        ttbFamilia.Enabled = false;
                        ttbRG.Enabled = false;
                        ttbTelefone.Enabled = false;
                        dtpData.Enabled = false;
                        btnAlterar.Enabled = false;
                        btnCadastrar.Enabled = false;
                        btnExcluir.Enabled = false;
                        lbIndice.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível excluir!");
                    }
                }
                else
                {
                    MessageBox.Show("Esta pessoa já está cadastrada à uma família e/ou ação!");
                }
            }       
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            List<string> listaErros = new List<string>();
            DateTime nascimento = dtpData.Value;
            if (ttbNome.Text.Length <= 0)
                listaErros.Add("Verifique o campo nome!");

            if (!ValidaCPF(ttbCPF.Text))
                listaErros.Add("CPF Inválido!");

            if (ttbRG.Text == "")
                listaErros.Add("Preencha o RG!");

            if (ttbTelefone.Text == "(  )     -")
                listaErros.Add("Preencha o telefone!");

            if (!validaNascimento(nascimento))
                listaErros.Add("Data de Nascimento inválida!");

            if (listaErros.Count == 0)
            {
                //grava
                PessoaController controller = new PessoaController();
                Pessoa pessoa = new Pessoa(0, Convert.ToInt32(ttbFamilia.Text), ttbNome.Text, ttbRG.Text, ttbTelefone.Text);

                if (controller.AlterarPessoa(pessoa))
                {
                    MessageBox.Show("Pessoa alterada com sucesso!");
                    ttbNome.Clear();
                    ttbCPF.Clear();
                    ttbFamilia.Clear();
                    ttbRG.Clear();
                    ttbTelefone.Clear();
                    dtpData.Value = DateTime.Now;
                    ttbNome.Focus();
                    ttbNome.Enabled = false;
                    ttbFamilia.Enabled = false;
                    ttbRG.Enabled = false;
                    ttbTelefone.Enabled = false;
                    dtpData.Enabled = false;
                    btnAlterar.Enabled = false;
                    btnCadastrar.Enabled = false;
                    btnExcluir.Enabled = false;
                    ttbCPF.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro na alteração!");
                }
            }
            else
            {
                //gera mensagens de erro
                string erro = "";
                for (int i = 0; i < listaErros.Count; i++)
                    erro = erro + listaErros[i] + "\n";

                MessageBox.Show("Verifique os campos abaixo: \n" + erro);
            }
        }

        public static bool ValidaCPF(string vrCPF)

        {

            string valor = vrCPF.Replace(".", "");

            valor = valor.Replace("-", "");



            if (valor.Length != 11)
                return false;



            bool igual = true;

            for (int i = 1; i < 11 && igual; i++)
                if (valor[i] != valor[0])
                    igual = false;



            if (igual || valor == "12345678909")
                return false;

            int[] numeros = new int[11];

            for (int i = 0; i < 11; i++)
                numeros[i] = int.Parse(valor[i].ToString());

            int soma = 0;

            for (int i = 0; i < 9; i++)

                soma += (10 - i) * numeros[i];
            int resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {
                if (numeros[9] != 0)
                    return false;

            }

            else if (numeros[9] != 11 - resultado)
                return false;

            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += (11 - i) * numeros[i];

            resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {

                if (numeros[10] != 0)
                    return false;

            }
            else
                if (numeros[10] != 11 - resultado)

                return false;

            return true;

        }

        private bool validaNascimento(DateTime nascimento)
        {

            try
            {
                DateTime dataHoje = DateTime.Now.Date;
                int idade = dataHoje.Year - nascimento.Year;
                if (idade > 18)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Mensagens.DataInvalida, ex.Message);
                return false;
            }
        }

    }
}
