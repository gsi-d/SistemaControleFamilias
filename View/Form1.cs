using CRUD_19_11.Controller;
using CRUD_19_11.View;
using ExercicioCrudBanco.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_19_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroPessoa pessoa = new CadastroPessoa();
            pessoa.ShowDialog();
        }

        private void famíliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFamilia familia = new CadastroFamilia();
            familia.ShowDialog();
        }

        private void açãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroAcao acao = new CadastroAcao();
            acao.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            List<string> listaErros = new List<string>();

            AcaoController controller = new AcaoController();
            PessoaController controllerPessoa = new PessoaController();

            if (ttbAcao2.Text == string.Empty)
                listaErros.Add("Valor inválido para o campo Ação!");
            if (ttbCPF2.Text == string.Empty)
                listaErros.Add("Valor inválido para o campo CPF!");
            if(listaErros.Count == 0)
            {
                DataTable pessoa = controllerPessoa.buscarPessoa(ttbCPF2.Text);
                DataTable acao = controller.buscarAcao(ttbAcao2.Text);
                if ((acao.Rows.Count > 0) && (pessoa.Rows.Count > 0))
                {
                    ControllerAcao_Familia acao_Familia = new ControllerAcao_Familia();
                    int id_familia = Convert.ToInt32(pessoa.Rows[0]["Id_Familia"].ToString());
                    int id_acao = Convert.ToInt32(acao.Rows[0]["Id_Acao"].ToString());
                    DataTable resultadoConsulta = acao_Familia.buscarAcao_Familia(id_familia, id_acao);
                    if(resultadoConsulta.Rows.Count > 0)
                    {
                        MessageBox.Show("Essa família já está cadastrada nessa ação!");
                    }
                    else
                    {
                        acao_Familia.gravarAcao_Familia(id_familia, id_acao);
                        MessageBox.Show("Família cadastrada na Ação!");
                        ttbAcao2.Clear();
                        ttbCPF2.Clear();
                    }
                }
            }
            else
            {
                foreach(string i in listaErros)
                {
                    MessageBox.Show(i +"\n");
                }
                
            }
            
            
            
        }

        private void açõesRealizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioAcao_Familia tela = new RelatorioAcao_Familia();
            tela.ShowDialog();
        }
    }
}
