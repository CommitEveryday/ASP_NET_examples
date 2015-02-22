<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Panel.aspx.cs" Inherits="WebApp2.TestControls.Panel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="Show/Hide" 
            onclick="Button1_Click" /><asp:Button ID="Button2"
            runat="server" Text="Movie Left" CommandArgument="-10" CommandName="Move" 
            oncommand="Button2_Command" /><asp:Button ID="Button3" runat="server" 
            Text="Movie Right" CommandArgument="10" CommandName="Move" 
            oncommand="Button2_Command" />
    </div>
    <asp:Panel ID="Panel1" runat="server">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button4" runat="server" Text="Button" />
            </asp:Panel>
    </form>
</body>
</html>
