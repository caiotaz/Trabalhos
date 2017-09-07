<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VisualizarAlunos.aspx.cs" Inherits="LTP2_ProjetoWeb_001.VisualizarAlunos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Alunos Cadastrados</title>
    <link href="StyloTabela.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            margin-left: 3px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="conteudo">
        <div id="topoAluno">

        </div>
         
            <br />
            <br />
            <asp:GridView ID="tabelaAlunos" runat="server" AutoGenerateColumns="false" OnRowCommand="tabelaAlunos_RowCommand" BorderStyle="None" CssClass="auto-style1" Width="784px">
                <Columns>
                    <asp:TemplateField HeaderText="Ações">
                        <ItemTemplate>
                            <asp:LinkButton ID="Editar" runat="server" CssClass="Editar" CommandName="editar" CommandArgument='<%# Eval("ID_Aluno") %>' ToolTip="Editar Aluno">
                            Editar
                            </asp:LinkButton>
                            &nbsp
                              <asp:LinkButton ID="Excluir" runat="server" CssClass="Excluir" CommandName="excluir" CommandArgument='<%# Eval("ID_Aluno") %>' ToolTip="Excluir Aluno">
                            Excluir
                            </asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField ItemStyle-CssClass="Htxt" HeaderText="Ra" DataField="Ra_Aluno" />
                    <asp:BoundField ItemStyle-CssClass="Htxt" HeaderText="Nome" DataField="Nome_Aluno" />
                    <asp:BoundField ItemStyle-CssClass="Htxt" HeaderText="Cpf" DataField="Cpf_Aluno" />
                    <asp:BoundField ItemStyle-CssClass="Htxt" HeaderText="Sexo" DataField="Sexo_Aluno" />
                    <asp:BoundField ItemStyle-CssClass="Htxt" HeaderText="Ingresso" DataField="Ingresso_Aluno" />
                </Columns>
            </asp:GridView>
    
    </div>
    </form>
</body>
</html>
