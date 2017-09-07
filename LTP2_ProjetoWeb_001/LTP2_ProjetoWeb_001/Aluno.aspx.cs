using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LTP2_ProjetoWeb_001
{
    public partial class Aluno : System.Web.UI.Page
    {
        conectAluno C = new conectAluno();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (VisualizarAlunos.ID != 0)
                {
                    preencherFormulario();
                }
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            C.configurarConexao();

            string test = txtSexo.Text;

            C.Ra_Aluno = txtRa.Text;
            C.Nome_Aluno = txtNomeAluno.Text;
            C.Cpf_Aluno = txtCpf.Text;
            C.Sexo_Aluno = txtSexo.Text;
            C.Ingresso_Aluno = txtIngresso.Text;

            if (VisualizarAlunos.ID == 0)
            {
                C.InserirAluno();
            }
            else
            {
                C.ID_Aluno = VisualizarAlunos.ID;
                C.alterarItem();
            }

            //lblSucesso.Text = "Aluno Inserido com sucesso!";
            Response.Redirect("VisualizarAlunos.aspx");

        }

        public void preencherFormulario()
        {
            int ID = VisualizarAlunos.ID;

            C.configurarConexao();
            C = C.retornarItem(ID);

            txtRa.Text = C.Ra_Aluno;
            txtNomeAluno.Text = C.Nome_Aluno;
            txtCpf.Text = C.Cpf_Aluno;
            txtSexo.Text = C.Sexo_Aluno;
            txtIngresso.Text = C.Ingresso_Aluno;
        }
    }
}