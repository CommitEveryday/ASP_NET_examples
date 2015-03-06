<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="WebApp2.TestControls.Menu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" 
            DataFile="~/XmlData/MenuItems.xml" XPath="/MenuItems/*"></asp:XmlDataSource>
        <asp:Menu ID="Menu1" runat="server" DataSourceID="XmlDataSource1" 
            onmenuitemclick="Menu1_MenuItemClick">
        </asp:Menu>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
