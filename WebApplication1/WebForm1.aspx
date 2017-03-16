<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnPregunta1" runat="server" Text="Pregunta1" OnClick="btnPregunta1_Click" />

        <asp:Label ID="lblRpta" runat="server" Text=""></asp:Label><br />
        <asp:Button ID="btnPregunta2" runat="server" Text="Pregunta2" OnClick="btnPregunta2_Click"  />
        <br />
        <asp:Button ID="btnPregunta3" runat="server" Text="Pregunta3" OnClick="btnPregunta3_Click"  />
    </div>
    </form>
</body>
</html>
