<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangeCheck.aspx.cs" Inherits="page_1.page_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="FirstName"></asp:Label>
&nbsp;:
        <asp:TextBox ID="txt4" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblVisitors" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="LastName"></asp:Label>
&nbsp;:&nbsp;
        <asp:TextBox ID="txt5" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
    
        <asp:CheckBox ID="chk1" runat="server" Text="invalid is check" />
        <br />
        <br />
        <br />
        <asp:Button ID="btn" runat="server" OnClick="Button1_Click" Text="change check is clicked" />
    
    &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnset" runat="server" OnClick="btnset_Click" Text="Set" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnrestore" runat="server" OnClick="btnrestore_Click" Text="Restore" />
    
    </div>
    </form>
</body>
</html>
