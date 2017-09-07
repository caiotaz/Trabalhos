using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LTP2_ProjetoWeb_001
{
    public partial class Disciplina : System.Web.UI.Page
    {
        ConectDisciplina C = new ConectDisciplina();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if ( VisualizarDisciplinas.ID != 0)
                {
                    preencherFormulario();
                }
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            C.configurarConexao();

            string test = txtSemestre.Text;

            C.Codigo_Disciplina = txtCodidoDisciplina.Text;
            C.Nome_Disciplina = txtNomeDisciplina.Text;
            C.Ementa_Disciplina = txtEmenta.Text;
            C.Semestre_Disciplina = txtSemestre.Text;
            C.Carga_Horaria = txtCargaHoraia.Text;

            if ( VisualizarDisciplinas.ID == 0)
            {
                C.InserirDisciplina();
            }
            else
            {
                C.ID_Disciplina =  VisualizarDisciplinas.ID;
                C.alterarItem();
            }

            lblSucesso.Text = "Disciplina Inserido com sucesso!";
            Response.Redirect("VisualizarDisciplinas.aspx");

        }

        public void preencherFormulario()
        {
            int ID =  VisualizarDisciplinas.ID;

            C.configurarConexao();
            C = C.retornarItem(ID);

            txtCodidoDisciplina.Text = C.Codigo_Disciplina;
            txtNomeDisciplina.Text = C.Nome_Disciplina;
            txtEmenta.Text = C.Ementa_Disciplina;
            txtSemestre.Text = C.Semestre_Disciplina;
            txtCargaHoraia.Text = C.Carga_Horaria;
        }
    }
}