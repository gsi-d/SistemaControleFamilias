using CRUD_19_11.Controller;
using CRUD_19_11.Model;
using ExemploComboBox.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace CRUD_19_11.View
{
    public partial class CadastroFamilia : Form
    {
        public CadastroFamilia()
        {
            InitializeComponent();
            cbbEstado.Items.Add(new ItemComboBox("Selecione!", 0));

            EstadoController controllerEstado = new EstadoController();
            DataTable dtEstados = controllerEstado.BuscarEstado();

            for (int i = 0; i < dtEstados.Rows.Count; i++)
                cbbEstado.Items.Add(new ItemComboBox(dtEstados.Rows[i]["Nome_Estado"].ToString(),
                    Convert.ToInt32(dtEstados.Rows[i]["Id_Estado"])));

            cbbEstado.SelectedIndex = cbbEstado.FindStringExact("Selecione!");
            cbbEstado.DropDownStyle = ComboBoxStyle.DropDownList;

            lbIndice.Visible = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCadastrar.Enabled = false;
            cbbCidade.Enabled = false;
            cbbEstado.Enabled = false;
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            List<string> listaErros = new List<string>();
            if (ttbFamilia.Text == "")
                listaErros.Add("Verifique o campo Família!");
            if (cbbEstado.SelectedItem.ToString() == "Selecione!")
                listaErros.Add("Verifique o campo Estado!");
            if (cbbCidade.SelectedIndex < 0)
                listaErros.Add("Verifique o campo Cidade!");
            if (listaErros.Count == 0)
            {
                FamiliaController controller = new FamiliaController();
                FamiliaEntity familia = new FamiliaEntity(0, (cbbCidade.SelectedItem as ItemComboBox).Id, ttbFamilia.Text);
                if (controller.GravarFamilia(familia))
                {
                    MessageBox.Show("Família cadastrada com sucesso!");
                    ttbFamilia.Clear();
                    cbbEstado.Items.Add(new ItemComboBox("Selecione!", 0));

                    EstadoController controllerEstado = new EstadoController();
                    DataTable dtEstados = controllerEstado.BuscarEstado();

                    for (int i = 0; i < dtEstados.Rows.Count; i++)
                        cbbEstado.Items.Add(new ItemComboBox(dtEstados.Rows[i]["Nome_Estado"].ToString(),
                            Convert.ToInt32(dtEstados.Rows[i]["Id_Estado"])));

                    cbbEstado.SelectedIndex = cbbEstado.FindStringExact("Selecione!");
                    cbbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
                    btnBuscar.Enabled = true;

                }
            }
            else
            {
                string erro = "";
                for (int i = 0; i < listaErros.Count; i++)
                    erro = erro + listaErros[i] + "\n";

                MessageBox.Show("Verifique os campos abaixo: \n" + erro, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbbEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            //Limpando elementos do combobox
            cbbCidade.Items.Clear();

            //Bloqueando edição do usuário
            cbbCidade.DropDownStyle = ComboBoxStyle.DropDownList;
            int idSelecionado = (cbbEstado.SelectedItem as ItemComboBox).Id;

            CidadeController controllerCidade = new CidadeController();
            DataTable consultaCidades = controllerCidade.BuscarCidade(idSelecionado);

            for (int i = 0; i < consultaCidades.Rows.Count; i++)
                cbbCidade.Items.Add(
                    new ItemComboBox(consultaCidades.Rows[i]["Nome_Cidade"].ToString(),
                    Convert.ToInt32(consultaCidades.Rows[i]["Id_Cidade"].ToString())));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FamiliaController controller = new FamiliaController();
            if ((controller.buscarFamiliaCompleta("%" + ttbFamilia.Text + "%").Rows.Count > 0) && (ttbFamilia.Text != string.Empty))
            {
                lblAviso.Text = "*Campos que são disponíveis para alteração: Nome Família e Nome Cidade.";
                DataTable result = controller.buscarFamiliaCompleta("%" + ttbFamilia.Text + "%");
                lbIndice.Text = result.Rows[0]["ID"].ToString();
                cbbCidade.SelectedItem = Convert.ToInt32(result.Rows[0]["Id_Cidade"].ToString());
                dgvFamilia.DataSource = result;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCadastrar.Enabled = false;
                btnBuscar.Enabled = true;
                cbbCidade.Enabled = false;
                cbbEstado.Enabled = false;
            }
            else if ((controller.buscarTodasFamiliasCompletas().Rows.Count > 0) && (ttbFamilia.Text == string.Empty))
            {
                lblAviso.Text = "*Campos que são disponíveis para alteração: Nome Família e Nome Cidade.";
                DataTable result = controller.buscarTodasFamiliasCompletas();
                lbIndice.Text = result.Rows[0]["ID"].ToString();
                dgvFamilia.DataSource = result;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = true;
                btnCadastrar.Enabled = false;
                btnBuscar.Enabled = true;
                cbbCidade.Enabled = true;
                cbbEstado.Enabled = true;



            }
            else
            {
                MessageBox.Show("Família não encontrada!");
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnCadastrar.Enabled = true;
                btnBuscar.Enabled = false;
                cbbCidade.Enabled = true;
                cbbEstado.Enabled = true;
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            FamiliaController controller = new FamiliaController();
            PessoaController controllerPessoa = new PessoaController();
            ControllerAcao_Familia controllerAcao_Familia = new ControllerAcao_Familia();

            if (MessageBox.Show("Deseja realmente excluir este registro?", "Mensagem de confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                int elemento = Convert.ToInt32(dgvFamilia.CurrentRow.Cells[0].Value.ToString());
                if ((controllerAcao_Familia.buscarAcao_FamiliaporId_Familia(elemento) == null) && (controllerPessoa.buscarPessoapeloId_Familia(elemento) == null))
                {
                    if (controller.excluirFamilia(elemento))
                    {
                        MessageBox.Show("Registro removido!");
                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Registro não encontrado!");
                    }
                }
                else
                {
                    MessageBox.Show("Essa família já está cadastrada em uma pessoa e/ou em uma ação!");
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FamiliaController controller = new FamiliaController();
            int id_cidade = 0;


            if (controller.buscarId_CidadeFamilia(dgvFamilia.CurrentRow.Cells[3].Value.ToString()).Rows.Count == 1)
            {

                DataTable result = controller.buscarId_CidadeFamilia(dgvFamilia.CurrentRow.Cells[3].Value.ToString());
                id_cidade = Convert.ToInt32(result.Rows[0]["Id_Cidade"].ToString());
                var objFamilia = new FamiliaEntity(Convert.ToInt32(dgvFamilia.CurrentRow.Cells[0].Value.ToString()),
                id_cidade, dgvFamilia.CurrentRow.Cells[2].Value.ToString());
                int pos = dgvFamilia.RowCount;

                controller.alterarFamilia(objFamilia);                
                MessageBox.Show("Registro alterado!");
                lblAviso.Text = "";
            }
            else
            {
                MessageBox.Show("Não foi possível alterar!");
            }
        }
    }
}
