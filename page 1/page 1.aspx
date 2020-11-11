<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page 1.aspx.cs" Inherits="page_1.page_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="txt1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="txt2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Move" />
    
    </div>
    </form>
</body>
</html>
