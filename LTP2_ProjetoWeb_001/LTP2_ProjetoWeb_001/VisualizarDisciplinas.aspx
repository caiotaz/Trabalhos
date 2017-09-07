<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VisualizarDisciplinas.aspx.cs" Inherits="LTP2_ProjetoWeb_001.VisualizarDisciplinas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Disciplinas Cadastradas</title>
        <link href="StyloTabela.css" rel="stylesheet" />

    <style type="text/css">
        .auto-style1 {
            margin-left: 0px;
            margin-top: 0px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div id="conteudo">
           <div id="topoDisciplina">

           </div>
            <br />
            <br />
            <asp:Label ID="lbl" runat="server" Text="Label"></asp:Label>
            <asp:GridView ID="tabelaDisciplinas" runat="server" AutoGenerateColumns="false" OnRowCommand="tabelaDisciplinas_RowCommand" BorderStyle="None" CssClass="auto-style1" Height="172px" Width="823px">
                <Columns>
                    <asp:TemplateField HeaderText="Ações">
                        <ItemTemplate>
                            <asp:LinkButton ID="Editar" runat="server" CssClass="Editar" CommandName="editar" CommandArgument='<%# Eval("ID_Disciplina") %>' ToolTip="Editar Disciplina">
                            Editar
                            </asp:LinkButton>
                            &nbsp
                              <asp:LinkButton ID="Excluir" runat="server" CssClass="Excluir" CommandName="excluir" CommandArgument='<%# Eval("ID_Disciplina") %>' ToolTip="Excluir Disciplina">
                            Excluir
                            </asp:LinkButton>
                       
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField ItemStyle-CssClass="Htxt" HeaderText="Código" DataField="Codigo_Disciplina" />
                    <asp:BoundField ItemStyle-CssClass="Htxt" HeaderText="Nome" DataField="Nome_Disciplina" />
                    <asp:BoundField ItemStyle-CssClass="Htxt" HeaderText="Ementa" DataField="Ementa_Disciplina" />
                    <asp:BoundField ItemStyle-CssClass="Htxt" HeaderText="Semestres" DataField="Semestre_Disciplina" />
                    <asp:BoundField ItemStyle-CssClass="Htxt" HeaderText="Carga Horaria" DataField="Carga_Horaria" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
