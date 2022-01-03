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
    public partial class CadastroAcao : Form
    {
        public CadastroAcao()
        {
            InitializeComponent();

            cbbEstado.Items.Add(new ItemComboBox("Selecione!", 0));

            EstadoController controllerEstado = new EstadoController();
            DataTable dtEstados = controllerEstado.BuscarEstado();

            for (int i = 0; i < dtEstados.Rows.Count; i++)
                cbbEstado.Items.Add(new ItemComboBox(dtEstados.Rows[i]["Nome_Estado"].ToString(),
                    Convert.ToInt32(dtEstados.Rows[i]["Id_Estado"].ToString())));

            cbbEstado.SelectedIndex = cbbEstado.FindStringExact("Selecione!");
            cbbEstado.DropDownStyle = ComboBoxStyle.DropDownList;

            dtpInicio.Enabled = false;
            dtpTermino.Enabled = false;
            cbbEstado.Enabled = false;
            cbbCidade.Enabled = false;
            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = false;
            lblIndice.Visible = false;


        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //cria uma lista chamada listaErros
            List<string> listaErros = new List<string>();

            //transforma o datatimepicker em um DateTime chamado inicio.
            DateTime inicio = dtpInicio.Value;

            DateTime termino = dtpTermino.Value;

            if (ttbAcao.Text == "")
            {
                listaErros.Add("Verifique o campo Ação!");
            }
            if (!validaInicio(inicio))//a função validaInicio vai validar o "inicio"
            {
                listaErros.Add("A ação precisa começar em até 10 dias!");
            }
            if (!validaTermino(inicio, termino))
            {
                listaErros.Add("A data final não pode ser anterior à data inicial!");
            }
            if (cbbEstado.SelectedItem.ToString() == "Selecione!")
            {
                listaErros.Add("Verifique o campo Estado!");
            }
            if ((cbbCidade.SelectedIndex < 0))
            {
                listaErros.Add("Verifique o campo Cidade!");
            }
            if (listaErros.Count == 0)
            {
                AcaoController controller = new AcaoController();
                AcaoEntity acao = new AcaoEntity(0, (cbbCidade.SelectedItem as ItemComboBox).Id, ttbAcao.Text, inicio, termino);
                if (controller.GravarAcao(acao))
                {
                    MessageBox.Show("Ação cadastrada com sucesso!");
                    this.Close();
                }

            }
            else
            {
                string erro = "";
                for (int i = 0; i < listaErros.Count; i++)
                {
                    erro = erro + listaErros[i] + "\n";

                    MessageBox.Show("Verifique os campos abaixo: \n" + erro, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            AcaoController controller = new AcaoController();
            PessoaController controllerPessoa = new PessoaController();
            ControllerAcao_Familia controllerAcao_Familia = new ControllerAcao_Familia();

            if (MessageBox.Show("Deseja realmente excluir este registro?", "Mensagem de confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                int elemento = Convert.ToInt32(dgvAcao.CurrentRow.Cells[0].Value.ToString());
                if (controllerAcao_Familia.buscarAcao_FamiliaporId_Familia(elemento) == null)
                {
                    if (controller.excluirAcao(elemento))
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
                    MessageBox.Show("Essa ação já possui famílias cadastradas!");
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AcaoController controller = new AcaoController();
            int id_cidade = 0;

            if (controller.buscarId_CidadeAcao(dgvAcao.CurrentRow.Cells[2].Value.ToString()).Rows.Count > 0)
            {
                DataTable result = controller.buscarId_CidadeAcao(dgvAcao.CurrentRow.Cells[2].Value.ToString());
                id_cidade = Convert.ToInt32(result.Rows[0]["Id_Cidade"].ToString());

                var objAcao = new AcaoEntity(Convert.ToInt32(dgvAcao.CurrentRow.Cells[0].Value.ToString()),                
                id_cidade,
                dgvAcao.CurrentRow.Cells[1].Value.ToString(),
                Convert.ToDateTime(dgvAcao.CurrentRow.Cells[4].Value.ToString()),
                Convert.ToDateTime(dgvAcao.CurrentRow.Cells[5].Value.ToString()));
                
                int pos = dgvAcao.RowCount;

                controller.alterarAcao(objAcao);
                MessageBox.Show("Registro alterado!");

            }
            else
            {
                MessageBox.Show("Não foi possível alterar!");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AcaoController controller = new AcaoController();
            if ((controller.buscarAcaoCompleta("%" + ttbAcao.Text + "%").Rows.Count > 0) && (ttbAcao.Text != string.Empty))
            {
                DataTable result = controller.buscarAcaoCompleta("%" + ttbAcao.Text + "%");
                lblIndice.Text = result.Rows[0]["ID"].ToString();
                dgvAcao.DataSource = result;

                btnAlterar.Enabled = true;
                btnCadastrar.Enabled = false;
                btnBuscar.Enabled = true;
                btnExcluir.Enabled = true;
                cbbCidade.Enabled = true;
                cbbEstado.Enabled = true;
                dtpInicio.Enabled = true;
                dtpTermino.Enabled = true;
            }
            else if ((controller.buscarTodasAcaoCompletas().Rows.Count > 0) && (ttbAcao.Text == string.Empty))
            {
                DataTable result = controller.buscarTodasAcaoCompletas();
                lblIndice.Text = result.Rows[0]["ID"].ToString();
                dgvAcao.DataSource = result;

                btnAlterar.Enabled = true;
                btnCadastrar.Enabled = true;
                btnBuscar.Enabled = true;
                btnExcluir.Enabled = true;
                cbbCidade.Enabled = true;
                cbbEstado.Enabled = true;
                dtpInicio.Enabled = true;
                dtpTermino.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ação não encontrada!");
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnCadastrar.Enabled = true;
                btnBuscar.Enabled = true;
                cbbCidade.Enabled = true;
                cbbEstado.Enabled = true;
                dtpInicio.Enabled = true;
                dtpTermino.Enabled = true;

            }
        }


        //Valida a data de inicio segundo as regras de negocio
        public bool validaInicio(DateTime t)
        {
            int inicio = t.Day - DateTime.Today.Day;

            if (inicio <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //i recebe o inicio, t recebe o termino
        public bool validaTermino(DateTime i, DateTime t)
        {

            if (i.Day <= t.Day)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
