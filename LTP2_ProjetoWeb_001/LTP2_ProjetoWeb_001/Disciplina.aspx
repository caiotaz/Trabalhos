<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Disciplina.aspx.cs" Inherits="LTP2_ProjetoWeb_001.Disciplina" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyloCurso.css" rel="stylesheet" />
</head>
<body>
        <form id="form1" runat="server">
    
    <div id="conteudo">
        <div id="topoDisciplina">
            
            </div>
  

        <asp:Label ID="lblSucesso" runat="server"></asp:Label>

          Código:
            <asp:TextBox ID="txtCodidoDisciplina" runat="server"></asp:TextBox>
       
          Nome:
            <asp:TextBox ID="txtNomeDisciplina" runat="server"></asp:TextBox>
        
            Ementa:
            <asp:TextBox ID="txtEmenta" runat="server"></asp:TextBox>
        
            Semestre:
            <asp:TextBox ID="txtSemestre" runat="server"></asp:TextBox>
 
        Carga Horaria:
            <asp:TextBox ID="txtCargaHoraia" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
        <br />
    </div>
    </form>
</body>
</html>
