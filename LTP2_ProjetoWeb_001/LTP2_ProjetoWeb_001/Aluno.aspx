<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Aluno.aspx.cs" Inherits="LTP2_ProjetoWeb_001.Aluno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Aluno</title>
     <link href="StyloCurso.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="conteudo">
           <div id="topoAluno">

            </div>
        

        <asp:Label ID="lblSucesso" runat="server"></asp:Label>
   
          RA:
            <asp:TextBox ID="txtRa" runat="server" ></asp:TextBox>
            Nome:
            <asp:TextBox ID="txtNomeAluno" runat="server"></asp:TextBox>
            CPF:
            <asp:TextBox ID="txtCpf" runat="server"></asp:TextBox>
            Sexo:
            <asp:TextBox ID="txtSexo" runat="server"></asp:TextBox>
            Ingresso:
            <asp:TextBox ID="txtIngresso" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" Height="37px" />
        <br />
    </div>
    </form>
</body>
</html>
