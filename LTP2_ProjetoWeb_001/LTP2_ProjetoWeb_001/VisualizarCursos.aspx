<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VisualizarCursos.aspx.cs" Inherits="LTP2_ProjetoWeb_001.VisualizarCursos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cursos Cadastrados</title>
        <link href="StyloTabela.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <div id="conteudo">
            <div id="topo">

            </div>
            <br />
            <br />
            <asp:GridView ID="tabelaCursos" runat="server" AutoGenerateColumns="false" OnRowCommand="tabelaCursos_RowCommand" BorderStyle="None" Width="848px">
                <Columns>
                    <asp:TemplateField HeaderText="Ações">
                        <ItemTemplate>
                            <asp:LinkButton ID="Editar" runat="server" CssClass="Editar" CommandName="editar" CommandArgument='<%# Eval("ID_Curso") %>' ToolTip="Editar Curso">
                            Editar
                            </asp:LinkButton>
                            &nbsp
                            <asp:LinkButton ID="Excluir" runat="server" CssClass="Excluir" CommandName="excluir" CommandArgument='<%# Eval("ID_Curso") %>' ToolTip="Excluir Curso">
                            Excluir
                            </asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField ItemStyle-CssClass="Htxt" HeaderText="Código" DataField="Codigo_Curso" />
                    <asp:BoundField ItemStyle-CssClass="Htxt" HeaderText="Curso" DataField="Nome_Curso" />
                    <asp:BoundField ItemStyle-CssClass="Htxt" HeaderText="Período" DataField="Periodo_Curso" />
                    <asp:BoundField ItemStyle-CssClass="Htxt" HeaderText="Duração" DataField="Duracao_Curso" />
                    <asp:BoundField ItemStyle-CssClass="Htxt" HeaderText="Enade" DataField="Enade_Curso" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
