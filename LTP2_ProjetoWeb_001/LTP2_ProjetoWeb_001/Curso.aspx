<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Curso.aspx.cs" Inherits="LTP2_ProjetoWeb_001.Curso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Curso</title>
    <link href="StyloCurso.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="conteudo">
           <div id="topo">

        </div>


        <asp:Label ID="lblSucesso" runat="server"></asp:Label>
    

            Código:     
            <asp:TextBox ID="txtCodido" runat="server"></asp:TextBox>       
            Curso:
            <asp:TextBox ID="txtCurso" runat="server"></asp:TextBox>
            Período:
            <asp:TextBox ID="txtPeriodo" runat="server"></asp:TextBox>
            Duração:
            <asp:TextBox ID="txtDuracao" runat="server"></asp:TextBox>
           Conceito Enade:
            <asp:TextBox ID="txtEnade" runat="server"></asp:TextBox>
    
        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" Height="37px" />
        <br />
        
    </div>
       
    </form>
</body>
</html>
