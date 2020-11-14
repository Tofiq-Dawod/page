<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Session.aspx.cs" Inherits="page_1.Session" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblName" runat="server" Text="LocationSide : "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt5" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblAge" runat="server" Text="Age : "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt6" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblVisitors" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnSend" runat="server" OnClick="btnSend_Click" Text="Send" />
        <br />
        <br />
        <asp:Button ID="btnSessionTimeOut" runat="server" OnClick="btnSessionTimeOut_Click" Text="SessionTimeOut" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="DisplaySessionTimeOut" runat="server"></asp:Label>
&nbsp;<br />
        <br />
        <br />
        <asp:Button ID="btnSessionId" runat="server" OnClick="btnSessionId_Click" Text="SessionID" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="DisplaySessionId" runat="server"></asp:Label>
&nbsp;<div>
    
    </div>
    </form>
</body>
</html>
