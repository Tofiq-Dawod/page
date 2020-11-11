<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page 2.aspx.cs" Inherits="page_1.page_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:CheckBox ID="chk1" runat="server" Text="invalid is check" />
        <br />
        <br />
        <br />
        <asp:Button ID="btn" runat="server" OnClick="Button1_Click" Text="change check is clicked" />
    
    </div>
    </form>
</body>
</html>
